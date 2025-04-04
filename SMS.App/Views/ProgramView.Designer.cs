namespace SMS.App
{
    partial class ProgramView
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
            txtBoxProgramName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxDescription = new TextBox();
            label3 = new Label();
            txtBoxId = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            dataGridViewProgramList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // txtBoxProgramName
            // 
            txtBoxProgramName.Location = new Point(31, 74);
            txtBoxProgramName.Name = "txtBoxProgramName";
            txtBoxProgramName.Size = new Size(176, 23);
            txtBoxProgramName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(31, 121);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(176, 23);
            txtBoxDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 12);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 5;
            label3.Text = "ID";
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(31, 30);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.Size = new Size(176, 23);
            txtBoxId.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(31, 150);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(176, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(31, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(31, 179);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(176, 23);
            btnRead.TabIndex = 8;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(31, 237);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(246, 12);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.Size = new Size(420, 248);
            dataGridViewProgramList.TabIndex = 11;
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(txtBoxId);
            Controls.Add(label2);
            Controls.Add(txtBoxDescription);
            Controls.Add(label1);
            Controls.Add(txtBoxProgramName);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxProgramName;
        private Label label1;
        private Label label2;
        private TextBox txtBoxDescription;
        private Label label3;
        private TextBox txtBoxId;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnRead;
        private Button btnDelete;
        private DataGridView dataGridViewProgramList;
    }
}