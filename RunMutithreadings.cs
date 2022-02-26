using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liscuter
{
    internal class RunMutithreadings
    {
        public static void CallToChildThread()
        {
            
            Process.Start("run.bat");
            //MessageBox.Show(String.Format("启动完成！"));
        }
    }
}
