﻿using System.Runtime.Serialization;

namespace TaxServiceLibrary.Model
{
    [DataContract]
    public class ReportTemplateParameterInfo
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string description;

        [DataMember]
        public string defaultValue;
    }
}
