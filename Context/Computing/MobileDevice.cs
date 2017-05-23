//-----------------------------------------------------------------------
// <copyright file="mobiledevice.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Computing {
    [Table("MobileDevice")]
    public abstract class MobileDevice : Device 
	{
		public int BatteryLevel{get; set;}
		public System.Collections.Generic.List<Sensor> Sensor{get; set;}

	}

}
