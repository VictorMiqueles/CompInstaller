using System;
using System.Data.Common;
using System.Windows.Forms;


namespace CompInstaller
{
    public partial class Form1 : Form
    {
        private string _currentDirectory = "";
        dynamic _environmentJson = "";

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
            ConfigReader configReader = new ConfigReader();
            _environmentJson = configReader.ReadConfig(_currentDirectory + "//Environment.json");

            // configReader(_currentPIFolder) *This isn't part of Load!! use this when creating server tabs*
            var testText = _environmentJson.Parameters.UserName.ToString();


            // ParameterTab instantiation here? ParameterTab method with environment.Json overload?


            SetupParametersTab();
            PopulateParametersTab();

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

            dgvParameters.Dock = DockStyle.Fill;
        }

        private void PopulateParametersTab()
        {

            foreach (var parameter in _environmentJson.Parameters)
            {
                string[] row = { parameter.Name, parameter.Value, "" };
                dgvParameters.Rows.Add(row);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }



        private void Form1_Closed(object sender, System.EventArgs e)
        {

        }



    }
}