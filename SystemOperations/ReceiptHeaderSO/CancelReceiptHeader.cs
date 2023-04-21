using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.ReceiptHeaderSO
{
    public class CancelReceiptHeader : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            return Broker.ReturnSession().Update(gdo);
        }
    }
}
