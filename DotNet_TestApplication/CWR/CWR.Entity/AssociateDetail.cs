//-----------------------------------------------------------------------
// <copyright file="AssociateDetail.cs" company="CTS">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary>
//  AssociateDetails class
// </summary>
//-----------------------------------------------------------------------
namespace CWR.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Associate Details class
    /// </summary>
    [Serializable]
    public partial class  AssociateDetail
    {
        /// <summary>
        /// Gets or sets Associate id
        /// </summary>
        public string AssociateId { get; set; }
        

        /// <summary>
        /// Gets or sets Associate name
        /// </summary>
        public string AssociateName { get; set; }

        /// <summary>
        /// Gets or sets user role
        /// </summary>
        public string UserRole { get; set; }


        /// <summary>
        /// Gets or sets Valid user
        /// </summary>
        public int IsValidUser { get; set; }


        /// <summary>
        /// Gets or sets Valid user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets Valid user
        /// </summary>
        public string password { get; set; }


        /// <summary>
        /// Gets or sets the ItemArray property
        /// </summary>        
        //public IList<AssociateDetail> ItemArray { get; set; }
    }
}
