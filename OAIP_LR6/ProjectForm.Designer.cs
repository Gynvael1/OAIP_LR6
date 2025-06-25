namespace OAIP_LR6
{
    partial class ProjectForm
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
            textBoxTitle = new TextBox();
            comboBoxStatus = new ComboBox();
            textBoxAddress = new TextBox();
            richTextBoxDescription = new RichTextBox();
            buttonAdd = new Button();
            labelCancel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(310, 31);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 0;
            label1.Text = "Добавление проекта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 116);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 213);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 126);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 126);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Адрес";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(61, 154);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(211, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(326, 154);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(531, 154);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(324, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDescription.Location = new Point(61, 253);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(521, 177);
            richTextBoxDescription.TabIndex = 8;
            richTextBoxDescription.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(657, 294);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(186, 55);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить ";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelCancel
            // 
            labelCancel.AutoSize = true;
            labelCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelCancel.ForeColor = SystemColors.Highlight;
            labelCancel.Location = new Point(710, 366);
            labelCancel.Name = "labelCancel";
            labelCancel.Size = new Size(74, 25);
            labelCancel.TabIndex = 10;
            labelCancel.Text = "Отмена";
            labelCancel.Click += labelCancel_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 520);
            Controls.Add(labelCancel);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxAddress);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProjectForm";
            Text = "Добавление проекта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox textBoxTitle;
        public ComboBox comboBoxStatus;
        public TextBox textBoxAddress;
        public RichTextBox richTextBoxDescription;
        private Button buttonAdd;
        private Label labelCancel;
    }
}