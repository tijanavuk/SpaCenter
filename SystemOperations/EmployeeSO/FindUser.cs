using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.EmployeeSO
{
    public class FindUser : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            return Broker.ReturnSession().ReturnForCondition(gdo).OfType<Employee>().ToList<Employee>();
        }
    }
}
