//-----------------------------------------------------------------------
// <copyright file="Accounts.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS


using System;
using System.Security.Cryptography;
using System.Text;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.Contact
{
    public class Account : ModelEntity<Account>, IBaseEntity
    {        

        /// <summary>
        /// Unique identifier
        /// </summary>
        [NonExportable]
        public int Id { get; private set; }

        /// <summary>
        /// The identifier of the System
        /// </summary>
        public string System { get; set; }

        /// <summary>
        /// User Id 
        /// </summary>
        public string UserName { get; set;  }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Email of the user (OPTIONAL)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Asociated account id (OPTIONAL)
        /// </summary>
        public string AccountId { get; set; }
    }
}
