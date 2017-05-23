//-----------------------------------------------------------------------
// <copyright file="IBaseEntity.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations;

namespace UM4RS
{
    public interface IBaseEntity
    {
        /// <summary>
        /// The Identifier of the object (unique DB identifier)
        /// </summary>        
        [Key]
        int Id { get; }
    }
}
