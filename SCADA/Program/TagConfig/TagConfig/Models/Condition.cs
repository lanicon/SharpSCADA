using System;
using System.Collections.Generic;
namespace TagConfig
{
    //TypeID,SourceID,AlarmType,EventType,ConditionType,Para,IsEnabled,Deadband,Delay,Comment
    [Serializable]
    public class Condition
    {
        #region Model
        public int TypeID { set; get; }
        public string Source { set; get; }
        public int AlarmType { set; get; }
        public int EventType { set; get; }
        public int ConditionType { set; get; }
        public float  Para { set; get; }
        public bool IsEnabled { set; get; }
        public float  DeadBand { set; get; }
        public int Delay { set; get; }
        public string Comment { set; get; }
        #endregion
        //}

        public Condition(int typeId, string source, int alarmType, byte eventType, byte condType, float  para, bool enable, float  deadband, int delay, string comment = null)
        {
            TypeID = typeId;
            Source = source;
            AlarmType = alarmType;
            IsEnabled = enable;
            EventType = eventType;
            ConditionType = condType;
            Delay = delay;
            Para = para;
            DeadBand = deadband;
            Comment = comment;
        }

        public Condition(string source)
        {
            Source = source;
        }
        public Condition()
        {
           
        }

        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<SubCondition> SubConditions { get; } = new List<SubCondition>();

        public override string ToString()
        {
            return Source;
        }
    }
}
