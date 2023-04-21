using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Session;

namespace SystemOperations.EmployeeRoleSO
{
    public class ReturnRolesForEmployee : GeneralSO
    {
        protected override object Execute(GeneralDomainObject gdo)
        {
            return Broker.ReturnSession().ReturnForConditionWithJoin(gdo).OfType<EmployeeRole>().ToList<EmployeeRole>();
        }
    }
}
