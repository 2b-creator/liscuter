using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace liscuter
{
    internal class StreamWriterTwo
    {
        public async Task ExampleAsync(string input)
        {
            String isAppend = ConfigurationManager.AppSettings["IsAppend"];
            string temp;
            if (isAppend == "y")
            {
                temp = "true";
            }
            else
            {
                temp = "false";
            }
            bool booltemp = Convert.ToBoolean(temp);
            StreamWriter file = new StreamWriter("run.bat", append: booltemp);
            await file.WriteLineAsync(input);
        }
    }
}
