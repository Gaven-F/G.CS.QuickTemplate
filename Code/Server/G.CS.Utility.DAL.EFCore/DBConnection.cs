using G.CS.Utility.DAL.Db.Interface;

using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace G.CS.Utility.DAL.EFCore;

class DBConnection(IDBConfig dbConfig) : System.Data.IDbConnection
{
	public IDbTransaction BeginTransaction()
	{
		throw new NotImplementedException();
	}

	public IDbTransaction BeginTransaction(IsolationLevel il = default)
	{
		throw new NotImplementedException();
	}

	public void ChangeDatabase(string databaseName)
	{
		throw new NotImplementedException();
	}

	public void Close()
	{
		throw new NotImplementedException();
	}

	public IDbCommand CreateCommand()
	{
		throw new NotImplementedException();
	}

	public void Dispose()
	{
		throw new NotImplementedException();
	}

	public void Open()
	{
		throw new NotImplementedException();
	}

	[AllowNull]
	public string ConnectionString
	{
		get => DbConfig.ConnectionString;
		set => DbConfig.ConnectionString = value ?? DbConfig.ConnectionString;
	}

	public int ConnectionTimeout => DbConfig.ConnectionTimeout;

	public string Database => DbConfig.DatabaseName;

	public IDBConfig DbConfig { get; set; } = dbConfig;

	public ConnectionState State => DbConfig.DatabaseState;
}
