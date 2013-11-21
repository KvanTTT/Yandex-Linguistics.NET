using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	[Flags]
	public enum LookupOptions
	{
		Family = 0x0001,
		Morpho = 0x0004,
		PosFilter = 0x0008
	}
}
