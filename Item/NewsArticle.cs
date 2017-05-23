//-----------------------------------------------------------------------
// <copyright file="NewsArticle.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UM4RS.Context.Location;

namespace UM4RS.Item {
    [Table("NewsArticle")]
    public class NewsArticle : Item <NewsArticle>
	{
        public string Topic { get; set; }
		public Place Place{get; set;}
        public List<Photo> Picture { get; set; }

	    public NewsArticle()
	    {
	        Picture = new List<Photo>();
	    }
    }

}
