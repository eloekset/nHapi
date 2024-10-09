using System;

using NHapi.Base;
using NHapi.Base.Log;
using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Model.V25.Datatype;

namespace NHapi.Model.V25_CustomMessages.Segment
{
    // ZFY_PatientFYIInformation
    [Serializable]
    public sealed class ZFY : AbstractSegment
    {
        public ZFY(IGroup parentStructure, IModelClassFactory factory)
            : base(parentStructure, factory)
        {
            var message = Message;
            try
            {
                add(typeof(ST), false, 1, 13, new object[] { message }, "Type");
                add(typeof(ST), false, 1, 20, new object[] { message }, "Action");
                add(typeof(ST), false, 1, 50, new object[] { message }, "Summary");
                add(typeof(ST), false, 1, 50, new object[] { message }, "Text");
            }
            catch (HL7Exception ex)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unable to instantiate segment: " + GetType().Name, ex);
            }
        }

        public ST Type
        {
            get
            {
                ST type;

                try
                {
                    var fieldData = GetField(1, 0);
                    type = (ST)fieldData;
                }
                catch (Exception ex)
                {
                    const string errorMessage = "Unexpected error occured while obtaining Type field value.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(errorMessage, ex);
                    throw new Exception(errorMessage, ex);
                }

                return type;
            }
        }

        public ST Action
        {
            get
            {
                ST action;

                try
                {
                    var fieldData = GetField(2, 0);
                    action = (ST)fieldData;
                }
                catch (Exception ex)
                {
                    const string errorMessage = "Unexpected error occured while obtaining Action field value.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(errorMessage, ex);
                    throw new Exception(errorMessage, ex);
                }

                return action;
            }
        }

        public ST Summary
        {
            get
            {
                ST summary;

                try
                {
                    var fieldData = GetField(3, 0);
                    summary = (ST)fieldData;
                }
                catch (Exception ex)
                {
                    const string errorMessage = "Unexpected error occured while obtaining Summary field value.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(errorMessage, ex);
                    throw new Exception(errorMessage, ex);
                }

                return summary;
            }
        }

        public ST Text
        {
            get
            {
                ST text;

                try
                {
                    var fieldData = GetField(4, 0);
                    text = (ST)fieldData;
                }
                catch (Exception ex)
                {
                    const string errorMessage = "Unexpected error occured while obtaining Text field value.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(errorMessage, ex);
                    throw new Exception(errorMessage, ex);
                }

                return text;
            }
        }
    }
}
