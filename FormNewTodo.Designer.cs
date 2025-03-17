namespace TodoList2
{
    partial class FormNewTodo
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
            dateTimePicker1 = new DateTimePicker();
            txtTodoInput = new TextBox();
            pictureBoxTodoImage = new PictureBox();
            richTextBoxMemoInput = new RichTextBox();
            txtSearchImage = new TextBox();
            btnSearchImage = new Button();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTodoImage).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtTodoInput
            // 
            txtTodoInput.Location = new Point(233, 12);
            txtTodoInput.Name = "txtTodoInput";
            txtTodoInput.Size = new Size(389, 23);
            txtTodoInput.TabIndex = 3;
            // 
            // pictureBoxTodoImage
            // 
            pictureBoxTodoImage.Location = new Point(12, 41);
            pictureBoxTodoImage.Name = "pictureBoxTodoImage";
            pictureBoxTodoImage.Size = new Size(216, 216);
            pictureBoxTodoImage.TabIndex = 8;
            pictureBoxTodoImage.TabStop = false;
            // 
            // richTextBoxMemoInput
            // 
            richTextBoxMemoInput.Location = new Point(233, 41);
            richTextBoxMemoInput.Name = "richTextBoxMemoInput";
            richTextBoxMemoInput.Size = new Size(389, 216);
            richTextBoxMemoInput.TabIndex = 9;
            richTextBoxMemoInput.Text = "";
            // 
            // txtSearchImage
            // 
            txtSearchImage.Location = new Point(12, 263);
            txtSearchImage.Name = "txtSearchImage";
            txtSearchImage.Size = new Size(135, 23);
            txtSearchImage.TabIndex = 10;
            // 
            // btnSearchImage
            // 
            btnSearchImage.Location = new Point(153, 263);
            btnSearchImage.Name = "btnSearchImage";
            btnSearchImage.Size = new Size(75, 23);
            btnSearchImage.TabIndex = 11;
            btnSearchImage.Text = "검색";
            btnSearchImage.UseVisualStyleBackColor = true;
            btnSearchImage.Click += btnSearchImage_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(547, 263);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 12;
            btnNew.Text = "저장";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // FormNewTodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 291);
            Controls.Add(btnNew);
            Controls.Add(btnSearchImage);
            Controls.Add(txtSearchImage);
            Controls.Add(richTextBoxMemoInput);
            Controls.Add(pictureBoxTodoImage);
            Controls.Add(txtTodoInput);
            Controls.Add(dateTimePicker1);
            Name = "FormNewTodo";
            Text = "FormNewTodo";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTodoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtTodoInput;
        private PictureBox pictureBoxTodoImage;
        private RichTextBox richTextBoxMemoInput;
        private TextBox txtSearchImage;
        private Button btnSearchImage;
        private Button btnNew;
    }
}
