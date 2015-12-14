using System.Collections.Generic;
using System.ServiceModel;

namespace WCF.SERVICEINTERFACE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFProductService" in both code and config file together.
    [ServiceContract]
    public interface IWCFProductService
    {
        [OperationContract]
        List<string> ListProducts();
    }
}
