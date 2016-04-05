using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
				LogHelper.WriteLog(typeof(Program), ex);
				MessageBox.Show(ex.Message);
            }
        }
		

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			LogHelper.WriteLog(typeof(Program), e.Exception);
			MessageBox.Show(e.Exception.Message);
        }
    }
}
