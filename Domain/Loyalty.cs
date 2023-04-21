using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Loyalty : GeneralDomainObject
    {
        int loyaltyID;
        String name;
        double discount;
        Boolean active;
        Employee createdBy;

        [Browsable(false)]
        public int LoyaltyID { get => loyaltyID; set => loyaltyID = value; }
        public string Name { get => name; set => name = value; }
        public double Discount { get => discount; set => discount = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }

        #region GeneralDomainObject Members
        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Loyalty l = new Loyalty
            {
                LoyaltyID = (int)row["LoyaltyID"],
                Name = row["Name"].ToString(),
                Discount = Convert.ToDouble(row["Discount"]),
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return l;
        }

        public string ReturnCoditionForWhereInJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnCoditionID()
        {
            return "LoyaltyID = "+this.loyaltyID+"";
        }

        public string ReturnCondition()
        {
            return "LoyaltyID is not null";
        }

        public string ReturnConditionForJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnConditionMore()
        {
            return "Name like '%" + this.name + "%'";
        }

        public string ReturnKey()
        {
            return "LoyaltyID"; ;
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> loyalties = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                Loyalty loyalty = new Loyalty();
                loyalty.loyaltyID = reader.GetInt32(0);
                loyalty.name = reader.GetString(1);
                loyalty.discount = reader.GetDouble(2);
                loyalty.active = reader.GetBoolean(3);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(4);
                loyalty.createdBy = employee;

                loyalties.Add(loyalty);
            }
            return loyalties;
        }

        public string ReturnTableName()
        {
            return "Loyalty";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            return "(Name, Discount, Active, CreatedBy) values ('"+this.name+"', "+this.discount+", "+Convert.ToInt32(this.active)+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            if (this.active == false) return "Active = 0";
            return "Name = '" + this.name + "', Discount = '" + this.discount + "'";
        }
        #endregion
    }
}
