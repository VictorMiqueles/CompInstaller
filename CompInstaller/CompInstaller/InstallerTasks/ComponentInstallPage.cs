using CompInstaller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompInstaller.InstallerTasks
{
    public class ComponentInstallPage
    {
        Form1 compInstaller = null;
        private readonly IInstallerTasks _installerTasks;

        public ComponentInstallPage(Form1 form) 
        {
            compInstaller = form;
            //_installerTasks = installerTasks;

        }

        public void ComponentInstallPageTab(TabControl tabControl, dynamic compsJson)
        {
            foreach (var serverComponent in compsJson.ServerComponents)
            {
                TabPage componentTabPage = new TabPage(serverComponent.ServerName.ToString());
                tabControl.TabPages.Add(componentTabPage);

                // Create a DataGridView
                DataGridView dgvComponents = new DataGridView();
                dgvComponents.RowHeadersVisible = false;
                dgvComponents.ColumnCount = 2;
                dgvComponents.Columns[0].Name = "Status";
                dgvComponents.Columns[1].Name = "Component";

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "";
                buttonColumn.Name = "More";
                buttonColumn.Text = "More";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvComponents.Columns.Add(buttonColumn);

                dgvComponents.Columns[0].Width = 150;
                dgvComponents.Columns[1].Width = 550;
                dgvComponents.Columns["More"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvComponents.AllowUserToAddRows = false;

                dgvComponents.Columns["Status"].ReadOnly = true;
                dgvComponents.Columns["Component"].ReadOnly = true;


                dgvComponents.Dock = DockStyle.Fill;
                componentTabPage.Controls.Add(dgvComponents);

                foreach (var installComponent in serverComponent.InstallComponents)
                {
                    // add rows
                    string[] row = { "", installComponent.ComponentName.ToString(), "" };
                    dgvComponents.Rows.Add(row);
                }
            }
        }
    }
}
