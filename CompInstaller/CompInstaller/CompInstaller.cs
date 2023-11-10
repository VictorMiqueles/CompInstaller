namespace CompInstaller
{
    public partial class CompInstaller : Form
    {
        private string _currentDirectory = "";

        public CompInstaller()
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






    }
}