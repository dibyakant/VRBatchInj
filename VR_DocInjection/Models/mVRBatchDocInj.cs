using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_DocInjection.Models
{
    public class mVRBatchDocInj
    {
        public string BatchName { get; set; }
        public string RenameBatchFileName { get; set; }
        public int Status { get; set; }
        public DateTime JobStarted { get; set; }
        public DateTime JobCompleted { get; set; }

    }
}
