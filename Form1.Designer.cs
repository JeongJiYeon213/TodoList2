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
            btnNew = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            pictureBoxImage = new PictureBox();
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
            listViewTodo.Size = new Size(611, 153);
            listViewTodo.TabIndex = 0;
            listViewTodo.UseCompatibleStateImageBehavior = false;
            listViewTodo.View = View.Details;
            listViewTodo.ItemChecked += listViewTodo_ItemChecked;
            listViewTodo.SelectedIndexChanged += listViewTodo_SelectedIndexChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(12, 171);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(216, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // txtTodo
            // 
            txtTodo.Location = new Point(234, 171);
            txtTodo.Name = "txtTodo";
            txtTodo.Size = new Size(389, 23);
            txtTodo.TabIndex = 2;
            // 
            // richTextBoxMemo
            // 
            richTextBoxMemo.Location = new Point(234, 200);
            richTextBoxMemo.Name = "richTextBoxMemo";
            richTextBoxMemo.Size = new Size(389, 215);
            richTextBoxMemo.TabIndex = 3;
            richTextBoxMemo.Text = "";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(386, 421);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 4;
            btnNew.Text = "신규";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(467, 421);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 5;
            btnModify.Text = "수정";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(548, 421);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(12, 200);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(216, 216);
            pictureBoxImage.TabIndex = 7;
            pictureBoxImage.TabStop = false;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelComplete, toolStripStatusLabelIncomplete, toolStripStatusLabelTotal });
            statusStrip.Location = new Point(0, 448);
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
            ClientSize = new Size(634, 470);
            Controls.Add(statusStrip);
            Controls.Add(pictureBoxImage);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnNew);
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
        private Button btnNew;
        private Button btnModify;
        private Button btnDelete;
        private PictureBox pictureBoxImage;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelComplete;
        private ToolStripStatusLabel toolStripStatusLabelIncomplete;
        private ToolStripStatusLabel toolStripStatusLabelTotal;
    }
}
