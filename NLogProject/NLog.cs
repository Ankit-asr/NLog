using NLog;
using System;

namespace NLogProject
{
	public class NLog
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		public void LogDebug(String message)
		{
			logger.Debug(message);
		}
		public void LogInfo(String message)
		{
			logger.Debug(message);
		}
		public void LogError(String message)
		{
			logger.Debug(message);
		}
		public void LogWarn(String message)
		{
			logger.Info(message);
		}
	}
}