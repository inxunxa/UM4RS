//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.Item {
    //[Table("Item")]
    public abstract class Item<TObject> : ModelEntity<TObject>, IBaseEntity where TObject : class, IBaseEntity
    { 
        [Exportable(Name="ItemId", GlobalOrder = 1)]
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Exportable]
        public string Name{get; set;}

        [NonExportable] // TODO: Verificar si es necesaria
        public int PurchaseItemActionId{get; set;}

        [NonExportable]
        public string Image { get; set; }

    }

}
