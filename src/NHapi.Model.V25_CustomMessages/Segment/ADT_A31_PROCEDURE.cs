﻿using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Model.V25.Segment;
using System;
using System.Collections.Generic;

namespace NHapi.Model.V25_CustomMessages.Segment
{
    ///<summary>
    ///Represents the ADT_A31_PROCEDURE Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    ///<ol>
    ///<li>0: PR1 (PR1 - procedures segment) </li>
    ///<li>1: ROL (Role) optional repeating</li>
    ///</ol>
    ///</summary>
    [Serializable]
    public class ADT_A31_PROCEDURE : AbstractGroup
    {
        ///<summary> 
        /// Creates a new ADT_A31_PROCEDURE Group.
        ///</summary>
        public ADT_A31_PROCEDURE(IGroup parent, IModelClassFactory factory) : base(parent, factory)
        {
            try
            {
                this.Add(typeof(PR1), true, false);
                this.Add(typeof(ROL), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A31_PROCEDURE - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns PR1 (PR1 - procedures segment) - creates it if necessary
        ///</summary>
        public PR1 PR1
        {
            get
            {
                PR1 ret = null;
                try
                {
                    ret = (PR1)this.GetStructure("PR1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of ROL (Role) - creates it if necessary
        ///</summary>
        public ROL GetROL()
        {
            ROL ret = null;
            try
            {
                ret = (ROL)this.GetStructure("ROL");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ROL
        /// * (Role) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ROL GetROL(int rep)
        {
            return (ROL)this.GetStructure("ROL", rep);
        }

        /** 
         * Returns the number of existing repetitions of ROL 
         */
        public int ROLRepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("ROL").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        /** 
         * Enumerate over the ROL results 
         */
        public IEnumerable<ROL> ROLs
        {
            get
            {
                for (int rep = 0; rep < ROLRepetitionsUsed; rep++)
                {
                    yield return (ROL)this.GetStructure("ROL", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new ROL
        ///</summary>
        public ROL AddROL()
        {
            return this.AddStructure("ROL") as ROL;
        }

        ///<summary>
        ///Removes the given ROL
        ///</summary>
        public void RemoveROL(ROL toRemove)
        {
            this.RemoveStructure("ROL", toRemove);
        }

        ///<summary>
        ///Removes the ROL at the given index
        ///</summary>
        public void RemoveROLAt(int index)
        {
            this.RemoveRepetition("ROL", index);
        }
    }
}
