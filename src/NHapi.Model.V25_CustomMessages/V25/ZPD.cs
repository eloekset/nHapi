using System;

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;

namespace NHapi.Model.V25_CustomMessages
{
    // ZPD
    [Serializable]
    public sealed class ZPD : AbstractSegment
    {
        public ZPD(IGroup parentStructure, IModelClassFactory factory)
            : base(parentStructure, factory)
        {
            var message = Message;
            try
            {
                // TODO: Implement the same structure as defined in BizTalk schema
                /*
                  <xs:element minOccurs="0" maxOccurs="unbounded" name="ZPD_1_PatientAncestry" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" maxOccurs="unbounded" name="ZPD_2_PreferredCommunicationMethod" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_3_MultipleBirthTotal" nillable="true" type="ns0:NM" />
                  <xs:element minOccurs="0" name="ZPD_4_MyChartStatus" nillable="true" type="ns0:ZPD_4_MyChartStatus" />
                  <xs:element minOccurs="0" maxOccurs="unbounded" name="ZPD_5_ResearchStudyIDs" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_6_AuthorizedServiceAreas" nillable="true" type="ns0:XON" />
                  <xs:element minOccurs="0" name="ZPD_7_PregnancyFlag" nillable="true" type="ns0:ID" />
                  <xs:element minOccurs="0" name="ZPD_8_ExpectedDeliveryDate" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_9_TransplantPatientFlag" nillable="true" type="ns0:ID" />
                  <xs:element minOccurs="0" name="ZPD_10_PayGrade" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_11_AssignedUnit" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_12_MilitaryPatientCategory" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_13_FamilyMemberPrefix" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_14_SchedulingGrouper" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_15_RaceEthnicityIDMethod" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_16_PatientTextingOptIn" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_17_PatientClientDeathPlace" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_18_ContactInterpreterRequired" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_19_Nationality" nillable="true" type="ns0:IS" />
                  <xs:element minOccurs="0" name="ZPD_20_GenderIdentity" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_21_Unknown" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_22_SexAssignedAtBirth" nillable="true" type="ns0:CWE" />
                  <xs:element minOccurs="0" name="ZPD_23_PatientMenarcheStatus" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_24_PatientProxySexForClinicalDecisions" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_25_Field25" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_26_Field26" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_27_Field27" nillable="true" type="ns0:ZPD_27_Field27" />
                  <xs:element minOccurs="0" name="ZPD_28_Field28" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_29_Field29" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_30_Field30" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_31_Field31" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_32_HearingImpaired" nillable="true" type="ns0:ST" />
                  <xs:element minOccurs="0" name="ZPD_33_VisuallyImpaired" nillable="true" type="ns0:ST" />
                */
   
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unable to instantiate segment: " + GetType().Name, ex);
            }
        }
    }
}
