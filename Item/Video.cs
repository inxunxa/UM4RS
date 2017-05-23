//-----------------------------------------------------------------------
// <copyright file="Video.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Linq2Csv.DataAnnotations;
using UM4RS.User.Demographics;

namespace UM4RS.Item {
    [Table("Video")]
	public class Video : Item<Video>
	{
        /// <summary>
        /// Duration in Milisecond
        /// </summary>
        [NonExportable]
        public long Duration{get; set;}
        
        [NonExportable]
        public string Quality{get; set;}

        [NonExportable]
        public string Title{get; set;}

        [NonExportable]
	    public DateTime? ReleaseDate{get; set;}
        

        public int Year { get; set; }


	    public string Country { set; get; }

        [NonExportable]
	    public string Description{get; set;}


	    public string Publisher{get; set;}


	    public VideoGenres Genre{get; set;}


	    public Language Language{get; set;}


        public virtual ICollection<string>  Directors { get; set; } = new List<string>();


        public virtual ICollection<string> Actors { get; set; } = new List<string>();

        public decimal? Budget { get; set; }

        
	    public Video()
	    {
	    }

        public new static Video Get(int id)
	    {
            
	        //return (Video)Item.Get(id);
	        using (ModelORM db = new ModelORM())
	        {
	            return db.Videos.Find(id);
	        }
	    }

        // TODO: Fix this mapping to Actor or Person class
        // for now, we map actors and directors as a csv
        [NonExportable]
        public string ListOfActors
        {
            get { return string.Join(",", Actors); }
            set { Actors = value.Split(',').ToList(); }
        }

        [NonExportable]
        public string ListOfDirectors
        {
            get { return string.Join(",", Directors); }
            set { Directors = value.Split(',').ToList(); }
        }

        /// <summary>
        /// Get or Creates an empty @User in DB (used by importers)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>@User</returns>
        public static Video GetOrCreate(int id)
        {
            var video = Get(id);
            if (video != null) return video;

            // create an empty User
            video = new Video()
            {
                Id = id
            };
            video.Save();

            return video;
        }
    }

}
