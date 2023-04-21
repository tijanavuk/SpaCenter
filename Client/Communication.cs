using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Client
{
    public class Communication
    {

        TcpClient client;
        NetworkStream stream;
        BinaryFormatter formater;

        public bool Connect()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 10000);
                stream = client.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        internal List<Employee> FindEmployee(Employee employee)
        {
            try
            {
                TransferClass transfer = new TransferClass();
                transfer.Operation = Operation.FindEmployee;
                transfer.TransferObject = employee;
                formater.Serialize(stream, transfer);

                transfer = formater.Deserialize(stream) as TransferClass;
                return transfer.Result as List<Employee>;
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show("Niste se konektovali na server!");
                //return null;
                throw;
            }
            
        }

        internal List<ReceiptHeader> SearchReceipt(ReceiptHeader rh)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchReceipt;
            transfer.TransferObject = rh;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<ReceiptHeader>;
        }

        internal List<EmployeeRole> ReturnRolesForEmployee(EmployeeRole er)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.returnRoleForEmployee;
            transfer.TransferObject = er;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<EmployeeRole>;
        }

        internal object CancelReceiptHeader(ReceiptHeader showReceiptHeader)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.CancelReceiptHeader;
            transfer.TransferObject = showReceiptHeader;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal Employee ReturnSelectedEmployee(Employee selectedEmployee)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnSelectedEmployee;
            transfer.TransferObject = selectedEmployee;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as Employee;
        }

        internal Loyalty ReturnSelectedLoyalty(Loyalty selectedLoyalty)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnSelectedLoyalty;
            transfer.TransferObject = selectedLoyalty;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as Loyalty;
        }

        internal List<ReceiptLine> ReturnReceiptLines(ReceiptLine receiptLine)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.returnReceiptLines;
            transfer.TransferObject = receiptLine;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<ReceiptLine>;
        }

        internal object SaveNewEmployeeRole(EmployeeRole newEmplRol)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveEmployeeRole;
            transfer.TransferObject = newEmplRol;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal List<Employee> ShowEmployee(Employee e)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ShowEmployee;
            transfer.TransferObject = e;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Employee>;
        }

        internal object EditService(Service showService)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.EditService;
            transfer.TransferObject = showService;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object EditClient(Domain.Client showClient)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.EditClient;
            transfer.TransferObject = showClient;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object EditEmployee(Employee showEmployee)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.EditEmployee;
            transfer.TransferObject = showEmployee;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object SaveReceipt(ReceiptHeader receiptHeader)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveReceipt;
            transfer.TransferObject = receiptHeader;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal List<Role> FindAdminRole(Role adminRole)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.FindAdminRole;
            transfer.TransferObject = adminRole;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Role>;
        }

        internal List<Category> ReturnCategories()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnCategories;
            transfer.TransferObject = new Category();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Category>;
        }

        internal List<Loyalty> ReturnLoyalties()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnLoyalties;
            transfer.TransferObject = new Loyalty();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Loyalty>;
        }

        internal List<PaymentMethod> ReturnPaymentMethods()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnPaymentMethods;
            transfer.TransferObject = new PaymentMethod();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<PaymentMethod>;
        }

        internal object EditLoyalty(Loyalty showLoyalty)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.EditLoyalty;
            transfer.TransferObject = showLoyalty;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object SaveNewClient(Domain.Client client)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveClient;
            transfer.TransferObject = client;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object SaveNewService(Service service)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveService;
            transfer.TransferObject = service;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object SaveNewLoyalty(Loyalty loyalty)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveLoyalty;
            transfer.TransferObject = loyalty;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal object SaveNewEmployee(Employee employee)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SaveEmployee;
            transfer.TransferObject = employee;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result;
        }

        internal List<Employee> SearchEmployees(Employee e)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchEmployee;
            transfer.TransferObject = e;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Employee>;
        }

        internal List<Domain.Client> SearchClients(Domain.Client client)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchClient;
            transfer.TransferObject = client;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Domain.Client>;
        }

        internal List<Loyalty> SearchLoyalties(Loyalty l)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchLoyalty;
            transfer.TransferObject = l;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Loyalty>;
        }

        internal List<Service> SearchServices(Service s)
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchService;
            transfer.TransferObject = s;
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Service>;
        }

        internal List<Role> ReturnRoles()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnRoles;
            transfer.TransferObject = new Role();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Role>;
        }

        internal List<Service> ReturnServices()
        {
            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.SearchService;
            transfer.TransferObject = new Service();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Service>;
        }

        internal List<Employee> ReturnAllEmployees()
        {

            TransferClass transfer = new TransferClass();
            transfer.Operation = Operation.ReturnAllEmployees;
            transfer.TransferObject = new Employee();
            formater.Serialize(stream, transfer);

            transfer = formater.Deserialize(stream) as TransferClass;
            return transfer.Result as List<Employee>;
        }
    }
}
