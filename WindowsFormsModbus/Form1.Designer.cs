namespace WindowsFormsModbus
{
    partial class Form_ES_Modbus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.vScrollBarDisplay = new System.Windows.Forms.VScrollBar();
            this.numericUpDownF = new System.Windows.Forms.NumericUpDown();
            this.buttonRev = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(25, 31);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(278, 168);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Green;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(25, 310);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(228, 310);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 35);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "СТОП";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // vScrollBarDisplay
            // 
            this.vScrollBarDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBarDisplay.Location = new System.Drawing.Point(285, 31);
            this.vScrollBarDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.vScrollBarDisplay.Name = "vScrollBarDisplay";
            this.vScrollBarDisplay.Padding = new System.Windows.Forms.Padding(2);
            this.vScrollBarDisplay.Size = new System.Drawing.Size(18, 168);
            this.vScrollBarDisplay.TabIndex = 4;
            // 
            // numericUpDownF
            // 
            this.numericUpDownF.DecimalPlaces = 2;
            this.numericUpDownF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownF.ForeColor = System.Drawing.Color.DarkOrange;
            this.numericUpDownF.Location = new System.Drawing.Point(55, 218);
            this.numericUpDownF.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownF.Name = "numericUpDownF";
            this.numericUpDownF.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownF.TabIndex = 5;
            this.numericUpDownF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownF.ValueChanged += new System.EventHandler(this.numericUpDownF_ValueChanged);
            // 
            // buttonRev
            // 
            this.buttonRev.BackColor = System.Drawing.Color.LightGray;
            this.buttonRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRev.Location = new System.Drawing.Point(130, 261);
            this.buttonRev.Name = "buttonRev";
            this.buttonRev.Size = new System.Drawing.Size(75, 35);
            this.buttonRev.TabIndex = 6;
            this.buttonRev.Text = "РЕВЕРС";
            this.buttonRev.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(197, 218);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 26);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "ЗАДАТЬ";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // Form_ES_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 359);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonRev);
            this.Controls.Add(this.numericUpDownF);
            this.Controls.Add(this.vScrollBarDisplay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxDisplay);
            this.Name = "Form_ES_Modbus";
            this.Text = "ES-Modbus";
            this.Load += new System.EventHandler(this.Form_ES_Modbus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.VScrollBar vScrollBarDisplay;
        private System.Windows.Forms.NumericUpDown numericUpDownF;
        private System.Windows.Forms.Button buttonRev;
        private System.Windows.Forms.Button buttonEnter;
    }
}