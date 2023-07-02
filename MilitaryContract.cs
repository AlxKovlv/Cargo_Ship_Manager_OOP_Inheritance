using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cargolator
{
    public class MilitaryContract : WorkOrder 
    {
        static string creditPath = @"MilitaryCredit.txt";
        public MilitaryContract() { }

        public void giveCredit()
        {
            int temp = Int32.Parse(File.ReadAllText(creditPath));
            temp++;
            if (Speed > 50) temp++;
            File.WriteAllText(creditPath, temp.ToString());
        }

        public void checkContract()
        {
            int temp = Int32.Parse(File.ReadAllText(creditPath));
            if (temp >= 100)
            {
                string zeroCredit = "0";
                File.WriteAllText(creditPath, zeroCredit);
                File.WriteAllText(@"file.Report.txt", "\nATTENTION!\nReached military contract limit\nPlease revise contract");
                Info info = new Info();
                info.Show();
            }
        }

    }
}
