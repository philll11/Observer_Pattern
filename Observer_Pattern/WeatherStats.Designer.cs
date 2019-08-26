namespace Observer_Pattern
{
    partial class WeatherStats
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
            this.regBtn = new System.Windows.Forms.Button();
            this.deRegBtn = new System.Windows.Forms.Button();
            this.displayMinLbl = new System.Windows.Forms.Label();
            this.displayMaxLbl = new System.Windows.Forms.Label();
            this.displayAverageLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tempMinLbl = new System.Windows.Forms.Label();
            this.tempMaxLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(33, 319);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(152, 23);
            this.regBtn.TabIndex = 36;
            this.regBtn.Text = "Register As Observer";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // deRegBtn
            // 
            this.deRegBtn.Location = new System.Drawing.Point(198, 319);
            this.deRegBtn.Name = "deRegBtn";
            this.deRegBtn.Size = new System.Drawing.Size(152, 23);
            this.deRegBtn.TabIndex = 35;
            this.deRegBtn.Text = "De-Register As Observer";
            this.deRegBtn.UseVisualStyleBackColor = true;
            this.deRegBtn.Click += new System.EventHandler(this.DeRegBtn_Click);
            // 
            // displayMinLbl
            // 
            this.displayMinLbl.AutoSize = true;
            this.displayMinLbl.Location = new System.Drawing.Point(159, 270);
            this.displayMinLbl.Name = "displayMinLbl";
            this.displayMinLbl.Size = new System.Drawing.Size(13, 13);
            this.displayMinLbl.TabIndex = 34;
            this.displayMinLbl.Text = "0";
            // 
            // displayMaxLbl
            // 
            this.displayMaxLbl.AutoSize = true;
            this.displayMaxLbl.Location = new System.Drawing.Point(159, 190);
            this.displayMaxLbl.Name = "displayMaxLbl";
            this.displayMaxLbl.Size = new System.Drawing.Size(13, 13);
            this.displayMaxLbl.TabIndex = 33;
            this.displayMaxLbl.Text = "0";
            // 
            // displayAverageLbl
            // 
            this.displayAverageLbl.AutoSize = true;
            this.displayAverageLbl.Location = new System.Drawing.Point(159, 108);
            this.displayAverageLbl.Name = "displayAverageLbl";
            this.displayAverageLbl.Size = new System.Drawing.Size(13, 13);
            this.displayAverageLbl.TabIndex = 32;
            this.displayAverageLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Weather Statistics";
            // 
            // tempMinLbl
            // 
            this.tempMinLbl.AutoSize = true;
            this.tempMinLbl.Location = new System.Drawing.Point(64, 270);
            this.tempMinLbl.Name = "tempMinLbl";
            this.tempMinLbl.Size = new System.Drawing.Size(54, 13);
            this.tempMinLbl.TabIndex = 30;
            this.tempMinLbl.Text = "Min Temp";
            // 
            // tempMaxLbl
            // 
            this.tempMaxLbl.AutoSize = true;
            this.tempMaxLbl.Location = new System.Drawing.Point(64, 190);
            this.tempMaxLbl.Name = "tempMaxLbl";
            this.tempMaxLbl.Size = new System.Drawing.Size(57, 13);
            this.tempMaxLbl.TabIndex = 29;
            this.tempMaxLbl.Text = "Max Temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Temp Average";
            // 
            // WeatherStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 381);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.deRegBtn);
            this.Controls.Add(this.displayMinLbl);
            this.Controls.Add(this.displayMaxLbl);
            this.Controls.Add(this.displayAverageLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempMinLbl);
            this.Controls.Add(this.tempMaxLbl);
            this.Controls.Add(this.label1);
            this.Name = "WeatherStats";
            this.Text = "WeatherStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button deRegBtn;
        private System.Windows.Forms.Label displayMinLbl;
        private System.Windows.Forms.Label displayMaxLbl;
        private System.Windows.Forms.Label displayAverageLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempMinLbl;
        private System.Windows.Forms.Label tempMaxLbl;
        private System.Windows.Forms.Label label1;
    }
}