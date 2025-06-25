using System;
using System.Linq;
using System.Windows.Forms;

namespace OAIP_LR6
{
    public partial class MainForm : Form
    {
        private readonly int engineerId;

        public MainForm(Engineer engineer)
        {
            InitializeComponent();
            engineerId = engineer.Id;
            labelWelcome.Text = $"��������...";
            LoadProjects();
        }

        private void LoadProjects()
        {
            using var context = new AppDbContext();
            var projects = context.Projects.Where(p => p.EngineerId == engineerId).ToList();

            if (projects.Count == 0)
            {
                labelWelcome.Text = $"{context.Engineers.Find(engineerId)?.Name}, � ��� ��� ��������";
            }
            else
            {
                labelWelcome.Text = $"{context.Engineers.Find(engineerId)?.Name}, ���� �������:";
            }

            dataGridViewProjects.DataSource = projects;

            foreach (DataGridViewColumn column in dataGridViewProjects.Columns)
            {
                switch (column.Name)
                {
                    case "Id":
                        column.HeaderText = "ID";
                        break;
                    case "Title":
                        column.HeaderText = "�������� �������";
                        break;
                    case "Description":
                        column.HeaderText = "��������";
                        break;
                    case "Address":
                        column.HeaderText = "�����";
                        break;
                    case "Status":
                        column.HeaderText = "������";
                        break;
                    case "EngineerId":
                        column.HeaderText = "ID ��������";
                        break;
                    default:
                        column.HeaderText = column.Name;
                        break;
                }
            }
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            var projectForm = new ProjectForm(new Engineer { Id = engineerId });
            if (projectForm.ShowDialog() == DialogResult.OK)
            {
                LoadProjects();
            }
        }

        private void buttonDeleteProject_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ � �������");
                return;
            }

            var selectedProject = dataGridViewProjects.SelectedRows[0].DataBoundItem as Project;
            if (selectedProject == null) return;

            using var context = new AppDbContext();
            var project = context.Projects.Find(selectedProject.Id);
            if (project != null)
            {
                context.Projects.Remove(project);
                context.SaveChanges();
                LoadProjects();
            }
        }

        private void buttonEditStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ � �������");
                return;
            }

            var selectedProject = dataGridViewProjects.SelectedRows[0].DataBoundItem as Project;
            if (selectedProject == null) return;

            var statusForm = new StatusForm(selectedProject);
            if (statusForm.ShowDialog() == DialogResult.OK)
            {
                LoadProjects();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void buttonShowDescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("�������� ������ � �������");
                return;
            }

            var selectedProject = dataGridViewProjects.SelectedRows[0].DataBoundItem as Project;
            if (selectedProject?.Description != null)
            {
                MessageBox.Show(selectedProject.Description, "�������� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}