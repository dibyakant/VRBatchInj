using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VR_DocInjection.Models
{
    public class ERM_BatchDetails
    {
        public int pk_batch_id { get; set; }
        public string batch_name { get; set; }
        public string verification_required_path { get; set; }
    }
}
