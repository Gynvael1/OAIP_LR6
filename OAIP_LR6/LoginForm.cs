using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OAIP_LR6
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Введите email");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            using var db = new AppDbContext();
            string hashedPassword = GetHashString(password);
            var engineer = db.Engineers.FirstOrDefault(e => e.Email == email && e.Password == hashedPassword);

            if (engineer == null)
            {
                MessageBox.Show("Неверный email или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mainForm = new MainForm(engineer);
            mainForm.Show();
            Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var regForm = new EngineerRegistrationForm();
            regForm.Show();
            Hide();
        }
    }
}