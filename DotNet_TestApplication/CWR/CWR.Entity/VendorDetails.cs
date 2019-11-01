using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
    [Serializable]
    public class VendorDetails
    { /// <summary>
        /// Gets or sets the Username property
        /// </summary>        
        public string Vendorname { get; set; }

        /// <summary>
        /// Gets or sets the Name property
        /// </summary>        
        public string VendorEmail { get; set; }

        /// <summary>
        /// Gets or sets the Name property
        /// </summary>        
        public string VendorContactNO { get; set; }

        /// <summary>
        /// Gets or sets the Name property
        /// </summary>        
        public int VendorID { get; set; }

    }
}
