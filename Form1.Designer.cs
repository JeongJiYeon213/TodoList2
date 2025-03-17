namespace TodoList2
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
            listViewTodo = new ListView();
            dateTimePicker = new DateTimePicker();
            txtTodo = new TextBox();
            richTextBoxMemo = new RichTextBox();
            btnSave = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            pictureBoxImage = new PictureBox();
            txtSearchImage = new TextBox();
            btnSearchImage = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabelComplete = new ToolStripStatusLabel();
            toolStripStatusLabelIncomplete = new ToolStripStatusLabel();
            toolStripStatusLabelTotal = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listViewTodo
            // 
            listViewTodo.CheckBoxes = true;
            listViewTodo.FullRowSelect = true;
            listViewTodo.Location = new Point(12, 12);
            listViewTodo.Name = "listViewTodo";
            listViewTodo.Size = new Size(611, 247);
            listViewTodo.TabIndex = 0;
            listViewTodo.UseCompatibleStateImageBehavior = false;
            listViewTodo.View = View.Details;
            listViewTodo.ItemChecked += listViewTodo_ItemChecked;
            listViewTodo.SelectedIndexChanged += listViewTodo_SelectedIndexChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(12, 265);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(216, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // txtTodo
            // 
            txtTodo.Location = new Point(234, 265);
            txtTodo.Name = "txtTodo";
            txtTodo.Size = new Size(389, 23);
            txtTodo.TabIndex = 2;
            // 
            // richTextBoxMemo
            // 
            richTextBoxMemo.Location = new Point(234, 294);
            richTextBoxMemo.Name = "richTextBoxMemo";
            richTextBoxMemo.Size = new Size(389, 124);
            richTextBoxMemo.TabIndex = 3;
            richTextBoxMemo.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(386, 422);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(467, 422);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 5;
            btnModify.Text = "수정";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(548, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(12, 294);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(216, 122);
            pictureBoxImage.TabIndex = 7;
            pictureBoxImage.TabStop = false;
            // 
            // txtSearchImage
            // 
            txtSearchImage.Location = new Point(12, 423);
            txtSearchImage.Name = "txtSearchImage";
            txtSearchImage.Size = new Size(135, 23);
            txtSearchImage.TabIndex = 8;
            // 
            // btnSearchImage
            // 
            btnSearchImage.Location = new Point(153, 422);
            btnSearchImage.Name = "btnSearchImage";
            btnSearchImage.Size = new Size(75, 23);
            btnSearchImage.TabIndex = 9;
            btnSearchImage.Text = "검색";
            btnSearchImage.UseVisualStyleBackColor = true;
            btnSearchImage.Click += btnSearchImage_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelComplete, toolStripStatusLabelIncomplete, toolStripStatusLabelTotal });
            statusStrip.Location = new Point(0, 449);
            statusStrip.Name = "statusStrip";
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusStrip.Size = new Size(634, 22);
            statusStrip.TabIndex = 10;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelComplete
            // 
            toolStripStatusLabelComplete.Name = "toolStripStatusLabelComplete";
            toolStripStatusLabelComplete.Size = new Size(45, 17);
            toolStripStatusLabelComplete.Text = "완료: 0";
            // 
            // toolStripStatusLabelIncomplete
            // 
            toolStripStatusLabelIncomplete.Name = "toolStripStatusLabelIncomplete";
            toolStripStatusLabelIncomplete.Size = new Size(57, 17);
            toolStripStatusLabelIncomplete.Text = "미완료: 0";
            // 
            // toolStripStatusLabelTotal
            // 
            toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            toolStripStatusLabelTotal.Size = new Size(45, 17);
            toolStripStatusLabelTotal.Text = "전체: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 471);
            Controls.Add(statusStrip);
            Controls.Add(btnSearchImage);
            Controls.Add(txtSearchImage);
            Controls.Add(pictureBoxImage);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnSave);
            Controls.Add(richTextBoxMemo);
            Controls.Add(txtTodo);
            Controls.Add(dateTimePicker);
            Controls.Add(listViewTodo);
            Name = "Form1";
            Text = "TodoList";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewTodo;
        private DateTimePicker dateTimePicker;
        private TextBox txtTodo;
        private RichTextBox richTextBoxMemo;
        private Button btnSave;
        private Button btnModify;
        private Button btnDelete;
        private PictureBox pictureBoxImage;
        private TextBox txtSearchImage;
        private Button btnSearchImage;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelComplete;
        private ToolStripStatusLabel toolStripStatusLabelIncomplete;
        private ToolStripStatusLabel toolStripStatusLabelTotal;
    }
}
