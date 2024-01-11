using CompInstaller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInstaller.InstallerTasks
{
    public class WindowsAPICodePack : IInstallerTasks
    {
        public void ExecuteTask(Form1 form)
        {
            // Code to start WindowsAPICodePack Command

            MessageBox.Show("Using WindowsAPI pack!");

            //throw new NotImplementedException();
        }
    }
}
