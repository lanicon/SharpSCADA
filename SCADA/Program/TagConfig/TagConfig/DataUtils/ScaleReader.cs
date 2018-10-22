using System;
using System.Collections.Generic;
using System.Data;

namespace TagConfig
{
    public class ScaleReader : IDataReader
    {
        IEnumerator<Scale> _enumer;

        public ScaleReader(IEnumerable<Scale> list)
        {
            this._enumer = list.GetEnumerator();
        }

        #region IDataReader Members

        public void Close()
        {

        }

        public int Depth
        {
            get { return 0; }
        }

        public DataTable GetSchemaTable()
        {
            DataTable table = new DataTable("Scale");
            table.Columns.Add("ScaleID", typeof(short));
            table.Columns.Add("ScaleType", typeof(byte));
            table.Columns.Add("EUHI", typeof(float));
            table.Columns.Add("EULO", typeof(float));
            table.Columns.Add("RAWHI", typeof(float));
            table.Columns.Add("RAWLO", typeof(float));
            return table;
        }
        public bool IsClosed
        {
            get { return false; }
        }

        public bool NextResult()
        {
            return false;
        }

        public bool Read()
        {
            return _enumer.MoveNext();
        }

        public int RecordsAffected
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion

        #region IDataRecord Members

        public int FieldCount
        {
            get { return 6; }
        }

        public bool GetBoolean(int i)
        {
            return (bool)GetValue(i);
        }

        public byte GetByte(int i)
        {
            return (byte)GetValue(i);
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            return (char)GetValue(i);
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            return this;
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            return (DateTime)GetValue(i);
        }

        public decimal GetDecimal(int i)
        {
            return (decimal)GetValue(i);
        }

        public double GetDouble(int i)
        {
            return (double)GetValue(i);
        }

        public Type GetFieldType(int i)
        {
            switch (i)
            {
                case 0:
                    return typeof(short);
                case 1:
                    return typeof(byte);
                case 2:
                    return typeof(float);
                case 3:
                    return typeof(float);
                case 4:
                    return typeof(float);
                case 5:
                    return typeof(float);
                default:
                    return typeof(int);
            }
        }

        public float GetFloat(int i)
        {
            return Convert.ToSingle(GetValue(i));
        }

        public Guid GetGuid(int i)
        {
            return (Guid)GetValue(i);
        }

        public short GetInt16(int i)
        {
            return (short)GetValue(i);
        }
        public int GetInt32(int i)
        {
            return (int)GetValue(i);
        }

        public long GetInt64(int i)
        {
            return (long)GetValue(i);
        }

        public string GetName(int i)
        {
            switch (i)
            {
                case 0:
                    return "ScaleID";
                case 1:
                    return "ScaleType";
                case 2:
                    return "EUHI";
                case 3:
                    return "EULO";
                case 4:
                    return "RAWHI";
                case 5:
                    return "RAWLO";
                default:
                    return string.Empty;
            }
        }

        public int GetOrdinal(string name)
        {
            switch (name)
            {
                case "ScaleID":
                    return 0;
                case "ScaleType":
                    return 1;
                case "EUHI":
                    return 2;
                case "EULO":
                    return 3;
                case "RAWHI":
                    return 4;
                case "RAWLO":
                    return 5;
                default:
                    return -1;
            }
        }

        public string GetString(int i)
        {
            return (string)GetValue(i);
        }

        public object GetValue(int i)
        {
            switch (i)
            {
                case 0:
                    return _enumer.Current.ScaleID;
                case 1:
                    return _enumer.Current.ScaleType;
                case 2:
                    return _enumer.Current.EUHi;
                case 3:
                    return _enumer.Current.EULo;
                case 4:
                    return _enumer.Current.RawHi;
                case 5:
                    return _enumer.Current.RawLo;
                default:
                    return null;
            }
        }

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public bool IsDBNull(int i)
        {
            return false;
        }

        public object this[string name]
        {
            get
            {
                return GetValue(GetOrdinal(name));
            }
        }

        public object this[int i]
        {
            get
            {
                return GetValue(i);
            }
        }

        #endregion
    }
}