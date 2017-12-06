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
            tbSymEncryptKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographySecretKeyFileName);

            //setting default input and output paths for symmetric decryption
            tbSymDecryptInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyEncryptedFileName);
            tbSymDecryptOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographyDecryptedFileName);
            tbSymDecryptKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.SymmetricCryptographySecretKeyFileName);

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

            //setting default input and output paths for text hashing
            tbHashTextInput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbHashTextOutput.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.HashedTextFileName);

            //setting default input paths for creating digital signature
            tbCreateDSInputText.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbCreateDSInputKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPrivateKeyFileName);

            //setting default input paths for checking digital signature
            tbCheckDSInputText.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.PlainTextFileName);
            tbCheckDSInputKey.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.AsymmetricCryptographyPublicKeyFileName);
            tbCheckDSInputSignature.Text = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.DigitalSignatureEncryptedFileName);
        }

        private void btnGenerateSymKey_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbGenerateSymKey.Text;
            string symmetricKey = SymmetricEncryption.GenerateKey_Aes();
            File.WriteAllText(outputFilePath, symmetricKey);
        }

        private void btnSymEncrypt_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbSymEncryptOutput.Text;
            string inputFilePath = tbSymEncryptInput.Text;
            string inputFileContent = File.ReadAllText(inputFilePath);
            string secretKeyPath = tbSymEncryptKey.Text;
            string secretKeyContent = File.ReadAllText(secretKeyPath);

            string encryptedText = SymmetricEncryption.EncryptString_Aes(inputFileContent, secretKeyContent);
            File.WriteAllText(outputFilePath, encryptedText);
        }

        private void btnSymDecrypt_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbSymDecryptOutput.Text;
            string inputFilePath = tbSymDecryptInput.Text;            
            string inputFileContent = File.ReadAllText(inputFilePath);
            string secretKeyPath = tbSymDecryptKey.Text;
            string secretKeyContent = File.ReadAllText(secretKeyPath);

            string decryptedText = SymmetricEncryption.DecryptString_Aes(inputFileContent, secretKeyContent);
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

        private void btnHashText_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbHashTextInput.Text;
            string outputFilePath = tbHashTextOutput.Text;

            string inputFileContent = File.ReadAllText(inputFilePath);
            string hashedText = Hashing.GetHashedText(inputFileContent);

            File.WriteAllText(outputFilePath, hashedText);
        }

        private void btnCreateDigitalSignature_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbCreateDSInputText.Text;
            string inputFileContent = File.ReadAllText(inputFilePath);

            string inputKeyPath = tbCreateDSInputKey.Text;
            string inputKeyContent = File.ReadAllText(inputKeyPath);
            RSAParameters inputKey = AsymmetricEncryption.ConvertStringKeyToParameters(inputKeyContent);

            string outputHashFilePath = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.DigitalSignatureHashedFileName);
            string hashedText = Hashing.GetHashedText(inputFileContent);
            File.WriteAllText(outputHashFilePath, hashedText);

            string outputEncryptedFilePath = Path.Combine(Properties.Settings.Default.FolderPath, Properties.Settings.Default.DigitalSignatureEncryptedFileName);
            string encryptedHash = AsymmetricEncryption.EncryptText(hashedText, inputKey);
            File.WriteAllText(outputEncryptedFilePath, encryptedHash);
        }

        private void btnCheckDigitalSignature_Click(object sender, EventArgs e)
        {
            string inputFilePath = tbCheckDSInputText.Text;
            string inputFileContent = File.ReadAllText(inputFilePath);

            string inputKeyPath = tbCheckDSInputKey.Text;
            string inputKeyContent = File.ReadAllText(inputKeyPath);
            RSAParameters inputKey = AsymmetricEncryption.ConvertStringKeyToParameters(inputKeyContent);

            string inputSignaturePath = tbCheckDSInputSignature.Text;
            string inputSignatureContent = File.ReadAllText(inputSignaturePath);

            string hashedText = Hashing.GetHashedText(inputFileContent);
            string decryptedHash = AsymmetricEncryption.DecryptText(inputSignatureContent, inputKey);

            if (decryptedHash == hashedText)
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Digital signature is not valid!");
            }
        }
    }
}
