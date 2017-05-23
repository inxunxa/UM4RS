//-----------------------------------------------------------------------
// <copyright file="PhysicalLocation.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Location {
    [Table("PhysicalLocation")]
    public class PhysicalLocation : ModelEntity<PhysicalLocation>, IBaseEntity
    {
        public int Id { get; private set; }
        public string Name{get; set;}
		public bool InDoor{get; set;}
        public Address Address { get; set; }
        public Coordinate Coordinate{get; set;}
	}
}
