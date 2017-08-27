//-----------------------------------------------------------------------
// <copyright file="InterestPreference.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UM4RS.User.InterestPreferences
{
    [Table("InterestPrerence")]
    public class InterestPreference : ModelEntity<InterestPreference>, IBaseEntity
    {
        public int Id { get; set; }
        public List<Interest> Interest { get; set; }
        public List<Preference> Preference { get; set; }

        public InterestPreference()
        {
            Interest = new List<Interest>();
            Preference = new List<Preference>();
        }

    }

}
