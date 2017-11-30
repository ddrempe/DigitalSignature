using Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            tbGenerateSymKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricKeyOutputFileName);
            tbSymEncryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbSymEncryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);
        }

        private void btnGenerateSymKey_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbGenerateSymKey.Text;
            string symmetricKey = SymmetricEncryption.GenerateKey(Properties.Settings.Default.SymmetricCryptographyPassphrase);
            File.WriteAllText(outputFilePath, symmetricKey);
        }

        private void btnSymEncrypt_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbSymEncryptInput.Text;
            string outputFilePath = tbSymEncryptOutput.Text;
            string inputFileContent = File.ReadAllText(inputFilePath);
            string encryptedText = SymmetricEncryption.EncryptText(inputFileContent, Properties.Settings.Default.SymmetricCryptographyPassphrase);
            File.WriteAllText(outputFilePath, encryptedText);
        }
    }
}
