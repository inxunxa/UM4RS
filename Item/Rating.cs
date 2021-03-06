//-----------------------------------------------------------------------
// <copyright file="Rating.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Item {
    [Table("Rating")]
    public class Rating : ModelEntity<Rating>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }

        [Exportable(Name = "rating", GlobalOrder = 2)]
        public int Rate{get; set;}

        [NonExportable]
		public RatingType Type{get; set;}
	}

}
