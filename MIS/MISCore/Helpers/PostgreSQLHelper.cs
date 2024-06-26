using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MIS.Helpers
{
    public class PostgreSQLHelper
    {
        private static PostgreSQLHelper instance;
        private readonly string connectionString;

        private PostgreSQLHelper()
        {
            string host = "";
            string password = "";
            if (false)
            {
                host = "192.168.0.107";
                password = "integration2024";
            } else
            {
                host = "localhost";
                password = "Yeison.2024.";
            }
            
            
            int port = 5432;
            string database = "metrology";
            string username = "postgres";
            connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password};";
        }

        public static PostgreSQLHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new PostgreSQLHelper();
            }
            return instance;
        }

        public async Task<DataTable> ExecuteQueryAsync(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            await Task.Run(() => adapter.Fill(dataTable));
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public object ExecuteScalar(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                object result = command.ExecuteScalar();
                                transaction.Commit(); // Confirmar la transacción si no hubo errores
                                return result;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback en caso de error
                            transaction.Rollback();
                            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                transaction.Commit();
                                return rowsAffected;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }



        public async Task<object> ExecuteScalarAsync(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (NpgsqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                // Ejecutar la consulta y devolver el primer resultado
                                object result = await command.ExecuteScalarAsync();
                                transaction.Commit();
                                return result;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
