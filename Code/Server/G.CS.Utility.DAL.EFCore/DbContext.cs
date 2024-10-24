using G.CS.Utility.DAL.Db.Interface;

namespace G.CS.Utility.DAL.EFCore;

class DbContext : IDbContext
{
	IDbConnection IDbContext.DbConnection
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}

	void IDbEditable.Delete(string entityId)
	{
		throw new NotImplementedException();
	}

	void IDbEditable.Delete(IList<string> entitiyIds)
	{
		throw new NotImplementedException();
	}

	void IDbEditable.Insert<TEntity>(TEntity entity)
	{
		throw new NotImplementedException();
	}

	void IDbEditable.Insert<TEntity>(IList<TEntity> entities)
	{
		throw new NotImplementedException();
	}

	void IDbEditable.Update<TEntity>(TEntity entity)
	{
		throw new NotImplementedException();
	}

	void IDbEditable.Update<TEntity>(IList<TEntity> entities)
	{
		throw new NotImplementedException();
	}

	IEnumerable<TEntity> IDbQueryable.GetEntities<TEntity>(Predicate<TEntity>? predicate)
	{
		throw new NotImplementedException();
	}
}
