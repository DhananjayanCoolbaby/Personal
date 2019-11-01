using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{

    [Serializable]
    public class EmpProfiles
    {
        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public int EmpID { get; set; }

        /// <summary>
        /// Gets or sets the VendorId property
        /// </summary>        
        public int Password { get; set; }

        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        public IList<EmpProfiles> ItemArray { get; set; }
    }
}
