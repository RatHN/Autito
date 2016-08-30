using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AutitoSoft_

{
    [DataContract]
    public class XivelyFeedFormat
    {
        [DataMember]
        public int id { get; set; }
        //[DataMember]
        //public string title { get; set; }
        [DataMember]
        public string @private { get; set; }
        [DataMember]
        public string feed { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string updated { get; set; }
        //[DataMember]
        //public string created { get; set; }
        //[DataMember]
        //public string creator { get; set; }
        //[DataMember]
        //public string version { get; set; }
        [DataMember]
        public List<Datastream> datastreams { get; set; }
        //[DataMember]
        //public string product_id { get; set; }
        //[DataMember]
        //public string device_serial { get; set; }
    }


    public class Unit
    {
        public string symbol { get; set; }
        public string label { get; set; }
    }

    [DataContract]
    public class Datastream
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string current_value { get; set; }
        public string at { get; set; }
        public string max_value { get; set; }
        public string min_value { get; set; }
        public List<string> tags { get; set; }
        [DataMember]
        public Unit unit { get; set; }
    }

    
}
