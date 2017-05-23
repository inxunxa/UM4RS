//-----------------------------------------------------------------------
// <copyright file="View.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.Item;

namespace UM4RS.Activity
{
    [Table("View")]
    public class View : RatedActivity<View>
    {
        [Exportable(Order = 2)]
        public virtual Video Video { get; set; }

        public virtual VideoService VideoService { get; set; }
    }
}
