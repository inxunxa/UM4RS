//-----------------------------------------------------------------------
// <copyright file="Audio.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Item {
    [Table("Audio")]
    public class Audio : Item<Audio>
	{
        /// <summary>
        /// Duration in Miliseconds
        /// </summary>
		public long Duration{get; set;}
		public string Quality{get; set;}
		public string Title{get; set;}
		public string Album{get; set;}

	}

}
