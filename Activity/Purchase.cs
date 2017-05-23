//-----------------------------------------------------------------------
// <copyright file="Purchase.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UM4RS.Context.Location;

namespace UM4RS.Activity {
    /// <summary>
    /// Represent the Purchase of Item(s)
    /// </summary>
    [Table("Purchase")]
    public class Purchase : RatedActivity<Purchase>
    {
        /// <summary>
        /// The Items(s) that were purchased
        /// </summary>
		public List<Item.Item<IBaseEntity>> Item{get; set;} 

        /// <summary>
        /// The Place(s) where the Items were purchased
        /// </summary>
        public List<Place> Place { get; set; }

        /// <summary>
        /// Empty contructors, initializes the Item and Place collections
        /// </summary>
	    public Purchase()
	    {
	        Item = new List<Item.Item<IBaseEntity>>();
            Place = new List<Place>();
	    }
    }
}
