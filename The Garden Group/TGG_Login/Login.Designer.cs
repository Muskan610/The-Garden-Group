namespace TGG_App
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnameTxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswdTxtbox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.RemMeCheckBox = new System.Windows.Forms.CheckBox();
            this.ForgorPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NoDesk: TGG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // UnameTxtbox
            // 
            this.UnameTxtbox.Location = new System.Drawing.Point(109, 141);
            this.UnameTxtbox.Name = "UnameTxtbox";
            this.UnameTxtbox.Size = new System.Drawing.Size(269, 20);
            this.UnameTxtbox.TabIndex = 3;
            this.UnameTxtbox.Text = "test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // PasswdTxtbox
            // 
            this.PasswdTxtbox.AcceptsReturn = true;
            this.PasswdTxtbox.Location = new System.Drawing.Point(109, 236);
            this.PasswdTxtbox.Name = "PasswdTxtbox";
            this.PasswdTxtbox.Size = new System.Drawing.Size(275, 20);
            this.PasswdTxtbox.TabIndex = 3;
            this.PasswdTxtbox.Text = "test";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Loginbtn.Location = new System.Drawing.Point(176, 313);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(107, 45);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // RemMeCheckBox
            // 
            this.RemMeCheckBox.AutoSize = true;
            this.RemMeCheckBox.Location = new System.Drawing.Point(109, 279);
            this.RemMeCheckBox.Name = "RemMeCheckBox";
            this.RemMeCheckBox.Size = new System.Drawing.Size(95, 17);
            this.RemMeCheckBox.TabIndex = 5;
            this.RemMeCheckBox.Text = "Remember Me";
            this.RemMeCheckBox.UseVisualStyleBackColor = true;
            this.RemMeCheckBox.CheckedChanged += new System.EventHandler(this.RemMeCheckBox_CheckedChanged);
            // 
            // ForgorPassLinkLabel
            // 
            this.ForgorPassLinkLabel.AutoSize = true;
            this.ForgorPassLinkLabel.Location = new System.Drawing.Point(292, 283);
            this.ForgorPassLinkLabel.Name = "ForgorPassLinkLabel";
            this.ForgorPassLinkLabel.Size = new System.Drawing.Size(92, 13);
            this.ForgorPassLinkLabel.TabIndex = 6;
            this.ForgorPassLinkLabel.TabStop = true;
            this.ForgorPassLinkLabel.Text = "Forgot Password?";
            this.ForgorPassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgorPassLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 406);
            this.Controls.Add(this.ForgorPassLinkLabel);
            this.Controls.Add(this.RemMeCheckBox);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswdTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UnameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnameTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswdTxtbox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.CheckBox RemMeCheckBox;
        private System.Windows.Forms.LinkLabel ForgorPassLinkLabel;
    }
}

