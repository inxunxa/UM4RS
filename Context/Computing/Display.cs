//-----------------------------------------------------------------------
// <copyright file="Display.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Computing {
    [Table("Display")]
    public class Display : Hardware 
	{
		public int Width{get; set;}
		public int Height{get; set;}
		public int Ppi{get; set;}
		public int DeviceHardwareId{get; set;}
		public System.Collections.Generic.List<DisplayResolution> Resolution{get; set;}



	}

}
