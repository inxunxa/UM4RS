//-----------------------------------------------------------------------
// <copyright file="Place.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;
using UM4RS.User.Contact;

//https://www.kaggle.com/c/expedia-hotel-recommendations/data
namespace UM4RS.Context.Location {
    [Table("Place")]
    public class Place : ModelEntity<Place>, IBaseEntity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NonExportable]
        public int Id { get; set; }
        public string Name { get; set; }
        public DigitalLocation DigitalLocation { get; set; }
        public PhysicalLocation PhysicalLocation { get; set; }
        public PlaceType PlaceType { get; set; }                
    }
}
