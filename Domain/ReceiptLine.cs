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
    public class ReceiptLine : GeneralDomainObject
    {
        int receiptHeader;
        int lineNumber;
        Service service;
        int quantity;
        double price;
        double discount;
        double lineAmount;
        Boolean active;
        Employee createdBy;

        [DisplayName("Line number")]
        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        [Browsable(false)]
        public Service Service { get => service; set => service = value; }
        [DisplayName("Service name")]
        public string ServiceName { get; set; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Discount { get => discount; set => discount = value; }
        [DisplayName("Line amount")]
        public double LineAmount { get => lineAmount; set => lineAmount = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }
        [Browsable(false)]
        public int ReceiptHeader { get => receiptHeader; set => receiptHeader = value; }
 

        #region GeneralDomainObject Memebers

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            ReceiptLine rl = new ReceiptLine
            {
                ReceiptHeader = (int)row["ReceiptID"],
                LineNumber = (int)row["LineNumber"],
                ServiceName = row["ServiceName"].ToString(),
                Quantity = (int)row["Quantity"],
                Price = Convert.ToDouble(row["Price"]),
                Discount = Convert.ToDouble(row["Discount"]),
                LineAmount = Convert.ToDouble(row["LineAmount"]),
                Service = new Service
                {
                    ServiceID = (int)row["ServiceID"],
                    Name = row["ServiceName"].ToString()
                },
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }

            };
            return rl;
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
            return "ReceiptID = "+this.receiptHeader+"";
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
            return "LineNumber";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> receiptLines = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                ReceiptLine receiptLine = new ReceiptLine();
                receiptLine.receiptHeader = reader.GetInt32(0);
                receiptLine.lineNumber = reader.GetInt32(1);
                Service service = new Service();
                service.ServiceID = reader.GetInt32(7);
                service.Name = reader.GetString(2);
                receiptLine.service = service;
                receiptLine.quantity = reader.GetInt32(3);
                receiptLine.price = reader.GetDouble(4);
                receiptLine.discount = reader.GetDouble(5);
                receiptLine.lineAmount = reader.GetDouble(6);
                receiptLine.active = reader.GetBoolean(8);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(9);
                receiptLine.createdBy = employee;

                receiptLines.Add(receiptLine);

            }
            return receiptLines;
        }

        public string ReturnTableName()
        {
            return "ReceiptLine";
        }

        public string ReturnTableNameForJoin()
        {
            throw new NotImplementedException();
        }

        public string ValueForInsert()
        {
            return "(ReceiptID, LineNumber, ServiceName, Quantity, Price, Discount, LineAmount, ServiceID, Active, CreatedBy)" +
                "values ("+this.receiptHeader+", "+this.lineNumber+", '"+this.service.Name+"', "+this.quantity+", "+this.price+", "+this.discount+" , "+this.lineAmount+", "+this.service.ServiceID+", "+Convert.ToInt32(this.active)+", "+this.createdBy.EmployeeID+")";
        }

        public string ValueForUpdate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
