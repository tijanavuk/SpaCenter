using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.EmployeeSO
{
    public class SearchEmployees : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            return Broker.ReturnSession().ReturnForConditionMore(gdo).OfType<Employee>().ToList<Employee>();
        }
    }
}
