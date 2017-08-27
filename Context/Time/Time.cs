//-----------------------------------------------------------------------
// <copyright file="Time.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Context.Time {
    [Table("Time")]
    public class Time : ModelEntity<Time>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }
        public DateTime? TimeStamp{get; set;}
		public DateTime? TimeInterval{get; set;}
		public DayOfWeek DayOfWeek{get; set;}
		public DayType DayType{get; set;}
        public TimeOfDay TimeOfDay { get; set; }        
        public Season Season { get; set; }
	}

}
