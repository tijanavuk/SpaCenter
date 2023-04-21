using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemOperations.EmployeeRoleSO;
using SystemOperations.EmployeeSO;
using SystemOperations.RoleSO;
using SystemOperations.CategorySO;
using SystemOperations.LoyaltySO;
using SystemOperations.ClientSO;
using SystemOperations.ServiceSO;
using SystemOperations.PaymentMethodSO;
using SystemOperations.ReceiptHeaderSO;
using SystemOperations.ReceiptLine;



namespace Server
{
    public class ThreadClient
    {
        NetworkStream stream;
        BinaryFormatter formater;

        public ThreadClient(NetworkStream stream)
        {
            this.stream = stream;
            formater = new BinaryFormatter();

            //ThreadStart ts = Process;
            //new Thread(ts).Start();

            Thread thread = new Thread(Process);
            thread.IsBackground = true;
            thread.Start();
        }

        private void Process()
        {
            try
            {
                int operation = 0;
                while (operation!= (int)Operation.End)
                {
                    TransferClass transfer = formater.Deserialize(stream) as TransferClass;
                    switch (transfer.Operation)
                    {
                        case Operation.End:
                            break;
                        case Operation.FindEmployee:
                            FindUser findUser = new FindUser();
                            transfer.Result = findUser.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.FindRoleForEmployee:
                            ReturnRolesForEmployee returnRolesForEmployee = new ReturnRolesForEmployee();
                            transfer.Result = returnRolesForEmployee.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.FindAdminRole:
                            FindRole findRole = new FindRole();
                            transfer.Result = findRole.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnCategories:
                            ReturnCategories returnCategories = new ReturnCategories();
                            transfer.Result = returnCategories.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnLoyalties:
                            ReturnLoyalties returnLoyalties = new ReturnLoyalties();
                            transfer.Result = returnLoyalties.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveClient:
                            SaveClient saveClient = new SaveClient();
                            transfer.Result = saveClient.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveService:
                            SaveService saveService = new SaveService();
                            transfer.Result = saveService.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveLoyalty:
                            SaveLoyalty saveLoyalty = new SaveLoyalty();
                            transfer.Result = saveLoyalty.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveEmployee:
                            SaveEmployee saveEmployee = new SaveEmployee();
                            transfer.Result = saveEmployee.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SearchEmployee:
                            SearchEmployees searchEmployees = new SearchEmployees();
                            transfer.Result = searchEmployees.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.EditEmployee:
                            EditEmployee editEmployee = new EditEmployee();
                            transfer.Result = editEmployee.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SearchLoyalty:
                            SearchLoyalties searchLoyalties = new SearchLoyalties();
                            transfer.Result = searchLoyalties.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SearchService:
                            SearchServices searchServices = new SearchServices();
                            transfer.Result = searchServices.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.EditService:
                            EditService editService = new EditService();
                            transfer.Result = editService.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.returnRoleForEmployee:
                            ReturnRolesForEmployee findRolesForEmployee = new ReturnRolesForEmployee();
                            transfer.Result = findRolesForEmployee.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnRoles:
                            ReturnRoles returnRoles = new ReturnRoles();
                            transfer.Result = returnRoles.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveEmployeeRole:
                            SaveEmployeeRole saveEmployeeRole = new SaveEmployeeRole();
                            transfer.Result = saveEmployeeRole.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SearchClient:
                            SearchClients searchClients = new SearchClients();
                            transfer.Result = searchClients.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.EditClient:
                            EditClient editClient = new EditClient();
                            transfer.Result = editClient.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.EditLoyalty:
                            EditLoyalty editLoyalty = new EditLoyalty();
                            transfer.Result = editLoyalty.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnPaymentMethods:
                            ReturnPaymentMethods returnPaymentMethods = new ReturnPaymentMethods();
                            transfer.Result = returnPaymentMethods.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SaveReceipt:
                            SaveReceiptHeader saveReceiptHeader = new SaveReceiptHeader();
                            transfer.Result = saveReceiptHeader.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.SearchReceipt:
                            SearchReceiptHeader searchReceiptHeader = new SearchReceiptHeader();
                            transfer.Result = searchReceiptHeader.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.returnReceiptLines:
                            ReturnReceiptLines returnReceiptLines = new ReturnReceiptLines();
                            transfer.Result = returnReceiptLines.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.CancelReceiptHeader:
                            CancelReceiptHeader cancelReceiptHeader = new CancelReceiptHeader();
                            transfer.Result = cancelReceiptHeader.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnAllEmployees:
                            ReturnAllEmployees retrunAllEmployees = new ReturnAllEmployees();
                            transfer.Result = retrunAllEmployees.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnSelectedLoyalty:
                            ReturnSelectedLoyalty returnSelectedLoyalt = new ReturnSelectedLoyalty();
                            transfer.Result = returnSelectedLoyalt.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        case Operation.ReturnSelectedEmployee:
                            ReturnSelectedEmployee returnSelectedEmployee = new ReturnSelectedEmployee();
                            transfer.Result = returnSelectedEmployee.ExecuteSo(transfer.TransferObject as GeneralDomainObject);
                            formater.Serialize(stream, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                //throw;
                try
                {
                    Server.clients.Remove(stream);

                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
    }
}
