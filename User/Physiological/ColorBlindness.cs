//-----------------------------------------------------------------------
// <copyright file="ColorBlindness.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Physiological {

    [Table("ColorBlindness")]
    public class ColorBlindness : VisualImpairment 
	{
		public float RodMonochromacy{get; set;}
		public float ConeMonochromacy{get; set;}
		public float Protanopia{get; set;}
		public float Deuteranopia{get; set;}
		public float Tritanopia{get; set;}

	}

}
