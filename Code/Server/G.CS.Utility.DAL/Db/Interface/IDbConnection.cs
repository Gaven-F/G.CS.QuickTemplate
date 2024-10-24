
namespace G.CS.Utility.DAL.Db.Interface;

public interface IDbConnection
{
	void Close();

	void Open();

	IDBConfig IDBConfig { get; set; }
}
