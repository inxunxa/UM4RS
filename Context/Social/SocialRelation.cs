//-----------------------------------------------------------------------
// <copyright file="SocialRelation.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Context.Social {
    [Table("SocialRelation")]
    public class SocialRelation : ModelEntity<SocialRelation>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }

        public SocialRelationType RelationType{get; set;}

        [NonExportable]
        /// <summary>
        /// List of related User Ids
        /// </summary>
		private System.Collections.Generic.List<int> UserIds{get; set; } // TODO: USER MANAGE


	    public SocialRelation()
	    {
            UserIds = new List<int>();
	    }
	}

}
