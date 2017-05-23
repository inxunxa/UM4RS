//-----------------------------------------------------------------------
// <copyright file="device.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Computing {

    [Table("Device")]
    public abstract class Device : Hardware 
	{
		public string Os{get; set;}
		public int Ram{get; set;}
		public int StorageCapacity{get; set;}
		public float ProcessorSpeed{get; set;}
		public System.Collections.Generic.List<Display> Display{get; set;}
		public System.Collections.Generic.List<HardwarePort> Port{get; set;}


	}

}
