using static System.Runtime.InteropServices.JavaScript.JSType;
using Spire.Xls;
using System.Text;

namespace CSVConverterApp
{
    public partial class Form1 : Form
    {
        string filePath = "C:\\Users\\Students\\Documents\\output.csv"; //To make custom    
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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string file = files[0];

                if (IsValidExcelFile(file))
                {
                    contentVisualizer.Visible = true;
                    csvButton.Visible = true;
                    txtButton.Visible = true;
                    dragTextLabel.Visible = false;
                    errorLabel.Visible = false;
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(file);
                    Worksheet sheet = workbook.Worksheets[0];
                    sheet.SaveToFile("ExceltoTxt.txt", ",", Encoding.UTF8);
                    using (StreamReader sr = new StreamReader("ExceltoTxt.txt"))
                    {
                        string line = "";
                        while (true)
                        {
                            if ((line = sr.ReadLine()) != null)
                            {
                                contentVisualizer.Items.Add(line);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    errorLabel.Visible = true;
                }
                for (int i = 0; i < contentVisualizer.Items.Count / 2; i++)
                {
                    contentVisualizer.Items.RemoveAt(0);
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
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var row in contentVisualizer.Items)
                {
                    if (row == null)
                    {
                        break;
                    }
                    sw.WriteLine(row);
                }
            }
        }

        private void txtButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var row in contentVisualizer.Items)
                {
                    if (row == null)
                    {
                        break;
                    }
                    sw.WriteLine(row);
                }
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
    }
}