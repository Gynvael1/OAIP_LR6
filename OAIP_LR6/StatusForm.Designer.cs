namespace OAIP_LR6
{
    partial class StatusForm
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
            labelProjectName = new Label();
            labelCurrentStatus = new Label();
            comboBoxNewStatus = new ComboBox();
            buttonSaveStatus = new Button();
            SuspendLayout();
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(66, 54);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(62, 20);
            labelProjectName.TabIndex = 0;
            labelProjectName.Text = "Проект:";
            // 
            // labelCurrentStatus
            // 
            labelCurrentStatus.AutoSize = true;
            labelCurrentStatus.Location = new Point(66, 114);
            labelCurrentStatus.Name = "labelCurrentStatus";
            labelCurrentStatus.Size = new Size(117, 20);
            labelCurrentStatus.TabIndex = 1;
            labelCurrentStatus.Text = "Текущий статус:";
            // 
            // comboBoxNewStatus
            // 
            comboBoxNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNewStatus.FormattingEnabled = true;
            comboBoxNewStatus.Location = new Point(66, 161);
            comboBoxNewStatus.Name = "comboBoxNewStatus";
            comboBoxNewStatus.Size = new Size(151, 28);
            comboBoxNewStatus.TabIndex = 2;
            // 
            // buttonSaveStatus
            // 
            buttonSaveStatus.Location = new Point(449, 92);
            buttonSaveStatus.Name = "buttonSaveStatus";
            buttonSaveStatus.Size = new Size(128, 42);
            buttonSaveStatus.TabIndex = 3;
            buttonSaveStatus.Text = "Сохранить";
            buttonSaveStatus.UseVisualStyleBackColor = true;
            buttonSaveStatus.Click += buttonSaveStatus_Click;
            // 
            // StatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 245);
            Controls.Add(buttonSaveStatus);
            Controls.Add(comboBoxNewStatus);
            Controls.Add(labelCurrentStatus);
            Controls.Add(labelProjectName);
            Name = "StatusForm";
            Text = "Изменение статуса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProjectName;
        private Label labelCurrentStatus;
        private ComboBox comboBoxNewStatus;
        private Button buttonSaveStatus;
    }
}

