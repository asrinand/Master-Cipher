using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripleCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (txtClearText.Text == "")
                {
                    MessageBox.Show("Enter the plain text you want to encrypt","Plain Text Field Empty !");
                }
                else
                {
                    try
                    {
                        string clearText = txtClearText.Text.Trim();
                        string cipherText = CipherAlgo.Encrypt(clearText, true);
                        labelTemp1.Text = cipherText;
                        string cipherText1 = CipherAlgo.Encrypt(labelTemp1.Text, true);
                        string cipherText2 = cipherText1.Replace("=", " kL$ ");
                        string cipherText3 = cipherText2.Replace("+", " R+rE ");
                        string cipherText4 = cipherText3.Replace("/", " nJ/G ");
                        string cipherText5 = cipherText4.Replace(" ", "");
                        txtCipherText.Text = cipherText5;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid text entered");
                    }
                }
            

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (txtClearText.Text == "")
            {
                MessageBox.Show("Enter the encrypted text you want to decrypt","Encrypted Text Field Empty !");
            }
            else
            {
                try
                {
                    string cipherText = txtClearText.Text.Trim();
                    string cipherText1 = cipherText.Replace("kL$", "=");
                    string cipherText2 = cipherText1.Replace("R+rE", "+");
                    string cipherText3 = cipherText2.Replace("nJ/G", "/");
                    string cipherText4 = CipherAlgo.Decrypt(cipherText3, true);
                    labelTemp1.Text = cipherText4;
                    string decryptedText = CipherAlgo.Decrypt(labelTemp1.Text, true);
                    txtCipherText.Text = decryptedText;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Encrypted text");
                }
            }
        }

        private void radioButtonEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            txtClearText.Text = "";
            txtCipherText.Text = "";
            label1.Text = "Enter Plain Text -";
            label2.Text = "Encrypted Text -";
            buttonDecrypt.Visible = false;
            buttonEncrypt.Visible = true;
            txtClearText.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtClearText.Text = "";
            txtCipherText.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonEncrypt.Checked = true;
            txtClearText.Text = "";
            txtCipherText.Text = "";
            label1.Text = "Enter Plain Text -";
            label2.Text = "Encrypted Text -";
            buttonDecrypt.Visible = false;
            buttonEncrypt.Visible = true;
        }

        private void radioButtonDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            txtClearText.Text = "";
            txtCipherText.Text = "";
            label1.Text = "Enter Encrypted Text -";
            label2.Text = "Decrypted Text -";
            buttonDecrypt.Visible = true;
            buttonEncrypt.Visible = false;
            txtClearText.Focus();
        }

        private void txtClearText_DoubleClick(object sender, EventArgs e)
        {
            txtClearText.SelectAll();
        }

        private void txtCipherText_DoubleClick(object sender, EventArgs e)
        {
            txtCipherText.SelectAll();
        }

    }
}
