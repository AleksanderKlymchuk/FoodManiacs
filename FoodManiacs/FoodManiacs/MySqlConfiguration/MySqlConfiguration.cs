using System.Data.Entity;
 
namespace FoodManiacs.Models
{
  public class MySqlConfiguration : DbConfiguration
  {
    public MySqlConfiguration()
    {
      SetHistoryContext(
      "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
    }
  }
}