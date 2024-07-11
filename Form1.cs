using static System.Runtime.InteropServices.JavaScript.JSType;
using Spire.Xls;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace CSVConverterApp
{
    public partial class Form1 : Form
    {
        string fileLoc = "";
        List<string> txtLines = new List<string>();
        bool ender = false;
        string downloadsFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragDrop += Form1_DragDrop;
            this.DragEnter += Form1_DragEnter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!ender)
            {
                txtLines.Clear();
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0)
                {
                    fileLoc = files[0];

                    if (IsValidExcelFile(fileLoc))
                    {
                        this.AllowDrop = false;
                        contentVisualizer.Visible = true;
                        dragTextLabel.Visible = false;
                        SaveAsButton.Visible = true;
                        discardButton.Visible = true;
                        errorLabel.Visible = false;
                        dialogTextBox.Enabled = false;
                        browseFiles.Enabled = false;
                        dialogSelectButton.Enabled = false;
                        Workbook workbook = new Workbook();
                        workbook.LoadFromFile(fileLoc);
                        Worksheet sheet = workbook.Worksheets[0];
                        sheet.SaveToFile("ExceltoTxt.txt", ",", Encoding.UTF8);
                        using (StreamReader sr = new StreamReader("ExceltoTxt.txt", Encoding.UTF8))
                        {
                            string line = "";
                            while (true)
                            {
                                if ((line = sr.ReadLine()) != null)
                                {
                                    txtLines.Add(line);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        ender = true;
                    }
                    else
                    {
                        errorLabel.Visible = true;
                    }
                    foreach (var line in txtLines)
                    {
                        contentVisualizer.Text += line + "\n";
                    }
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0 && IsValidExcelFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private bool IsValidExcelFile(string file)
        {
            string ext = Path.GetExtension(file).ToLower();
            return ext == ".xlsx" || ext == ".xls";
        }

        private async void csvButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameTextBox.Text == string.Empty) throw new NullNameException();
                txtLines.Clear();
                txtLines = contentVisualizer.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                using (StreamWriter sw = new StreamWriter($"{downloadsFolderPath}\\{fileNameTextBox.Text}.csv", false, Encoding.UTF8))
                {
                    foreach (var row in txtLines)
                    {
                        if (row == null)
                        {
                            break;
                        }
                        sw.WriteLine(row);
                    }
                }
                errorLabel2.Visible = false;
                notifLabel.Visible = true;
                notifLabel.Text = "Successfully made the .csv file!";
                csvButton.Enabled = false;
                txtButton.Enabled = false;
                fileNameTextBox.Enabled = false;
                discardButton.Enabled = false;
                await Task.Delay(3000);
                notifLabel.Visible = false;
                csvButton.Enabled = true;
                txtButton.Enabled = true;
                fileNameTextBox.Enabled = true;
                discardButton.Enabled = true;
            }
            catch (NullNameException)
            {
                errorLabel2.Text = "File name must not be empty/File not found!";
                errorLabel2.Visible = true;
            }
            catch (Exception)
            {
                errorLabel2.Text = "An error has occurred. Try again.";
                errorLabel2.Visible = true;
            }
        }
        private async void txtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileNameTextBox.Text == string.Empty) throw new NullNameException();
                txtLines.Clear();
                txtLines = contentVisualizer.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                using (StreamWriter sw = new StreamWriter($"{downloadsFolderPath}\\{fileNameTextBox.Text}.txt", false, Encoding.UTF8))
                {
                    foreach (var row in txtLines)
                    {
                        if (row == null)
                        {
                            break;
                        }
                        sw.WriteLine(row);
                    }
                }
                errorLabel2.Visible = false;
                notifLabel.Visible = true;
                notifLabel.Text = "Successfully made the .txt file!";
                notifLabel.Visible = true;
                csvButton.Enabled = false;
                txtButton.Enabled = false;
                fileNameTextBox.Enabled = false;
                discardButton.Enabled = false;
                await Task.Delay(3000);
                csvButton.Enabled = true;
                txtButton.Enabled = true;
                fileNameTextBox.Enabled = true;
                notifLabel.Visible = false;
                discardButton.Enabled = true;
            }
            catch (NullNameException)
            {
                errorLabel2.Text = "File name must not be empty/File not found!";
                errorLabel2.Visible = true;
            }
            catch (Exception)
            {
                errorLabel2.Text = "An error has occurred. Try again.";
                errorLabel2.Visible = true;
            }
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                dialogTextBox.Text = fdlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ender)
            {
                txtLines.Clear();
                if (IsValidExcelFile(dialogTextBox.Text))
                {
                    this.AllowDrop = false;
                    fileLoc = dialogTextBox.Text;
                    contentVisualizer.Visible = true;
                    dragTextLabel.Visible = false;
                    SaveAsButton.Visible = true;
                    discardButton.Visible = true;
                    errorLabel.Visible = false;
                    dialogTextBox.Enabled = false;
                    dialogSelectButton.Enabled = false;
                    browseFiles.Enabled = false;
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(dialogTextBox.Text);
                    Worksheet sheet = workbook.Worksheets[0];
                    sheet.SaveToFile("ExceltoTxt.txt", ",", Encoding.UTF8);
                    using (StreamReader sr = new StreamReader("ExceltoTxt.txt"))
                    {
                        string line = "";
                        while (true)
                        {
                            if ((line = sr.ReadLine()) != null)
                            {
                                txtLines.Add(line);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    ender = true;
                }
                else
                {
                    errorLabel.Visible = true;
                }
                foreach (var line in txtLines)
                {
                    contentVisualizer.Text += line + "\n";
                }
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            csvButton.Visible = true;
            txtButton.Visible = true;
            fileNameTextBox.Visible = true;
            fileNameLabel.Visible = true;
            infoLabel.Visible = true;
            SaveAsButton.Enabled = false;
        }

        private async void notifLabel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            contentVisualizer.Text = string.Empty;
            contentVisualizer.Visible = false; 
            SaveAsButton.Visible = false;
            discardButton.Visible = false;
            dragTextLabel.Visible = true;

            csvButton.Visible = false;
            txtButton.Visible = false;
            fileNameTextBox.Visible = false;
            fileNameLabel.Visible = false;
            infoLabel.Visible = false;

            SaveAsButton.Enabled = true;
            browseFiles.Enabled = true;
            dialogSelectButton.Enabled = true;
            dialogTextBox.Enabled = true;

            ender = false;
            this.AllowDrop = true;
        }
    }
}