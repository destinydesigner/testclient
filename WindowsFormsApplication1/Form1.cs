using System;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms; 

namespace WindowsFormsApplication1
{
    public partial class HttpTest : Form
    {
        string sPrivateKey;
        string sKeyValueSeparator = "=";
        string sParametersSeparator = "&";
        string sData;
        string sSignature;

        public HttpTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddKeyValuePair("Key", "Value");
        }

        public void AddKeyValuePair(string keyStr, string valueStr)
        {
            System.Windows.Forms.TextBox key = new System.Windows.Forms.TextBox();
            System.Windows.Forms.TextBox value = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button delete = new System.Windows.Forms.Button();

            int row = this.Parameters.RowCount;
            this.Parameters.RowCount += 1;

            key.Text = keyStr;
            value.Text = valueStr;
            value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            
            this.Parameters.Controls.Add(key, 0, row);
            this.Parameters.Controls.Add(value, 1, row);
            this.Parameters.Controls.Add(delete, 2, row);

            delete.Text = "Delete";
            delete.Click += new EventHandler(DeleteKeyValuePair);
        }

        private void DeleteKeyValuePair(object sender, EventArgs e)
        {
            if (this.Parameters.RowCount == 0)
                return;
            int index = this.Parameters.Controls.GetChildIndex((System.Windows.Forms.Control)sender);
            int start = index - this.Parameters.ColumnCount + 1;
            for (int i = start, j = 0; j < this.Parameters.ColumnCount; j++)
            {
                this.Parameters.Controls.RemoveAt(i);
            }            
        }

        private void ChoosePrivateFile_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openPrivateKey.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.PrivateFile.Text = this.openPrivateKey.FileName;
                sPrivateKey = this.openPrivateKey.FileName;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                this.ResponseGroupBox.Visible = false;

                if (this.sPrivateKey == null || this.sPrivateKey.Equals(""))
                {
                    throw new Exception("Please select a private key.");
                }
                this.sData = GetParametersString();
                this.sSignature = MakeSignature(this.sData);
                SendRequest(this.sData + this.sParametersSeparator + "signature=" + this.sSignature);

                this.ResponseGroupBox.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetParametersString()
        {
            int i = 0;
            List<string> pairs = new List<string>();
            for (i = 0; i < this.Parameters.RowCount; i++)
            {
                Control key = this.Parameters.GetControlFromPosition(0, i);
                Control value = this.Parameters.GetControlFromPosition(1, i);

                pairs.Add(key.Text + this.sKeyValueSeparator + value.Text);

            }
            pairs.Sort();
            return string.Join(sParametersSeparator, pairs.ToArray());
        }

        private string MakeSignature(string data)
        {
            string sSignature = string.Empty;

            try
            {
                string signedData = data;

                string strPrivateKeyXml = System.IO.File.ReadAllText(this.sPrivateKey);

                RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();
                rsaProvider.FromXmlString(strPrivateKeyXml);

                UTF8Encoding enc = new UTF8Encoding();
                byte[] _databyte = enc.GetBytes(signedData);

                byte[] plain = rsaProvider.SignData(_databyte, "SHA1");
                sSignature = Convert.ToBase64String(plain);
                return sSignature;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SendRequest(string sParameters)
        {
            var request = new MyRequest(this.URL.Text);

            request.Method = GetMethod();
            request.Parameters = sParameters;

            WebResponse response = request.DoRequest();

            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                this.textBox1.Text = reader.ReadToEnd();
            }

            this.LoadingTime.Text = request.LoadingTime.ToString() + " ms";

        }

        private string GetMethod()
        {
            RadioButton checkedButton = this.MethodGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            return checkedButton.Text;
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            string s = this.ParametersTextBox.Text;
            if (s.Equals(""))
            {
                return;
            }
            ClearParameters();
            try
            {
                foreach ( string p in s.Split(this.sParametersSeparator.ToCharArray()) )
                {
                    string[] pair = p.Split(this.sKeyValueSeparator.ToCharArray());
                    AddKeyValuePair(pair[0], pair[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_to_Raw(object sender, EventArgs e)
        {
            this.ParametersTextBox.Text = GetParametersString();
        }

        private void ClearParameters()
        {
            this.Parameters.Controls.Clear();
            this.Parameters.RowCount = 0;
        }

        private void ClearParametersButton_Click(object sender, EventArgs e)
        {
            ClearParameters();
        }

        private void ParameterFormPage_Click(object sender, EventArgs e)
        {
            Parse_Click(sender, e);
        }

        private void ParameterTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ParameterTabControl.SelectedTab.Text.Equals("Form"))
            {
                Parse_Click(sender, e);
            }
            else if (this.ParameterTabControl.SelectedTab.Text.Equals("Raw"))
            {
                Form_to_Raw(sender, e);
            }
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {
            string s = this.URL.Text;
            string[] list = s.Split('?');
            if (list.Length == 2)
            {
                this.URL.Text = list[0];
                this.ParametersTextBox.Text = list[1];
            }
        }
    }
}
