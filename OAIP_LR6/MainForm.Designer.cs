namespace OAIP_LR6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcome = new Label();
            dataGridViewProjects = new DataGridView();
            groupBox1 = new GroupBox();
            buttonShowDescription = new Button();
            buttonExit = new Button();
            buttonDeleteProject = new Button();
            buttonEditStatus = new Button();
            buttonAddProject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWelcome.Location = new Point(47, 25);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(288, 41);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Имя, ваши проекты";
            // 
            // dataGridViewProjects
            // 
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjects.Location = new Point(47, 96);
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.RowHeadersWidth = 51;
            dataGridViewProjects.Size = new Size(684, 410);
            dataGridViewProjects.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonShowDescription);
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Controls.Add(buttonDeleteProject);
            groupBox1.Controls.Add(buttonEditStatus);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Location = new Point(763, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 410);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // buttonShowDescription
            // 
            buttonShowDescription.Location = new Point(27, 245);
            buttonShowDescription.Name = "buttonShowDescription";
            buttonShowDescription.Size = new Size(169, 37);
            buttonShowDescription.TabIndex = 6;
            buttonShowDescription.Text = "Описание";
            buttonShowDescription.UseVisualStyleBackColor = true;
            buttonShowDescription.Click += buttonShowDescription_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(65, 357);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(109, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDeleteProject
            // 
            buttonDeleteProject.Location = new Point(27, 181);
            buttonDeleteProject.Name = "buttonDeleteProject";
            buttonDeleteProject.Size = new Size(169, 37);
            buttonDeleteProject.TabIndex = 4;
            buttonDeleteProject.Text = "Удалить проект";
            buttonDeleteProject.UseVisualStyleBackColor = true;
            buttonDeleteProject.Click += buttonDeleteProject_Click;
            // 
            // buttonEditStatus
            // 
            buttonEditStatus.Location = new Point(27, 116);
            buttonEditStatus.Name = "buttonEditStatus";
            buttonEditStatus.Size = new Size(169, 37);
            buttonEditStatus.TabIndex = 3;
            buttonEditStatus.Text = "Изменить статус";
            buttonEditStatus.UseVisualStyleBackColor = true;
            buttonEditStatus.Click += buttonEditStatus_Click;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Location = new Point(27, 50);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(169, 39);
            buttonAddProject.TabIndex = 0;
            buttonAddProject.Text = "Добавить проект";
            buttonAddProject.UseVisualStyleBackColor = true;
            buttonAddProject.Click += buttonAddProject_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 541);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewProjects);
            Controls.Add(labelWelcome);
            Name = "MainForm";
            Text = "Учет проектов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private DataGridView dataGridViewProjects;
        private GroupBox groupBox1;
        private Button buttonExit;
        private Button buttonDeleteProject;
        private Button buttonEditStatus;
        private Button buttonAddProject;
        private Button buttonShowDescription;
    }
}
