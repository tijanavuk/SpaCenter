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
    public class Client : GeneralDomainObject
    {
        public int clientID;
        public String firstName;
        public String lastName;
        public String email;
        public Loyalty loyalty;
        public bool active;
        public Employee createdBy;

        [Browsable(false)]
        public int ClientID { get => clientID; set => clientID = value; }
        [DisplayName("First name")]
        public string FirstName { get => firstName; set => firstName = value; }
        [DisplayName("Last name")]
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        [Browsable(false)]
        public Loyalty Loyalty { get => loyalty; set => loyalty = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }
        [DisplayName("Loyalty name")]
        public string LoyaltyName { get; set; }



        #region GeneralDomainObject Members

        public string ReturnCondition()
        {
            throw new NotImplementedException();
        }


        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Client c = new Client
            {
                ClientID = (int)row["ClientID"],
                FirstName = row["FirstName"].ToString(),
                LastName = row["LastName"].ToString(),
                Email = row["Email"].ToString(),
                Loyalty = new Loyalty
                {
                    LoyaltyID = row["LoyaltyID"] != DBNull.Value ? (int)row["LoyaltyID"] : -1,
                    Name = row["Name"] != DBNull.Value ? row["Name"].ToString() : null,
                    Discount = row["Discount"] != DBNull.Value ? Convert.ToDouble(row["Discount"]) : -1
                },
                LoyaltyName = row["Name"] != DBNull.Value ? row["Name"].ToString() : null,
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return c;
        }

        public string ReturnConditionMore()
        {
            return "(FirstName like '%" + this.firstName + "%' or LastName like '%" + this.firstName + "%' or Email like '%" + this.firstName + "%')";
        }

        public string ReturnKey()
        {
            return "ClientID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> clients = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                Client client = new Client();
                client.clientID = reader.GetInt32(0);
                client.firstName = reader.GetString(1);
                client.lastName = reader.GetString(2);
                client.email = reader.GetString(3);
                if (!reader.IsDBNull(4)) {
                    Loyalty loyalty = new Loyalty();
                    loyalty.LoyaltyID = reader.GetInt32(4);
                    client.loyalty = loyalty;
                };               
                client.active = reader.GetBoolean(5);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(6);
                client.createdBy = employee;

                clients.Add(client);
            }
            return clients;
        }

        public string ReturnTableName()
        {
            return "Client";
        }

        public string ValueForInsert()
        {
            if (this.loyalty == null) {
                return "(FirstName, LastName, Email, LoyaltyID, Active, CreatedBy) values " +
               "('" + this.firstName + "', '" + this.lastName + "', '" + this.email + "',null, " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";
            }
            return "(FirstName, LastName, Email, LoyaltyID, Active, CreatedBy) values " +
            "('" + this.firstName + "', '" + this.lastName + "', '" + this.email + "', " + this.loyalty.LoyaltyID + ", " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";

        }


        public string ValueForUpdate()
        {
            if (this.active == false) return "Active = 0";
            if (this.loyalty == null)
            {
                return "FirstName = '" + this.firstName + "', LastName = '" + this.lastName + "', Email = '" + this.email + "'";
            }
            return "FirstName = '" + this.firstName + "', LastName = '" + this.lastName + "', Email = '" + this.email + "', LoyaltyID = " + this.loyalty.LoyaltyID + "";
        }

        public string ReturnCoditionID()
        {
            return "ClientID = " + this.clientID + "";
        }

        public string ReturnConditionForJoin()
        {
            return "Loyalty l on l.LoyaltyID = c.LoyaltyID";
        }

        public string ReturnTableNameForJoin()
        {
            return "Client c";
        }

        public string ReturnCoditionForWhereInJoin()
        {
            if (this.firstName == null && this.loyalty == null) return "c.Active = 1";
            if (this.clientID>0) return "c.Active = 1 and c.ClientID = "+this.clientID+"";
            if (this.firstName == "" && this.loyalty != null) return "c.Active = 1 and c.LoyaltyID = "+this.loyalty.LoyaltyID+" ";
            if (this.firstName!="" && this.loyalty == null) return "c.Active = 1 and (c.FirstName like '%" + this.firstName + "%' or c.LastName like '%" + this.firstName + "%' or c.Email like '%" + this.firstName + "%')";
            return "c.Active = 1 and (c.FirstName like '%" + this.firstName + "%' or c.LastName like '%" + this.firstName + "%' or c.Email like '%" + this.firstName + "%') and c.LoyaltyID = " + this.loyalty.LoyaltyID + " ";
        }

        #endregion
    }
}
