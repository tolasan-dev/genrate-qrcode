
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
        










namespace qr_code_generation
{


   
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            System.Timers.Timer delaytime = new System.Timers.Timer();

        }


        public void btnClear(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //textBox2.Clear();
            pictureBox1.Image = null;
        }
        private void btnGenerateqrCode(object sender, EventArgs e)
        {

            string data = $"Name: {textBox1.Text}\n" +
                          $"Email: {textBox2.Text}\n";






            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
              string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter all information.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int width = 200;
            int height = 200;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);


            // Hight quality image generation
            Bitmap qrCodeImage = qrCode.GetGraphic(
                80,
                Color.Black, Color.White, drawQuietZones: true


             );

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // IMPORTANT
            pictureBox1.Image = qrCodeImage;

            if (pictureBox1.Image != null)
            {
                textBox1.Clear();
                textBox2.Clear();

            }
            else if(pictureBox1.Image != null)
            {
                btnClear(sender, e);
                return;
            }



        }
    }
}
