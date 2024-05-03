namespace _17
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
            SearchButton = new Button();
            BookListBox = new ListBox();
            AuthorTextBox = new TextBox();
            TitleTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(811, 10);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 68);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "ПОШУК";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 15;
            BookListBox.Location = new Point(18, 94);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(868, 274);
            BookListBox.TabIndex = 1;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(129, 55);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(657, 23);
            AuthorTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(129, 10);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(657, 23);
            TitleTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Назва видання:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 58);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 5;
            label2.Text = "Автор видання:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 383);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TitleTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(BookListBox);
            Controls.Add(SearchButton);
            Name = "Form1";
            Text = "Пошук книг у базі даних сайту за автором та назвою видання ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private ListBox BookListBox;
        private TextBox AuthorTextBox;
        private TextBox TitleTextBox;
        private Label label1;
        private Label label2;
    }
}
