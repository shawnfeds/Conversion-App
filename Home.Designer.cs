namespace Base64
{
    partial class Home
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
            rtbOutput = new RichTextBox();
            rtbInput = new RichTextBox();
            btnStrEncode = new Button();
            btnStrDecode = new Button();
            btnEncodeImg = new Button();
            btnDecodeImg = new Button();
            btnDecodePdf = new Button();
            btnEncodePdf = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = Color.OldLace;
            rtbOutput.BorderStyle = BorderStyle.None;
            rtbOutput.Dock = DockStyle.Bottom;
            rtbOutput.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbOutput.ForeColor = Color.Black;
            rtbOutput.Location = new Point(0, 211);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(861, 397);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            // 
            // rtbInput
            // 
            rtbInput.BackColor = Color.Honeydew;
            rtbInput.BorderStyle = BorderStyle.None;
            rtbInput.Dock = DockStyle.Top;
            rtbInput.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbInput.ForeColor = SystemColors.WindowText;
            rtbInput.Location = new Point(0, 0);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(861, 130);
            rtbInput.TabIndex = 1;
            rtbInput.Text = "";
            // 
            // btnStrEncode
            // 
            btnStrEncode.BackColor = Color.Khaki;
            btnStrEncode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStrEncode.ForeColor = Color.Olive;
            btnStrEncode.Location = new Point(12, 145);
            btnStrEncode.Name = "btnStrEncode";
            btnStrEncode.Size = new Size(110, 42);
            btnStrEncode.TabIndex = 2;
            btnStrEncode.Text = "Encode String";
            btnStrEncode.UseVisualStyleBackColor = false;
            btnStrEncode.Click += btnStrEncode_Click;
            // 
            // btnStrDecode
            // 
            btnStrDecode.BackColor = Color.Khaki;
            btnStrDecode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStrDecode.ForeColor = Color.Olive;
            btnStrDecode.Location = new Point(128, 145);
            btnStrDecode.Name = "btnStrDecode";
            btnStrDecode.Size = new Size(116, 42);
            btnStrDecode.TabIndex = 3;
            btnStrDecode.Text = "Decode String";
            btnStrDecode.UseVisualStyleBackColor = false;
            btnStrDecode.Click += btnStrDecode_Click;
            // 
            // btnEncodeImg
            // 
            btnEncodeImg.BackColor = Color.Khaki;
            btnEncodeImg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEncodeImg.ForeColor = Color.Olive;
            btnEncodeImg.Location = new Point(250, 145);
            btnEncodeImg.Name = "btnEncodeImg";
            btnEncodeImg.Size = new Size(113, 42);
            btnEncodeImg.TabIndex = 4;
            btnEncodeImg.Text = "Img to Base64";
            btnEncodeImg.UseVisualStyleBackColor = false;
            btnEncodeImg.Click += btnEncodeImg_Click;
            // 
            // btnDecodeImg
            // 
            btnDecodeImg.BackColor = Color.Khaki;
            btnDecodeImg.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDecodeImg.ForeColor = Color.Olive;
            btnDecodeImg.Location = new Point(369, 145);
            btnDecodeImg.Name = "btnDecodeImg";
            btnDecodeImg.Size = new Size(113, 42);
            btnDecodeImg.TabIndex = 5;
            btnDecodeImg.Text = "Base64 to Img";
            btnDecodeImg.UseVisualStyleBackColor = false;
            btnDecodeImg.Click += btnDecodeImg_Click;
            // 
            // btnDecodePdf
            // 
            btnDecodePdf.BackColor = Color.Khaki;
            btnDecodePdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDecodePdf.ForeColor = Color.Olive;
            btnDecodePdf.Location = new Point(606, 145);
            btnDecodePdf.Name = "btnDecodePdf";
            btnDecodePdf.Size = new Size(113, 42);
            btnDecodePdf.TabIndex = 7;
            btnDecodePdf.Text = "Base64 to PDF";
            btnDecodePdf.UseVisualStyleBackColor = false;
            btnDecodePdf.Click += btnDecodePdf_Click;
            // 
            // btnEncodePdf
            // 
            btnEncodePdf.BackColor = Color.Khaki;
            btnEncodePdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEncodePdf.ForeColor = Color.Olive;
            btnEncodePdf.Location = new Point(488, 145);
            btnEncodePdf.Name = "btnEncodePdf";
            btnEncodePdf.Size = new Size(112, 42);
            btnEncodePdf.TabIndex = 6;
            btnEncodePdf.Text = "PDF to Base64";
            btnEncodePdf.UseVisualStyleBackColor = false;
            btnEncodePdf.Click += btnEncodePdf_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.Olive;
            btnClear.Location = new Point(725, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 42);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 608);
            Controls.Add(btnClear);
            Controls.Add(btnDecodePdf);
            Controls.Add(btnEncodePdf);
            Controls.Add(btnDecodeImg);
            Controls.Add(btnEncodeImg);
            Controls.Add(btnStrDecode);
            Controls.Add(btnStrEncode);
            Controls.Add(rtbInput);
            Controls.Add(rtbOutput);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversion App";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbOutput;
        private RichTextBox rtbInput;
        private Button btnStrEncode;
        private Button btnStrDecode;
        private Button btnEncodeImg;
        private Button btnDecodeImg;
        private Button btnDecodePdf;
        private Button btnEncodePdf;
        private Button btnClear;
    }
}
