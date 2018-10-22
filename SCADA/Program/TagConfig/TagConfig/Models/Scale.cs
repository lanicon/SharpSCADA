using System;

namespace TagConfig
{
    [Serializable]
    //public class Scale
    //{
  
        public class Scale : IComparable<Scale>
    {
        //    #region Model
        public short ScaleID { set; get; }
        public int ScaleType { set; get; }
        public float EUHi { set; get; }
        public float EULo { set; get; }
        public float RawHi { set; get; }
        public float RawLo { set; get; }
        //    #endregion
        

        public Scale(short id, byte type, float euHi, float euLo, float rawHi, float rawLo)
        {
            ScaleID = id;
            ScaleType = type;
            EUHi =   euHi;
            EULo = euLo;
            RawHi =   rawHi;
            RawLo =   rawLo;
        }

        public Scale()
        {

        }

        public int CompareTo(Scale other)
        {
            return ScaleID.CompareTo(other.ScaleID);
        }

    }
}