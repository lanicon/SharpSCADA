using System;
using System.Text;

namespace TagConfig
{



    [Serializable]
    public class Tag : IComparable<Tag>
    {
        #region Model
        public short TagID { set; get; }
        public string TagName { set; get; }
        public int DataType { set; get; }
        public short DataSize { set; get; }
        public string Address { set; get; }
        public short GroupID { set; get; }
        public bool IsActive { set; get; }
        public bool Archive { set; get; }
        public object DefaultValue { set; get; }
        public string Description { set; get; }
        public float Maximum { set; get; }
        public float Minimum { set; get; }
        public int Cycle { set; get; }
        public DateTime RowVersion { set; get; }
        public bool HasAlarm { set; get; }
        public bool HasScale { set; get; }
        #endregion


        //TagID,GroupID,TagName,Address,DataType,DataSize,IsActive






        public Tag(short id, short grpId, string name, string address, byte type, short size, bool active, bool alarm, bool scale, bool archive,
            object defaultV, string desp, float  max, float  min, int cycle)
        {
            TagID = id;
            GroupID = grpId;
            TagName = name;
            Address = address;
            Description = desp;
            DataType = type;
            DataSize = size;
            IsActive = active;
            HasAlarm = alarm;
            Archive = archive;
            Maximum = max;
            Minimum = min;
            HasScale = scale;
            Cycle = cycle;
            DefaultValue = defaultV;
        }

        public Tag(short grpId, string name)
        {
            GroupID = grpId;
            TagName = name;
        }

        public Tag()
        {
        }

        public int CompareTo(Tag other)
        {
            //return this._groupId.CompareTo(other._groupId);
            int cmp = this.GroupID.CompareTo(other.GroupID);
            return cmp == 0 ? this.TagName.CompareTo(other.TagName) : cmp;
        }
    }
}
