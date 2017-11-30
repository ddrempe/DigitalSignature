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
        }

        private void btnGenerateSymKey_Click(object sender, EventArgs e)
        {
            string outputFilePath = tbGenerateSymKey.Text;
            string symmetricKey = SymmetricEncryption.GenerateKey(Properties.Settings.Default.SymmetricCryptographyPassphrase);
            File.WriteAllText(outputFilePath, symmetricKey);
        }
    }
}
