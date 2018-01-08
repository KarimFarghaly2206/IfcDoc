// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPropertyResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcSharedBldgElements;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;
using BuildingSmart.IFC.IfcSharedComponentElements;
using BuildingSmart.IFC.IfcSharedFacilitiesElements;
using BuildingSmart.IFC.IfcStructuralElementsDomain;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("e1436374-df3e-4e00-a829-415f1c1078a2")]
	public enum IfcInternalOrExternalEnum
	{
		[Description("The space boundary faces a physical or virtual element where there is an internal" +
	    " space on the other side.")]
		INTERNAL = 1,
	
		[Description("The space boundary faces a physical or virtual element where there is an external" +
	    " space on the other side.")]
		EXTERNAL = 2,
	
		[Description("The space boundary faces a physical or virtual element where there is earth (or t" +
	    "errain) on the other side.")]
		EXTERNAL_EARTH = 3,
	
		[Description("The space boundary faces a physical or virtual element where there is water (wate" +
	    "r component of terrain) on the other side.")]
		EXTERNAL_WATER = 4,
	
		[Description("The space boundary faces a physical or virtual element where there is another bui" +
	    "lding on the other side.")]
		EXTERNAL_FIRE = 5,
	
		[Description("No information available.")]
		NOTDEFINED = 0,
	
	}
}