using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Cargolator
{
    public partial class EncryptionCenter : Form
    {
        private string filePath, keyPath, preData;
        private int postData,woNum;

        public EncryptionCenter()
        {
            InitializeComponent();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                filePath = txtBox_filePath.Text + ".txt";
                keyPath = txtBox_keyFile.Text + ".txt";
                preData = File.ReadAllText(filePath);
                Cypher cy = new Cypher(keyPath);
                postData = cy.Encryption(preData);
                cy.PrepDecryptedFile(postData);
                File.WriteAllText(@"file.Report.txt", "\nData decrypted successfully\nName of file: DecryptedFile.txt");
                Info info = new Info();
                info.Show();
                txtBox_filePath.Text = null;
                txtBox_keyFile.Text = null;
                txtBox_name.Text = null;
                txtBox_woNum = null;
            }
            catch
            {
                File.WriteAllText(@"file.Report.txt", "\nERROR!\nInvalid paths\ntry again");
                Info info = new Info();
                info.Show();
                return;
            }
        }

        private void btn_fileCreate_Click(object sender, EventArgs e)
        {
            filePath = txtBox_name.Text + ".txt";
            try { woNum = Int32.Parse(txtBox_woNum.Text); }
            catch
            {
                Info info = new Info();
                File.WriteAllText(@"file.Report.txt", "\nERROR!\nInvalid input\ntry again");
                info.Show();
                return;
            }
            WorkOrder tempWo = new WorkOrder(woNum);
            if (tempWo.MCflag == 0)
            {
                Info info = new Info();
                File.WriteAllText(@"file.Report.txt", "\nOnly for military contracts\nThis is not a military contract\n");
                info.Show();
                return;
            }
            try
            {
                    using (StreamWriter sw = File.CreateText(filePath)) { }
                    File.WriteAllText(filePath, tempWo.Speed.ToString());
                    Info info = new Info();
                    File.WriteAllText(@"file.Report.txt", "\nReport file " + filePath + " \nGenerated");
                    info.Show();

            }
            catch
            {
                Info info = new Info();
                File.WriteAllText(@"file.Report.txt", "\nERROR!\nInvalid input\ntry again");
                info.Show();
                return;
            }
            //txtBox_name.Text = null;
            //txtBox_woNum = null;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                filePath = txtBox_filePath.Text + ".txt";
                keyPath = txtBox_keyFile.Text + ".txt";
                preData = File.ReadAllText(filePath);
                Cypher cy = new Cypher(keyPath);
                postData = cy.Encryption(preData);
                cy.PrepEncryptedFile(postData);
                File.WriteAllText(@"file.Report.txt", "\nData encrypted successfully\nName of file: EncryptedFile.txt");
                Info info = new Info();
                info.Show();
                txtBox_filePath.Text = null;
                txtBox_keyFile.Text = null;
            }
            catch
            {
                File.WriteAllText(@"file.Report.txt", "\nERROR!\nInvalid paths\ntry again");
                Info info = new Info();
                info.Show();
                return;
            }
        }
    }
}
