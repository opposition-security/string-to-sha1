using System.Text.RegularExpressions;

namespace string_to_sha1
{
    public partial class ConversionForm : System.Windows.Forms.Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void convertString_button_Click(object sender, EventArgs e)
        {
            string stringToConvert = string_textbox.Text;
            string hash = sha1.Convert(stringToConvert);
            sha1_textbox.Text = hash;
            if (!String.IsNullOrEmpty(output_textbox.Text))
            {
                using (StreamWriter sw = File.AppendText(output_textbox.Text))
                {
                    sw.WriteLine(hash);
                }
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    file_textbox.Text = filePath;
                    var fileName = Path.GetFileNameWithoutExtension(filePath);
                    var fileDirectory = Path.GetDirectoryName(filePath);

                    output_textbox.Text = Path.Combine(fileDirectory, fileName + "_sha1.txt");
                }
            }
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                output_textbox.Text = saveFileDialog.FileName;
            }
        }

        private void convertFile_button_Click(object sender, EventArgs e)
        {
            //Get the path of specified file
            string filePath = file_textbox.Text;
            string outPath = output_textbox.Text;
            var lines = File.ReadLines(filePath);

            int lineCount = lines.Count();
            int completedLines = 0;
            using (StreamWriter sw = File.AppendText(outPath))
            {
                foreach (string line in lines)
                {
                    string hash = sha1.Convert(line);
                    sw.WriteLine(hash);
                    completedLines++;
                    decimal progress = ((decimal)completedLines / (decimal)lineCount) * 100;
                    progressBar.Value = (int)progress;
                }
            }
        }
    }
}