//-----------------------------------------------------------------------
// <copyright file="RatingType.cs" company="Sergio Inzunza">
//    Sergio Inzunza and Contributors
// </copyright>
//-----------------------------------------------------------------------
// This file is part of User Model for Context-Aware Recommender Systems (UM4RS) and is dual licensed under MS-PL and Apache 2.0.
// https://github.com/inxunxa/UM4RS

namespace UM4RS.Item {
    /// <summary>
    /// The type of Rating to represent
    /// </summary>
	public enum RatingType {
        /// <summary>
        /// values 0 or 1
        /// </summary>
		Boolean = 0,

        /// <summary>
        /// values from 0 to 2
        /// </summary>
		TreePoints = 1,

        /// <summary>
        /// values from 0 to 3
        /// </summary>
		FourPoints = 2,

        /// <summary>
        /// values from 0 to 4
        /// </summary>
		FivePoint = 3,

        /// <summary>
        /// /// values from 0 to 9
        /// </summary>
		Decimal = 4,

	}

}
