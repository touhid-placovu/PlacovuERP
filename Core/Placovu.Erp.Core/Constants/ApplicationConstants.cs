using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Placovu.Erp.Core.Constants
{
    public static partial class AppConstants
    {
        public static List<long> RoboticFurtherCareNotificationIds 
            = new List<long>() {2,4,6,374,375,376};
        public static class Application
        {
            public const string Name = "Ontrack Health";
            public const string ShortName = "Ontrack Health";
        }
        public static class AreaNames
        {
            public const string Administration = "Administration";
            public const string Patient = "Patient";
            public const string Professional = "Professional";
        }

        public static class EmailTemplateType
        {
            public const string NotificatiionEmail = "EMAIL";
            public const string RegistrationEmail = "R-EMAIL";
            public const string RegistrationResetPasswordEmail = "RRP-EMAIL";
            public const string ResetPasswordEmail = "RP-EMAIL";
            public const string AccountReactivationEmail = "ARE-EMAIL";
        }

        public static class SmsTemplateType
        {
            public const string NotificationSMS = "PN-SMS";
            public const string RegistrationSMS = "R-SMS";
            public const string RegistrationResetPasswordSMS = "RRP-SMS";
            public const string ResetPasswordSMS = "RP-SMS";
            public const string AccountReactivationSMS = "ARE-SMS";
        }
        public static class DefaultActionText
        {
            public const string Save = "Save";
            public const string Edit = "Edit";
            public const string Update = "Update";
            public const string ReturnToHome = "Return to Home";
            public const string Add = "Add New";
            public const string Create = "Create";
            public const string Close = "Close";
            public const string Cancel = "Cancel";
        }
        public static class DefaultRoutingName
        {
            public const string AdministrationArea = AreaNames.Administration + "_" + "Default";
            public const string PatientArea = AreaNames.Patient + "_" + "Default";
            public const string ProfessionalArea = AreaNames.Professional + "_" + "Default";
            public const string Default = "Default";
        }
        public static class DefaultRoutingNamespace
        {
            public const string AdministrationArea = "Placovu.Erp.Web.Areas.Administration.Controllers";
            public const string PatientArea = "Placovu.Erp.Web.Areas.Patient.Controllers";
            public const string ProfessionalArea = "Placovu.Erp.Web.Areas.Professional.Controllers";
            public const string Default = "Placovu.Erp.Web.Controllers";
        }
        public static class GridPaging
        {
            public const int PatientProfile = 15;
            public const int PracticeProfile = 15;
            public const int ProfessionalProfile = 15;
            public const int SchedulerProfile = 15;
        }

        public enum AppRoleEnum
        {
            [Description("4e19531e-feda-4718-a881-71f44ad03fc8")]
            SystemAdmin,
            [Description("d5574059-eb35-473c-b46e-05b51b794faf")]
            Professional,
            [Description("c73bac84-6e25-44c3-ba25-cc05f9b5c3af")]
            Patient,
            [Description("0370b298-9a43-4b4a-a1a9-e910a80e88bd")]
            PracticeAdmin,
            [Description("eed22661-c44a-4c57-8001-06b48a51e6f5")]
            Scheduler
        }

        public static class SystemUserRoleEnum
        {
            public const string SystemAdmin = "SystemAdmin";
            public const string PracticeAdmin = "PracticeAdmin";
            public const string Patient = "Patient";
            public const string Professional = "Professional";
            public const string OperatingRoomPersonnel = "OperatingRoomPersonnel";
            public const string Scheduler = "Scheduler";

        }

        public static class PartialViewName
        {
            public static readonly string PracticeProfileDropdownList = "_PracticeProfileDropdownList";
            public static readonly string ProfessionalProfileDropdownList = "_ProfessionalProfileDropdownList";
            public static readonly string ProcedureDropdownList = "_ProcedureDropdownList";
            public static readonly string PracticeLocationDropdownList = "_PracticeLocationDropdownList";
        }

        public static class BaseDocument
        {
            public static class DocumentType
            {
                public const string ProfilePicture = "PP";
                public const string Logo = "LG";
                public const string Others = "OH";
            }
        }

        public static class QuestionIds
        {
            public const string BSS = "37_39_42";
        }
        public static decimal RoundTwoDigit(this decimal obj)
        {
            return Math.Round(obj, 2);
        }

        public static readonly Guid UroNavPracticeProfileId= new Guid("0158A183-241F-4B90-95C3-762820EBA581");
        public static readonly string StandardErrorMessage = "The application has encountered an unknown error."
                                                           +" It doesn't appear to have affected your data, but our technical staff have been automatically notified and will be looking into this with the utmost urgency."
                                                           +" Also help us improve your experience by sending an error report.";
    }
}
