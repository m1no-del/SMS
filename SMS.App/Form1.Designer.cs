namespace SMS.App
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxId = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            buttonShow = new Button();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 136);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 165);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 194);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Student Email";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(334, 128);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(185, 23);
            textBoxId.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(334, 186);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(185, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(334, 157);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 23);
            textBoxName.TabIndex = 5;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(248, 67);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(271, 34);
            buttonShow.TabIndex = 6;
            buttonShow.Text = "SHOW INFORMATION";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(334, 218);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(108, 15);
            labelAddedInformation.TabIndex = 8;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAddedInformation);
            Controls.Add(buttonShow);
            Controls.Add(textBoxName);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxId;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Button buttonShow;
        private Label labelAddedInformation;
    }
}
