//-----------------------------------------------------------------------
// <copyright file="Dish.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Item {
    [Table("Dish")]
    public class Dish : Item<Dish>
	{
		public string FoodType{get; set;}
		public int Calories{get; set;}
		public double Price{get; set;}
		public int EatItemActionId{get; set;}
		public int RestaurantItemId{get; set;}
		public System.Collections.Generic.List<Photo> Picture{get; set;}

	    public Dish()
	    {
	        Picture = new List<Photo>();
	    }

	}

}
