namespace Base64
{
    public partial class Base64PdfViewer : Form
    {
        private readonly string _base64Pdf;
        private string _pdfFilePath;
        public Base64PdfViewer(string base64Pdf)
        {
            _base64Pdf = base64Pdf;
            InitializeComponent();
            SavePdf();
        }

        private void showPdf()
        {
            pdfViewer.LoadDocument(_pdfFilePath);
            this.Controls.Add(pdfViewer);
        }

        private void Base64PdfViewer_Load(object sender, EventArgs e)
        {
            showPdf();
        }

        private void SavePdf()
        {
            byte[] pdfBytes = Convert.FromBase64String(_base64Pdf);

            string projectFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            string saveFolderPath = Path.Combine(projectFolderPath, "PDFs");
            _pdfFilePath = Path.Combine(saveFolderPath, $"{Guid.NewGuid()}.pdf");

            if (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
            }

            File.WriteAllBytes(_pdfFilePath, pdfBytes);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "MyDocument.pdf"; // default name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = saveFileDialog.FileName;

                    File.Copy(_pdfFilePath, destinationPath, true);
                    MessageBox.Show("File saved successfully!");
                }
            }
        }
    }
}
