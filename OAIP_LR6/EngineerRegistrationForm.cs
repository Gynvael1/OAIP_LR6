using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OAIP_LR6
{
    public partial class EngineerRegistrationForm : Form
    {
        public EngineerRegistrationForm()
        {
            InitializeComponent();
            comboBoxSpecialization.Items.AddRange(new[]
            {
                "Проектировщик",
                "Архитектор",
                "Конструктор",
                "Электрик",
                "Инженер ПТО"
            });
            textBoxName.KeyPress += TextBoxName_KeyPress;
            comboBoxSpecialization.SelectedIndex = 0;
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            using var md5 = MD5.Create();
            byte[] byteHash = md5.ComputeHash(bytes);
            var hash = string.Empty;
            foreach (var b in byteHash)
                hash += b.ToString("x2");
            return hash;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Введите email");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (comboBoxSpecialization.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите специализацию");
                return;
            }

            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен быть не менее 8 символов");
                return;
            }

            if (!textBoxPassword.Text.Any(char.IsDigit) || !textBoxPassword.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Пароль должен содержать и буквы, и цифры");
                return;
            }

            try
            {
                var addr = new MailAddress(textBoxEmail.Text);
            }
            catch
            {
                MessageBox.Show("E-mail в неверном формате");
                return;
            }

            try
            {
                string domain = textBoxEmail.Text.Split('@')[1];
                Dns.GetHostEntry(domain);
            }
            catch
            {
                MessageBox.Show("Домен почты не существует или не отвечает");
                return;
            }

            using var db = new AppDbContext();

            if (db.Engineers.Any(e => e.Email == textBoxEmail.Text))
            {
                MessageBox.Show("Этот email уже зарегистрирован");
                return;
            }

            string StrName = textBoxEmail.Text;
            StrName = char.ToUpper(StrName[0]) + StrName.Substring(1).ToLower();

            var engineer = new Engineer
            {
                Name = textBoxName.Text,
                Email = textBoxEmail.Text,
                Password = GetHashString(textBoxPassword.Text),
                Specialization = comboBoxSpecialization.SelectedItem?.ToString() ?? ""
            };

            db.Engineers.Add(engineer);
            db.SaveChanges();

            MessageBox.Show("Регистрация успешна!");
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void labelAlreadyReg_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void buttonPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '❤';
        }
    }
}