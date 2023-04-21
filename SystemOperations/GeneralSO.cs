using Domain;
using Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class GeneralSO
    {

        public List<GeneralDomainObject> List
        {
            get { return List; }
            set { List = value; }
        }

        public object ExecuteSo(GeneralDomainObject gdo)
        {
            object result = null;

            Broker.ReturnSession().OpenConnection();
            Broker.ReturnSession().BeginTransaction();
            try
            {
                result = Execute(gdo);
                Broker.ReturnSession().CommitTransaction();
            }
            catch (Exception)
            {
                Broker.ReturnSession().RollbackTransaction();
            }
            finally
            {
                Broker.ReturnSession().CloseConnection();
            }

            return result;
        }

        protected abstract object Execute(GeneralDomainObject gdo);
    }
}
