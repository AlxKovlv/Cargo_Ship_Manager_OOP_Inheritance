namespace Cargolator
{
    partial class EncryptionCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionCenter));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtBox_woNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_fileCreate = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_filePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_keyFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cargolator.Properties.Resources.encryption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encryption Center";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(142, 561);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 39);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Close";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtBox_woNum
            // 
            this.txtBox_woNum.Location = new System.Drawing.Point(40, 46);
            this.txtBox_woNum.Name = "txtBox_woNum";
            this.txtBox_woNum.Size = new System.Drawing.Size(215, 20);
            this.txtBox_woNum.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter work order number";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.BackColor = System.Drawing.Color.DimGray;
            this.btn_encrypt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_encrypt.Location = new System.Drawing.Point(19, 122);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(130, 39);
            this.btn_encrypt.TabIndex = 29;
            this.btn_encrypt.Text = "Encrypt ";
            this.btn_encrypt.UseVisualStyleBackColor = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_fileCreate
            // 
            this.btn_fileCreate.BackColor = System.Drawing.Color.DimGray;
            this.btn_fileCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_fileCreate.Location = new System.Drawing.Point(80, 138);
            this.btn_fileCreate.Name = "btn_fileCreate";
            this.btn_fileCreate.Size = new System.Drawing.Size(130, 39);
            this.btn_fileCreate.TabIndex = 30;
            this.btn_fileCreate.Text = "Generate File";
            this.btn_fileCreate.UseVisualStyleBackColor = false;
            this.btn_fileCreate.Click += new System.EventHandler(this.btn_fileCreate_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.Color.DimGray;
            this.btn_decrypt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_decrypt.Location = new System.Drawing.Point(155, 122);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(130, 39);
            this.btn_decrypt.TabIndex = 31;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Enter file name";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(40, 98);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(215, 20);
            this.txtBox_name.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_fileCreate);
            this.groupBox2.Controls.Add(this.txtBox_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBox_woNum);
            this.groupBox2.Location = new System.Drawing.Point(62, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 199);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create report file ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBox_keyFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBox_filePath);
            this.groupBox3.Controls.Add(this.btn_decrypt);
            this.groupBox3.Controls.Add(this.btn_encrypt);
            this.groupBox3.Location = new System.Drawing.Point(62, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 199);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encrypt/Decrypt file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Enter file name";
            // 
            // txtBox_filePath
            // 
            this.txtBox_filePath.Location = new System.Drawing.Point(40, 47);
            this.txtBox_filePath.Name = "txtBox_filePath";
            this.txtBox_filePath.Size = new System.Drawing.Size(215, 20);
            this.txtBox_filePath.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Enter encryption key";
            // 
            // txtBox_keyFile
            // 
            this.txtBox_keyFile.Location = new System.Drawing.Point(40, 89);
            this.txtBox_keyFile.Name = "txtBox_keyFile";
            this.txtBox_keyFile.Size = new System.Drawing.Size(215, 20);
            this.txtBox_keyFile.TabIndex = 39;
            // 
            // EncryptionCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 626);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionCenter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtBox_woNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_fileCreate;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_filePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_keyFile;
    }
}