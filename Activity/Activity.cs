//-----------------------------------------------------------------------
// <copyright file="Activity.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;


namespace UM4RS.Activity {
    /// <summary>
    /// Activity Base Class, used to related an User in a Context at specific TimeStamp.
    /// This class is futher derived into specialized Activities (like Eat and View) to include Items information.
    /// </summary>
    [Table("Activity")]
    public class Activity<TObject> : ModelEntity<TObject>, IBaseEntity where TObject : class, IBaseEntity
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [NonExportable]
        public int Id { get; set; }
        
        /// <summary>
        /// Name of the activity
        /// </summary>
        [NonExportable]
        public string Name { get; set; }

        /// <summary>
        /// The User instance that is performing the Activity
        /// </summary>
        [Exportable(Order = 1)]
        public User.User User { get; set; }

        /// <summary>
        /// The Context instance where the Context is performed
        /// </summary>
        public Context.Context Context { get; set; }

        /// <summary>
        /// The DateTime when the Activity is performed
        /// </summary>
        [NonExportable]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}