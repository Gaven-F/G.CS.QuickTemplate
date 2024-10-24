
using G.CS.Utility.DAL.Entity.Interface;

namespace G.CS.Utility.DAL.Entity;

public static class EntityExtension
{
	public static bool IsEntity(this Type type) => !type.IsAbstract &&
		!type.IsInterface &&
		type.GetInterface(nameof(IEId)) is not null;

	public static bool IsEntity<T>(this T entity)
	{
		if (entity == null)
		{
			return false;
		}
		return entity.GetType().IsEntity();
	}
}
