//-----------------------------------------------------------------------
// <copyright file="Preference.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.InterestPreferences
{
    [Table("Preference")]
    public class Preference : ModelEntity<Preference>, IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public Item.Item<IBaseEntity> Item { get; set; }
        
        [NonExportable] // WARNING: Trying to export this info will increase exponentially the exportation time
        public Context.Context Context { get; set; }
    }
}
