//-----------------------------------------------------------------------
// <copyright file="Eat.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UM4RS.Item;

namespace UM4RS.Activity
{
    /// <summary>
    /// Class to represent an Eat activity
    /// </summary>
    [Table("Eat")]
    public class Eat : RatedActivity<Eat>
    {
        /// <summary>
        /// Collection of Dishes the user Eat
        /// </summary>
        public ICollection<Dish> Dish { get; set; }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Eat()
        {
            Dish = new List<Dish>();
        }

    }
}
