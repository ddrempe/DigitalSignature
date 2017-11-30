using Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            tbGenerateSymKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographySecretKeyFileName);

            //setting default input and output paths for symmetric encryption
            tbSymEncryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbSymEncryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);

            //setting default input and output paths for symmetric decryption
            tbSymDecryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);
            tbSymDecryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyDecryptedFileName);

            //setting default path for files created for public and private key pair
            tbGenerateAsymPublicKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPublicKeyFileName);
            tbGenerateAsymPrivateKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPrivateKeyFileName);

            //setting default input and output paths for asymmetric encryption
            tbAsymEncryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbAsymEncryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyEncryptedFileName);
            tbAsymEncryptKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPublicKeyFileName);

            //setting default input and output paths for asymmetric decryption
            tbAsymDecryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyEncryptedFileName);
            tbAsymDecryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyDecryptedFileName);
            tbAsymDecryptKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPrivateKeyFileName);
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

        private void btnGenerateAsymKey_Click(object sender, EventArgs e)
        {
            string outputPublicKeyFilePath = tbGenerateAsymPublicKey.Text;
            string outputPrivateKeyFilePath = tbGenerateAsymPrivateKey.Text;

            RSACryptoServiceProvider csp = AsymmetricEncryption.GenerateCSP();
            RSAParameters publicKey = csp.ExportParameters(false);
            string publicKeyString = AsymmetricEncryption.ConvertParametersToStringKey(publicKey);
            RSAParameters privateKey = csp.ExportParameters(true);
            string privateKeyString = AsymmetricEncryption.ConvertParametersToStringKey(privateKey);

            File.WriteAllText(outputPublicKeyFilePath, publicKeyString);
            File.WriteAllText(outputPrivateKeyFilePath, privateKeyString);
        }

        private void btnAsymEncrypt_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbAsymEncryptInput.Text;
            string outputFilePath = tbAsymEncryptOutput.Text;
            string publicKeyPath = tbAsymEncryptKey.Text;

            string inputFileContent = File.ReadAllText(inputFilePath);
            string publicKeyContent = File.ReadAllText(publicKeyPath);
            RSAParameters publicKey = AsymmetricEncryption.ConvertStringKeyToParameters(publicKeyContent);

            string encryptedText = AsymmetricEncryption.EncryptText(inputFileContent, publicKey);
            File.WriteAllText(outputFilePath, encryptedText);
        }

        private void btnAsymDecrypt_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbAsymDecryptInput.Text;
            string outputFilePath = tbAsymDecryptOutput.Text;
            string privateKeyPath = tbAsymDecryptKey.Text;

            string inputFileContent = File.ReadAllText(inputFilePath);
            string privateKeyContent = File.ReadAllText(privateKeyPath);
            RSAParameters privateKey = AsymmetricEncryption.ConvertStringKeyToParameters(privateKeyContent);

            string decryptedText = AsymmetricEncryption.DecryptText(inputFileContent, privateKey);
            File.WriteAllText(outputFilePath, decryptedText);
        }
    }
}
