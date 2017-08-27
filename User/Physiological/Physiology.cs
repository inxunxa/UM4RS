//-----------------------------------------------------------------------
// <copyright file="Physiology.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Physiological {
    [Table("Physiology")]
    public class Physiology : ModelEntity<Physiology>, IBaseEntity
    {
        public int Id { get; set; }
        public int HeadBodyPartId{get; set;}
		public Head Head{get; set;}
		public List<Disability> Disabilities{get; set;}
		public List<Arm> Arms{get; set;}
		public List<Foot> Feet{get; set;}
		public List<PhysiologicalState> PhysiologicalStates{get; set;}

	    public Physiology()
	    {
	        Disabilities = new List<Disability>();
            PhysiologicalStates = new List<PhysiologicalState>();
	    }
	}

}
