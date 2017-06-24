using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SecurityDialog
{
    public partial class Form1 : Form
    {
        int lenght = 512;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lenght = 1024;
            Encrypt(lenght);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lenght = 2048;
            Encrypt(lenght);
        }

        public void Encrypt(int lenght)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(lenght);
            textBox1.Text = rsa.ToXmlString(false);
            textBox2.Text = rsa.ToXmlString(true);
            File.WriteAllText("public.xml", rsa.ToXmlString(false));
            File.WriteAllText("private.xml", rsa.ToXmlString(true));
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            lenght = 512;
            Encrypt(lenght);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lenght = 3072;
            Encrypt(lenght);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lenght = 4096;
            Encrypt(lenght);
        }
    }
}
