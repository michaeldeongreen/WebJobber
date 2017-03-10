using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobber.Services
{
    public class FileService
    {
        public void Write()
        {
            string path = string.Format(@"{0}\webjobber.txt", Environment.CurrentDirectory);
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
