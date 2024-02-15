using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using SistemaControloAlerta.Views;

namespace SistemaControloAlerta
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private const string appName = "MUTEX_DEPA";
        private static Mutex _mutex = new Mutex(false, appName);
        [STAThread]
        static void Main()
        {

            // espera por 3 seconds ate ter certeza de que não há outra instância sendo executada
            if (!_mutex.WaitOne(TimeSpan.FromSeconds(3), false))
            {
                try
                {
                    ActivateExistingInstance();
                }
                finally
                {
                    Application.Exit();
                }
            }
            else {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new DepaView());
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            }
        }

        static void ActivateExistingInstance()
        {
            try
            {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "DEPAPIPE", PipeDirection.Out, PipeOptions.Asynchronous))
                {
                    pipeClient.Connect();
                    using (StreamWriter writer = new StreamWriter(pipeClient))
                    {
                        writer.WriteLine("ActivateWindow");
                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
