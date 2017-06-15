using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;
using System.Net.Sockets;
using System.IO.Ports;
using System.Threading;
using System.IO;
using Modbus.Extensions.Enron;

namespace WindowsFormsModbus
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_ES_Modbus());

            //string portName = "COM3";
            //int baudRate = 9600;
            //byte slaveAddress = 1;
            //ushort startAddress = 7;
            //ushort numberOfPoints = 1;

            //var master = ModbusSerialMaster.CreateRtu(new System.IO.Ports.SerialPort(portName, baudRate));

            //while (true)
            //{
            //    Console.Write("\r{0}", master.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints)[0]);
            //}

            {
                SerialPort serialPort = new SerialPort()
                {
                    PortName = "COM3",
                    BaudRate = 9600,
                    DataBits = 8,
                    Parity = Parity.Even,
                    StopBits = StopBits.One
                };
                try
                {
                    serialPort.Open();
                }

                catch (IOException)
                {
                    Console.WriteLine("Не удалось подключиться к порту");
                }

                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
                byte slaveID = 1;

                SerialPort slaveSerialPort = new SerialPort()
                {
                    PortName = "COM3",
                    BaudRate = 9600,
                    DataBits = 8,
                    Parity = Parity.Even,
                    StopBits = StopBits.One
                };
                ModbusSlave slave = ModbusSerialSlave.CreateRtu(slaveID, slaveSerialPort);
                Thread slaveThread = new Thread(new ThreadStart(slave.Listen));
                slaveThread.Start();

                ushort startAddress = 4;
                ushort numRegisters = 4;

                // Запись в один регистр

                //master.WriteSingleRegister(slaveID, 7, 4000);

                // Запись в несколько регистров НЕ РАБОТАЕТ

                //ushort[] data = { 4444, 3333, 1111, 2222};
                //master.WriteMultipleRegisters(slaveID, startAddress, data);

                // Чтение нескольких регистров

                ushort[] coils = master.ReadHoldingRegisters(slaveID, startAddress, numRegisters);

                for (int i = 0; i < numRegisters; i++)
                {
                    Console.WriteLine("Значение в регистре {0} = {1}", (int)startAddress + i, coils[i]);
                }

                //Console.Write("Для выхода нажмите любую клавишу...");
                //Console.ReadKey(true);
            }

        }
    }
}
