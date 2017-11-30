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

            //setting default path for file created for symmetric key
            tbGenerateSymKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricKeyOutputFileName);

            //setting default input and output paths for symmetric encryption
            tbSymEncryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbSymEncryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);

            //setting default input and output paths for symmetric decryption
            tbSymDecryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);
            tbSymDecryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyDecryptedFileName);
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

        private void btnSymDecrypt_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbSymDecryptInput.Text;
            string outputFilePath = tbSymDecryptOutput.Text;
            string inputFileContent = File.ReadAllText(inputFilePath);
            string decryptedText = SymmetricEncryption.DecryptText(inputFileContent, Properties.Settings.Default.SymmetricCryptographyPassphrase);
            File.WriteAllText(outputFilePath, decryptedText);
        }
    }
}
