//-----------------------------------------------------------------------
// <copyright file="SocialRelationType.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

namespace UM4RS.Context.Social {
	public enum SocialRelationType {
        NoSpecified = 0,
        Alone,
		Family,
		Friend,
		Companion,
		Other,
		Partner,
        Parent        
	}

}
