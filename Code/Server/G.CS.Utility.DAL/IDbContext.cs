using G.CS.Utility.DAL.Db.Interface;

namespace G.CS.Utility.DAL;

public interface IDbContext : IDbEditable, IDbQueryable
{
	IDbConnection DbConnection { get; set; }
}
