using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.ReceiptHeaderSO
{
    public class SaveReceiptHeader : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            ReceiptHeader rh = (ReceiptHeader)gdo; 
            Object o = Broker.ReturnSession().Save(gdo);
            if (o != null)
            {
                rh.receiptID = Broker.ReturnSession().ReturnNumber(gdo);

                foreach (Domain.ReceiptLine line in rh.receiptLines)
                {
                    line.ReceiptHeader = rh.receiptID;
                    o = Broker.ReturnSession().Save(line as GeneralDomainObject);
                    if (o == null) return null;
                }               
            }
            return o;

        }
    }
}
