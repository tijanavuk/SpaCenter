using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.ReceiptLine
{
    public class ReturnReceiptLines : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            return Broker.ReturnSession().ReturnForCondition(gdo).OfType<Domain.ReceiptLine>().ToList<Domain.ReceiptLine>();
        }
    }
}
