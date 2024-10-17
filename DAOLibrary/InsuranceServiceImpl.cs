using EntityLibrary;
using ExceptionLibrary;
using Microsoft.Data.SqlClient;

namespace DAOLibrary
{
    public class InsuranceServiceImpl : IPolicyService
    {
        private SqlConnection sqlConnection = UtilLibrary.DBConnection.GetConnectionString();

        public InsuranceServiceImpl()
        {
            sqlConnection.Open();
        }

        public bool CreatePolicy(Policy policy)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Policies (PolicyNumber) VALUES (@PolicyNumber)", sqlConnection))
            {
                command.Parameters.AddWithValue("@PolicyNumber", policy.PolicyNumber);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public Policy GetPolicy(int policyId)
        {
            using (SqlCommand command = new SqlCommand("SELECT PolicyId, PolicyNumber FROM Policies WHERE PolicyId = @PolicyId", sqlConnection))
            {
                command.Parameters.AddWithValue("@PolicyId", policyId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Policy
                        {
                            PolicyID = (int)reader["PolicyId"],
                            PolicyNumber = reader["PolicyNumber"].ToString()
                        };
                    }
                }
            }

            throw new PolicyNotFoundException($"Policy with ID {policyId} not found.");
        }

        public List<Policy> GetAllPolicies()
        {
            List<Policy> policies = new List<Policy>();
            using (SqlCommand command = new SqlCommand("SELECT PolicyId, PolicyNumber FROM Policies", sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        policies.Add(new Policy
                        {
                            PolicyID = (int)reader["PolicyId"],
                            PolicyNumber = reader["PolicyNumber"].ToString()
                        });
                    }
                }
            }
            return policies;
        }

        public bool UpdatePolicy(Policy policy)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Policies SET PolicyNumber = @PolicyNumber WHERE PolicyId = @PolicyId", sqlConnection))
            {
                command.Parameters.AddWithValue("@PolicyId", policy.PolicyID);
                command.Parameters.AddWithValue("@PolicyNumber", policy.PolicyNumber);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool DeletePolicy(int policyId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Policies WHERE PolicyId = @PolicyId", sqlConnection))
            {
                command.Parameters.AddWithValue("@PolicyId", policyId);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}
