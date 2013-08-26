using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ArchemedxSsoUrlBuilder
{
    public partial class SsoUrlBuilder : Form
    {
        // token is a UTC timestamp w/ strict formatting requirements
        public static string tokenFormat = @"yyyy-M-d H:mm:ss UTC";

        public SsoUrlBuilder()
        {
            InitializeComponent();
        }

        private void SsoTester_Load(object sender, EventArgs e)
        {
            // show/hide panels
            pnlUrl.Visible = false;

            // set provider name
            txtProvider.Text = "test-provider";

            // set initiative name
            txtInitiative.Text = "test-initiative";

            // set lesson name
            txtLesson.Text = "test-lesson";

            // set secret key
            txtSecret.Text = "your_secret_key";

            // format and set token
            txtToken.Text = DateTime.UtcNow.ToString(tokenFormat);

            // set first name
            txtFirstName.Text = "william";

            // set last name
            txtLastName.Text = "gates";

            // set email name
            txtEmail.Text = "bill.gates@your_company.com";

            // set user id
            txtUserId.Text = "user's unique id";

            // set combobox values
            cboSpecialties.Items.Add(new ComboboxItem("Critical Care", 23));
            cboSpecialties.Items.Add(new ComboboxItem("Dentistry", 24));
            cboSpecialties.Items.Add(new ComboboxItem("Endocrinology", 27));
            cboSpecialties.SelectedIndex = 0;
        }

        private void btnGenerateTestUrl_Click(object sender, EventArgs e)
        {
            // get specialty id
            string specialtyName = ((ComboboxItem)cboSpecialties.SelectedItem).Text;

            // generate url
            txtUrl.Text = buildURL(txtProvider.Text, txtInitiative.Text, txtLesson.Text, txtSecret.Text, txtToken.Text,
                                   txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUserId.Text, specialtyName);

            // show/hide panels
            pnlUrl.Visible = true;
        }

        private void toolEncryptDecrypt_Click(object sender, EventArgs e)
        {
            Form formEncryption = new EncryptDecryptExample();
            formEncryption.Show();
        }

        private string buildURL(string provider, string initiative, string lesson, string secret_key, string token,
                                string first_name, string last_name, string email, string user_id, string specialtyName)
        {
            // assemble the data
            string data = buildData(first_name, last_name, email, user_id, specialtyName);

            // encrypt both token and data values
            string encryptedToken = Encryption.OpenSslAes.Encrypt(token, secret_key);
            string encryptedData =  Encryption.OpenSslAes.Encrypt(data, secret_key);

            // both token and data values must be URL Encoded
            string encodedToken = WebUtility.UrlEncode(encryptedToken);
            string encodedData =  WebUtility.UrlEncode(encryptedData);

            // assemble the url
            // query string parameters are:
            //   t = token
            //   d = data
            return String.Format("https://{0}.archemedx.com/initiatives/{1}/lessons/{2}?t={3}&d={4}", provider, initiative, lesson, encodedToken, encodedData);
        }

        private string buildData(string first_name, string last_name, string email, string user_id, string specialtyName)
        {
            // build the data string.  it's in query string form with the following keys:
            //   f  = first name
            //   l  = last name
            //   e  = email
            //   s  = specialty name (not specialty id)
            //   id = user id
            return String.Format("f={0}&l={1}&e={2}&s={3}&id={4}", first_name, last_name, email, specialtyName, user_id);
        }
    }
}
