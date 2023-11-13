using System;


namespace CompInstaller
{
    public partial class Form1 : Form
    {
        private string _currentDirectory = "";
        dynamic _environmentJson = "";

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
        }


        


        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigReader configReader = new ConfigReader();
            _environmentJson = configReader.ReadConfig(_currentDirectory + "//Environment.json");

            // configReader(_currentPIFolder) *This isn't part of Load!! use this when creating server tabs*

            var testText = _environmentJson.Parameters.UserName.ToString();




        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("On Shown");


        }



        private void Form1_Closed(object sender, System.EventArgs e)
        {

        }



    }
}