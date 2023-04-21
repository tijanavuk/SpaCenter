using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    public class Broker
    {
        SqlCommand command;
        SqlTransaction transaction;
        SqlConnection connection;
        public static Broker instance;
        SqlDataReader reader;

        public void Connect() {
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SpaIWellness;Integrated Security=True");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            Connect();
        }

        public static Broker ReturnSession() {

            if (instance == null) instance = new Broker();
            return instance;
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri otvaranju baze!");
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }

        public void BeginTransaction()
        {
            try
            {
                transaction = connection.BeginTransaction();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zapocinjanju transakcije!");
            }
        }

        public void CommitTransaction()
        {
            try
            {
                transaction.Commit();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri komitovanju transakcije!");
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                transaction.Rollback();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri ponistavanju transakcije!");
            }
        }

        public int ReturnNumber(GeneralDomainObject gdo)
        {
            string query = "Select max(" + gdo.ReturnKey() + ") from " + gdo.ReturnTableName();
            command = new SqlCommand(query, connection, transaction);
            try
            {
                int number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch (Exception)
            {

                return 1;
            }
        }

        public List<GeneralDomainObject> ReturnAll(GeneralDomainObject gdo)
        {
            List<GeneralDomainObject> list = new List<GeneralDomainObject>();
            try
            {
                string query = "Select * from " + gdo.ReturnTableName() + " where Active = 1";
                command = new SqlCommand(query, connection, transaction);
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    list.Add(gdo.ReadTableRow(row));
                }
                reader.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //reader.Close();
                //throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public List<GeneralDomainObject> ReturnForCondition(GeneralDomainObject gdo)
        {
            List<GeneralDomainObject> list = new List<GeneralDomainObject>();
            try
            {
                string query = "Select * from " + gdo.ReturnTableName() + " where Active = 1 and " + gdo.ReturnCondition();
                command = new SqlCommand(query, connection, transaction);
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    list.Add(gdo.ReadTableRow(row));
                }
                reader.Close();
                return list;    
            }
            catch (Exception)
            {
                //reader.Close();
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public List<GeneralDomainObject> ReturnForConditionMore(GeneralDomainObject gdo)
        {
            List<GeneralDomainObject> list = new List<GeneralDomainObject>();
            try
            {
                string query = "Select * from " + gdo.ReturnTableName() + " where Active = 1 and " + gdo.ReturnConditionMore();
                command = new SqlCommand(query, connection, transaction);
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    list.Add(gdo.ReadTableRow(row));
                }
                reader.Close();
                return list;
            }
            catch (Exception)
            {
                //reader.Close();
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public GeneralDomainObject ReturnOneForID(GeneralDomainObject gdo)
        {
            try
            {
                string query = "Select * from " + gdo.ReturnTableName() + " where Active = 1 and " + gdo.ReturnCoditionID();
                command = new SqlCommand(query, connection, transaction);
                reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                reader.Close();

                if (table.Rows.Count == 0) return null;
                else return gdo.ReadTableRow(table.Rows[0]);

            }
            catch (Exception)
            {
                throw new Exception("Greska pri vracanju objekta!");
            }

        }

        public List<GeneralDomainObject> ReturnForConditionWithJoin(GeneralDomainObject gdo)
        {
            List<GeneralDomainObject> list = new List<GeneralDomainObject>();
            try
            {
                string query = "Select * from " + gdo.ReturnTableNameForJoin() + " left join "+gdo.ReturnConditionForJoin()+" where " + gdo.ReturnCoditionForWhereInJoin();
                command = new SqlCommand(query, connection, transaction);
                SqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                foreach (DataRow row in table.Rows)
                {
                    list.Add(gdo.ReadTableRow(row));
                }
                reader.Close();
                return list;
            }
            catch (Exception)
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        public int Save(GeneralDomainObject gdo)
        {
            string query = "insert into " + gdo.ReturnTableName() + "" + gdo.ValueForInsert();
            SqlCommand command = new SqlCommand(query, connection, transaction);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public object Delete(GeneralDomainObject gdo)
        {
            string query = "DELETE *" + " FROM " + gdo.ReturnTableName() + " WHERE " + gdo.ReturnCondition();
            SqlCommand command = new SqlCommand(query, connection, transaction);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public object Update(GeneralDomainObject gdo)
        {
            string query = "UPDATE " + gdo.ReturnTableName() + " SET " + gdo.ValueForUpdate() + " WHERE " + gdo.ReturnCoditionID();
            SqlCommand command = new SqlCommand(query, connection, transaction);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

    }
}
