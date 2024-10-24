namespace G.CS.Utility.DAL.Db.Interface;

public interface IDBConfig : IDisposable
{
	string DatabaseName { get; set; }

	string DatabaseType { get; set; }

	string ConnectionString { get; set; }
}