//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.User.Contact;
using UM4RS.User.Demographics;
using UM4RS.User.Emotion;
using UM4RS.User.InterestPreferences;
using UM4RS.User.Personality;
using UM4RS.User.Physiological;

namespace UM4RS.User
{
    /// <summary>
    /// Class to represent the User in the model
    /// </summary>
    [Table("User")]
    public class User : ModelEntity<User>, IBaseEntity
    {

        /// <summary>
        /// Id (unique) to use as key in the DataBase
        /// </summary>
        [Exportable(GlobalOrder = 0, Order = 0, Name = "userID")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        /// <summary>
        /// Represent the Demographic aspects of the User
        /// </summary>
        [Exportable]
        public virtual Demographic Demographic { get; set; }

        /// <summary>
        /// Represent the Contact information of the User
        /// </summary>
        [NonExportable]
        public virtual Contact.Contact Contact { get; set; }

        /// <summary>
        /// To store the registration (user/password) information 
        /// </summary>
        public virtual Contact.Account Account { get; set; }

        /// <summary>
        /// The Roles that the <c>User</c> is playing
        /// </summary>
        [NonExportable]
        public virtual ICollection<Role.Role> Roles { get; set; } = new List<Role.Role>();

        /// <summary>
        /// List of the <see cref="EmotionalState" /> of the User
        /// </summary>
        //[Exportable(Order = 1)]
        [Exportable]
        public virtual ICollection<EmotionalState> Emotions { get; set; } = new List<EmotionalState>();

        /// <summary>
        /// Represent the <c>Personality</c> attributes of the <c>User</c>
        /// </summary>
        [NonExportable]
        public virtual ICollection<PersonalityAttribute> Personality { get; set; } = new List<PersonalityAttribute>();

        /// <summary>
        /// Represent the Physiological aspects of the <c>User</c>
        /// </summary>
        [Exportable]
        public virtual Physiology Physiology { get; set; }

        /// <summary>
        /// Represents the Mental characteristics of the <c>User</c>
        /// </summary>
        [Exportable]
        public virtual Mental.Mental Mental { get; set; }

        /// <summary>
        /// Represent a Relation class for the Interest and Preferences of the User
        /// </summary>
        [Exportable]
        public virtual InterestPreference InterestPreference { get; set; }

        /// <summary>
        /// The list of social networks/online platforms the user belong to
        /// </summary>
        [Exportable]
        public virtual ICollection<SocialNetwork> SocialNetworks { get; set; } = new List<SocialNetwork>();

        /// <summary>
        /// Get or Creates an empty @User in DB (used by importers)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>@User</returns>
        public static User GetOrCreate(int id)
        {
            var usr = Get(id);
            if (usr != null) return usr;
            
            // create an empty User
            usr = new User()
            {
                Id = id
            };
            usr.Save();

            return usr;
        }
    }

}