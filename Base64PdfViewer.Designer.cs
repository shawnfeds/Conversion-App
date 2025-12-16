namespace Base64
{
    partial class Base64PdfViewer
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
            pdfViewer = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            btnDownload = new Button();
            SuspendLayout();
            // 
            // pdfViewer
            // 
            pdfViewer.BackColor = SystemColors.ControlDark;
            pdfViewer.CurrentIndex = -1;
            pdfViewer.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfViewer.Dock = DockStyle.Bottom;
            pdfViewer.Document = null;
            pdfViewer.FormHighlightColor = Color.Transparent;
            pdfViewer.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer.LoadingIconText = "Loading...";
            pdfViewer.Location = new Point(0, 64);
            pdfViewer.Margin = new Padding(4, 3, 4, 3);
            pdfViewer.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer.Name = "pdfViewer";
            pdfViewer.OptimizedLoadThreshold = 1000;
            pdfViewer.Padding = new Padding(12, 12, 12, 12);
            pdfViewer.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer.PageAutoDispose = true;
            pdfViewer.PageBackColor = Color.White;
            pdfViewer.PageBorderColor = Color.Black;
            pdfViewer.PageMargin = new Padding(10);
            pdfViewer.PageSeparatorColor = Color.Gray;
            pdfViewer.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer.ShowCurrentPageHighlight = true;
            pdfViewer.ShowLoadingIcon = true;
            pdfViewer.ShowPageSeparator = true;
            pdfViewer.Size = new Size(671, 433);
            pdfViewer.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfViewer.TabIndex = 0;
            pdfViewer.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer.TilesCount = 2;
            pdfViewer.UseProgressiveRender = true;
            pdfViewer.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.Vertical;
            pdfViewer.Zoom = 1F;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Khaki;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDownload.ForeColor = Color.Olive;
            btnDownload.Location = new Point(12, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(135, 42);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // Base64PdfViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 497);
            Controls.Add(btnDownload);
            Controls.Add(pdfViewer);
            Name = "Base64PdfViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pdf Viewer";
            Load += Base64PdfViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer;
        private Button btnDownload;
    }
}