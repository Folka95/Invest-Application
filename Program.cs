using InvestApp.Forms;

namespace InvestApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoaderForm());
        }    
    }
}