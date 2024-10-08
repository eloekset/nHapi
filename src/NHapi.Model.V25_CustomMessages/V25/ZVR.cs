using System;

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;

namespace NHapi.Model.V25_CustomMessages
{
    // ZVR_Epic
    [Serializable]
    public sealed class ZVR : AbstractSegment
    {
        public ZVR(IGroup parentStructure, IModelClassFactory factory)
            : base(parentStructure, factory)
        {
            var message = Message;
            try
            {
                // TODO: Implment structure defined in BizTalk schema
                /*
                  <xs:element minOccurs="0" name="ZVR_1_PatientRelationResponsibilityCode" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_2_PatientRelationCompetencyCode" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_3_PatientRelationLimitationCode" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_4_Guardianship" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_5_GuardianshipRelationshipType" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_6_PatientRelationActionCode" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_7_AdditionalRelationType" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_8_AdditionalRelationStartDate" type="xs:string" />
                  <xs:element minOccurs="0" name="ZVR_9_AdditionalRelationEndDate" type="xs:string" />
                 */
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unable to instantiate segment: " + GetType().Name, ex);
            }
        }
    }
}
