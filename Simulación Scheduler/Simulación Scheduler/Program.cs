using Simulación_Scheduler.Control;
using Simulación_Scheduler.GUI;

namespace Simulación_Scheduler
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Scheduler());
            
        }
    }
}