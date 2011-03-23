// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;

namespace Cureos.Measures.Quantities
{
    /// <summary>
    /// Implementation of the solid angle quantity
    /// </summary>
    public struct SolidAngle : IQuantity<SolidAngle>
    {
        #region FIELDS

        private static readonly QuantityDimension _dimension = new QuantityDimension(DimensionlessDifferentiators.Steradian);

        public static readonly Unit<SolidAngle> Steradian = new Unit<SolidAngle>("sr");

        #endregion

        #region Implementation of IQuantity<SolidAngle>

        /// <summary>
        /// Gets the physical dimension of the quantity in terms of SI units
        /// </summary>
        public QuantityDimension Dimension
        {
            get { return _dimension; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        IUnit IQuantity.StandardUnit
        {
            get { return StandardUnit; }
        }

        /// <summary>
        /// Gets the standard unit associated with the quantity
        /// </summary>
        public IUnit<SolidAngle> StandardUnit
        {
            get { return Steradian; }
        }

        #endregion
    }
}