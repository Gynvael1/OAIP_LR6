namespace OAIP_LR6
{
    partial class EngineerRegistrationForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxSpecialization = new ComboBox();
            buttonRegister = new Button();
            labelAlreadyReg = new Label();
            buttonPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(187, 31);
            label1.Name = "label1";
            label1.Size = new Size(313, 38);
            label1.TabIndex = 0;
            label1.Text = "Регистрация инженера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 127);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 245);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "EMAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 245);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Специализация";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 127);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Пароль";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(77, 171);
            textBoxName.MaxLength = 40;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(187, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(380, 171);
            textBoxPassword.MaxLength = 65;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '❤';
            textBoxPassword.Size = new Size(273, 27);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(32, 281);
            textBoxEmail.MaxLength = 80;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(315, 27);
            textBoxEmail.TabIndex = 7;
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(442, 280);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(151, 28);
            comboBoxSpecialization.TabIndex = 8;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(237, 344);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(239, 48);
            buttonRegister.TabIndex = 9;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelAlreadyReg
            // 
            labelAlreadyReg.AutoSize = true;
            labelAlreadyReg.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelAlreadyReg.ForeColor = SystemColors.MenuHighlight;
            labelAlreadyReg.Location = new Point(308, 415);
            labelAlreadyReg.Name = "labelAlreadyReg";
            labelAlreadyReg.Size = new Size(107, 20);
            labelAlreadyReg.TabIndex = 10;
            labelAlreadyReg.Text = "Уже зареганы";
            labelAlreadyReg.Click += labelAlreadyReg_Click;
            // 
            // buttonPass
            // 
            buttonPass.Location = new Point(659, 169);
            buttonPass.Name = "buttonPass";
            buttonPass.Size = new Size(30, 29);
            buttonPass.TabIndex = 11;
            buttonPass.Text = "👁";
            buttonPass.UseVisualStyleBackColor = true;
            buttonPass.MouseDown += buttonPass_MouseDown;
            buttonPass.MouseUp += buttonPass_MouseUp;
            // 
            // EngineerRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 498);
            Controls.Add(buttonPass);
            Controls.Add(labelAlreadyReg);
            Controls.Add(buttonRegister);
            Controls.Add(comboBoxSpecialization);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EngineerRegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private ComboBox comboBoxSpecialization;
        private Button buttonRegister;
        private Label labelAlreadyReg;
        private Button buttonPass;
    }
}