using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum Operation { End = 1,
        FindEmployee = 2,
        FindRoleForEmployee = 3,
        FindAdminRole = 4,
        ReturnCategories = 5,
        ReturnLoyalties = 6,
        SaveClient = 7,
        SaveService = 8,
        SaveLoyalty = 9,
        SaveEmployee = 10,
        SearchEmployee = 11,
        ShowEmployee = 12,
        EditEmployee = 13,
        SearchLoyalty = 15,
        SearchService = 16,
        EditService = 17,
        returnRoleForEmployee = 19,
        ReturnRoles = 20,
        SaveEmployeeRole = 21,
        SearchClient = 22,
        EditClient = 24,
        EditLoyalty = 26,
        ReturnPaymentMethods = 27,
        ReturnServices = 28,
        SaveReceipt = 29,
        SearchReceipt = 31,
        returnReceiptLines = 32,
        CancelReceiptHeader = 33,
        ReturnAllClients = 34,
        ReturnAllEmployees = 35,
        ReturnSelectedLoyalty = 36,
        ReturnSelectedEmployee = 37,
    }
    [Serializable]
    public class TransferClass
    {
        Operation operation;
        Object transferObject; 
        Object result;

        public Operation Operation { get => operation; set => operation = value; }
        public object TransferObject { get => transferObject; set => transferObject = value; }
        public object Result { get => result; set => result = value; }


    }
}
