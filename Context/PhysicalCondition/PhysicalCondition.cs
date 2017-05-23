//-----------------------------------------------------------------------
// <copyright file="PhysicalCondition.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Context.Physicalcondition {
    [Table("PhysicalCondition")]
    public class PhysicalCondition : ModelEntity<PhysicalCondition>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }
        public float Crowd{get; set;}
		public float Traffic{get; set;}
		public Noise Noise{get; set;}
		public Weather Weather{get; set;}
		public Light Light{get; set;}
	}

}
