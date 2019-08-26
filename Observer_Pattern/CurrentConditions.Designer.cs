namespace Observer_Pattern
{
    partial class CurrentConditions
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
            this.displayTempLbl = new System.Windows.Forms.Label();
            this.displayHumidityLbl = new System.Windows.Forms.Label();
            this.displayPressureLbl = new System.Windows.Forms.Label();
            this.deRegBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Current Conditions";
            // 
            // pressureLbl
            // 
            this.pressureLbl.AutoSize = true;
            this.pressureLbl.Location = new System.Drawing.Point(60, 278);
            this.pressureLbl.Name = "pressureLbl";
            this.pressureLbl.Size = new System.Drawing.Size(48, 13);
            this.pressureLbl.TabIndex = 12;
            this.pressureLbl.Text = "Pressure";
            // 
            // humidityLbl
            // 
            this.humidityLbl.AutoSize = true;
            this.humidityLbl.Location = new System.Drawing.Point(60, 198);
            this.humidityLbl.Name = "humidityLbl";
            this.humidityLbl.Size = new System.Drawing.Size(47, 13);
            this.humidityLbl.TabIndex = 11;
            this.humidityLbl.Text = "Humidity";
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Location = new System.Drawing.Point(60, 117);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(34, 13);
            this.tempLbl.TabIndex = 10;
            this.tempLbl.Text = "Temp";
            // 
            // displayTempLbl
            // 
            this.displayTempLbl.AutoSize = true;
            this.displayTempLbl.Location = new System.Drawing.Point(155, 116);
            this.displayTempLbl.Name = "displayTempLbl";
            this.displayTempLbl.Size = new System.Drawing.Size(13, 13);
            this.displayTempLbl.TabIndex = 14;
            this.displayTempLbl.Text = "0";
            // 
            // displayHumidityLbl
            // 
            this.displayHumidityLbl.AutoSize = true;
            this.displayHumidityLbl.Location = new System.Drawing.Point(155, 198);
            this.displayHumidityLbl.Name = "displayHumidityLbl";
            this.displayHumidityLbl.Size = new System.Drawing.Size(13, 13);
            this.displayHumidityLbl.TabIndex = 15;
            this.displayHumidityLbl.Text = "0";
            // 
            // displayPressureLbl
            // 
            this.displayPressureLbl.AutoSize = true;
            this.displayPressureLbl.Location = new System.Drawing.Point(155, 278);
            this.displayPressureLbl.Name = "displayPressureLbl";
            this.displayPressureLbl.Size = new System.Drawing.Size(13, 13);
            this.displayPressureLbl.TabIndex = 16;
            this.displayPressureLbl.Text = "0";
            // 
            // deRegBtn
            // 
            this.deRegBtn.Location = new System.Drawing.Point(194, 327);
            this.deRegBtn.Name = "deRegBtn";
            this.deRegBtn.Size = new System.Drawing.Size(152, 23);
            this.deRegBtn.TabIndex = 17;
            this.deRegBtn.Text = "De-Register As Observer";
            this.deRegBtn.UseVisualStyleBackColor = true;
            this.deRegBtn.Click += new System.EventHandler(this.DeRegBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(29, 327);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(152, 23);
            this.regBtn.TabIndex = 18;
            this.regBtn.Text = "Register As Observer";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // CurrentConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 381);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.deRegBtn);
            this.Controls.Add(this.displayPressureLbl);
            this.Controls.Add(this.displayHumidityLbl);
            this.Controls.Add(this.displayTempLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pressureLbl);
            this.Controls.Add(this.humidityLbl);
            this.Controls.Add(this.tempLbl);
            this.Name = "CurrentConditions";
            this.Text = "CurrentConditions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pressureLbl;
        private System.Windows.Forms.Label humidityLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label displayTempLbl;
        private System.Windows.Forms.Label displayHumidityLbl;
        private System.Windows.Forms.Label displayPressureLbl;
        private System.Windows.Forms.Button deRegBtn;
        private System.Windows.Forms.Button regBtn;
    }
}