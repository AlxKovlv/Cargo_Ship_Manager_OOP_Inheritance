using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cargolator
{
    public class Cypher : WorkOrder
    {
        private int Key { get; set; }
        private string KeyPath { get; set; }
        public Cypher(string keyPath)
        {
            KeyPath = keyPath;
            Key = Int32.Parse((File.ReadAllText(keyPath)));
        }
        public int Encryption(string Data)
        {
            int temp = Int32.Parse(Data);
            return temp ^ Key;
        }
        public void PrepEncryptedFile(int data)
        {
            File.WriteAllText(@"EncryptedFile.txt", data.ToString());
        }
        public void PrepDecryptedFile(int data)
        {
            File.WriteAllText(@"DecryptedFile.txt", data.ToString());
        }

    }
}
