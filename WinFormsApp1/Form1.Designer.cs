namespace WinFormsApp1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addButton = new Button();
            countTB = new TextBox();
            yearTB = new TextBox();
            nameTB = new TextBox();
            authorTB = new TextBox();
            articleTB = new TextBox();
            tabPage3 = new TabPage();
            searchButton = new Button();
            searchTB = new TextBox();
            searchCB = new ComboBox();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(597, 337);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(589, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список книг";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(577, 297);
            dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(addButton);
            tabPage2.Controls.Add(countTB);
            tabPage2.Controls.Add(yearTB);
            tabPage2.Controls.Add(nameTB);
            tabPage2.Controls.Add(authorTB);
            tabPage2.Controls.Add(articleTB);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(589, 309);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить книгу";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 133);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 10;
            label5.Text = "Количество:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 104);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Год издания:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Автор:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Артикул:";
            // 
            // addButton
            // 
            addButton.Location = new Point(98, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(105, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Добавить книгу";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // countTB
            // 
            countTB.Location = new Point(98, 130);
            countTB.Name = "countTB";
            countTB.Size = new Size(171, 23);
            countTB.TabIndex = 4;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(98, 101);
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(171, 23);
            yearTB.TabIndex = 3;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(98, 72);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(171, 23);
            nameTB.TabIndex = 2;
            // 
            // authorTB
            // 
            authorTB.Location = new Point(98, 43);
            authorTB.Name = "authorTB";
            authorTB.Size = new Size(171, 23);
            authorTB.TabIndex = 1;
            // 
            // articleTB
            // 
            articleTB.Location = new Point(98, 12);
            articleTB.Name = "articleTB";
            articleTB.Size = new Size(171, 23);
            articleTB.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(searchButton);
            tabPage3.Controls.Add(searchTB);
            tabPage3.Controls.Add(searchCB);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(589, 309);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Поиск книг";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(315, 17);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(121, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Искать";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(169, 17);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(140, 23);
            searchTB.TabIndex = 1;
            // 
            // searchCB
            // 
            searchCB.FormattingEnabled = true;
            searchCB.Items.AddRange(new object[] { "Артикул", "Автор", "Название" });
            searchCB.Location = new Point(22, 17);
            searchCB.Name = "searchCB";
            searchCB.Size = new Size(141, 23);
            searchCB.TabIndex = 0;
            searchCB.Text = "Тип поиска";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 58);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(414, 248);
            dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 361);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button addButton;
        private TextBox countTB;
        private TextBox yearTB;
        private TextBox nameTB;
        private TextBox authorTB;
        private TextBox articleTB;
        private TabPage tabPage3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox searchCB;
        private Button searchButton;
        private TextBox searchTB;
        private DataGridView dataGridView2;
    }
}