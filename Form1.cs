using static System.Runtime.InteropServices.JavaScript.JSType;
using Spire.Xls;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace CSVConverterApp
{
    public partial class Form1 : Form
    {
        string filePath = "C:\\Users\\Students\\Documents\\output.csv"; //To make custom
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
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0)
                {
                    fileLoc = files[0];

                    if (IsValidExcelFile(fileLoc))
                    {
                        contentVisualizer.Visible = true;
                        dragTextLabel.Visible = false;
                        SaveAsButton.Visible = true;
                        errorLabel.Visible = false;
                        textBox1.Enabled = false;
                        browseFiles.Enabled = false;
                        dialogSelectButton.Enabled = false;
                        Workbook workbook = new Workbook();
                        workbook.LoadFromFile(fileLoc);
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

        private void csvButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == string.Empty) throw new NullNameException();
                txtLines.Clear();
                txtLines = contentVisualizer.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                using (StreamWriter sw = new StreamWriter($"{downloadsFolderPath}\\{textBox3.Text}.csv"))
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
        private void txtButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == string.Empty) throw new NullNameException();
                txtLines.Clear();
                txtLines = contentVisualizer.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                using (StreamWriter sw = new StreamWriter($"{downloadsFolderPath}\\{textBox3.Text}.txt"))
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
                textBox1.Text = fdlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ender)
            {
                if (IsValidExcelFile(textBox1.Text))
                {
                    fileLoc = textBox1.Text;
                    contentVisualizer.Visible = true;
                    dragTextLabel.Visible = false;
                    SaveAsButton.Visible = true;
                    errorLabel.Visible = false;
                    textBox1.Enabled = false;
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(textBox1.Text);
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
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}