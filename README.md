# 🌀 Base64 Conversion App

A simple yet powerful Windows Forms application built with **.NET 8** that allows you to **encode and decode strings, images, and PDFs to and from Base64**. The app also includes built‑in viewers so you can **preview images and PDFs instantly** without leaving the application.

---

## ✨ Features
- 🔤 **String Conversion**
  - Encode plain text into Base64.
  - Decode Base64 back into readable text.

- 🖼️ **Image Conversion**
  - Convert images (`.jpg`, `.png`, `.bmp`, `.gif`) to Base64.
  - Decode Base64 back into images.
  - Preview images directly in the built‑in viewer.

- 📄 **PDF Conversion**
  - Convert PDF files into Base64 strings.
  - Decode Base64 back into PDF files.
  - Preview PDFs using the integrated PDF viewer.

- 💾 **Save & Load**
  - Save converted files to disk.
  - Load existing Base64 strings and decode them.

---

## 🛠️ Tech Stack
- **.NET 8**
- **Windows Forms**
- **System.Drawing.Common** for image handling
- **PDF rendering library** (e.g., `PdfiumViewer` or similar)

---

## 🚀 Getting Started

### Prerequisites
- Windows 10/11
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/base64-conversion-app.git
   ```
2. Navigate to the project folder:

```bash
cd base64-conversion-app
```
Build and run:

```bash
dotnet run
```
## 📂 Usage
1. Launch the app.
2. Select whether you want to encode or decode.
3. Choose your input type:
    - Enter text in the string box.
    - Upload an image or PDF file.
4. View the result:
    - Encoded Base64 string appears in the output box.
    - Decoded files can be previewed in the viewer.

5. Save the output if needed.

## 🎯 Example Workflows
- Encode a string → Type "Hello World" → Get Base64 "SGVsbG8gV29ybGQ=".
- Decode an image → Paste Base64 → Preview the image instantly.
- Preview a PDF → Load Base64 → See the PDF in the viewer.

## 📦 Build Portable Executable
To generate a portable .exe:

```bash
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./publish
```
The executable will be available in the publish folder.

## 🚀 Download

You can grab the latest portable `.exe` from the [Releases page](https://github.com/shawnfeds/Conversion-App/releases/latest).

## 🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you’d like to change.

## 📜 License
This project is licensed under the [MIT License](https://github.com/shawnfeds/Conversion-App/blob/main/LICENSE).
