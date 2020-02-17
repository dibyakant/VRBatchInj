using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_DocInjection.Models
{
    public class SROutPut
    {
        public string DocumentFilename { get; set; }
        public string DocID { get; set; }
        public string Account { get; set; }
        public string RecordSeries { get; set; }
        public string Scanning { get; set; }
        public string DocCategory { get; set; }
        public string DocType { get; set; }
        public DateTime? DocDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string IdentificationNumber { get; set; }
        public string Campus { get; set; }
        public DateTime? GraduationDate { get; set; }
        public DateTime? WithdrawalDate { get; set; }
        public string ApplicableSchoolYear { get; set; }
        public string BoxNumber { get; set; }
        public string ScannedBy { get; set; }
        public string Status { get; set; }
        public string DocSuperCategory { get; set; }

    }
}
