using System.Runtime.Serialization;


namespace Automation.Extantions.Contracts
{
    [DataContract]
    public class DriverParams
    {
        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public string Driver { get; set; }

        [DataMember]
        public string Binaries { get; set; }

    }
}
