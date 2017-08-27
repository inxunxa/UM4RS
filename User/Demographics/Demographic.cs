//-----------------------------------------------------------------------
// <copyright file="Demographic.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Linq2Csv.DataAnnotations;

namespace UM4RS.User.Demographics
{
    [Table("Demographic")]
    public class Demographic : ModelEntity<Demographic>, IBaseEntity
    {
        // Private Properties
        //private int m_age =-1;

        // Class Attributes
        [NonExportable]
        public int Id { get; set; }

        public int Age { get; set; }

        [NonExportable]
        public string Employment { get; set; }

        [NonExportable]
        public double? Salary { get; set; }

        [NonExportable]
        public double? Wealth { get; set; }

        [NonExportable]
        public RelationshipStatus? RelationshipStatus { get; set; }

        [NonExportable]
        public System.Collections.Generic.List<SpokenLanguage> SpokenLanguages { get; set; }

        [Exportable(Order =1, GlobalOrder = 1, Name = "sex")]
        public Gender? Gender { get; set; }    
        
        [NonExportable]        
        public DateTime? Birthday { get; set; }

        // Not DB Mapped Class Attributes        
//        [Exportable(Order = 2, GlobalOrder = 1, Name = "Age")]
//        public int Age {
//            get
//            {
//                if (m_age < 0) CalculateAge();
//                return m_age;
//            }
//        }

        public Demographic()
        {
            SpokenLanguages = new List<SpokenLanguage>();
        }

//        /// <summary>
//        /// Calculates the Age based on the Birthday
//        /// </summary>
//        private void CalculateAge()
//        {
//            if(!Birthday.HasValue) return;
//
//            var now = DateTime.Now;
//            m_age = now.Year - Birthday.Value.Year;
//
//            // finally adjust the result based on the current momemnt of year
//            if (now.Month < Birthday.Value.Month || (now.Month == Birthday.Value.Month && now.Day < Birthday.Value.Day))
//                m_age--;
//        }
    }

}
