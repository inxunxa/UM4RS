//-----------------------------------------------------------------------
// <copyright file="Interest.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.InterestPreferences
{
    [Table("Interest")]
    public class Interest : ModelEntity<Interest>, IBaseEntity
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public virtual ICollection<Item.Item<IBaseEntity>> Items { get; set; } = new List<Item.Item<IBaseEntity>>();

        public Interest()
        {
        }
    }

}
