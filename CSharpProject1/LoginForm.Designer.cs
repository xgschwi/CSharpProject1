namespace CSharpProject1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userText = new MetroFramework.Controls.MetroTextBox();
            this.passText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPass = new MetroFramework.Controls.MetroLabel();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSharpProject1.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(33, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userText
            // 
            this.userText.BackColor = System.Drawing.Color.DimGray;
            // 
            // 
            // 
            this.userText.CustomButton.Image = null;
            this.userText.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.userText.CustomButton.Name = "";
            this.userText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userText.CustomButton.TabIndex = 1;
            this.userText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userText.CustomButton.UseSelectable = true;
            this.userText.CustomButton.Visible = false;
            this.userText.Lines = new string[0];
            this.userText.Location = new System.Drawing.Point(53, 228);
            this.userText.MaxLength = 32767;
            this.userText.Name = "userText";
            this.userText.PasswordChar = '\0';
            this.userText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userText.SelectedText = "";
            this.userText.SelectionLength = 0;
            this.userText.SelectionStart = 0;
            this.userText.ShortcutsEnabled = true;
            this.userText.Size = new System.Drawing.Size(147, 23);
            this.userText.TabIndex = 7;
            this.userText.UseSelectable = true;
            this.userText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passText
            // 
            this.passText.BackColor = System.Drawing.Color.DimGray;
            // 
            // 
            // 
            this.passText.CustomButton.Image = null;
            this.passText.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.passText.CustomButton.Name = "";
            this.passText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passText.CustomButton.TabIndex = 1;
            this.passText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passText.CustomButton.UseSelectable = true;
            this.passText.CustomButton.Visible = false;
            this.passText.Lines = new string[0];
            this.passText.Location = new System.Drawing.Point(53, 303);
            this.passText.MaxLength = 32767;
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passText.SelectedText = "";
            this.passText.SelectionLength = 0;
            this.passText.SelectionStart = 0;
            this.passText.ShortcutsEnabled = true;
            this.passText.Size = new System.Drawing.Size(147, 23);
            this.passText.TabIndex = 8;
            this.passText.UseSelectable = true;
            this.passText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelUser
            // 
            this.metroLabelUser.AutoSize = true;
            this.metroLabelUser.Location = new System.Drawing.Point(53, 195);
            this.metroLabelUser.Name = "metroLabelUser";
            this.metroLabelUser.Size = new System.Drawing.Size(42, 20);
            this.metroLabelUser.TabIndex = 9;
            this.metroLabelUser.Text = "User:";
            // 
            // metroLabelPass
            // 
            this.metroLabelPass.AutoSize = true;
            this.metroLabelPass.Location = new System.Drawing.Point(53, 270);
            this.metroLabelPass.Name = "metroLabelPass";
            this.metroLabelPass.Size = new System.Drawing.Size(69, 20);
            this.metroLabelPass.TabIndex = 10;
            this.metroLabelPass.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(138, 369);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 425);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.metroLabelPass);
            this.Controls.Add(this.metroLabelUser);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox userText;
        private MetroFramework.Controls.MetroTextBox passText;
        private MetroFramework.Controls.MetroLabel metroLabelUser;
        private MetroFramework.Controls.MetroLabel metroLabelPass;
        private MetroFramework.Controls.MetroButton loginBtn;
    }
}