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
    public class Service : GeneralDomainObject
    {
        public int serviceID;
        public String name;
        public String description;
        public double price;
        public Category category;
        public Boolean active;
        public Employee createdBy;

        [Browsable(false)]
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        [Browsable(false)]
        public Category Category { get => category; set => category = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }
        [DisplayName("Category name")]
        public string CategoryName { get; set; }

        #region GeneralDomainObject  members

        public string ReturnCondition()
        {
            throw new NotImplementedException();
        }

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Service s = new Service
            {
                ServiceID = (int)row["ServiceID"],
                Name = row["Name"].ToString(),
                Description = row["Description"].ToString(),
                Price = Convert.ToDouble(row["Price"]),
                Category = new Category
                {
                    CategoryID = (int)row["CategoryID"],
                    Name = row[8].ToString(),
                },
                CategoryName = row[8].ToString(),
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return s;
        }

        public string ReturnConditionMore()
        {
            return "Name like '%" + this.name + "%' or Description like '%"+this.name+"%'";
        }

        public string ReturnKey()
        {
            return "ServiceID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> services = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                Service service = new Service();
                service.serviceID = reader.GetInt32(0);
                service.name = reader.GetString(1);
                service.description = reader.GetString(2);
                service.price = reader.GetDouble(3);
                Category category = new Category();
                category.CategoryID = reader.GetInt32(4);
                service.category = category;
                service.Active = reader.GetBoolean(5);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(6);
                service.createdBy = employee;

                services.Add(service);

            }
            return services;
        }

        public string ReturnTableName()
        {
            return "Service";
        }

        public string ValueForInsert()
        {
            return "(Name, Description, Price, CategoryID, Active, CreatedBy) values ('"+this.name+"', '"+this.description+"', "+this.price+", "+this.category.CategoryID+", "+Convert.ToInt32(this.Active)+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            if (this.active == false) return "Active = 0";
            return "Name = '" + this.name + "', Description = '" + this.description + "', Price = " + this.price + ", CategoryID = " + this.category.CategoryID + "";
        }

        public string ReturnCoditionID()
        {
            return "ServiceID = " + serviceID + "";
        }

        public string ReturnConditionForJoin()
        {
            return "Category c on c.CategoryID = s.CategoryID";
        }

        public string ReturnTableNameForJoin()
        {
            return "Service s";
        }

        public string ReturnCoditionForWhereInJoin()
        {
            if (this.name == null && this.category == null) return "s.Active = 1";
            if (this.serviceID>0) return "s.Active = 1 and s.ServiceID = "+this.serviceID+"";
            if (this.name == "" && this.category!=null) return "s.Active = 1 and s.CategoryID = "+this.category.CategoryID+"";
            if (this.name !="" && this.category == null) return "s.Active = 1 and (s.Name like '%" + this.name + "%' or s.Description like '%" + this.name + "%')";
            return "s.Active = 1 and (s.Name like '%" + this.name + "%' or s.Description like '%" + this.name + "%') and s.CategoryID = "+this.category.CategoryID+"";
        }

        #endregion
    }
}
