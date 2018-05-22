using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Logger
{
    public interface ILoggerHelper
    {
        void ErrorLog();
        void ErrorLog(string exception);
        void ErrorLog(Exception ex);
        void InfoLog(Exception ex);
        void WarnLog(Exception ex);
    }
}
