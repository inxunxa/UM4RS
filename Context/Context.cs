//-----------------------------------------------------------------------
// <copyright file="Context.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.Context.Location;
using UM4RS.Context.Physicalcondition;
using UM4RS.Context.Social;

namespace UM4RS.Context {

    [Table("Context")]
    [ExportableClass]
    public class Context : ModelEntity<Context>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }

        [NonExportable]
        public virtual Location.PhysicalLocation PhysicalLocation { get; set; }
        public virtual Time.Time Time { get; set; }
        public virtual Computing.Computing Computing { get; set; }
        public virtual PhysicalCondition PhysicalCondition { get; set; }
        public virtual Resource.Resource Resource { get; set; }
        public virtual ICollection<SocialRelation> SocialRelation { get; set; }
        public virtual Place Place { get; set; }

        public Context()
        {
            SocialRelation = new List<SocialRelation>();
        }
    }

}
