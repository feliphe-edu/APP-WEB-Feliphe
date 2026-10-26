using MySql.Data.MySqlClient;

namespace AppWebExemplo.Configs
{
    public static class DAOHelper
    {
        // Lê um texto. Se o valor for NULL, retorna uma string vazia.
        public static string GetString(MySqlDataReader reader, string column_name)
        {
            string text = string.Empty;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
            {
                text = reader.GetString(column_name);
            }

            return text;
        }

        // Lê um número double. Se o valor for NULL, retorna 0.
        public static double GetDouble(MySqlDataReader reader, string column_name)
        {
            double value = 0.0;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
            {
                value = reader.GetDouble(column_name);
            }

            return value;
        }

        // Lê uma data. Se o valor for NULL, retorna null.
        public static DateTime? GetDateTime(MySqlDataReader reader, string column_name)
        {
            DateTime? value = null;

            if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
            {
                value = reader.GetDateTime(column_name);
            }

            return value;
        }

        // Verifica se uma coluna contém NULL.
        public static bool IsNull(MySqlDataReader reader, string column_name)
        {
            return reader.IsDBNull(reader.GetOrdinal(column_name));
        }
    }
}