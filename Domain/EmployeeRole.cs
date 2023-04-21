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
    public class EmployeeRole : GeneralDomainObject
    {
        Employee employee;
        Role role;
        DateTime dateFrom;
        DateTime dateTo;
        Boolean active;
        Employee createdBy;

        [Browsable(false)]
        public Employee Employee { get => employee; set => employee = value; }
        [Browsable(false)]
        public Role Role { get => role; set => role = value; }
        [DisplayName("Role name")]
        public string RoleName { get; set; }
        [DisplayName("Date from")]
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        [DisplayName("Date to")]
        public DateTime DateTo { get => dateTo; set => dateTo = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }
        
        #region GeneralDominObject Members

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            EmployeeRole er = new EmployeeRole
            {
                Employee = new Employee
                {
                    EmployeeID = (int)row["EmployeeID"]
                },
                Role = new Role
                {
                    RoleID = (int)row["RoleID"],
                    Name = row["Name"].ToString()
                },
                DateFrom = Convert.ToDateTime(row["DateFrom"]),
                DateTo = row["DateTo"] != DBNull.Value ? Convert.ToDateTime(row["DateTo"]) : DateTime.MinValue,
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                },
                RoleName = row["Name"].ToString()
            };
            return er;
        }

        public string ReturnCoditionForWhereInJoin()
        {
            return "er.Active = 1 and er.EmployeeID = "+this.employee.employeeID+"";
        }

        public string ReturnCoditionID()
        {
            throw new NotImplementedException();
        }

        public string ReturnCondition()
        {
            return "EmployeeID = "+employee.EmployeeID+"";
        }

        public string ReturnConditionForJoin()
        {
            return "Role r on r.RoleID = er.RoleID";
        }

        public string ReturnConditionMore()
        {
            throw new NotImplementedException();
        }

        public string ReturnKey()
        {
            throw new NotImplementedException();
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> employeeRoles = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                EmployeeRole employeeRole = new EmployeeRole();
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(0);
                employeeRole.employee = employee;
                Role role = new Role();
                role.RoleID = reader.GetInt32(1);
                employeeRole.role = role;
                employeeRole.dateFrom = reader.GetDateTime(2);
                if (!reader.IsDBNull(3)) employeeRole.dateTo = reader.GetDateTime(3);
                employeeRole.active = reader.GetBoolean(4);
                Employee employeeCreate = new Employee();
                employeeCreate.EmployeeID = reader.GetInt32(5);
                employeeRole.createdBy = employeeCreate;

                employeeRoles.Add(employeeRole);
            }
            return employeeRoles;
        }

        public string ReturnTableName()
        {
            return "EmployeeRole";
        }

        public string ReturnTableNameForJoin()
        {
            return "EmployeeRole er";
        }

        public string ValueForInsert()
        {
            if (DateTo == DateTime.MinValue) {
                return "(EmployeeID, RoleID, DateFrom, DateTo, Active, CreatedBy) values (" + this.employee.EmployeeID + ", " + this.role.RoleID + ", '" + this.dateFrom.ToShortDateString() + "', null, " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";
            } 
            return "(EmployeeID, RoleID, DateFrom, DateTo, Active, CreatedBy) values (" + this.employee.EmployeeID + ", " + this.role.RoleID + ", '" + this.dateFrom.ToShortDateString() + "', '" + this.dateTo.ToShortDateString() + "', " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";
        }

        public string ValueForUpdate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
