using CompInstaller.InstallerTasks;
using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;


namespace CompInstaller
{
    public partial class Form1 : Form
    {
        private string _currentDirectory = "";
        dynamic environmentJson = "";
        dynamic compsJson = "";

        public Form1 compInstaller = null;


        public Form1()
        {
            InitializeComponent();

#if DEBUG
            try
            {
                string dir = "C:\\CompInstaller";
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
#endif

            _currentDirectory = Directory.GetCurrentDirectory();

            compInstaller = this;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SetupParametersTab()
        {
            dgvParameters.Name = "Parameters Tab";
            dgvParameters.RowHeadersVisible = false;

            dgvParameters.ColumnCount = 2;

            dgvParameters.Columns[0].Name = "Name";
            dgvParameters.Columns[1].Name = "Value";

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "More";
            buttonColumn.Text = "More";
            buttonColumn.UseColumnTextForButtonValue = true;

            dgvParameters.Columns.Add(buttonColumn);

            dgvParameters.Columns[0].Width = 150;
            dgvParameters.Columns[1].Width = 550;
            dgvParameters.Columns["More"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvParameters.AllowUserToAddRows = false;

            dgvParameters.Columns["Name"].ReadOnly = true;
            dgvParameters.Columns["Value"].ReadOnly = true;

            dgvParameters.Dock = DockStyle.Fill;
        }

        private void PopulateParametersTab()
        {

            foreach (var parameter in environmentJson.Parameters)
            {
                string[] row = { parameter.Name, parameter.Value, "" };
                dgvParameters.Rows.Add(row);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ConfigReader configReader = new ConfigReader();

            if (File.Exists(_currentDirectory + "//Environment.json"))
            {
                environmentJson = configReader.ReadConfig(_currentDirectory + "//Environment.json");
            }
            else
            {
                MessageBox.Show("There is no Environment Json file to load");
                return;
            }

            string[] compFiles = Directory.GetFiles(_currentDirectory, "Comps*.*"); // not lazy
            if (compFiles.Length == 1)
            {
                foreach (var file in compFiles)
                {
                    compsJson = configReader.ReadConfig(file);
                }
            }
            else if (compFiles.Length > 1)
            {
                MessageBox.Show("There is more than one Comps.json file.  Please make sure there is only one in the folder");
                btnLoadComps.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("There is no Comps Json file to load");
                btnLoadComps.Enabled = false;
                return;
            }
          
            SetupParametersTab();
            PopulateParametersTab();
        }

        private void btnLoadComps_Click(object sender, EventArgs e)
        {
            // Instantiate CompsPage here
            ComponentInstallPage componentInstallPage = new ComponentInstallPage(compInstaller);
            componentInstallPage.ComponentInstallPageTab(tabControl, compsJson);
            tabControl.SelectTab(2); // by index 
        }



        private void Form1_Closed(object sender, System.EventArgs e)
        {

        }

        
    }
}