//-----------------------------------------------------------------------
// <copyright file="VideoService.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;
using UM4RS.Context.Location;

namespace UM4RS.Item {
    [Table("VideService")]
    public class VideoService : ModelEntity<VideoService>, IBaseEntity
    {
        public int Id { get; private set; }
        public string Name{get; set;}
		public DigitalLocation DigitalLocation{get; set;}

	}
}
