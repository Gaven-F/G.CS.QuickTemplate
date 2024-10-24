using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.CS.Utility.DAL.Entity.Interface;

public interface IETimeInfo
{
	DateTimeOffset CreateTime { get; set; }

	DateTimeOffset UpdateTime { get; set; }
}
