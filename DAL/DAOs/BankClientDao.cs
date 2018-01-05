using DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOs
{
    public class BankClientDao : IDAO<BankClientDto>
    {
        private SqlConnection sqlConnection = null;
        public void Create(BankClientDto t)
        {
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "InsertNewBankClient";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter idParam = new SqlParameter("Id", SqlDbType.NVarChar);
                    idParam.Value = t.Id;
                    SqlParameter emailParam = new SqlParameter("Email", SqlDbType.VarChar);
                    emailParam.Value = t.Email;
                    SqlParameter firstNameParam = new SqlParameter("FirstName", SqlDbType.VarChar);
                    firstNameParam.Value = t.FirstName;
                    SqlParameter lastNameParam = new SqlParameter("LastName", SqlDbType.VarChar);
                    lastNameParam.Value = t.LastName;
                    SqlParameter accountNumberParam = new SqlParameter("AccountNumber", SqlDbType.VarChar);
                    accountNumberParam.Value = t.AccountNumber;

                    sqlCommand.Parameters.Add(idParam);
                    sqlCommand.Parameters.Add(emailParam);
                    sqlCommand.Parameters.Add(firstNameParam);
                    sqlCommand.Parameters.Add(lastNameParam);
                    sqlCommand.Parameters.Add(accountNumberParam);

                    int result = sqlCommand.ExecuteNonQuery();

                }
                sqlConnection.Close();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BankClientDto Read(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<BankClientDto> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(BankClientDto t)
        {
            throw new NotImplementedException();
        }
    }
}
