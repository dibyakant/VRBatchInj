using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_DocInjection.Models
{
    public class tVRDocDetails
    {
        public string DocGUID { get; set; }
        public int RSId { get; set; }
        public int IsActiveDoc { get; set; }
        public int CampusId { get; set; }
        public int GradeId { get; set; }
        public int PersonDataId { get; set; }
        public int AccountTemplateId { get; set; }
        public DateTime? DocDate { get; set; }
        public string BoxNumber { get; set; }
        public string ScannedBy { get; set; }
        public string OriginalDocumentName { get; set; }
        public int VRBatchDocInjId { get; set; }
        public string AccountIdMetaData { get; set; }
        public string DocIdMetaData { get; set; }
        public int ScanningTypeIdMetaData { get; set; }
        public int FileTypeId { get; set; }
        public int PDFPageCount { get; set; }
        public string DocumentSize { get; set; }
        public int DocIndexFlag { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime LastUpdatedDt { get; set; }
        public int IsDeleted { get; set; }

    }
}
