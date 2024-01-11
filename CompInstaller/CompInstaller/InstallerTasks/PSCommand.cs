using CompInstaller.Interfaces;
using System.Management.Automation;

namespace CompInstaller.InstallerTasks
{
    public class PSCommand : IInstallerTasks
    {
        dynamic compsJson = "";
        string componentName = "";
        string scriptPath = "";


        public PSCommand(dynamic comps, string compName)
        {
            compsJson = comps;
            componentName = compName;

            //var test = compsJson.Components;
        }

        public void ExecuteTask(Form1 form)
        {
            // Code to start PowerShell API

            PSScriptPath(componentName);


            RunPowerShellScript(scriptPath);


            //MessageBox.Show("Using PowerShell API!");

            //throw new NotImplementedException();
        }

        public void PSScriptPath(string componentName)
        {
            foreach (var component in compsJson.Components)
            {
                if (string.Equals(componentName, component.ComponentName.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    scriptPath = component.ScriptPath;
                }
            }
        }

        public void RunPowerShellScript(string scriptPath)
        {
            // Error with runspace not being 'opened'



            string scriptContent = File.ReadAllText(scriptPath);
            using (var powerShell = PowerShell.Create())
            {
                powerShell.AddScript(scriptContent);
                powerShell.Invoke();
            }
        }
    }


}
