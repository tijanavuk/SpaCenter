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
    public class Category : GeneralDomainObject
    {
        int categoryID;
        String name;
        Category parentCategory;
        Boolean active;
        Employee createdBy;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Name { get => name; set => name = value; }
        public Category ParentCategory { get => parentCategory; set => parentCategory = value; }
        public bool Active { get => active; set => active = value; }
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }

        #region GeneralDomainObject Members
        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            Category c = new Category
            {
                CategoryID = (int)row["CategoryID"],
                Name = row["Name"].ToString(),
                ParentCategory = new Category
                {
                    CategoryID = row["ParentCategoryID"] != DBNull.Value ? (int)row["ParentCategoryID"] : -1
                },
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return c;  
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
            return "ParentCategoryID is not null";
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
            return "CategoryID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> categories = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                Category category = new Category();
                category.categoryID = reader.GetInt32(0);
                category.name = reader.GetString(1);
                if (!reader.IsDBNull(2)) {
                    Category parent = new Category();
                    parent.categoryID = reader.GetInt32(2);
                    category.parentCategory = parent;
                }
                category.active = reader.GetBoolean(3);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(4);
                category.createdBy = employee;

                categories.Add(category);
            }
            return categories;
        }

        public string ReturnTableName()
        {
            return "Category";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            return "(Name, ParentCategoryID, Active, CreatedBy) values " +
                "('"+this.name+"', "+this.parentCategory.categoryID+", "+this.active+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
