using System;

namespace TagConfig
{
    [Serializable]
    public class Driver
    {
        #region Model
        public short DriverID { set; get; }
        public int DriverType { set; get; }
        public string DriverName { set; get; }
        #endregion


        public object Target { get; set; } 


        public Driver(short id, int driver, string name)
        {
            DriverID = id;
            DriverType = driver;
            DriverName = name;
        }

        public Driver()
        {

        }
    }
}