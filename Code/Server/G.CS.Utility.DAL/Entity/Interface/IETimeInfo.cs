
using System;
using System.Linq;

namespace G.CS.Utility.DAL.Entity.Interface;

public interface IETimeInfo
{
	DateTimeOffset CreateTime { get; set; }

	DateTimeOffset UpdateTime { get; set; }
}
