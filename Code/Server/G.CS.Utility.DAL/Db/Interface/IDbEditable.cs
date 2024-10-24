using G.CS.Utility.DAL.Entity.Interface;

namespace G.CS.Utility.DAL.Db.Interface;

public interface IDbEditable
{
	void Delete(string entityId);

	void Delete(IList<string> entitiyIds);

	void Insert<TEntity>(TEntity entity) where TEntity : class, IEId;

	void Insert<TEntity>(IList<TEntity> entities) where TEntity : class, IEId;

	void Update<TEntity>(TEntity entity) where TEntity : class, IEId;

	void Update<TEntity>(IList<TEntity> entities) where TEntity : class, IEId;
}
