using System;
using System.Reflection;
using System.Web;

namespace Placovu.Erp.Logger
{
    public class LoggerHelper : ILoggerHelper
    {

        private readonly log4net.ILog _logger;// = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public LoggerHelper(log4net.ILog logger) {
            _logger = logger;          
        }
        public void ErrorLog()
        {
            Exception ex = HttpContext.Current.Server.GetLastError();
            ErrorLog(ex);
        }

        public void ErrorLog(string exception)
        {
            _logger.Error(exception);
        }

        public void ErrorLog(Exception ex)
        {
            _logger.Error("Error Log: ", ex);
        }

        public void InfoLog(Exception ex)
        {
            _logger.Info("Info Log: ", ex);
        }

        public void WarnLog(Exception ex)
        {
            _logger.Warn("Warn Log: ", ex);
        }
        
    }
}
