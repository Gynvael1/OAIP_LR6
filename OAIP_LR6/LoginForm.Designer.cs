namespace OAIP_LR6
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
            label1 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label5 = new Label();
            buttonRegister = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(158, 46);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(91, 157);
            textBoxEmail.MaxLength = 80;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(315, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 119);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "EMAIL";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(114, 246);
            textBoxPassword.MaxLength = 65;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '❤';
            textBoxPassword.Size = new Size(273, 27);
            textBoxPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 203);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 10;
            label5.Text = "Пароль";
            // 
            // buttonRegister
            // 
            buttonRegister.AutoSize = true;
            buttonRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = SystemColors.MenuHighlight;
            buttonRegister.Location = new Point(194, 371);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(128, 20);
            buttonRegister.TabIndex = 12;
            buttonRegister.Text = "Еще не зареганы";
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(179, 299);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(161, 41);
            buttonLogin.TabIndex = 13;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label5;
        private Label buttonRegister;
        private Button buttonLogin;
    }
}