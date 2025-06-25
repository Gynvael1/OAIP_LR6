using System;
using System.Windows.Forms;

namespace OAIP_LR6
{
    public partial class ProjectForm : Form
    {
        private readonly Engineer engineer;

        public ProjectForm(Engineer engineer)
        {
            InitializeComponent();
            this.engineer = engineer;

            comboBoxStatus.Items.AddRange(new[] { "Планируется", "В процессе", "Завершен" });
            comboBoxStatus.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Введите название проекта");
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                MessageBox.Show("Введите описание проекта");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес проекта");
                return;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите статус проекта");
                return;
            }

            using var context = new AppDbContext();

            var project = new Project
            {
                Title = textBoxTitle.Text,
                Description = richTextBoxDescription.Text,
                Address = textBoxAddress.Text,
                Status = comboBoxStatus.SelectedItem?.ToString() ?? "Планируется",
                EngineerId = engineer.Id
            };

            context.Projects.Add(project);
            context.SaveChanges();

            MessageBox.Show("Проект добавлен!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void labelCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}