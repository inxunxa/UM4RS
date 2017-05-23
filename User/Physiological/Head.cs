//-----------------------------------------------------------------------
// <copyright file="Head.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Physiological {
    [Table("Head")]
    public class Head : BodyPart 
	{
		public int HeadSize{get; set;}
		public Boolean HasHair{get; set;}
		public int HairLong{get; set;}


	}

}
