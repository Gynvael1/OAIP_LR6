using System;
using System.Windows.Forms;

namespace OAIP_LR6
{
    public partial class StatusForm : Form
    {
        private readonly int projectId;

        public StatusForm(Project project)
        {
            InitializeComponent();
            projectId = project.Id;
            labelProjectName.Text = $"Проект: {project.Title}";
            labelCurrentStatus.Text = $"Текущий статус: {project.Status}";
            comboBoxNewStatus.Items.AddRange(new[] { "Планируется", "В процессе", "Завершен" });
            comboBoxNewStatus.SelectedItem = project.Status;
        }

        private void buttonSaveStatus_Click(object sender, EventArgs e)
        {
            if (comboBoxNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите новый статус");
                return;
            }

            string newStatus = comboBoxNewStatus.SelectedItem.ToString();

            using var context = new AppDbContext();
            var project = context.Projects.Find(projectId);

            if (project == null)
            {
                MessageBox.Show("Проект не найден");
                return;
            }

            if (newStatus == project.Status)
            {
                MessageBox.Show("Выбран текущий статус");
                return;
            }

            project.Status = newStatus;
            context.SaveChanges();

            MessageBox.Show("Статус обновлен!");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}