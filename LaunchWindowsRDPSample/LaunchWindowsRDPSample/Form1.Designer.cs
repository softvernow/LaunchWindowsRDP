namespace LaunchWindowsRDPSample
{
    partial class Form1
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
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(66, 21);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.PasswordChar = '*';
            this.txtMachineName.Size = new System.Drawing.Size(183, 20);
            this.txtMachineName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Machine:";
            // 
            // btnRDP
            // 
            this.btnRDP.Location = new System.Drawing.Point(12, 50);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(237, 23);
            this.btnRDP.TabIndex = 9;
            this.btnRDP.Text = "RDP";
            this.btnRDP.UseVisualStyleBackColor = true;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 87);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRDP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRDP;
    }
}

