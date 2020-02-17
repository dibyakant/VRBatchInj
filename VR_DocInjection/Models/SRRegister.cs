using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_DocInjection.Models
{
    public class SRRegister : ClassMap<SROutPut>
    {
        public SRRegister()
        {
            Map(m => m.DocumentFilename).Name("DocumentFilename");
            Map(m => m.DocID).Name("DocID");
            Map(m => m.Account).Name("Account");
            Map(m => m.RecordSeries).Name("RecordSeries");
            Map(m => m.Scanning).Name("Scanning");
            Map(m => m.DocCategory).Name("DocCategory");
            Map(m => m.DocType).Name("DocType");
            Map(m => m.DocDate).Name("DocDate");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.MiddleName).Name("MiddleName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.Alias).Name("Alias");
            Map(m => m.DateofBirth).Name("DateofBirth");
            Map(m => m.IdentificationNumber).Name("IdentificationNumber");
            Map(m => m.Campus).Name("Campus");
            Map(m => m.GraduationDate).Name("GraduationDate");
            Map(m => m.WithdrawalDate).Name("WithdrawalDate");
            Map(m => m.ApplicableSchoolYear).Name("ApplicableSchoolYear");
            Map(m => m.BoxNumber).Name("BoxNumber");
            Map(m => m.ScannedBy).Name("ScannedBy");
            Map(m => m.Status).Name("Status");
            Map(m => m.DocSuperCategory).Name("DocSuperCategory");

        }
    }
}
