using System;
using DbNanites.Core.Scheme;
using DbNanites.Core.Data;

namespace DbNanites.Core
{
	public interface IDefinition
	{
		SchemeDefinition Scheme { get; set; }

		ImportSet Data { get; set; }
	}
}

