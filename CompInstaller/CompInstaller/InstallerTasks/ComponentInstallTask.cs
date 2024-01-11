using CompInstaller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInstaller.InstallerTasks
{

    public class ComponentInstallTask
    {
        private readonly IInstallerTasks _installer;
        private readonly Form1 _form;

        public ComponentInstallTask(IInstallerTasks installer, Form1 form)
        {
            _installer = installer;
            _form = form;
        }
    
        public void InstallComponent()
        {
            _installer.ExecuteTask(_form);

        }
    
    
    }


}
