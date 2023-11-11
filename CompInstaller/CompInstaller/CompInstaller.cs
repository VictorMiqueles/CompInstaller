using System;


namespace CompInstaller
{
    public partial class Form1 : Form
    {
        private string _currentDirectory = "";

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


        public void ConfigReader(string folderPath)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("On Load");



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