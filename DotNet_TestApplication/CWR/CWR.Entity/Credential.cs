using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
    [Serializable]
    public class Credential
    {
        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public string Userlevel { get; set; }


        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public int Access { get; set; }

        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        public IList<Credential> ItemArray { get; set; }

    }
}
