﻿using System;
using System.Collections.Generic;

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V25.Segment;
using NHapi.Model.V25_CustomMessages.Segment;

namespace NHapi.Model.V25_CustomMessages.Message
{
    ///<summary>
    /// Represents a ADT_A31 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    ///<ol>
    ///<li>0: MSH (MSH - message header segment) </li>
    ///<li>1: EVN (EVN - event type segment) </li>
    ///<li>2: PID (PID - patient identification segment) </li>
    ///<li>3: PD1 (PD1 - patient additional demographic segment) optional </li>
    ///<li>4: ZFY (ZFY - Epic special for information about GP) optional repeating</li>
    ///<li>5: ROL (ROL - Person relation in a period of time) optional repeating</li>
    ///<li>6: NK1 (NK1 - next of kin / associated parties segment-) optional repeating</li>
    ///<li>7: PV1 (PV1 - patient visit segment-) </li>
    ///<li>8: PV2 (PV2 - patient visit - additional information segment) optional </li>
    ///<li>9: DB1 (DB1 - Disability segment) optional repeating</li>
    ///<li>10: OBX (OBX - observation/result segment) optional repeating</li>
    ///<li>11: AL1 (AL1 - patient allergy information segment) optional repeating</li>
    ///<li>12: DG1 (DG1 - diagnosis segment) optional repeating</li>
    ///<li>13: DRG (DRG - diagnosis related group segment) optional </li>
    ///<li>14: ADT_A31_PROCEDURE (a Group object) optional repeating</li>
    ///<li>15: GT1 (GT1 - guarantor segment) optional repeating</li>
    ///<li>16: ADT_A31_INSURANCE (a Group object) optional repeating</li>
    ///<li>17: ACC (ACC - accident segment) optional </li>
    ///<li>18: UB1 (UB1 - UB82 data segment) optional </li>
    ///<li>19: UB2 (UB2 - UB92 data segment) optional </li>
    ///<li>20: ZPD (ZPD - Epic special) optional </li>
    ///<li>21: ZVR (ZVR - Epic special) optional </li>
    ///</ol>
    ///</summary>
    [Serializable]
    public class ADT_A31 : AbstractMessage
    {
        public override string Version => "2.5";

        public ADT_A31(IModelClassFactory factory)
            : base(factory)
        {
            Init(factory);
        }

        public ADT_A31()
            : base(new DefaultModelClassFactory())
        {
            Init(new DefaultModelClassFactory());
        }

        private void Init(IModelClassFactory factory)
        {
            try
            {
                Add(typeof(MSH), true, false);
                MSH.MessageType.MessageCode.Value = "ADT";
                MSH.MessageType.TriggerEvent.Value = "A31";
                Add(typeof(EVN), true, false);
                Add(typeof(PID), true, false);
                Add(typeof(PD1), false, false);
                Add(typeof(ZFY), false, true);
                Add(typeof(ROL), false, true);
                Add(typeof(NK1), false, true);
                Add(typeof(PV1), false, false);
                Add(typeof(PV2), false, false);
                Add(typeof(DB1), false, true);
                Add(typeof(OBX), false, true);
                Add(typeof(AL1), false, true);
                Add(typeof(DG1), false, true);
                Add(typeof(DRG), false, false);
                Add(typeof(ADT_A31_PROCEDURE), false, true);
                Add(typeof(GT1), false, true);
                Add(typeof(ADT_A31_INSURANCE), false, true);
                Add(typeof(ACC), false, false);
                Add(typeof(UB1), false, false);
                Add(typeof(UB2), false, false);
                Add(typeof(ZPD), false, false);
                Add(typeof(ZVR), false, false);
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Error creating ADT_A31", ex);
            }
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

        /// <summary>
        /// Epic special for information about GP
        /// </summary>
        public virtual ZFY ZFY
        {
            get
            {
                ZFY segmentData = null;

                try
                {
                    segmentData = (ZFY)this.GetStructure("ZFY");
                }
                catch (HL7Exception ex)
                {
                    const string errorMessage = "Unexpected error accessing ZFY segment data";
                    HapiLogFactory.GetHapiLog(this.GetType()).Error(errorMessage, ex);
                    throw new System.Exception(errorMessage, ex);
                }

                return segmentData;
            }
        }

        /// <summary>
        /// Epic special
        /// </summary>
        public virtual ZPD ZPD
        {
            get
            {
                ZPD segmentData = null;

                try
                {
                    segmentData = (ZPD)this.GetStructure("ZPD");
                }
                catch (HL7Exception ex)
                {
                    const string errorMessage = "Unexpected error accessing ZPD segment data";
                    HapiLogFactory.GetHapiLog(this.GetType()).Error(errorMessage, ex);
                    throw new System.Exception(errorMessage, ex);
                }

                return segmentData;
            }
        }

        /// <summary>
        /// Epic special
        /// </summary>
        public virtual ZVR ZVR
        {
            get
            {
                ZVR segmentData = null;

                try
                {
                    segmentData = (ZVR)this.GetStructure("ZVR");
                }
                catch (HL7Exception ex)
                {
                    const string errorMessage = "Unexpected error accessing ZVR segment data";
                    HapiLogFactory.GetHapiLog(this.GetType()).Error(errorMessage, ex);
                    throw new System.Exception(errorMessage, ex);
                }

                return segmentData;
            }
        }

        // Seems like all segments must be redefined to reimplement the structure to V25 instead of inhering from ADT_A31 from V231
        #region Reimplementation of V231 of this message type
        ///<summary>
        /// Returns MSH (MSH - message header segment) - creates it if necessary
        ///</summary>
        public MSH MSH
        {
            get
            {
                MSH ret = null;
                try
                {
                    ret = (MSH)this.GetStructure("MSH");
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
        /// Returns EVN (EVN - event type segment) - creates it if necessary
        ///</summary>
        public EVN EVN
        {
            get
            {
                EVN ret = null;
                try
                {
                    ret = (EVN)this.GetStructure("EVN");
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
        /// Returns PID (PID - patient identification segment) - creates it if necessary
        ///</summary>
        public PID PID
        {
            get
            {
                PID ret = null;
                try
                {
                    ret = (PID)this.GetStructure("PID");
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
        /// Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
        ///</summary>
        public PD1 PD1
        {
            get
            {
                PD1 ret = null;
                try
                {
                    ret = (PD1)this.GetStructure("PD1");
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
        /// Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary
        ///</summary>
        public NK1 GetNK1()
        {
            NK1 ret = null;
            try
            {
                ret = (NK1)this.GetStructure("NK1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NK1
        /// * (NK1 - next of kin / associated parties segment-) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NK1 GetNK1(int rep)
        {
            return (NK1)this.GetStructure("NK1", rep);
        }

        /** 
         * Returns the number of existing repetitions of NK1 
         */
        public int NK1RepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NK1").Length;
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
         * Enumerate over the NK1 results 
         */
        public IEnumerable<NK1> NK1s
        {
            get
            {
                for (int rep = 0; rep < NK1RepetitionsUsed; rep++)
                {
                    yield return (NK1)this.GetStructure("NK1", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new NK1
        ///</summary>
        public NK1 AddNK1()
        {
            return this.AddStructure("NK1") as NK1;
        }

        ///<summary>
        ///Removes the given NK1
        ///</summary>
        public void RemoveNK1(NK1 toRemove)
        {
            this.RemoveStructure("NK1", toRemove);
        }

        ///<summary>
        ///Removes the NK1 at the given index
        ///</summary>
        public void RemoveNK1At(int index)
        {
            this.RemoveRepetition("NK1", index);
        }

        ///<summary>
        /// Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
        ///</summary>
        public PV1 PV1
        {
            get
            {
                PV1 ret = null;
                try
                {
                    ret = (PV1)this.GetStructure("PV1");
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
        /// Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
        ///</summary>
        public PV2 PV2
        {
            get
            {
                PV2 ret = null;
                try
                {
                    ret = (PV2)this.GetStructure("PV2");
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
        /// Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
        ///</summary>
        public DB1 GetDB1()
        {
            DB1 ret = null;
            try
            {
                ret = (DB1)this.GetStructure("DB1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DB1
        /// * (DB1 - Disability segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DB1 GetDB1(int rep)
        {
            return (DB1)this.GetStructure("DB1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DB1 
         */
        public int DB1RepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DB1").Length;
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
         * Enumerate over the DB1 results 
         */
        public IEnumerable<DB1> DB1s
        {
            get
            {
                for (int rep = 0; rep < DB1RepetitionsUsed; rep++)
                {
                    yield return (DB1)this.GetStructure("DB1", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new DB1
        ///</summary>
        public DB1 AddDB1()
        {
            return this.AddStructure("DB1") as DB1;
        }

        ///<summary>
        ///Removes the given DB1
        ///</summary>
        public void RemoveDB1(DB1 toRemove)
        {
            this.RemoveStructure("DB1", toRemove);
        }

        ///<summary>
        ///Removes the DB1 at the given index
        ///</summary>
        public void RemoveDB1At(int index)
        {
            this.RemoveRepetition("DB1", index);
        }

        ///<summary>
        /// Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary
        ///</summary>
        public OBX GetOBX()
        {
            OBX ret = null;
            try
            {
                ret = (OBX)this.GetStructure("OBX");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of OBX
        /// * (OBX - observation/result segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public OBX GetOBX(int rep)
        {
            return (OBX)this.GetStructure("OBX", rep);
        }

        /** 
         * Returns the number of existing repetitions of OBX 
         */
        public int OBXRepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBX").Length;
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
         * Enumerate over the OBX results 
         */
        public IEnumerable<OBX> OBXs
        {
            get
            {
                for (int rep = 0; rep < OBXRepetitionsUsed; rep++)
                {
                    yield return (OBX)this.GetStructure("OBX", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new OBX
        ///</summary>
        public OBX AddOBX()
        {
            return this.AddStructure("OBX") as OBX;
        }

        ///<summary>
        ///Removes the given OBX
        ///</summary>
        public void RemoveOBX(OBX toRemove)
        {
            this.RemoveStructure("OBX", toRemove);
        }

        ///<summary>
        ///Removes the OBX at the given index
        ///</summary>
        public void RemoveOBXAt(int index)
        {
            this.RemoveRepetition("OBX", index);
        }

        ///<summary>
        /// Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary
        ///</summary>
        public AL1 GetAL1()
        {
            AL1 ret = null;
            try
            {
                ret = (AL1)this.GetStructure("AL1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of AL1
        /// * (AL1 - patient allergy information segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public AL1 GetAL1(int rep)
        {
            return (AL1)this.GetStructure("AL1", rep);
        }

        /** 
         * Returns the number of existing repetitions of AL1 
         */
        public int AL1RepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("AL1").Length;
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
         * Enumerate over the AL1 results 
         */
        public IEnumerable<AL1> AL1s
        {
            get
            {
                for (int rep = 0; rep < AL1RepetitionsUsed; rep++)
                {
                    yield return (AL1)this.GetStructure("AL1", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new AL1
        ///</summary>
        public AL1 AddAL1()
        {
            return this.AddStructure("AL1") as AL1;
        }

        ///<summary>
        ///Removes the given AL1
        ///</summary>
        public void RemoveAL1(AL1 toRemove)
        {
            this.RemoveStructure("AL1", toRemove);
        }

        ///<summary>
        ///Removes the AL1 at the given index
        ///</summary>
        public void RemoveAL1At(int index)
        {
            this.RemoveRepetition("AL1", index);
        }

        ///<summary>
        /// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
        ///</summary>
        public DG1 GetDG1()
        {
            DG1 ret = null;
            try
            {
                ret = (DG1)this.GetStructure("DG1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DG1
        /// * (DG1 - diagnosis segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DG1 GetDG1(int rep)
        {
            return (DG1)this.GetStructure("DG1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DG1 
         */
        public int DG1RepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DG1").Length;
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
         * Enumerate over the DG1 results 
         */
        public IEnumerable<DG1> DG1s
        {
            get
            {
                for (int rep = 0; rep < DG1RepetitionsUsed; rep++)
                {
                    yield return (DG1)this.GetStructure("DG1", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new DG1
        ///</summary>
        public DG1 AddDG1()
        {
            return this.AddStructure("DG1") as DG1;
        }

        ///<summary>
        ///Removes the given DG1
        ///</summary>
        public void RemoveDG1(DG1 toRemove)
        {
            this.RemoveStructure("DG1", toRemove);
        }

        ///<summary>
        ///Removes the DG1 at the given index
        ///</summary>
        public void RemoveDG1At(int index)
        {
            this.RemoveRepetition("DG1", index);
        }

        ///<summary>
        /// Returns DRG (DRG - diagnosis related group segment) - creates it if necessary
        ///</summary>
        public DRG DRG
        {
            get
            {
                DRG ret = null;
                try
                {
                    ret = (DRG)this.GetStructure("DRG");
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
        /// Returns  first repetition of ADT_A31_PROCEDURE (a Group object) - creates it if necessary
        ///</summary>
        public ADT_A31_PROCEDURE GetPROCEDURE()
        {
            ADT_A31_PROCEDURE ret = null;
            try
            {
                ret = (ADT_A31_PROCEDURE)this.GetStructure("PROCEDURE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ADT_A31_PROCEDURE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ADT_A31_PROCEDURE GetPROCEDURE(int rep)
        {
            return (ADT_A31_PROCEDURE)this.GetStructure("PROCEDURE", rep);
        }

        /** 
         * Returns the number of existing repetitions of ADT_A31_PROCEDURE 
         */
        public int PROCEDURERepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PROCEDURE").Length;
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
         * Enumerate over the ADT_A31_PROCEDURE results 
         */
        public IEnumerable<ADT_A31_PROCEDURE> PROCEDUREs
        {
            get
            {
                for (int rep = 0; rep < PROCEDURERepetitionsUsed; rep++)
                {
                    yield return (ADT_A31_PROCEDURE)this.GetStructure("PROCEDURE", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new ADT_A31_PROCEDURE
        ///</summary>
        public ADT_A31_PROCEDURE AddPROCEDURE()
        {
            return this.AddStructure("PROCEDURE") as ADT_A31_PROCEDURE;
        }

        ///<summary>
        ///Removes the given ADT_A31_PROCEDURE
        ///</summary>
        public void RemovePROCEDURE(ADT_A31_PROCEDURE toRemove)
        {
            this.RemoveStructure("PROCEDURE", toRemove);
        }

        ///<summary>
        ///Removes the ADT_A31_PROCEDURE at the given index
        ///</summary>
        public void RemovePROCEDUREAt(int index)
        {
            this.RemoveRepetition("PROCEDURE", index);
        }

        ///<summary>
        /// Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary
        ///</summary>
        public GT1 GetGT1()
        {
            GT1 ret = null;
            try
            {
                ret = (GT1)this.GetStructure("GT1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of GT1
        /// * (GT1 - guarantor segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public GT1 GetGT1(int rep)
        {
            return (GT1)this.GetStructure("GT1", rep);
        }

        /** 
         * Returns the number of existing repetitions of GT1 
         */
        public int GT1RepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("GT1").Length;
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
         * Enumerate over the GT1 results 
         */
        public IEnumerable<GT1> GT1s
        {
            get
            {
                for (int rep = 0; rep < GT1RepetitionsUsed; rep++)
                {
                    yield return (GT1)this.GetStructure("GT1", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new GT1
        ///</summary>
        public GT1 AddGT1()
        {
            return this.AddStructure("GT1") as GT1;
        }

        ///<summary>
        ///Removes the given GT1
        ///</summary>
        public void RemoveGT1(GT1 toRemove)
        {
            this.RemoveStructure("GT1", toRemove);
        }

        ///<summary>
        ///Removes the GT1 at the given index
        ///</summary>
        public void RemoveGT1At(int index)
        {
            this.RemoveRepetition("GT1", index);
        }

        ///<summary>
        /// Returns  first repetition of ADT_A31_INSURANCE (a Group object) - creates it if necessary
        ///</summary>
        public ADT_A31_INSURANCE GetINSURANCE()
        {
            ADT_A31_INSURANCE ret = null;
            try
            {
                ret = (ADT_A31_INSURANCE)this.GetStructure("INSURANCE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ADT_A31_INSURANCE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ADT_A31_INSURANCE GetINSURANCE(int rep)
        {
            return (ADT_A31_INSURANCE)this.GetStructure("INSURANCE", rep);
        }

        /** 
         * Returns the number of existing repetitions of ADT_A31_INSURANCE 
         */
        public int INSURANCERepetitionsUsed
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("INSURANCE").Length;
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
         * Enumerate over the ADT_A31_INSURANCE results 
         */
        public IEnumerable<ADT_A31_INSURANCE> INSURANCEs
        {
            get
            {
                for (int rep = 0; rep < INSURANCERepetitionsUsed; rep++)
                {
                    yield return (ADT_A31_INSURANCE)this.GetStructure("INSURANCE", rep);
                }
            }
        }

        ///<summary>
        ///Adds a new ADT_A31_INSURANCE
        ///</summary>
        public ADT_A31_INSURANCE AddINSURANCE()
        {
            return this.AddStructure("INSURANCE") as ADT_A31_INSURANCE;
        }

        ///<summary>
        ///Removes the given ADT_A31_INSURANCE
        ///</summary>
        public void RemoveINSURANCE(ADT_A31_INSURANCE toRemove)
        {
            this.RemoveStructure("INSURANCE", toRemove);
        }

        ///<summary>
        ///Removes the ADT_A31_INSURANCE at the given index
        ///</summary>
        public void RemoveINSURANCEAt(int index)
        {
            this.RemoveRepetition("INSURANCE", index);
        }

        ///<summary>
        /// Returns ACC (ACC - accident segment) - creates it if necessary
        ///</summary>
        public ACC ACC
        {
            get
            {
                ACC ret = null;
                try
                {
                    ret = (ACC)this.GetStructure("ACC");
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
        /// Returns UB1 (UB1 - UB82 data segment) - creates it if necessary
        ///</summary>
        public UB1 UB1
        {
            get
            {
                UB1 ret = null;
                try
                {
                    ret = (UB1)this.GetStructure("UB1");
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
        /// Returns UB2 (UB2 - UB92 data segment) - creates it if necessary
        ///</summary>
        public UB2 UB2
        {
            get
            {
                UB2 ret = null;
                try
                {
                    ret = (UB2)this.GetStructure("UB2");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }
        #endregion // Reimplementation of V231 of this message type

    }
}