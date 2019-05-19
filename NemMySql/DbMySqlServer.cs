using MySql.Data.MySqlClient;
using NemDbCore;

namespace NemMySql {
  public class DbMySqlServer : DbBase<MySqlCommand, MySqlConnection, MySqlDataReader, DbMySqlServerSettings> {
    public DbMySqlServer() : base() { }
    public DbMySqlServer(DbMySqlServerSettings settings) : base(settings) {
    }

    public override MySqlConnection GetConnection(DbMySqlServerSettings settings) {
      MySqlConnection connection;
      if (settings.SecurePassword != null) {
        connection = new MySqlConnection(settings.GetConnectionStringWithPassword());
      } else {
        connection = new MySqlConnection(settings.ConnectionString);
      }

      return connection;
    }

  }
}
