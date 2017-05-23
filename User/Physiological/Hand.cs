//-----------------------------------------------------------------------
// <copyright file="Hand.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Physiological {
    [Table("Hand")]
    public class Hand : BodyPart 
	{
		public int HandSize{get; set;}
		public int RightSize{get; set;}
		public int ArmBodyPartId{get; set;}
		public BodySide Side{get; set;}



	}

}
