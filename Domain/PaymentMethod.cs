using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class PaymentMethod : GeneralDomainObject
    {
        int paymentMethodID;
        String name;
        Boolean active;
        Employee createdBy;

        public int PaymentMethodID { get => paymentMethodID; set => paymentMethodID = value; }
        public string Name { get => name; set => name = value; }
        public bool Active { get => active; set => active = value; }
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }


        #region GeneralDomainObject Members

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            PaymentMethod pm = new PaymentMethod
            {
                PaymentMethodID = (int)row["PaymentMethodID"],
                Name = row["Name"].ToString(), 
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return pm;
        }

        public string ReturnCoditionForWhereInJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnCoditionID()
        {
            throw new NotImplementedException();
        }

        public string ReturnCondition()
        {
            throw new NotImplementedException();
        }

        public string ReturnConditionForJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnConditionMore()
        {
            throw new NotImplementedException();
        }

        public string ReturnKey()
        {
            return "PaymentMethodID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> paymentMethods = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                PaymentMethod paymentMethod = new PaymentMethod();
                paymentMethod.paymentMethodID = reader.GetInt32(0);
                paymentMethod.name = reader.GetString(1);
                paymentMethod.active = reader.GetBoolean(2);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(3);
                paymentMethod.createdBy = employee;

                paymentMethods.Add(paymentMethod);
            }
            return paymentMethods;
        }

        public string ReturnTableName()
        {
            return "PaymentMethod";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            return "(Name, Active, CreatedBy) values ('"+this.name+"', "+this.active+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
