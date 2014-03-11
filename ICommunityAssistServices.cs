using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment7b
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommunityAssistServices" in both code and config file together.
    [ServiceContract]
    public interface ICommunityAssistServices
    {
        [OperationContract]
        List<ComService> GetServices();


    }

    [DataContract]
    public class ComService
    {
        [DataMember]
        public string ServiceName { get; set; }
        [DataMember]
        public string ServiceDescription { get; set; }
    }
}
