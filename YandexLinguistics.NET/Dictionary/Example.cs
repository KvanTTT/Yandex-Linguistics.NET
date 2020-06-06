using RestSharp.Deserializers;
using System.Collections.Generic;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Ex
	{
		[DeserializeAs(Attribute = false)] public string Text { get; set; }

		public List<Tr> Translations { get; set; }

		public Ex()
		{
		}

		public void ToString(StringBuilder builder, int level, bool formatting, string indent)
		{
			for (int i = 0; i < level; i++)
				builder.Append(indent);

			if (Translations != null && Translations.Count != 0)
				foreach (var tr in Translations)
					tr.ToString(builder, level + 1, formatting, indent);
		}
	}
}
