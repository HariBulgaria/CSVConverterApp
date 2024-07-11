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
            dialogTextBox = new TextBox();
            dialogSelectButton = new Button();
            contentVisualizer = new RichTextBox();
            SaveAsButton = new Button();
            fileNameTextBox = new TextBox();
            fileNameLabel = new Label();
            infoLabel = new Label();
            errorLabel2 = new Label();
            notifLabel = new Label();
            discardButton = new Button();
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
            browseFiles.Size = new Size(87, 23);
            browseFiles.TabIndex = 5;
            browseFiles.Text = "Browse";
            browseFiles.UseVisualStyleBackColor = false;
            browseFiles.Click += browseFiles_Click;
            // 
            // dialogTextBox
            // 
            dialogTextBox.BackColor = Color.Linen;
            dialogTextBox.Cursor = Cursors.IBeam;
            dialogTextBox.Location = new Point(108, 12);
            dialogTextBox.Name = "dialogTextBox";
            dialogTextBox.Size = new Size(479, 23);
            dialogTextBox.TabIndex = 6;
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
            // fileNameTextBox
            // 
            fileNameTextBox.BackColor = Color.Linen;
            fileNameTextBox.Cursor = Cursors.IBeam;
            fileNameTextBox.Location = new Point(108, 160);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(134, 23);
            fileNameTextBox.TabIndex = 12;
            fileNameTextBox.Visible = false;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.BackColor = Color.Transparent;
            fileNameLabel.Font = new Font("Times New Roman", 11F);
            fileNameLabel.Location = new Point(31, 160);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(68, 17);
            fileNameLabel.TabIndex = 13;
            fileNameLabel.Text = "File name:";
            fileNameLabel.Visible = false;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Font = new Font("Times New Roman", 11F);
            infoLabel.ForeColor = Color.DarkSlateGray;
            infoLabel.Location = new Point(308, 207);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(320, 17);
            infoLabel.TabIndex = 14;
            infoLabel.Text = "Your document can be found in the downloads folder.";
            infoLabel.Visible = false;
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
            // notifLabel
            // 
            notifLabel.AutoSize = true;
            notifLabel.ForeColor = Color.OliveDrab;
            notifLabel.Location = new Point(308, 189);
            notifLabel.Name = "notifLabel";
            notifLabel.Size = new Size(68, 15);
            notifLabel.TabIndex = 16;
            notifLabel.Text = "notification";
            notifLabel.Visible = false;
            notifLabel.VisibleChanged += notifLabel_VisibleChanged;
            // 
            // discardButton
            // 
            discardButton.BackColor = Color.NavajoWhite;
            discardButton.FlatStyle = FlatStyle.Popup;
            discardButton.Font = new Font("Times New Roman", 12F);
            discardButton.Location = new Point(685, 189);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(87, 35);
            discardButton.TabIndex = 17;
            discardButton.Text = "Discard";
            discardButton.UseVisualStyleBackColor = false;
            discardButton.Visible = false;
            discardButton.Click += discardButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(784, 461);
            Controls.Add(discardButton);
            Controls.Add(notifLabel);
            Controls.Add(errorLabel2);
            Controls.Add(infoLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(fileNameTextBox);
            Controls.Add(SaveAsButton);
            Controls.Add(contentVisualizer);
            Controls.Add(dialogSelectButton);
            Controls.Add(dialogTextBox);
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
        private TextBox dialogTextBox;
        private Button dialogSelectButton;
        private RichTextBox contentVisualizer;
        private Button SaveAsButton;
        private TextBox fileNameTextBox;
        private Label fileNameLabel;
        private Label infoLabel;
        private Label errorLabel2;
        private Label notifLabel;
        private Button discardButton;
    }
}
