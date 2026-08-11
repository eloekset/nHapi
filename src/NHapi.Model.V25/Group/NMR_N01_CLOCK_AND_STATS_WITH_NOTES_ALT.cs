using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V25.Segment;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V25.Group
{
///<summary>
///Represents the NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: NMR_N01_CLOCK (a Group object) optional </li>
///<li>1: NMR_N01_APP_STATS (a Group object) optional </li>
///<li>2: NMR_N01_APP_STATUS (a Group object) optional </li>
///</ol>
///</summary>
[Serializable]
public class NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT : AbstractGroup {

	///<summary> 
	/// Creates a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group.
	///</summary>
	public NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NMR_N01_CLOCK), false, false);
	      this.add(typeof(NMR_N01_APP_STATS), false, false);
	      this.add(typeof(NMR_N01_APP_STATUS), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns NMR_N01_CLOCK (a Group object) - creates it if necessary
	///</summary>
	public NMR_N01_CLOCK CLOCK { 
get{
	   NMR_N01_CLOCK ret = null;
	   try {
	      ret = (NMR_N01_CLOCK)this.GetStructure("CLOCK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error occurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns NMR_N01_APP_STATS (a Group object) - creates it if necessary
	///</summary>
	public NMR_N01_APP_STATS APP_STATS { 
get{
	   NMR_N01_APP_STATS ret = null;
	   try {
	      ret = (NMR_N01_APP_STATS)this.GetStructure("APP_STATS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error occurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns NMR_N01_APP_STATUS (a Group object) - creates it if necessary
	///</summary>
	public NMR_N01_APP_STATUS APP_STATUS { 
get{
	   NMR_N01_APP_STATUS ret = null;
	   try {
	      ret = (NMR_N01_APP_STATUS)this.GetStructure("APP_STATUS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error occurred",e);
	   }
	   return ret;
	}
	}

}
}
