//-----------------------------------------------------------------------
// <copyright file="Software.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Context.Computing {
    [Table("Software")]
    public class Software : ModelEntity<Software>, IBaseEntity
    {
        public int Id { get; set; }
        public string Name{get; set;}
		public string Version{get; set;}
		public string Vendor{get; set;}
		public string Os{get; set;}
		public string Platform{get; set;}        
	}

}
