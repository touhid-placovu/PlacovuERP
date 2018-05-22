using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.Dictionary
{
    /// <summary>
    /// UronavRegistry database dictionary
    /// </summary>
    public static class PlacovuErpDbDictionary
    {

        public static readonly string DatabaseName = "PlacovuEnterprise";

        public static class StoredProcedure
        {
            public static class ParameterName
            {
                public static readonly string PracticeProfileId = "@PracticeProfileId";
                public static readonly string ProfessionalProfileId = "@ProfessionalProfileId";
                public static readonly string ProfessionalName = "@ProfessionalName";
                public static readonly string ProfessionalEmail = "@ProfessionalEmail";
                public static readonly string PatientProfileId = "@PatientProfileId";
                public static readonly string ProcedureId = "@ProcedureId";
                public static readonly string MinimumAge = "@MinimumAge";
                public static readonly string MaximumAge = "@MaximumAge";
                public static readonly string SurveyQuestionIds = "@SurveyQuestionIds";
                public static readonly string MinScore = "@MinScore";
                public static readonly string MaxScore = "@MaxScore";

                public static readonly string PatientProcedureDetailId = "@PatientProcedureDetailId";
                public static readonly string PatientProcedureStatusId = "@PatientProcedureStatusId";
            }
            public static class ProcedureNameWithParameter
            {
                /// <summary>
                /// SpNumberOfBiopsyPerYear @PracticeProfileId, @ProfessionalProfileId
                /// </summary>
                public static readonly string SpNumberOfBiopsyPerYear = "SpNumberOfBiopsyPerYear @PracticeProfileId, @ProfessionalProfileId";

                /// <summary>
                /// SpUpdatePatientProcedureDetailStatus @PatientProcedureDetailId (type: guid), @PatientProcedureStatusId (type: int)
                /// </summary>
                public static readonly string SpUpdatePatientProcedureDetailStatus = "SpUpdatePatientProcedureDetailStatus @PatientProcedureDetailId, @PatientProcedureStatusId";

                /// <summary>
                /// SpUpdatePatientProcedureDetailStatus @PatientProcedureDetailId (type: guid), @PatientProcedureStatusId (type: int)
                /// </summary>
                public static readonly string SpDeactivatePatientProcedureDetail = "SpDeactivatePatientProcedureDetail @PatientProcedureDetailId, @PatientProcedureStatusId";
            }
        }
    }
}
