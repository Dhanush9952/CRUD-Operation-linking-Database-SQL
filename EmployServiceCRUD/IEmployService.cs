using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployService" in both code and config file together.
    [ServiceContract]
    public interface IEmployService
    {
        [OperationContract]
        emp[] ShowEmploy();
    }
    [DataContract]
    public class emp
    {
        [DataMember]
        public int Empno { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Dept { get; set; }
        [DataMember]
        public string Desig { get; set; }
        [DataMember]
        public int Basic { get; set; } 
    }
}
