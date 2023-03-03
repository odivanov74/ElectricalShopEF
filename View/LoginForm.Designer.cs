
namespace ElectricalDevicesEF.View
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
            this.Registration_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginInput_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Registration_LinkLabel
            // 
            this.Registration_LinkLabel.AutoSize = true;
            this.Registration_LinkLabel.Location = new System.Drawing.Point(18, 85);
            this.Registration_LinkLabel.Name = "Registration_LinkLabel";
            this.Registration_LinkLabel.Size = new System.Drawing.Size(184, 13);
            this.Registration_LinkLabel.TabIndex = 21;
            this.Registration_LinkLabel.TabStop = true;
            this.Registration_LinkLabel.Text = "Регистрация нового пользователя";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(185, 113);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(136, 23);
            this.Cancel_button.TabIndex = 20;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(43, 113);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(136, 23);
            this.Login_button.TabIndex = 19;
            this.Login_button.Text = "Войти";
            this.Login_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль:";
            // 
            // PasswordInput_textBox
            // 
            this.PasswordInput_textBox.Location = new System.Drawing.Point(89, 53);
            this.PasswordInput_textBox.Name = "PasswordInput_textBox";
            this.PasswordInput_textBox.PasswordChar = '*';
            this.PasswordInput_textBox.Size = new System.Drawing.Size(247, 20);
            this.PasswordInput_textBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Имя:";
            // 
            // LoginInput_textBox
            // 
            this.LoginInput_textBox.Location = new System.Drawing.Point(89, 22);
            this.LoginInput_textBox.Name = "LoginInput_textBox";
            this.LoginInput_textBox.Size = new System.Drawing.Size(247, 20);
            this.LoginInput_textBox.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 146);
            this.Controls.Add(this.Registration_LinkLabel);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordInput_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginInput_textBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Registration_LinkLabel;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordInput_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginInput_textBox;
    }
}