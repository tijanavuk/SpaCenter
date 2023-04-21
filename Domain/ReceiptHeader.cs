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
    public enum Status { None, Obradjen, Storniran}
    [Serializable]
    public class ReceiptHeader : GeneralDomainObject
    {
        public int receiptID;
        public String receiptNumber;
        public String note;
        public DateTime receiptDate;
        public double amount;
        public Status status;
        public Client client;
        public PaymentMethod paymentMethod;
        public Boolean active;
        public Employee createdBy;
        public BindingList<ReceiptLine> receiptLines;
        public double discount;

        public ReceiptHeader()
        {
            receiptLines = new BindingList<ReceiptLine>();
        }

        [Browsable(false)]
        public int ReceiptID { get => receiptID; set => receiptID = value; }
        [DisplayName("Receipt number")]
        public string ReceiptNumber { get => receiptNumber; set => receiptNumber = value; }
        public string Note { get => note; set => note = value; }
        [DisplayName("Receipt date")]
        public DateTime ReceiptDate { get => receiptDate; set => receiptDate = value; }
        public double Amount { get => amount; set => amount = value; }
        public Status Status { get => status; set => status = value; }
        [Browsable(false)]
        public Client Client { get => client; set => client = value; }
        [Browsable(false)]
        public PaymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        [Browsable(false)]
        public bool Active { get => active; set => active = value; }
        [Browsable(false)]
        public Employee CreatedBy { get => createdBy; set => createdBy = value; }
        [Browsable(false)]
        public BindingList<ReceiptLine> ReceiptLines { get => receiptLines; set => receiptLines = value; }
        [DisplayName("Client name")]
        public string ClientName { get; set; }
        [DisplayName("Payment method name")]
        public string PaymentMethodName { get; set; }
        [Browsable(false)]
        public double Discount { get => discount; set => discount = value; }


        #region GeneralDomainObject Members

        public GeneralDomainObject ReadTableRow(DataRow row)
        {
            ReceiptHeader rh = new ReceiptHeader
            {
                ReceiptID = (int)row["ReceiptID"],
                ReceiptNumber = row["ReceiptNumber"].ToString(),
                Note = row["Note"].ToString(),
                ReceiptDate = Convert.ToDateTime(row["ReceiptDate"]),
                Amount = Convert.ToDouble(row["Amount"]),
                Status = (Status)Enum.Parse(typeof(Status), row["Status"].ToString()),
                Client = new Client
                {
                    ClientID = row["ClientID"] != DBNull.Value ? (int)row["ClientID"] : -1,
                    FirstName = row["FirstName"] != DBNull.Value ? row["FirstName"].ToString() : null,
                    LastName = row["LastName"] != DBNull.Value ? row["LastName"].ToString() : null,
                },
                ClientName = row["FirstName"] != DBNull.Value ? row["FirstName"].ToString() + " " + row["LastName"].ToString() : null,
                PaymentMethod = new PaymentMethod
                {
                    PaymentMethodID = row["PaymentMethodID"] != DBNull.Value ? (int)row["PaymentMethodID"] : -1,
                    Name = row["Name"] != DBNull.Value ? row["Name"].ToString() : null,
                },
                PaymentMethodName = row["Name"] != DBNull.Value ? row["Name"].ToString() : null,
                Active = Convert.ToBoolean(row["Active"]),
                CreatedBy = new Employee
                {
                    EmployeeID = (int)row["CreatedBy"]
                }
            };
            return rh;
        }
       
        public string ReturnCoditionForWhereInJoin()
        {
            if (this.receiptNumber == null || (this.receiptNumber == "" && this.status ==Status.None)) return "rh.Active = 1";
            if(this.receiptNumber == "" && this.status != Status.None) return "rh.Active = 1 and rh.Status = '" + this.status.ToString()+"'";
            if (this.receiptNumber != "" && this.status == Status.None) return "rh.Active = 1 and rh.ReceiptNumber like '%" + this.receiptNumber + "%'";
            return "rh.Active = 1 and rh.Status = '" + this.status.ToString() + "' and rh.ReceiptNumber like '%" + this.receiptNumber + "%'";
        }

        public string ReturnCoditionID()
        {
            return "ReceiptID = " + this.receiptID + "";
        }

        public string ReturnCondition()
        {
            throw new NotImplementedException();
        }

        public string ReturnConditionForJoin()
        {
            return "Client c on c.ClientID = rh.ClientID left join PaymentMethod pm on pm.PaymentMethodID = rh.PaymentMethodID";
        }

        public string ReturnConditionMore()
        {
            throw new NotImplementedException();
        }

        public string ReturnKey()
        {
            return "ReceiptID";
        }

        public List<GeneralDomainObject> ReturnList(SqlDataReader reader)
        {
            List<GeneralDomainObject> receipts = new List<GeneralDomainObject>();
            while (reader.Read())
            {
                ReceiptHeader receipt = new ReceiptHeader();
                receipt.receiptID = reader.GetInt32(0);
                receipt.receiptNumber = reader.GetString(1);
                if (!reader.IsDBNull(2)) receipt.note = reader.GetString(2);
                receipt.receiptDate = reader.GetDateTime(3);
                receipt.amount = reader.GetDouble(4);
                Status status = new Status();
                if (Enum.TryParse<Status>(reader.GetString(2), out status)) receipt.status = status;
                if (!reader.IsDBNull(6)) {
                    Client client = new Client();
                    client.ClientID = reader.GetInt32(6);
                    receipt.client = client;
                }
                PaymentMethod paymentMethod = new PaymentMethod();
                paymentMethod.PaymentMethodID = reader.GetInt32(7);
                receipt.paymentMethod = paymentMethod;
                receipt.active = reader.GetBoolean(8);
                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(9);
                receipt.createdBy = employee;

                receipts.Add(receipt);

            }
            return receipts;
        }

        public string ReturnTableName()
        {
            return "ReceiptHeader";
        }

        public string ReturnTableNameForJoin()
        {
            return "ReceiptHeader rh";
        }

        public string ValueForInsert()
        {
            if (this.client != null) {
                return "(ReceiptNumber, Note, ReceiptDate, Amount, Status, ClientID, PaymentMethodID, Active, CreatedBy) values " +
                "('" + this.receiptNumber + "', '" + this.note + "', '" + this.receiptDate.ToShortDateString() + "', " + this.amount + ", '" + this.status.ToString() + "', " + this.client.ClientID + ", " + this.paymentMethod.PaymentMethodID + ", " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";
            }
            return "(ReceiptNumber, Note, ReceiptDate, Amount, Status, ClientID, PaymentMethodID, Active, CreatedBy) values " +
                "('" + this.receiptNumber + "', '" + this.note + "', '" + this.receiptDate.ToShortDateString() + "', " + this.amount + ", '" + this.status.ToString() + "', null, " + this.paymentMethod.PaymentMethodID + ", " + Convert.ToInt32(this.active) + ", " + this.createdBy.EmployeeID + ")";


        }

        public string ValueForUpdate()
        {
           return "Status = '"+this.status.ToString()+"'";
        }
        #endregion
    }
}
