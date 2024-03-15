using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()=="")
            {
                MessageBox.Show("BOŞ BIRAKMAYINIZ..");

            }

            else
            {  
                //MessagingToolkit.QRCode.Codec.QRCodeEncoder

                QRCodeEncoder yarat = new QRCodeEncoder();
                pictureBox1.Image = yarat.Encode(textBox1.Text);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resim = pictureBox1.Image;

            resim.Save(Application.StartupPath+ "\\"+DateTime.Now.ToShortDateString()+ DateTime.Now.ToFileTime() +".png");
            MessageBox.Show("QR CODE BAŞARILI BİR ŞEKİLDE YARATILDI....");
            textBox1.Clear();

            pictureBox1.Image = null;

        }
    }
}
