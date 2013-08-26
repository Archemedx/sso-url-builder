using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchemedxSsoUrlBuilder
{
    public partial class EncryptDecryptExample : Form
    {
        public EncryptDecryptExample()
        {
            InitializeComponent();
        }

        private void EncryptionTester_Load(object sender, EventArgs e)
        {
            pnlEncrypted.Visible = false;
            pnlDecrypted.Visible = false;

            txtSecretKey.Text = "your_secret_key";
            txtStringToEncrypt.Text = "encrypt me";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string secretKey = txtSecretKey.Text;
            string stringToEncrypt = txtStringToEncrypt.Text;

            // encrypt the plain text value
            txtEncryptedString.Text = Encryption.OpenSslAes.Encrypt(stringToEncrypt, secretKey);

            // show/hide panels accordingly
            pnlEncrypted.Visible = true;
            pnlDecrypted.Visible = false;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string secretKey = txtSecretKey.Text;
            string encryptedString = txtEncryptedString.Text;

            // decrypt the encrypted string
            txtDecryptedString.Text = Encryption.OpenSslAes.Decrypt(encryptedString, secretKey);

            // show/hide panels accordingly
            pnlDecrypted.Visible = true;
        }
    }
}