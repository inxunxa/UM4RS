//-----------------------------------------------------------------------
// <copyright file="mentalstate.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.Mental
{
    [Table("MentalState")]
    public class MentalState : ModelEntity<MentalState>, IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime ActivationTime { get; set; }
        public float Decay { get; set; }

    }

}
