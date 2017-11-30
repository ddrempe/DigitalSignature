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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSymEncryptInput = new System.Windows.Forms.TextBox();
            this.btnSymEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSymEncryptOutput = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpSymmetric.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpSymmetric);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(958, 529);
            this.tabControl.TabIndex = 1;
            // 
            // tpSymmetric
            // 
            this.tpSymmetric.BackColor = System.Drawing.Color.White;
            this.tpSymmetric.Controls.Add(this.groupBox2);
            this.tpSymmetric.Controls.Add(this.groupBox1);
            this.tpSymmetric.Location = new System.Drawing.Point(4, 29);
            this.tpSymmetric.Name = "tpSymmetric";
            this.tpSymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.tpSymmetric.Size = new System.Drawing.Size(950, 496);
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
            this.groupBox1.Text = "Generating key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output file path";
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
            this.btnGenerateSymKey.Location = new System.Drawing.Point(732, 26);
            this.btnGenerateSymKey.Name = "btnGenerateSymKey";
            this.btnGenerateSymKey.Size = new System.Drawing.Size(200, 50);
            this.btnGenerateSymKey.TabIndex = 0;
            this.btnGenerateSymKey.Text = "Generate";
            this.btnGenerateSymKey.UseVisualStyleBackColor = true;
            this.btnGenerateSymKey.Click += new System.EventHandler(this.btnGenerateSymKey_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSymEncryptOutput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSymEncryptInput);
            this.groupBox2.Controls.Add(this.btnSymEncrypt);
            this.groupBox2.Location = new System.Drawing.Point(6, 103);
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
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input file path";
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
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output file path";
            // 
            // tbSymEncryptOutput
            // 
            this.tbSymEncryptOutput.Location = new System.Drawing.Point(6, 106);
            this.tbSymEncryptOutput.Name = "tbSymEncryptOutput";
            this.tbSymEncryptOutput.Size = new System.Drawing.Size(720, 27);
            this.tbSymEncryptOutput.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabControl);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.tabControl.ResumeLayout(false);
            this.tpSymmetric.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpSymmetric;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

