using System.Runtime.Serialization;

namespace TFL.DAL
{
    [DataContract(Name = "repo")]
    public class Repository
    {        
        [DataMember(Name = "displayName")]
        public string Name { get; set; }

        [DataMember(Name = "statusSeverity")]
        public string Status { get; set; }

        [DataMember(Name = "statusSeverityDescription")]
        public string StatusDescription { get; set; }       

        [DataMember(Name = "httpStatusCode")]
        public int HttpStatusCode { get; set; }

        [DataMember(Name = "httpStatus")]
        public string HttpStatus { get; set; }
    }
}
