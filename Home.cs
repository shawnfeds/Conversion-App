using System.Windows.Forms;

namespace Base64
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnStrEncode_Click(object sender, EventArgs e)
        {
            var input = rtbInput.Text;

            var plainBytes = System.Text.Encoding.UTF8.GetBytes(input);
            var base64String = Convert.ToBase64String(plainBytes);

            rtbOutput.Text = base64String;
        }

        private void btnStrDecode_Click(object sender, EventArgs e)
        {
            var input = rtbInput.Text;


            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter base64 string");
                return;
            }

            var decodedBytes = Convert.FromBase64String(input);
            var decodedText = System.Text.Encoding.UTF8.GetString(decodedBytes);

            rtbOutput.Text = decodedText;
        }

        private void btnEncodeImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var imageBytes = File.ReadAllBytes(ofd.FileName);
                    string base64String = Convert.ToBase64String(imageBytes);

                    rtbOutput.Text = base64String;
                }
            }
        }

        private void btnDecodeImg_Click(object sender, EventArgs e)
        {
            var input = rtbInput.Text;


            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter base64 string");
                return;
            }

            byte[] imageBytes = Convert.FromBase64String(input);
            using (var ms = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(ms);

                var imageViewForm = new ImageView(image);
                imageViewForm.Show();
            }
        }

        private void btnEncodePdf_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an PDF file";
                ofd.Filter = "PDF Files|*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var PdfBytes = File.ReadAllBytes(ofd.FileName);
                    string base64String = Convert.ToBase64String(PdfBytes);

                    rtbOutput.Text = base64String;
                }
            }
        }

        private void btnDecodePdf_Click(object sender, EventArgs e)
        {
            var input = rtbInput.Text;

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter base64 string");
                return;
            }

            var base64PdfViewerForm = new Base64PdfViewer(input);
            base64PdfViewerForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInput.Text = string.Empty;
            rtbOutput.Text = string.Empty;
        }
    }
}
