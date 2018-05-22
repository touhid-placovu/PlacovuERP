using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Logger
{
    public static class Log4NetMessageHelper
    {
        public static string FormateMessage(string description, string methodName, string userId, string status = "", string message = "")
        {
            string strMessage = string.Empty; ;

            strMessage = $"Description: {description}, MethodName: {methodName}, Message: {message}, Status: {status}, UserId: {userId}, RequestDateTimeUtc: {DateTime.UtcNow}";

            return strMessage;
        }

        public static string FormateMessageForStart(string methodName, string userId, string status = "", string message = "")
        {
            string strMessage = string.Empty; ;

            strMessage = $"Description: Request received, MethodName: {methodName}, Message: {message}, Status: {status}, UserId: {userId}, RequestDateTimeUtc: {DateTime.UtcNow}";

            return strMessage;
        }

        public static string FormateMessageForProfessionalPortalStart(string methodName, string ProfessionalEmail, long PracticeProfileId, string additionalInfo = "", string message = "")
        {
            string strMessage = string.Empty; ;

            strMessage = $"Description: Request received, MethodName: {methodName}, ProfessionalEmail: {ProfessionalEmail}, PracticeProfileId : {PracticeProfileId}, AdditionalInfo: {additionalInfo},Message: {message}, RequestDateTimeUtc: {DateTime.UtcNow}";

            return strMessage;
        }

        public static string FormateMessageForEnd(string methodName, string userId, string status = "", string message = "")
        {
            string strMessage = string.Empty; ;

            strMessage = $"Description: Request end, MethodName: {methodName}, Message: {message}, Status: {status}, UserId: {userId}, RequestDateTimeUtc: {DateTime.UtcNow}";

            return strMessage;
        }

        public static string FormateMessageForException(Exception ex, string methodName, string userId)
        {
            string strMessage = string.Empty; ;

            string exceptionMessage = "";// ex.Message;
            //string innerExceptionMessage = ""; // ex.InnerException != null ? ex.InnerException.Message : "";
            if (ex.InnerException != null)
            {                
                if (ex.InnerException.InnerException != null)
                {
                    exceptionMessage = ex.InnerException.InnerException.Message;
                }
                else {
                    exceptionMessage = ex.InnerException.Message;
                }
            }
            else if (ex.Message != null)
            {
                exceptionMessage = ex.Message;
            }

            string stackTraceMessage = ex.StackTrace != null ? ex.StackTrace.ToString() : "";

            strMessage = $"Description: Error!, MethodName: {methodName}, Exception: {exceptionMessage}, StackTrace: {stackTraceMessage}, UserId: {userId}";

            return strMessage;
        }
    }
}
