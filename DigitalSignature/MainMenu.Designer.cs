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
            this.gbGenerateSymKey = new System.Windows.Forms.GroupBox();
            this.btnGenerateSymKey = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbGenerateSymKey = new System.Windows.Forms.TextBox();
            this.labelGenerateSymKey = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpSymmetric.SuspendLayout();
            this.gbGenerateSymKey.SuspendLayout();
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
            this.tpSymmetric.Controls.Add(this.gbGenerateSymKey);
            this.tpSymmetric.Location = new System.Drawing.Point(4, 29);
            this.tpSymmetric.Name = "tpSymmetric";
            this.tpSymmetric.Padding = new System.Windows.Forms.Padding(3);
            this.tpSymmetric.Size = new System.Drawing.Size(950, 496);
            this.tpSymmetric.TabIndex = 0;
            this.tpSymmetric.Text = "Symmetric cryptography";
            // 
            // gbGenerateSymKey
            // 
            this.gbGenerateSymKey.Controls.Add(this.labelGenerateSymKey);
            this.gbGenerateSymKey.Controls.Add(this.tbGenerateSymKey);
            this.gbGenerateSymKey.Controls.Add(this.btnGenerateSymKey);
            this.gbGenerateSymKey.Location = new System.Drawing.Point(6, 6);
            this.gbGenerateSymKey.Name = "gbGenerateSymKey";
            this.gbGenerateSymKey.Size = new System.Drawing.Size(938, 91);
            this.gbGenerateSymKey.TabIndex = 1;
            this.gbGenerateSymKey.TabStop = false;
            this.gbGenerateSymKey.Text = "Generating key";
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
            // tbGenerateSymKey
            // 
            this.tbGenerateSymKey.Location = new System.Drawing.Point(6, 49);
            this.tbGenerateSymKey.Name = "tbGenerateSymKey";
            this.tbGenerateSymKey.Size = new System.Drawing.Size(720, 27);
            this.tbGenerateSymKey.TabIndex = 1;
            // 
            // labelGenerateSymKey
            // 
            this.labelGenerateSymKey.AutoSize = true;
            this.labelGenerateSymKey.Location = new System.Drawing.Point(6, 26);
            this.labelGenerateSymKey.Name = "labelGenerateSymKey";
            this.labelGenerateSymKey.Size = new System.Drawing.Size(123, 20);
            this.labelGenerateSymKey.TabIndex = 2;
            this.labelGenerateSymKey.Text = "Output file path";
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
            this.gbGenerateSymKey.ResumeLayout(false);
            this.gbGenerateSymKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpSymmetric;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerateSymKey;
        private System.Windows.Forms.GroupBox gbGenerateSymKey;
        private System.Windows.Forms.Label labelGenerateSymKey;
        private System.Windows.Forms.TextBox tbGenerateSymKey;
    }
}

