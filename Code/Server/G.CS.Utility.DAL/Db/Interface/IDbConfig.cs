
using System.Data;

namespace G.CS.Utility.DAL.Db.Interface;

public interface IDBConfig : IDisposable
{
	string ConnectionString { get; set; }

	int ConnectionTimeout { get; set; }

	string DatabaseName { get; set; }

	ConnectionState DatabaseState { get; set; }

	string DatabaseType { get; set; }
}
