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
    public class Employee : GeneralDomainObject
    {
        public int employeeID;
        public String username;
        public String password;
        public String firstName;
        public String lastName;
        public DateTime workStartDate;
        public DateTime workEndDate;
        public Boolean active;
        public Employee createdBy;
      
        [Browsable(false)]
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        [DisplayName("First name")]
        public string FirstName { get => firstName; set => firstName = value; }
        [DisplayName("Last name")]
        public string LastName { get => lastName; set => lastName = value; }
        [DisplayName("Work start date")]
        public DateTime WorkStartDate { get => workStartDate; set => workStartDate = value; }
        [DisplayName("Work end date")]
        public DateTime WorkEndDate { get => workEndDate; set => workEndDate = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }

        #region GeneralDomainObject Members

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Employee e = new Employee
            {
                EmployeeID = (int)row["EmployeeID"],
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                FirstName = row["FirstName"].ToString(),
                LastName = row["LastName"].ToString(),
                WorkStartDate = Convert.ToDateTime(row["WorkStartDate"]),
                WorkEndDate = row["WorkEndDate"] != DBNull.Value ? Convert.ToDateTime(row["WorkEndDate"]) : DateTime.MinValue,
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return e;
        }

        public string ReturnCoditionForWhereInJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnCoditionID()
        {
            return "EmployeeID = " + this.employeeID + "";
        }

        public string ReturnCondition()
        {
            return "Username = '"+username+"' AND Password = '"+password+"'";
        }

        public string ReturnConditionForJoin()
        {
            throw new NotImplementedException();
        }

        public string ReturnConditionMore()
        {
            return "(Username like '%"+this.username+ "%' or FirstName like '%" + this.username + "%' or LastName like '%" + this.username + "%')";
        }

        public string ReturnKey()
        {
            return "EmployeeID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> employees = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.employeeID = reader.GetInt32(0);
                employee.username = reader.GetString(1);
                employee.password = reader.GetString(2);
                employee.firstName = reader.GetString(3);
                employee.lastName = reader.GetString(4);
                employee.workStartDate = reader.GetDateTime(5);
                if (!reader.IsDBNull(6)) employee.workEndDate = reader.GetDateTime(6);
                employee.active = reader.GetBoolean(7);
                Employee employeeCreate = new Employee();
                employeeCreate.employeeID = reader.GetInt32(8);
                employee.createdBy = employeeCreate;

                employees.Add(employee);
            }
            return employees;
        }

        public string ReturnTableName()
        {
            return "Employee";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            if (this.workEndDate <= DateTime.Now) {
                return "(Username, Password, FirstName, LastName, WorkStartDate, WorkEndDate, Active, CreatedBy) values " +
                "('" + this.username + "', '" + this.password + "', '" + this.firstName + "', '" + this.lastName + "', '" + this.workStartDate.ToShortDateString() + "', null, " + Convert.ToInt32(this.active) + ", " + this.createdBy.employeeID + ")";

            }
            return "(Username, Password, FirstName, LastName, WorkStartDate, WorkEndDate, Active, CreatedBy) values " +
                "('" + this.username + "', '" + this.password + "', '" + this.firstName + "', '" + this.lastName + "', '" + this.workStartDate.ToShortDateString() + "', '" + this.workEndDate.ToShortDateString() + "', " + Convert.ToInt32(this.active) + ", " + this.createdBy.employeeID + ")";
        }

        public string ValueForUpdate()
        {
            if (this.active == false) return "Active = 0";

            if (this.workEndDate == DateTime.MinValue)
            {
                return "Username = '" + this.username + "', Password = '" + this.password + "', FirstName = '" + this.firstName + "', LastName = '" + this.lastName + "', WorkStartDate = '" + this.workStartDate.ToShortDateString() + "'";
            }
            return "Username = '" + this.username + "', Password = '" + this.password + "', FirstName = '" + this.firstName + "', LastName = '" + this.lastName + "', WorkStartDate = '" + this.workStartDate.ToShortDateString() + "', WorkEndDate = '" + this.workEndDate.ToShortDateString() + "'";
        }
    
        #endregion
    }
}
