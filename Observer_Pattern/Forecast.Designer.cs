namespace Observer_Pattern
{
    partial class Forecast
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
            this.displayExpConLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(34, 178);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(152, 23);
            this.regBtn.TabIndex = 27;
            this.regBtn.Text = "Register As Observer";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // deRegBtn
            // 
            this.deRegBtn.Location = new System.Drawing.Point(199, 178);
            this.deRegBtn.Name = "deRegBtn";
            this.deRegBtn.Size = new System.Drawing.Size(152, 23);
            this.deRegBtn.TabIndex = 26;
            this.deRegBtn.Text = "De-Register As Observer";
            this.deRegBtn.UseVisualStyleBackColor = true;
            this.deRegBtn.Click += new System.EventHandler(this.DeRegBtn_Click);
            // 
            // displayExpConLbl
            // 
            this.displayExpConLbl.AutoSize = true;
            this.displayExpConLbl.Location = new System.Drawing.Point(205, 108);
            this.displayExpConLbl.Name = "displayExpConLbl";
            this.displayExpConLbl.Size = new System.Drawing.Size(85, 13);
            this.displayExpConLbl.TabIndex = 23;
            this.displayExpConLbl.Text = "_____________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Forecast";
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Location = new System.Drawing.Point(84, 108);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(102, 13);
            this.tempLbl.TabIndex = 19;
            this.tempLbl.Text = "Expected Condition:";
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 233);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.deRegBtn);
            this.Controls.Add(this.displayExpConLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempLbl);
            this.Name = "Forecast";
            this.Text = "Forecast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button deRegBtn;
        private System.Windows.Forms.Label displayExpConLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempLbl;
    }
}