using System;

namespace TagConfig
{
    [Serializable]
    public class SubCondition : IComparable<SubCondition>
    {
        #region Model
        public int ConditionID { set; get; }
        public int SubAlarmType { set; get; }
        public decimal Threshold { set; get; }
        public int Severity { set; get; }
        public string Message { set; get; }
        public bool IsEnable { set; get; }
        #endregion


        public SubCondition(bool enable, int severity, int condId, int subType, decimal threshold, string message = null)
        {
            IsEnable = enable;
            Severity = severity;
            ConditionID = condId;
            SubAlarmType = subType;
            Threshold = threshold;
            Message = message;
        }

        public SubCondition(int condId)
        {
            ConditionID = condId;
        }

        public SubCondition()
        {
          
        }


        public SubCondition(int condId, int type, decimal threshold, byte severity, string message, bool enabled)
        {
            ConditionID = condId;
            SubAlarmType = type;
            Threshold = threshold;
            Severity = severity;
            Message = message;
            IsEnable = enabled;
        }

        public int CompareTo(SubCondition other)
        {
            return ConditionID.CompareTo(other.ConditionID);
        }
    }
}