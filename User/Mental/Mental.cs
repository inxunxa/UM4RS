//-----------------------------------------------------------------------
// <copyright file="Mental.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.Mental
{
    [Table("Mental")]
    public class Mental : ModelEntity<Mental>, IBaseEntity
    {
        [NonExportable]
        public int Id { get; private set; }
        public virtual ICollection<MentalState> MentalState { get; set; } = new List<MentalState>();
        public virtual ICollection<CognitiveStyle> CognitiveStyle { get; set; } = new List<CognitiveStyle>();
        public virtual MentalStress MentalStress { get; set; }
        public virtual ICollection<Mood> Mood { get; set; } = new List<Mood>();
        
    }

}
