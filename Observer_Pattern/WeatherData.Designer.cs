namespace Observer_Pattern
{
    partial class WeatherData
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
            this.label4 = new System.Windows.Forms.Label();
            this.pressureLbl = new System.Windows.Forms.Label();
            this.humidityLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.pressureTB = new System.Windows.Forms.TextBox();
            this.humidityTB = new System.Windows.Forms.TextBox();
            this.tempTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Weather Station Data";
            // 
            // pressureLbl
            // 
            this.pressureLbl.AutoSize = true;
            this.pressureLbl.Location = new System.Drawing.Point(64, 270);
            this.pressureLbl.Name = "pressureLbl";
            this.pressureLbl.Size = new System.Drawing.Size(48, 13);
            this.pressureLbl.TabIndex = 21;
            this.pressureLbl.Text = "Pressure";
            // 
            // humidityLbl
            // 
            this.humidityLbl.AutoSize = true;
            this.humidityLbl.Location = new System.Drawing.Point(64, 190);
            this.humidityLbl.Name = "humidityLbl";
            this.humidityLbl.Size = new System.Drawing.Size(47, 13);
            this.humidityLbl.TabIndex = 20;
            this.humidityLbl.Text = "Humidity";
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Location = new System.Drawing.Point(64, 109);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(34, 13);
            this.tempLbl.TabIndex = 19;
            this.tempLbl.Text = "Temp";
            // 
            // pressureTB
            // 
            this.pressureTB.Location = new System.Drawing.Point(167, 267);
            this.pressureTB.Name = "pressureTB";
            this.pressureTB.Size = new System.Drawing.Size(100, 20);
            this.pressureTB.TabIndex = 23;
            this.pressureTB.Leave += new System.EventHandler(this.PressureTB_Leave);
            // 
            // humidityTB
            // 
            this.humidityTB.Location = new System.Drawing.Point(167, 187);
            this.humidityTB.Name = "humidityTB";
            this.humidityTB.Size = new System.Drawing.Size(100, 20);
            this.humidityTB.TabIndex = 24;
            this.humidityTB.Leave += new System.EventHandler(this.HumidityTB_Leave);
            // 
            // tempTB
            // 
            this.tempTB.Location = new System.Drawing.Point(167, 106);
            this.tempTB.Name = "tempTB";
            this.tempTB.Size = new System.Drawing.Size(100, 20);
            this.tempTB.TabIndex = 25;
            this.tempTB.Leave += new System.EventHandler(this.TempTB_Leave);
            // 
            // WeatherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 381);
            this.Controls.Add(this.tempTB);
            this.Controls.Add(this.humidityTB);
            this.Controls.Add(this.pressureTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pressureLbl);
            this.Controls.Add(this.humidityLbl);
            this.Controls.Add(this.tempLbl);
            this.Name = "WeatherData";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pressureLbl;
        private System.Windows.Forms.Label humidityLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.TextBox pressureTB;
        private System.Windows.Forms.TextBox humidityTB;
        private System.Windows.Forms.TextBox tempTB;
    }
}

