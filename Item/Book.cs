//-----------------------------------------------------------------------
// <copyright file="Book.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.Item {
    [Table("Book")]
    public class Book : Item<Book>
	{
		public string Author{get; set;}
		public string Topic{get; set;}
		public int Year{get; set;}
		public int Pages{get; set;}        

	}

}
