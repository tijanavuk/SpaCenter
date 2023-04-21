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
    public class Role : GeneralDomainObject
    {
        int roleID;
        String name;
        String description;
        Boolean active;
        Employee createdBy;

        public int RoleID { get => roleID; set => roleID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public bool Active { get => active; set => active = value; }
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }


        #region GeneralDomainObject Members

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Role role = new Role
            {
                RoleID = (int)row["RoleID"],
                Name = row["Name"].ToString(),
                Description = row["Description"].ToString(),
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return role;
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
            return "Name = '"+name+"'";
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
            return "RoleID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> roles = new List<GeneralDomainObject>();
            while (reader.Read()) {

                Role role = new Role();
                role.roleID = reader.GetInt32(0);
                role.name = reader.GetString(1);
                role.description = reader.GetString(2);
                role.active = reader.GetBoolean(3);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(4);
                role.createdBy = employee;

                roles.Add(role);
            }
            return roles;     
        }

        public string ReturnTableName()
        {
            return "Role";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            return "(Name, Description, Active, CreatedBy) values ('"+this.name+"', '"+this.description+"', "+this.active+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
