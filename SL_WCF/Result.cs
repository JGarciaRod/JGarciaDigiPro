﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SL_WCF
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public string ErrorMassage { get; set; }
        [DataMember]
        public bool Correct { get; set; }
        [DataMember]
        public object Object { get; set; }
        [DataMember]
        public List<object> Objects { get; set; }
        [DataMember]
        public Exception Ex { get; set; }
    }
}