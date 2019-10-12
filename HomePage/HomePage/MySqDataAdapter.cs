using System.Data.SqlClient;

namespace HomePage
{
    internal class MySqDataAdapter
    {
        private string query;
        private SqlConnection cons;

        public MySqDataAdapter(string query, SqlConnection cons)
        {
            this.query = query;
            this.cons = cons;
        }
    }
}