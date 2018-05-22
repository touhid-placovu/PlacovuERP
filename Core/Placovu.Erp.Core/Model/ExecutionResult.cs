using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.Model
{
    public class ExecutionResult
    {
        public ExecutionResult()
        {
            this.Messages = new List<string>();
        }
        public bool Success { get; set; }
        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool Exists { get; set; }
        public object PrimaryKey { get; set; }
        public object SecondKey { get; set; }
        public object DataItem { get; set; }
        public bool HasError { get; set; }
        public bool NoRecordFound { get; set; }
        public string TagOne { get; set; }
        public string TagTwo { get; set; }
        public string TagThree { get; set; }
        public List<string> Messages { get; set; }
        public string Message { get; set; }
        public int UpdatedRowCount { get; set; }
        public int Count { get; set; }
        public long PracticeProfileId { get; set; }
        public long ProfessionalProfileId { get; set; }
        public long ProcedureId { get; set; }
        public long PatientProfileId { get; set; }
        public Guid PatientProcedureDetailId { get; set; }
        public string Url { get; set; }
        public Exception Exception { get; set; }

        public string ResultMessage => Success ? "Success" : "Failed";
    }
}
