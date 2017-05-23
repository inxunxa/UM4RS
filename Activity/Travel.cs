//-----------------------------------------------------------------------
// <copyright file="Travel.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.Context.Location;
using UM4RS.Item;

namespace UM4RS.Activity {

    [Table("Travel")]
    public class Travel : RatedActivity<Travel>
    {
        [NonExportable]
		public Place Place{get; set;}

		public Hotel Hotel{get; set;}
        
        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int DurationDays { get; set; }
        
	    public Travel()
	    {
	    }

	}

}
