//-----------------------------------------------------------------------
// <copyright file="cognitivestyle.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Mental
{
    [Table("CognitiveStyle")]
    public class CognitiveStyle : ModelEntity<CognitiveStyle>, IBaseEntity
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public float Intensity { get; set; }

        /// <summary>
        /// True for positive mood, false for negative valence
        /// </summary>
        public bool Valence { get; set; }
    }

}
