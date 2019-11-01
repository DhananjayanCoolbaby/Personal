using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
    [Serializable]
    public class State
    {
        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the VendorId property
        /// </summary>        
        public string Name { get; set; }
    }
}
