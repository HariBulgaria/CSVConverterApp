namespace CSVConverterApp
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
            openFileDialog1 = new OpenFileDialog();
            dragTextLabel = new Label();
            csvButton = new Button();
            errorLabel = new Label();
            txtButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            browseFiles = new Button();
            textBox1 = new TextBox();
            dialogSelectButton = new Button();
            contentVisualizer = new RichTextBox();
            SaveAsButton = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            errorLabel2 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dragTextLabel
            // 
            dragTextLabel.AutoSize = true;
            dragTextLabel.BackColor = Color.Transparent;
            dragTextLabel.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragTextLabel.Location = new Point(82, 171);
            dragTextLabel.Name = "dragTextLabel";
            dragTextLabel.Size = new Size(612, 61);
            dragTextLabel.TabIndex = 1;
            dragTextLabel.Text = "Drag your Excel file here:";
            // 
            // csvButton
            // 
            csvButton.BackColor = Color.NavajoWhite;
            csvButton.FlatStyle = FlatStyle.Popup;
            csvButton.Font = new Font("Times New Roman", 12F);
            csvButton.Location = new Point(108, 189);
            csvButton.Name = "csvButton";
            csvButton.Size = new Size(87, 35);
            csvButton.TabIndex = 2;
            csvButton.Text = "Make .csv";
            csvButton.UseVisualStyleBackColor = false;
            csvButton.Visible = false;
            csvButton.Click += csvButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(229, 232);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(344, 22);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "The file must be in a .xls or a .xlsx format!";
            errorLabel.Visible = false;
            // 
            // txtButton
            // 
            txtButton.BackColor = Color.NavajoWhite;
            txtButton.FlatStyle = FlatStyle.Popup;
            txtButton.Font = new Font("Times New Roman", 12F);
            txtButton.Location = new Point(201, 189);
            txtButton.Name = "txtButton";
            txtButton.Size = new Size(87, 35);
            txtButton.TabIndex = 4;
            txtButton.Text = "Make .txt";
            txtButton.UseVisualStyleBackColor = false;
            txtButton.Visible = false;
            txtButton.Click += txtButton_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Test message!";
            // 
            // browseFiles
            // 
            browseFiles.BackColor = Color.NavajoWhite;
            browseFiles.FlatStyle = FlatStyle.Popup;
            browseFiles.Font = new Font("Times New Roman", 10F);
            browseFiles.Location = new Point(12, 12);
            browseFiles.Name = "browseFiles";
            browseFiles.Size = new Size(75, 23);
            browseFiles.TabIndex = 5;
            browseFiles.Text = "Browse";
            browseFiles.UseVisualStyleBackColor = false;
            browseFiles.Click += browseFiles_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Linen;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(108, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 6;
            // 
            // dialogSelectButton
            // 
            dialogSelectButton.BackColor = Color.NavajoWhite;
            dialogSelectButton.FlatStyle = FlatStyle.Popup;
            dialogSelectButton.Font = new Font("Times New Roman", 10F);
            dialogSelectButton.Location = new Point(593, 12);
            dialogSelectButton.Name = "dialogSelectButton";
            dialogSelectButton.Size = new Size(75, 23);
            dialogSelectButton.TabIndex = 7;
            dialogSelectButton.Text = "Select";
            dialogSelectButton.UseVisualStyleBackColor = false;
            dialogSelectButton.Click += button1_Click;
            // 
            // contentVisualizer
            // 
            contentVisualizer.BackColor = Color.Linen;
            contentVisualizer.Location = new Point(12, 235);
            contentVisualizer.Name = "contentVisualizer";
            contentVisualizer.Size = new Size(760, 214);
            contentVisualizer.TabIndex = 8;
            contentVisualizer.Text = "";
            contentVisualizer.Visible = false;
            // 
            // SaveAsButton
            // 
            SaveAsButton.BackColor = Color.NavajoWhite;
            SaveAsButton.FlatStyle = FlatStyle.Popup;
            SaveAsButton.Font = new Font("Times New Roman", 12F);
            SaveAsButton.Location = new Point(12, 189);
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(87, 35);
            SaveAsButton.TabIndex = 9;
            SaveAsButton.Text = "Save As";
            SaveAsButton.UseVisualStyleBackColor = false;
            SaveAsButton.Visible = false;
            SaveAsButton.Click += SaveAsButton_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Linen;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(108, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 12;
            textBox3.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 11F);
            label1.Location = new Point(31, 160);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 13;
            label1.Text = "File name:";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 11F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(308, 207);
            label2.Name = "label2";
            label2.Size = new Size(320, 17);
            label2.TabIndex = 14;
            label2.Text = "Your document can be found in the downloads folder.";
            label2.Visible = false;
            // 
            // errorLabel2
            // 
            errorLabel2.AutoSize = true;
            errorLabel2.BackColor = Color.Transparent;
            errorLabel2.Font = new Font("Times New Roman", 10F);
            errorLabel2.ForeColor = Color.Firebrick;
            errorLabel2.Location = new Point(108, 141);
            errorLabel2.Name = "errorLabel2";
            errorLabel2.Size = new Size(35, 16);
            errorLabel2.TabIndex = 15;
            errorLabel2.Text = "error";
            errorLabel2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(784, 461);
            Controls.Add(errorLabel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(SaveAsButton);
            Controls.Add(contentVisualizer);
            Controls.Add(dialogSelectButton);
            Controls.Add(textBox1);
            Controls.Add(browseFiles);
            Controls.Add(txtButton);
            Controls.Add(errorLabel);
            Controls.Add(csvButton);
            Controls.Add(dragTextLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label dragTextLabel;
        private Button csvButton;
        private Label errorLabel;
        private Button txtButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button browseFiles;
        private TextBox textBox1;
        private Button dialogSelectButton;
        private RichTextBox contentVisualizer;
        private Button SaveAsButton;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label errorLabel2;
    }
}
