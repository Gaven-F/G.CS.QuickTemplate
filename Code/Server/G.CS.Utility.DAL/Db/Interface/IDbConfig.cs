
namespace G.CS.Utility.DAL.Db.Interface;

public interface IDBConfig : IDisposable
{
	string ConnectionString { get; set; }

	string DatabaseName { get; set; }

	string DatabaseType { get; set; }
}