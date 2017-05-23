//-----------------------------------------------------------------------
// <copyright file="RatedActivity.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS


using System.ComponentModel.DataAnnotations.Schema;
using UM4RS.Item;

namespace UM4RS.Activity
{
    [Table("RatedActivity")]
    public class RatedActivity<TObject> : Activity<TObject>  where TObject : class, IBaseEntity
    {       
        public Rating Rating { get; set; }
    }
}
