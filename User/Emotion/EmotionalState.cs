//-----------------------------------------------------------------------
// <copyright file="EmotionalState.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.Emotion
{
    [ExportableClass]
    [Table("EmotionalSatate")]
    public class EmotionalState : ModelEntity<EmotionalState>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; set; }

        [Exportable(Name = "Emotion", Order = 1)]
        public string Name { get; set; }

        [Exportable(Name = "Level", Order = 2)]
        public float Level { get; set; }

        [NonExportable]
        public DateTime? ActivationTime { get; set; }  

        [NonExportable]
        public float Decay { get; set; }

        [NonExportable] // WARNING: Trying to export this info will increase exponentially the exportation time
        public virtual Context.Context Context { get; set; }

    }
}
