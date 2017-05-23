//-----------------------------------------------------------------------
// <copyright file="Weather.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Context.Physicalcondition {
    [Table("Weather")]
    public class Weather : ModelEntity<Weather>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; private set; }
        public string Condition{get; set;}

        [NonExportable]
		public float MinTemp{get; set;}

        [NonExportable]
		public float MaxTemp{get; set;}

        [NonExportable]
		public float Humidity{get; set;}


	}

}
