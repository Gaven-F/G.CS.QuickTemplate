using G.CS.Utility.DAL.Db.Interface;

using System.Data;

namespace G.CS.Utility.DAL.EFCore;

public class DbConfig : IDBConfig
{
	public void Dispose()
	{
		throw new NotImplementedException();
	}

	public string ConnectionString
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}
	public int ConnectionTimeout => throw new NotImplementedException();

	public string DatabaseName
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}
	public ConnectionState DatabaseState => throw new NotImplementedException();

	public string DatabaseType
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}
}
