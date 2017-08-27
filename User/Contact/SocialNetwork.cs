//-----------------------------------------------------------------------
// <copyright file="SocialNetwork.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.Contact
{
    /// <summary>
    /// Class to represent the online platforms that user uses
    /// </summary>
    [Table("SocialNetwork")]
    public class SocialNetwork : ModelEntity<SocialNetwork>, IBaseEntity
    {
        /// <summary>
        /// Id (unique) to use as key in the DataBase
        /// </summary>
        [Exportable(Name = "UserId", GlobalOrder = 0)]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>
        /// Optional User Id asigned by the platform to the user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The username of the user in the platform
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The URL of the website
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Name of the Social network to witch the user is afilliated       
        /// </summary>
        public string SocialNetworkName { get; set; }
    }
}
