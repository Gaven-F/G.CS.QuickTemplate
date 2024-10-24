using G.CS.Utility.DAL.Entity.Interface;

namespace G.CS.Utility.DAL.Db.Interface;

public interface IDbQueryable
{
	IEnumerable<TEntity> GetEntities<TEntity>(Predicate<TEntity>? predicate = default)
		where TEntity : class, IEId;
}
