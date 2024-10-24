namespace G.CS.Utility.DAL.Db.Interface;

public interface IDbConnection
{
	IDBConfig IDBConfig { get; set; }

	void Open();

	void Close();

}
