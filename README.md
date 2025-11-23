# qr-code-generation

# QR Code Generation in Winforms Application using C#


This repository contains a simple Winforms application that generates QR codes using C#. The application allows users to input text and generate a corresponding QR code image.	



##Setup Instructions


Project → Manage NuGet Packages → Browse → QRCoder → Install


##✅ Step 2 – Create UI

   1. Open Visual Studio and create a new Winforms Application project.
   
	 Add the following controls to your WinForm:

TextBox → name: txtQRText

Button → name: btnGenerate → Text: "Generate"

PictureBox → name: pictureBox1


##✅ Step 3 – Add Code to Generate QR Code

```using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

private void btnGenerate_Click(object sender, EventArgs e)
{
    string text = txtQRText.Text.Trim();

    if (string.IsNullOrEmpty(text))
    {
        MessageBox.Show("Please enter text.");
        return;
    }

    QRCodeGenerator qrGenerator = new QRCodeGenerator();
    QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
    QRCode qrCode = new QRCode(qrCodeData);

    Bitmap qrImage = qrCode.GetGraphic(20); // 20 = pixel per module

    pictureBox1.Image = qrImage; // display QR in picture box
}
