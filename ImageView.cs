using System.Drawing.Imaging;

namespace Base64
{
    public partial class ImageView : Form
    {
        private readonly System.Drawing.Image _image;
        public ImageView(System.Drawing.Image image)
        {
            InitializeComponent();
            _image = image;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter =
                    "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "bas64ToImage"; // default name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Ensure we have a valid image
                        if (_image == null)
                        {
                            MessageBox.Show("No image loaded.");
                            return;
                        }

                        // Clone the image into a Bitmap to avoid stream/disposal issues
                        using (Bitmap bmp = new Bitmap(_image))
                        {
                            // Choose format based on extension
                            string ext = Path.GetExtension(saveFileDialog.FileName).ToLower();
                            ImageFormat format = ImageFormat.Png;

                            switch (ext)
                            {
                                case ".jpg":
                                case ".jpeg":
                                    format = ImageFormat.Jpeg;
                                    break;
                                case ".bmp":
                                    format = ImageFormat.Bmp;
                                    break;
                                case ".gif":
                                    format = ImageFormat.Gif;
                                    break;
                                default:
                                    format = ImageFormat.Png;
                                    break;
                            }

                            // Save safely
                            bmp.Save(saveFileDialog.FileName, format);
                        }

                        MessageBox.Show("Image saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message);
                    }
                }
            }
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
            pbDecodedImage.Image = _image;
            pbDecodedImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
