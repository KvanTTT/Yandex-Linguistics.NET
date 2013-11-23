using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class DicResult
	{
		public List<Def> Definitions
		{
			get;
			set;
		}

		public DicResult()
		{
		}

		public string ToString(bool formatting, string indent)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < Definitions.Count; i++)
			{
				builder.Append((i + 1) + ". ");
				Definitions[i].ToString(builder, formatting, indent);
			}

			return builder.ToString();
		}

		public override string ToString()
		{
			return ToString(false, "    ");
		}
	}
}
