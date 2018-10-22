using System;

namespace TagConfig
{

    [Serializable]
    public class RegisterModule
    {
        #region Model
        public int DriverID { set; get; }
        public bool Enable { get; set; } 
        public string AssemblyName { set; get; }
        public string ClassName { set; get; }
        public string ClassFullName { set; get; }
        public string Description { set; get; }
        #endregion

        //sql = "SELECT DRIVERID,ISNULL(Description,CLASSNAME),AssemblyName,ClassFullName FROM RegisterModule";

        public RegisterModule(int type, string name, string path, string className)
        {
            DriverID = type;
            Description = name;
            AssemblyName = path;
            ClassFullName = className;
        }
        public RegisterModule(string assembly, string className, string classFull, string description)
        {
            AssemblyName = assembly;
            ClassName = className;
            ClassFullName = classFull;
            Description = description;
        }

        public RegisterModule()
        { 
        }
    }
}