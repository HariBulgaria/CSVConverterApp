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
            contentVisualizer = new ListBox();
            dragTextLabel = new Label();
            csvButton = new Button();
            errorLabel = new Label();
            txtButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            browseFiles = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contentVisualizer
            // 
            contentVisualizer.FormattingEnabled = true;
            contentVisualizer.ItemHeight = 15;
            contentVisualizer.Location = new Point(12, 235);
            contentVisualizer.Name = "contentVisualizer";
            contentVisualizer.Size = new Size(760, 214);
            contentVisualizer.TabIndex = 0;
            contentVisualizer.Visible = false;
            // 
            // dragTextLabel
            // 
            dragTextLabel.AutoSize = true;
            dragTextLabel.BackColor = Color.Transparent;
            dragTextLabel.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragTextLabel.Location = new Point(64, 161);
            dragTextLabel.Name = "dragTextLabel";
            dragTextLabel.Size = new Size(654, 71);
            dragTextLabel.TabIndex = 1;
            dragTextLabel.Text = "Drag your Excel file here.";
            // 
            // csvButton
            // 
            csvButton.Location = new Point(685, 189);
            csvButton.Name = "csvButton";
            csvButton.Size = new Size(87, 35);
            csvButton.TabIndex = 2;
            csvButton.Text = "Make .csv";
            csvButton.UseVisualStyleBackColor = true;
            csvButton.Visible = false;
            csvButton.Click += csvButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Font = new Font("Segoe UI", 15F);
            errorLabel.ForeColor = Color.IndianRed;
            errorLabel.Location = new Point(222, 232);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(365, 28);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "The file must be in a .xls or a .xlsx format!";
            errorLabel.Visible = false;
            // 
            // txtButton
            // 
            txtButton.Location = new Point(685, 148);
            txtButton.Name = "txtButton";
            txtButton.Size = new Size(87, 35);
            txtButton.TabIndex = 4;
            txtButton.Text = "Make .txt";
            txtButton.UseVisualStyleBackColor = true;
            txtButton.Visible = false;
            txtButton.Click += txtButton_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Test message!";
            // 
            // browseFiles
            // 
            browseFiles.Location = new Point(12, 12);
            browseFiles.Name = "browseFiles";
            browseFiles.Size = new Size(75, 23);
            browseFiles.TabIndex = 5;
            browseFiles.Text = "Browse";
            browseFiles.UseVisualStyleBackColor = true;
            browseFiles.Click += browseFiles_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(textBox1);
            Controls.Add(browseFiles);
            Controls.Add(txtButton);
            Controls.Add(errorLabel);
            Controls.Add(csvButton);
            Controls.Add(dragTextLabel);
            Controls.Add(contentVisualizer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox contentVisualizer;
        private Label dragTextLabel;
        private Button csvButton;
        private Label errorLabel;
        private Button txtButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button browseFiles;
        private TextBox textBox1;
    }
}
