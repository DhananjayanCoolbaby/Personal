using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
    [Serializable]
    public class Reporting
    { /// <summary>
        /// Gets or sets the Username property
        /// </summary>        
        public int ReportingID { get; set; }

        /// <summary>
        /// Gets or sets the Name property
        /// </summary>        
        public string ReportingName { get; set; }

    }
}
