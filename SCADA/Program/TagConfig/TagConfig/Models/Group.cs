namespace TagConfig
{
    public class Group
    {
        public string GroupName { get; set; }

        public short GroupID { get; set; }

        public int UpdateRate { get; set; }

        public float DeadBand { get; set; }

        public bool IsActive { get; set; }

        public short DriverID { get; set; }
        //GroupID,DriverID,GroupName,UpdateRate,DeadBand,IsActive
        public Group(short id, short deviceId, string name, int updateRate, float deadBand, bool active)
        {
            GroupID = id;
            DriverID = deviceId;
            GroupName = name;
            UpdateRate = updateRate;
            DeadBand = deadBand;
            IsActive = active;
        }

        public Group()
        {
        }
    }
}