namespace Base64
{
    partial class ImageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbDecodedImage = new PictureBox();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDecodedImage).BeginInit();
            SuspendLayout();
            // 
            // pbDecodedImange
            // 
            pbDecodedImage.Dock = DockStyle.Bottom;
            pbDecodedImage.Location = new Point(0, 59);
            pbDecodedImage.Name = "pbDecodedImange";
            pbDecodedImage.Size = new Size(800, 391);
            pbDecodedImage.TabIndex = 0;
            pbDecodedImage.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Khaki;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDownload.ForeColor = Color.Olive;
            btnDownload.Location = new Point(12, 11);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(135, 42);
            btnDownload.TabIndex = 4;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // ImageView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDownload);
            Controls.Add(pbDecodedImage);
            Name = "ImageView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ImageView";
            Load += ImageView_Load;
            ((System.ComponentModel.ISupportInitialize)pbDecodedImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbDecodedImage;
        private Button btnDownload;
    }
}