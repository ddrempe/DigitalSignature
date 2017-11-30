namespace DigitalSignature
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpSymmetric = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGenerateSymKey = new System.Windows.Forms.TextBox();
            this.btnGenerateSymKey = new System.Windows.Forms.Button();
            this.tpAsymmetric = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSymEncryptInput = new System.Windows.Forms.TextBox();
            this.btnSymEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSymEncryptOutput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSymDecryptOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSymDecryptInput = new System.Windows.Forms.TextBox();
            this.btnSymDecrypt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAsymDecryptOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAsymDecryptInput = new System.Windows.Forms.TextBox();
            this.btnAsymDecrypt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAsymEncryptOutput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAsymEncryptInput = new System.Windows.Forms.TextBox();
            this.btnAsymEncrypt = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGenerateAsymPublicKey = new System.Windows.Forms.TextBox();
            this.btnGenerateAsymKey = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAsymEncryptKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAsymDecryptKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbGenerateAsymPrivateKey = new System.Windows.Forms.TextBox();
            this.tpHash = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbHashTextOutput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbHashTextInput = new System.Windows.Forms.TextBox();
            this.btnHashText = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpSymmetric.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpAsymmetric.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpHash.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpSymmetric);
            this.tabControl.Controls.Add(this.tpAsymmetric);
            this.tabControl.Controls.Add(this.tpHash);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(958, 612);
            this.tabControl.TabIndex = 1;
            // 
            // tpSymmetric
            // 
            this.tpSymmetric.BackColor = System.Drawing.Color.White;
            this.tpSymmetric.Controls.Add(this.groupBox3);
            this.tpSymmetric.Controls.Add(this.groupBox2);
            this.tpSymmetric.Controls.Add(this.groupBox1);
            this.tpSymmetric.Location = new System.Drawing.Point(4, 29);
            this.tpSymmetric.Name = "tpSymmetric";
            this.tpSymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.tpSymmetric.Size = new System.Drawing.Size(950, 579);
            this.tpSymmetric.TabIndex = 0;
            this.tpSymmetric.Text = "Symmetric cryptography";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbGenerateSymKey);
            this.groupBox1.Controls.Add(this.btnGenerateSymKey);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generating secret key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Secret key output file";
            // 
            // tbGenerateSymKey
            // 
            this.tbGenerateSymKey.Location = new System.Drawing.Point(6, 49);
            this.tbGenerateSymKey.Name = "tbGenerateSymKey";
            this.tbGenerateSymKey.Size = new System.Drawing.Size(720, 27);
            this.tbGenerateSymKey.TabIndex = 1;
            // 
            // btnGenerateSymKey
            // 
            this.btnGenerateSymKey.Location = new System.Drawing.Point(732, 49);
            this.btnGenerateSymKey.Name = "btnGenerateSymKey";
            this.btnGenerateSymKey.Size = new System.Drawing.Size(200, 27);
            this.btnGenerateSymKey.TabIndex = 0;
            this.btnGenerateSymKey.Text = "Generate";
            this.btnGenerateSymKey.UseVisualStyleBackColor = true;
            this.btnGenerateSymKey.Click += new System.EventHandler(this.btnGenerateSymKey_Click);
            // 
            // tpAsymmetric
            // 
            this.tpAsymmetric.BackColor = System.Drawing.Color.White;
            this.tpAsymmetric.Controls.Add(this.groupBox4);
            this.tpAsymmetric.Controls.Add(this.groupBox5);
            this.tpAsymmetric.Controls.Add(this.groupBox6);
            this.tpAsymmetric.Location = new System.Drawing.Point(4, 29);
            this.tpAsymmetric.Name = "tpAsymmetric";
            this.tpAsymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsymmetric.Size = new System.Drawing.Size(950, 579);
            this.tpAsymmetric.TabIndex = 1;
            this.tpAsymmetric.Text = "Asymmetric cryptography";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSymEncryptOutput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSymEncryptInput);
            this.groupBox2.Controls.Add(this.btnSymEncrypt);
            this.groupBox2.Location = new System.Drawing.Point(6, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Symmetric encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plain text input file";
            // 
            // tbSymEncryptInput
            // 
            this.tbSymEncryptInput.Location = new System.Drawing.Point(6, 49);
            this.tbSymEncryptInput.Name = "tbSymEncryptInput";
            this.tbSymEncryptInput.Size = new System.Drawing.Size(720, 27);
            this.tbSymEncryptInput.TabIndex = 1;
            // 
            // btnSymEncrypt
            // 
            this.btnSymEncrypt.Location = new System.Drawing.Point(732, 49);
            this.btnSymEncrypt.Name = "btnSymEncrypt";
            this.btnSymEncrypt.Size = new System.Drawing.Size(200, 84);
            this.btnSymEncrypt.TabIndex = 0;
            this.btnSymEncrypt.Text = "Encrypt";
            this.btnSymEncrypt.UseVisualStyleBackColor = true;
            this.btnSymEncrypt.Click += new System.EventHandler(this.btnSymEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encrypted text output file";
            // 
            // tbSymEncryptOutput
            // 
            this.tbSymEncryptOutput.Location = new System.Drawing.Point(6, 106);
            this.tbSymEncryptOutput.Name = "tbSymEncryptOutput";
            this.tbSymEncryptOutput.Size = new System.Drawing.Size(720, 27);
            this.tbSymEncryptOutput.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbSymDecryptOutput);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbSymDecryptInput);
            this.groupBox3.Controls.Add(this.btnSymDecrypt);
            this.groupBox3.Location = new System.Drawing.Point(6, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(938, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symmetric decryption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Decrypted text output file";
            // 
            // tbSymDecryptOutput
            // 
            this.tbSymDecryptOutput.Location = new System.Drawing.Point(6, 106);
            this.tbSymDecryptOutput.Name = "tbSymDecryptOutput";
            this.tbSymDecryptOutput.Size = new System.Drawing.Size(720, 27);
            this.tbSymDecryptOutput.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Encrypted text input file";
            // 
            // tbSymDecryptInput
            // 
            this.tbSymDecryptInput.Location = new System.Drawing.Point(6, 49);
            this.tbSymDecryptInput.Name = "tbSymDecryptInput";
            this.tbSymDecryptInput.Size = new System.Drawing.Size(720, 27);
            this.tbSymDecryptInput.TabIndex = 1;
            // 
            // btnSymDecrypt
            // 
            this.btnSymDecrypt.Location = new System.Drawing.Point(732, 49);
            this.btnSymDecrypt.Name = "btnSymDecrypt";
            this.btnSymDecrypt.Size = new System.Drawing.Size(200, 84);
            this.btnSymDecrypt.TabIndex = 0;
            this.btnSymDecrypt.Text = "Decrypt";
            this.btnSymDecrypt.UseVisualStyleBackColor = true;
            this.btnSymDecrypt.Click += new System.EventHandler(this.btnSymDecrypt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbAsymDecryptKey);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbAsymDecryptOutput);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbAsymDecryptInput);
            this.groupBox4.Controls.Add(this.btnAsymDecrypt);
            this.groupBox4.Location = new System.Drawing.Point(6, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(938, 195);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asymmetric decryption";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Decrypted text output file";
            // 
            // tbAsymDecryptOutput
            // 
            this.tbAsymDecryptOutput.Location = new System.Drawing.Point(6, 163);
            this.tbAsymDecryptOutput.Name = "tbAsymDecryptOutput";
            this.tbAsymDecryptOutput.Size = new System.Drawing.Size(720, 27);
            this.tbAsymDecryptOutput.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Encrypted text input file";
            // 
            // tbAsymDecryptInput
            // 
            this.tbAsymDecryptInput.Location = new System.Drawing.Point(6, 49);
            this.tbAsymDecryptInput.Name = "tbAsymDecryptInput";
            this.tbAsymDecryptInput.Size = new System.Drawing.Size(720, 27);
            this.tbAsymDecryptInput.TabIndex = 1;
            // 
            // btnAsymDecrypt
            // 
            this.btnAsymDecrypt.Location = new System.Drawing.Point(732, 49);
            this.btnAsymDecrypt.Name = "btnAsymDecrypt";
            this.btnAsymDecrypt.Size = new System.Drawing.Size(200, 137);
            this.btnAsymDecrypt.TabIndex = 0;
            this.btnAsymDecrypt.Text = "Decrypt";
            this.btnAsymDecrypt.UseVisualStyleBackColor = true;
            this.btnAsymDecrypt.Click += new System.EventHandler(this.btnAsymDecrypt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbAsymEncryptKey);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tbAsymEncryptOutput);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbAsymEncryptInput);
            this.groupBox5.Controls.Add(this.btnAsymEncrypt);
            this.groupBox5.Location = new System.Drawing.Point(6, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(938, 195);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Asymmetric encryption";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Encrypted text output file";
            // 
            // tbAsymEncryptOutput
            // 
            this.tbAsymEncryptOutput.Location = new System.Drawing.Point(6, 159);
            this.tbAsymEncryptOutput.Name = "tbAsymEncryptOutput";
            this.tbAsymEncryptOutput.Size = new System.Drawing.Size(720, 27);
            this.tbAsymEncryptOutput.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Plain text input file";
            // 
            // tbAsymEncryptInput
            // 
            this.tbAsymEncryptInput.Location = new System.Drawing.Point(6, 49);
            this.tbAsymEncryptInput.Name = "tbAsymEncryptInput";
            this.tbAsymEncryptInput.Size = new System.Drawing.Size(720, 27);
            this.tbAsymEncryptInput.TabIndex = 1;
            // 
            // btnAsymEncrypt
            // 
            this.btnAsymEncrypt.Location = new System.Drawing.Point(732, 49);
            this.btnAsymEncrypt.Name = "btnAsymEncrypt";
            this.btnAsymEncrypt.Size = new System.Drawing.Size(200, 137);
            this.btnAsymEncrypt.TabIndex = 0;
            this.btnAsymEncrypt.Text = "Encrypt";
            this.btnAsymEncrypt.UseVisualStyleBackColor = true;
            this.btnAsymEncrypt.Click += new System.EventHandler(this.btnAsymEncrypt_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tbGenerateAsymPrivateKey);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.tbGenerateAsymPublicKey);
            this.groupBox6.Controls.Add(this.btnGenerateAsymKey);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(938, 140);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Generating public and private key pair";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Public key output file";
            // 
            // tbGenerateAsymPublicKey
            // 
            this.tbGenerateAsymPublicKey.Location = new System.Drawing.Point(6, 49);
            this.tbGenerateAsymPublicKey.Name = "tbGenerateAsymPublicKey";
            this.tbGenerateAsymPublicKey.Size = new System.Drawing.Size(720, 27);
            this.tbGenerateAsymPublicKey.TabIndex = 1;
            // 
            // btnGenerateAsymKey
            // 
            this.btnGenerateAsymKey.Location = new System.Drawing.Point(732, 49);
            this.btnGenerateAsymKey.Name = "btnGenerateAsymKey";
            this.btnGenerateAsymKey.Size = new System.Drawing.Size(200, 80);
            this.btnGenerateAsymKey.TabIndex = 0;
            this.btnGenerateAsymKey.Text = "Generate";
            this.btnGenerateAsymKey.UseVisualStyleBackColor = true;
            this.btnGenerateAsymKey.Click += new System.EventHandler(this.btnGenerateAsymKey_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Encryption key input file";
            // 
            // tbAsymEncryptKey
            // 
            this.tbAsymEncryptKey.Location = new System.Drawing.Point(6, 104);
            this.tbAsymEncryptKey.Name = "tbAsymEncryptKey";
            this.tbAsymEncryptKey.Size = new System.Drawing.Size(720, 27);
            this.tbAsymEncryptKey.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Decryption key input file";
            // 
            // tbAsymDecryptKey
            // 
            this.tbAsymDecryptKey.Location = new System.Drawing.Point(6, 107);
            this.tbAsymDecryptKey.Name = "tbAsymDecryptKey";
            this.tbAsymDecryptKey.Size = new System.Drawing.Size(720, 27);
            this.tbAsymDecryptKey.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(811, 627);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Damir Drempetić (2017)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Public key output file";
            // 
            // tbGenerateAsymPrivateKey
            // 
            this.tbGenerateAsymPrivateKey.Location = new System.Drawing.Point(6, 102);
            this.tbGenerateAsymPrivateKey.Name = "tbGenerateAsymPrivateKey";
            this.tbGenerateAsymPrivateKey.Size = new System.Drawing.Size(720, 27);
            this.tbGenerateAsymPrivateKey.TabIndex = 3;
            // 
            // tpHash
            // 
            this.tpHash.Controls.Add(this.groupBox7);
            this.tpHash.Location = new System.Drawing.Point(4, 29);
            this.tpHash.Name = "tpHash";
            this.tpHash.Padding = new System.Windows.Forms.Padding(3);
            this.tpHash.Size = new System.Drawing.Size(950, 579);
            this.tpHash.TabIndex = 2;
            this.tpHash.Text = "Hashing";
            this.tpHash.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.tbHashTextOutput);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.tbHashTextInput);
            this.groupBox7.Controls.Add(this.btnHashText);
            this.groupBox7.Location = new System.Drawing.Point(6, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(938, 151);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Text hashing";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Hashed text output file";
            // 
            // tbHashTextOutput
            // 
            this.tbHashTextOutput.Location = new System.Drawing.Point(6, 106);
            this.tbHashTextOutput.Name = "tbHashTextOutput";
            this.tbHashTextOutput.Size = new System.Drawing.Size(720, 27);
            this.tbHashTextOutput.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Plain text input file";
            // 
            // tbHashTextInput
            // 
            this.tbHashTextInput.Location = new System.Drawing.Point(6, 49);
            this.tbHashTextInput.Name = "tbHashTextInput";
            this.tbHashTextInput.Size = new System.Drawing.Size(720, 27);
            this.tbHashTextInput.TabIndex = 1;
            // 
            // btnHashText
            // 
            this.btnHashText.Location = new System.Drawing.Point(732, 49);
            this.btnHashText.Name = "btnHashText";
            this.btnHashText.Size = new System.Drawing.Size(200, 84);
            this.btnHashText.TabIndex = 0;
            this.btnHashText.Text = "Hash";
            this.btnHashText.UseVisualStyleBackColor = true;
            this.btnHashText.Click += new System.EventHandler(this.btnHashText_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tabControl);
            this.Name = "MainMenu";
            this.Text = "Digital Signature";
            this.tabControl.ResumeLayout(false);
            this.tpSymmetric.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpAsymmetric.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpHash.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpSymmetric;
        private System.Windows.Forms.TabPage tpAsymmetric;
        private System.Windows.Forms.Button btnGenerateSymKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGenerateSymKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSymEncryptOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSymEncryptInput;
        private System.Windows.Forms.Button btnSymEncrypt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSymDecryptOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSymDecryptInput;
        private System.Windows.Forms.Button btnSymDecrypt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAsymDecryptOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAsymDecryptInput;
        private System.Windows.Forms.Button btnAsymDecrypt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAsymEncryptOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAsymEncryptInput;
        private System.Windows.Forms.Button btnAsymEncrypt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGenerateAsymPublicKey;
        private System.Windows.Forms.Button btnGenerateAsymKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAsymDecryptKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAsymEncryptKey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbGenerateAsymPrivateKey;
        private System.Windows.Forms.TabPage tpHash;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbHashTextOutput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbHashTextInput;
        private System.Windows.Forms.Button btnHashText;
    }
}

