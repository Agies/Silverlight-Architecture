using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SilverlightArchitecture
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember]
        public int EmployeeCode { get; set; }

        public string GetFullName()
        {
            return FirstName + ' ' + LastName;
        }
        
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public IEnumerable<Project> Projects { get; set; }

    }
}