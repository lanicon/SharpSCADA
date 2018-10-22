using System;
using System.Collections.Generic;
using System.Data;

namespace TagConfig
{
    public class SubConditionReader : IDataReader
    {
        IEnumerator<SubCondition> _enumer;

        public SubConditionReader(IEnumerable<SubCondition> list)
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
            DataTable table = new DataTable("SubCondition");
            //table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ConditionID", typeof(int));
            table.Columns.Add("SubAlarmType", typeof(int));
            table.Columns.Add("Threshold", typeof(float));
            table.Columns.Add("Severity", typeof(byte));
            table.Columns.Add("Message", typeof(string));
            table.Columns.Add("IsEnable", typeof(bool));
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
                    return typeof(int);
                case 1:
                    return typeof(int);
                case 2:
                    return typeof(float);
                case 3:
                    return typeof(byte);
                case 4:
                    return typeof(string);
                case 5:
                    return typeof(bool);
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
                    return "ConditionID";
                case 1:
                    return "SubAlarmType";
                case 2:
                    return "Threshold";
                case 3:
                    return "Severity";
                case 4:
                    return "Message";
                case 5:
                    return "IsEnable";
                default:
                    return string.Empty;
            }
        }

        public int GetOrdinal(string name)
        {
            switch (name)
            {
                case "ConditionID":
                    return 0;
                case "SubAlarmType":
                    return 1;
                case "Threshold":
                    return 2;
                case "Severity":
                    return 3;
                case "Message":
                    return 4;
                case "IsEnable":
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
                    return _enumer.Current.ConditionID;
                case 1:
                    return _enumer.Current.SubAlarmType;
                case 2:
                    return _enumer.Current.Threshold;
                case 3:
                    return _enumer.Current.Severity;
                case 4:
                    return _enumer.Current.Message;
                case 5:
                    return _enumer.Current.IsEnable;
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
            switch (i)
            {
                case 4:
                    return string.IsNullOrEmpty(_enumer.Current.Message);
                default:
                    return false;
            }
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