
namespace G.CS.Utility.DAL.Db.Interface;

public interface IDbConnection : System.Data.IDbConnection
{
	IDBConfig DBConfig { get; set; }
}
