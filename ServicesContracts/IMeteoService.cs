using DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContracts
{
    [ServiceContract]
    public interface IMeteoService
    {
        [OperationContract()]
        Int32 GetTemperature(String city);
        [OperationContract()]
        List<Temperature> GetTemperatures();
    }
}
