//-----------------------------------------------------------------------
// <copyright file="Contact.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.Context.Location;

namespace UM4RS.User.Contact {
    [Table("Contact")]
    public class Contact : ModelEntity<Contact>, IBaseEntity
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [NonExportable]
        public int Id { get; private set; }
        /// <summary>
        /// First name of the User
        /// </summary>
        public string FirstName{get; set;}
        /// <summary>
        /// Middle name of the User
        /// </summary>
		public string MiddleName{get; set;}
        /// <summary>
        /// Last name of the user
        /// </summary>
		public string LastName{get; set;}
        /// <summary>
        /// Email address of the User
        /// </summary>
		public string Email{get; set;}
        /// <summary>
        /// Phone Number of the User
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Address instance to represent the address of the user
        /// </summary>
		public Address Address{get; set;}		
	}

}

