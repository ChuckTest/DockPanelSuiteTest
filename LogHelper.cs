using System;
using System.IO;
using log4net;
using log4net.Config;

namespace WindowsFormsApplication1
{
	public class LogHelper
	{
		public static void WriteLog(Type t, Exception ex)
		{
			ILog log = LogManager.GetLogger(t);
			//log.IsErrorEnabled = true;
			log.Error("Error", ex);
		}

		private static string configFile;

		public static void Init(string fileName)
		{
			LogFactoryBase(fileName);
			LoadLogConfig();
		}

		private static void LoadLogConfig()
		{
			if(configFile == null)
			{
				return;
			}
			XmlConfigurator.Configure(new FileInfo(configFile));
		}

		private static void LogFactoryBase(string tempConfigFile)
		{
			if(Path.IsPathRooted(tempConfigFile))
			{
				configFile = tempConfigFile;
				return;
			}
			var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tempConfigFile);

			if(File.Exists(filePath))
			{
				configFile = filePath;
				return;
			}

			filePath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config"), tempConfigFile);//这里的config是debug下的子文件夹

			if(File.Exists(filePath))
			{
				configFile = filePath;
			}
		}
	}
}
