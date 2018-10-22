using System;
using System.Collections.Generic;
using System.Data;

namespace TagConfig
{
    public class ConditionReader : IDataReader
    {
        IEnumerator<Condition> _enumer;

        public ConditionReader(IEnumerable<Condition> list)
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
            DataTable table = new DataTable("Condition");
            table.Columns.Add("TypeID", typeof(int));
            table.Columns.Add("Source", typeof(string));
            table.Columns.Add("AlarmType", typeof(int));
            table.Columns.Add("EventType", typeof(byte));
            table.Columns.Add("ConditionType", typeof(byte));
            table.Columns.Add("Para", typeof(float));
            table.Columns.Add("IsEnabled", typeof(bool));
            table.Columns.Add("DeadBand", typeof(float));
            table.Columns.Add("Delay", typeof(int));
            table.Columns.Add("Comment", typeof(string));
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
            get { return 10; }
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
                    return typeof(string);
                case 2:
                    return typeof(int);
                case 3:
                    return typeof(byte);
                case 4:
                    return typeof(byte);
                case 5:
                    return typeof(float);
                case 6:
                    return typeof(bool);
                case 7:
                    return typeof(float);
                case 8:
                    return typeof(int);
                case 9:
                    return typeof(string);
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
                    return "TypeID";
                case 1:
                    return "Source";
                case 2:
                    return "AlarmType";
                case 3:
                    return "EventType";
                case 4:
                    return "ConditionType";
                case 5:
                    return "Para";
                case 6:
                    return "IsEnabled";
                case 7:
                    return "DeadBand";
                case 8:
                    return "Delay";
                case 9:
                    return "Comment";
                default:
                    return string.Empty;
            }
        }

        public int GetOrdinal(string name)
        {
            switch (name)
            {
                case "TypeID":
                    return 0;
                case "Source":
                    return 1;
                case "AlarmType":
                    return 2;
                case "EventType":
                    return 3;
                case "ConditionType":
                    return 4;
                case "Para":
                    return 5;
                case "IsEnabled":
                    return 6;
                case "DeadBand":
                    return 7;
                case "Delay":
                    return 8;
                case "Comment":
                    return 9;
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
                    return _enumer.Current.TypeID;
                case 1:
                    return _enumer.Current.Source;
                case 2:
                    return _enumer.Current.AlarmType;
                case 3:
                    return _enumer.Current.EventType;
                case 4:
                    return _enumer.Current.ConditionType;
                case 5:
                    return _enumer.Current.Para;
                case 6:
                    return _enumer.Current.IsEnabled;
                case 7:
                    return _enumer.Current.DeadBand;
                case 8:
                    return _enumer.Current.Delay;
                case 9:
                    return _enumer.Current.Comment;
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
                case 1:
                    return string.IsNullOrEmpty(_enumer.Current.Source);
                case 9:
                    return string.IsNullOrEmpty(_enumer.Current.Comment);
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