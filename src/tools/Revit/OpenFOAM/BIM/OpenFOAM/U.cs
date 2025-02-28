﻿/* This file is part of COVISE.

   You can use it under the terms of the GNU Lesser General Public License
   version 2.1 or later, see lgpl-2.1.txt.

 * License: LGPL 2+ */
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace BIM.OpenFOAMExport.OpenFOAM
{
    /// <summary>
    /// Represents velocity parameter in CFD-Simulation in OpenFOAM.
    /// </summary>
    public class U : FOAMParameter<Vector3D>
    {
        ///// <summary>
        ///// InternalField-entry
        ///// </summary>
        //private InternalField<Vector3D> m_InternalField;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="version">Version-Object</param>
        /// <param name="path">Path to this file.</param>
        /// <param name="attributes">Additional attributs.</param>
        /// <param name="format">Format of this file.</param>
        /// <param name="settings">Settings-object</param>
        /// <param name="_wallName">Name of the patch wall.</param>
        /// <param name="_InletNames">Patchnames of the inlets as string-array.</param>
        /// <param name="_OutletNames">Patchnames of the outlets as string-array.</param>
        public U(Version version, string path, Dictionary<string, object> attributes, SaveFormat format, Settings settings, List<string> _wallNames,
            List<string> _InletNames, List<string> _OutletNames, List<string> _SlipNames)
            :base(version, path, attributes, format, settings, "U", "volVectorField", _wallNames, _InletNames, _OutletNames,_SlipNames)
        {
        }

        /// <summary>
        /// Initialize Attributes.
        /// </summary>
        public override void InitAttributes()
        {
            m_Dimensions = new int[] { 0, 1, -1, 0, 0, 0, 0 };
            m_InternalFieldString = m_Uniform + " (" + m_InternalField.Value.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat).Replace(",", " ") + ")";
            base.InitAttributes();
        }
    }
}
