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
using System.Windows.Shapes;

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

            AppDomain.CurrentDomain.SetData("DataDirectory", Application.UserAppDataPath);

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
                    CheckDatabase();
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

        static void CheckDatabase() {

            string dbPath = System.IO.Path.Combine(Application.UserAppDataPath, "DB.mdf");
            string dbLogPath = System.IO.Path.Combine(Application.UserAppDataPath, "DB_log.mdf");

            bool dbExists = File.Exists(dbPath);
            bool dbLogExists = File.Exists(dbLogPath);

            if (!dbExists && !dbLogExists) {

                string sourceDbFolder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "DB");

                string sourceDbFile = System.IO.Path.Combine(sourceDbFolder, "DB.mdf");

                string sourceDbLogFile = System.IO.Path.Combine(sourceDbFolder, "DB_log.mdf");

                try
                {
                    File.Copy(sourceDbFile, dbPath, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }

                try
                {
                    File.Copy(sourceDbLogFile, dbLogPath, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
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
