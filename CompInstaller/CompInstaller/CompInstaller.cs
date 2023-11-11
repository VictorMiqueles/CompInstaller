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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("someString");
        }



        //private void Form1_Closed(object sender, System.EventArgs e)
        //{
        //    //count -= 1;
        //}



    }
}