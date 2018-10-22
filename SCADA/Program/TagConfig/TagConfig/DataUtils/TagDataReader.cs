using System;
using System.Collections.Generic;
using System.Data;

namespace TagConfig
{
    public class TagDataReader : IDataReader
    {
        IEnumerator<Tag> _enumer;

        public TagDataReader(IEnumerable<Tag> list)
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
            DataTable table = new DataTable("Tag");
            table.Columns.Add("TagID", typeof(short));
            table.Columns.Add("TagName", typeof(string));
            table.Columns.Add("DataType", typeof(byte));
            table.Columns.Add("DataSize", typeof(short));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("GroupID", typeof(short));
            table.Columns.Add("IsActive", typeof(bool));
            table.Columns.Add("Archive", typeof(bool));
            table.Columns.Add("DefaultValue", typeof(object));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Maximum", typeof(float));
            table.Columns.Add("Minimum", typeof(float));
            table.Columns.Add("Cycle", typeof(int));
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
            get { return 13; }
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
                    return typeof(string);
                case 2:
                    return typeof(byte);
                case 3:
                    return typeof(short);
                case 4:
                    return typeof(string);
                case 5:
                    return typeof(short);
                case 6:
                    return typeof(bool);
                case 7:
                    return typeof(bool);
                case 8:
                    return typeof(object);
                case 9:
                    return typeof(string);
                case 10:
                    return typeof(float);
                case 11:
                    return typeof(float);
                case 12:
                    return typeof(int);
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
                    return "TagID";
                case 1:
                    return "TagName";
                case 2:
                    return "DataType";
                case 3:
                    return "DataSize";
                case 4:
                    return "Address";
                case 5:
                    return "GroupID";
                case 6:
                    return "IsActive";
                case 7:
                    return "Archive";
                case 8:
                    return "DefaultValue";
                case 9:
                    return "Description";
                case 10:
                    return "Maximum";
                case 11:
                    return "Minimum";
                case 12:
                    return "Cycle";
                default:
                    return string.Empty;
            }
        }

        public int GetOrdinal(string name)
        {
            switch (name)
            {
                case "TagID":
                    return 0;
                case "TagName":
                    return 1;
                case "DataType":
                    return 2;
                case "DataSize":
                    return 3;
                case "Address":
                    return 4;
                case "GroupID":
                    return 5;
                case "IsActive":
                    return 6;
                case "Archive":
                    return 7;
                case "DefaultValue":
                    return 8;
                case "Description":
                    return 9;
                case "Maximum":
                    return 10;
                case "Minimum":
                    return 11;
                case "Cycle":
                    return 12;
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
                    return _enumer.Current.TagID;
                case 1:
                    return _enumer.Current.TagName;
                case 2:
                    return _enumer.Current.DataType;
                case 3:
                    return _enumer.Current.DataSize;
                case 4:
                    return _enumer.Current.Address;
                case 5:
                    return _enumer.Current.GroupID;
                case 6:
                    return _enumer.Current.IsActive;
                case 7:
                    return _enumer.Current.Archive;
                case 8:
                    return _enumer.Current.DefaultValue;
                case 9:
                    return _enumer.Current.Description;
                case 10:
                    return _enumer.Current.Maximum;
                case 11:
                    return _enumer.Current.Minimum;
                case 12:
                    return _enumer.Current.Cycle;
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
                    return string.IsNullOrEmpty(_enumer.Current.TagName);
                case 4:
                    return string.IsNullOrEmpty(_enumer.Current.Address);
                case 8:
                    return _enumer.Current.DefaultValue == null;
                case 9:
                    return string.IsNullOrEmpty(_enumer.Current.Description);
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