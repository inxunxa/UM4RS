//-----------------------------------------------------------------------
// <copyright file="smartphone.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Computing {
    [Table("SmartPhone")]
    public class SmartPhone : MobileDevice 
	{
		public System.Collections.Generic.List<Network> Network{get; set;}
        
	}

}
