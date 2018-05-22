using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core
{
    public static class Enums
    {
        public enum NotificationTypeEnum
        {
            //Procedure Registration
            ProcRegistration = 0,
            Registration = 1,
            PreProcedure = 2,
            PostProcedure = 3,
            PostRegistration = 4
        }
        
        public enum ProcedureEnum
        {
            Biopsy = 1,
            Robotic = 2,
            UroLift = 10,
            UronavProstateBiopsy = 11
        }
        public enum ProcedurePreOpNotificationIdEnum
        {
            Biopsy = 1,
            [Description("Pre-Op")]
            Robotic = 25,
            UroLift = 161
        }

        public enum SurgeryNotificationIdEnum
        {
            Robotic=2,
            Biopsy=36,
            UronavProstateBiopsy=380
        }
        public enum ProcedurePostOp3MonthNotificationIdEnum
        {
            [Description("Post-Op(3 Months)")]
            Robotic = 13
        }
        public enum SurveyQuestionTypeEnum
        {
            [Description("Yes/No")]
            Yes_No = 1,
            [Description("Multiple Option")]
            Multiple_Option = 2,
            [Description("Text")]
            Text = 3,
            [Description("Multiple Checkbox")]
            Multiple_Checkbox = 4
        }
        public enum CRUDOperationType
        {
            Create = 1,
            Update = 2,
            Delete = 3,
        }
        public enum CrudOperationType
        {
            Create = 1,
            Update = 2,
            Delete = 3,
        }
        public enum EmailTypeEnum
        {
            Reigistration = 1,
            RegistrationResetPassword = 2,
            ResetPassword = 3
        }
        public enum PracticeLocationTypeEnum
        {
            Hospital = 1,
            Clinic = 2,
            [Description("Surgery Center")]
            SurgeryCenter = 3
           // Office = 4
        }

        public enum NotificationAreaEnum {
            Common = 1,
            HospitalOnly = 2,
            ClinicOnly = 3,
        }

        public enum GraphTypeEnum
        {
            BarChart=0,
            LineChart,
            PieChart,
        }
        public enum GraphPropertyForEnum
        {
            [Description("Patient")]
            Patient =0,
            [Description("My Patients")]
            Physician,
            [Description("Patients In Hospital")]
            Group,
            [Description("Patients In System")]
            All,
            [Description("Total Biopsies")]
            TotalBiopsies,
            [Description("UroNav")]
            UroNav,
            [Description("Standard")]
            Standard,
            [Description("Infection")]
            Infection,
            [Description("Bleeding")]
            Bleeding,
            [Description("Retention")]
            Retention,
            [Description("Buring")]
            Burning,
            [Description("Other")]
            Other,
            [Description("Primary Care")]
            PrimaryCare,
            [Description("Emergency Room")]
            EmergencyRoom,
            [Description("Urgency Room")]
            UrgencyRoom,
            [Description("Clinic")]
            Clinic,
            [Description("Health Care")]
            HealthCare,
            [Description("Hospitalized")]
            Hospitalized,
            [Description("Biopsy")]
            Biopsy,
            [Description("Antibiotic")]
            Antibiotic,
            [Description("Travel")]
            Travel,
            [Description("None")]
            None,
            [Description("Misc")]
            Misc,

            [Description("0 (No Pain)")]
            Pain0,
            [Description("1")]
            Pain1,
            [Description("2")]
            Pain2,
            [Description("3")]
            Pain3,
            [Description("4")]
            Pain4,
            [Description("5 (Severe Pain)")]
            Pain5,

            [Description("BM")]
            BM,
            [Description("Flatus")]
            Flatus,
            [Description("Nausea")]
            Nausea,
            [Description("Vomiting")]
            Vomiting,

            [Description("All the time")]
            Regret0,
            [Description("Most")]
            Regret01,
            [Description("Good bit")]
            Regret02,
            [Description("Some")]
            Regret03,
            [Description("Little")]
            Regret04,
            [Description("None")]
            Regret05,

            [Description("Delighted")]
            UQOL0,
            [Description("Happy")]
            UQOL01,
            [Description("Satisfied")]
            UQOL02,
            [Description("Mixed")]
            UQOL03,
            [Description("Terrible")]
            UQOL04,
            [Description("Unhappy")]
            UQOL05,

            [Description("0 Pads")]
            NoPads,
            [Description("1 Pad")]
            OnePad,
            [Description("2 Pads")]
            TwoPads,
            [Description("> 3 Pads")]
            MoreThan3Pads,

        }

        public enum GraphDatasetColorForEnum
        {
            [Description("#00A1FF")]
            Patient,
            [Description("#61D739")]
            Physician,
            [Description("#95190C")]
            Group,
            [Description("#F8BB2B")]
            All,
            [Description("#E94033")]
            None,
            [Description("#F7DC6F")]
            Misc

        }

        public enum UroNavRegistryBiopsyTypeForEnum
        {
            [Description("Standard")]
            Standard = 1,
            [Description("UroNav")]
            UroNav = 2,
            [Description("Aggregate")]
            Aggregate = 3
        }

        public enum GraphDataSetIdEnum
        {
            Patient=1,
            Physician=2,
            Group=3,
            All=4
        }
        public enum AgeRange
        {
            Maximum=120,
            Minimum=0
        }
        public enum SurveyQuestionSetIdForEnum
        {
            IPSS=8,
            BSS=8,
            IIEF=12,
            PAD = 7,
            UQOL = 9,
            SignAndSymptoms=19,
            AcutePain = 21,
            Travel = 1,
            Regret=16,
            SexuallyActive = 28,
            Readmission = 22,
            OutsideCare = 23,
            BowelRecovery=20,
            AntibioticSurveyQuestion=2,
            HealthCareWorkerSurveyQuestion=4
        }
        public enum SurveyQuestionIdForEnum
        {
            Regret = 64,
            SexuallyActive = 102,
            SexuallyActivePostOp=45,
            UQOL = 43,
            Pain = 84,
            Fever_101 = 72,
            PainPills=85,
            Pads=94,
            Hospitalized=21,
            AdditionalCare=20,
            OutsideCare = 89,
            Readmission = 87,
            Travel = 1,
            Antibiotic = 2,
            HealthCare = 3,
            Biopsy = 4,
            None=0,
            ErectionalStatusPreOp=105,
            ErectionalStatusPreOpExcluding = 304,
            ErectionalStatusPostOp = 47,
            ErectionalStatusPostOpExcluding = 138,
        }
        public enum ErectionalStatusPreOpQuestionDetailIdForEnum
        {
            Medication = 300,
            Pump = 301,
            Injection = 302,
            Implant = 303
        }                                                                    
        public enum ErectionalStatusPostOpQuestionDetailIdForEnum
        {
            Medication = 134,
            Pump = 135,
            Injection = 136,
            Implant = 137
        }
        public enum BiopsyAdditionalCareQuestionDetailIdEnum
        {
            PrimaryCare = 44,
            UrgentCare = 45,
            EmergencyRoom = 46,
            Hospitalized = 47
        }
        public enum BiopsyInfectionRiskFactorIdForEnum
        {
            Travel = 1,
            Antibiotic = 2,
            HealthCare = 3,
            Biopsy = 4,
            [Description("No Risk Factor")]
            None = 100
        }

        public enum BiopsyComplicationQuestionIdForEnum
        {
            None=100,
            Bleeding1=9,
            Bleeding2=18,
            Retention1=7,
            Retention2=17,
            Burning=8,
            Infection=16
        }
        
        public enum SurveyQuestionDetailIdForEnum
        {
            SexuallyActive=293
        }

        public enum TwoWeekNotificationIdEnum
        {
            Day2=374,
            Day4=375,
            Day6=376
        }
        public enum OneWeekNotificationIdEnum
        {
            Day2 = 2,
            Day4 = 4,
            Day6 = 6
        }
        public enum ProcedureIdForEnum
        {
            Biopsy = 1,
            Robotic = 2

        }

        public enum PadScoreQuestionIdEnum
        {
            EarlyPadAndVoidingScore  = 33,
            PadAndVoidingScoreWithResource  = 48,
            PadAndVoidingScoreWithoutResource  = 66,
            PreOpVoidingScore = 101
        }

        public enum RequiredTreatmentReasonEnum
        {
            [Description("Bleeding")]
            Bleeding = 0,
            [Description("Other")]
            Other,
            [Description("Infection")]
            Infection,
            [Description("Difficulty Urinating")]
            Difficulty_Urinating
        }
        public enum PreviousMedicareTypeEnum
        {
            [Description("Primary Care")]
            Primary_Care = 0,
            [Description("Urgent Care")]
            Urgent_Care,
            [Description("Emergency Room")]
            Emergency_Room,
            [Description("Hospitalized")]
            Hospitalized
        }
        public enum BiopsyInfectionEnum
        {
            [Description("Blood")]
            Blood = 0,
            [Description("Other")]
            Other,
            [Description("Infection")]
            Infection,
            [Description("Retention")]
            Retention
        }
        public enum PatientProcedureStatusEnum
        {
            Active = 1,
            Completed = 2,
            Canceled = 3
        }
        public enum NotificationStatusEnum
        {
            Active = 1,
            Completed = 2,
            Canceled = 3
        }
        public enum EmailNotificationStatusEnum
        {
            Pending = 1,
            Sent = 2,
            Canceled = 3,
            Failed = 4,
            Waiting = 5
        }

        public enum SmsNotificationStatusEnum
        {
            Pending = 1,
            Sent = 2,
            Canceled = 3,
            Failed = 4,
            Waiting = 5
        }
        public enum CountryEnum
        {
            [Display(Name = "United States")]
            [Description("US")]
            USA = 1
        }
        public enum AppRoleEnum
        {
            [Display(Name = "System Admin")]
            [Description("4e19531e-feda-4718-a881-71f44ad03fc8")]
            SystemAdmin = 1,
            [Display(Name = "Practice Admin")]
            [Description("0370b298-9a43-4b4a-a1a9-e910a80e88bd")]
            PracticeAdmin = 2,
            [Description("d5574059-eb35-473c-b46e-05b51b794faf")]
            Professional = 3,
            [Description("c73bac84-6e25-44c3-ba25-cc05f9b5c3af")]
            Patient = 4,
            [Description("eed22661-c44a-4c57-8001-06b48a51e6f5")]
            Scheduler = 5,
            [Display(Name = "Operating Room Personnel")]
            [Description("ce3fc961-27c6-4adf-9c0f-f978be006c3b")]
            OperatingRoomPersonnel = 6
        }

        public enum YesNoQuestionEnum
        {
            [Description("False")]
            False,
            [Description("True")]
            True
        }
        public enum EmailTemplateEnum
        {
            [Display(Name = "Surgical Concierge")]
            [Description("45F19ACD-3B21-47A7-B234-37DB46D35AD9")]
            SurgicalConcierge = 1
            
        }
        public enum SmsTemplateEnum
        {
            [Display(Name = "Surgical Concierge")]
            [Description("2A0F09B5-7495-4514-8F72-2BEDE55003C8")]
            SurgicalConcierge = 1
        }

        public enum EmailTemplateTypeEnum
        {
            [Display(Name = "Surgical Concierge")]
            [Description("SCC-EMAIL")]
            SurgicalConciergeComment = 1,
            [Display(Name = "Procedure Notification Reminder")]
            [Description("PNR-EMAIL")]
            ProcedureNotificationReminder = 2
        }
        public enum SmsTemplateTypeEnum
        {
            [Display(Name = "Surgical Concierge")]
            [Description("SCC-SMS")]
            SurgicalConciergeComment = 1,
            [Display(Name = "Procedure Notification Reminder")]
            [Description("PNR-SMS")]
            ProcedureNotificationReminder = 2
        }

        public enum RoboticProstatectomyOneWeekNotificationIdEnum
        {
            TwoDaysNotificationId=2,
            FourDaysNotificationId=4,
            SixDaysNotificationId=6,
            ExcludeSurveyQuestionId=71
        }

        public enum RoboticProstatectomyOneWeekSignAndSymptomsQuestionIdEnum
        {
            Foley = 92,
            Urgency = 95,
            Dysuria = 96,
            Hematuria = 97,
            PerinealPain = 98
        }

        public enum RoboticProstatectomyTwoWeekNotificationIdEnum
        {
            TwoDaysNotificationId = 374,
            FourDaysNotificationId = 375,
            SixDaysNotificationId = 376,
            ExcludeSurveyQuestionId = 71
        }

        public enum AdditonalReportTypeEnum
        {
            Chart = 1,
            Table = 2 
        }

        //public enum EmailTemplateEnum
        //{
        //    [Display(Name = "Surgical Concierge")]
        //    [Description("5e389fd4-a369-490c-95f6-c755d611c51b")]
        //    SurgicalConcierge = 1
        //}
        //public enum SmsTemplateEnum
        //{
        //    [Display(Name = "Surgical Concierge")]
        //    [Description("1cd44f4a-afb6-4048-af11-c779d55bfbc4")]
        //    SurgicalConcierge = 1
        //}
        public enum PatientClaimType
        {
            [Description("ChangePasswordFirstTimeToken")]
            ChangePasswordFirstTimeToken = 1,

            [Description("ResetPasswordToken")]
            ResetPasswordToken = 2
        }
        public enum ProfessionalBioSectionEnum
        {
            [Display(Name = "General Information")]
            [Description("854892d8-0dc5-4f9d-add6-471b16bb7bab")]
            ProfessionalBioGenarelInfo = 1,

            [Display(Name = "Education Information")]
            [Description("afefbad8-9eff-452a-a9eb-724269cec9d5")]
            ProfessionalBioEducation = 2,

            [Display(Name = "Association Information")]
            [Description("31745f14-6a95-4b90-b8db-bad260169761")]
            ProfessionalBioAssociation = 3,

            [Display(Name = "Interest Information")]
            [Description("3120facf-ba67-4cb6-a315-a34b42620d58")]
            ProfessionalBioInterest = 4,

            [Display(Name = "Licensure Information")]
            [Description("d1ddd027-bb45-4358-b4f5-4083429bd0f6")]
            ProfessionalBioLicensure = 5
        }
    }
}
