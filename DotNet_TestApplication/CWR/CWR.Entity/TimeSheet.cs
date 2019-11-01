using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
     [Serializable]
    public class TimeSheet
    {
        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public int Date { get; set; }

        /// <summary>
        /// Gets or sets the VendorId property
        /// </summary>        
        public string Days { get; set; }

        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public string ProjectHoursWorked { get; set; }


        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public string DateWorked { get; set; }

        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public int TimesheetPeriodid { get; set; }

        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the ProductId property
        /// </summary>        
        public string RequestId { get; set; }
      

        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        public IList<TimeSheet> ItemArray { get; set; }

        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        public string AssociateId { get; set; }
        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        public string Status { get; set; }
    }
}
