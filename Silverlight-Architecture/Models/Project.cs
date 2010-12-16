using System;
using System.Runtime.Serialization;

namespace SilverlightArchitecture
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Uri Website { get; set; }
    }
}