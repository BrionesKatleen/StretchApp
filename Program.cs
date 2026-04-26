using StretchApp.src.tests;

namespace StretchApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        DatabaseTest.TestConnection();

        Application.Run(new StartForm());
    }
}