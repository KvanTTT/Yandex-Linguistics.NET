using RestSharp.Deserializers;
using System.Collections.Generic;
using System.Text;

namespace YandexLinguistics.NET
{
	public class Tr
	{
		[DeserializeAs(Attribute = false)]
		public string Text
		{
			get;
			set;
		}

		[DeserializeAs(Name = "pos")]
		public string PartOfSpeech
		{
			get;
			set;
		}

		public List<Syn> Synonyms
		{
			get;
			set;
		}

		public List<Mean> Meanings
		{
			get;
			set;
		}

		public List<Ex> Examples
		{
			get;
			set;
		}

		public Tr()
		{
		}

		public void ToString(StringBuilder builder, int level, bool formatting, string indent)
		{
			for (int i = 0; i < level; i++)
				builder.Append(indent);
			builder.Append("Translation: " + Text);
			if (!string.IsNullOrEmpty(PartOfSpeech))
				builder.Append("; PartOfSpeech: " + PartOfSpeech);
			builder.AppendLine();
			
			if (Synonyms != null && Synonyms.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Synonyms: ");
				for (int i = 0; i < Synonyms.Count; i++)
				{
					builder.Append(Synonyms[i].Text);
					if (i != Synonyms.Count - 1)
						builder.Append(", ");
					else
						builder.Append('.');
				}
				builder.AppendLine();
			}

			if (Meanings != null && Meanings.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Meanings: ");
				for (int i = 0; i < Meanings.Count; i++)
				{
					builder.Append(Meanings[i].Text);
					if (i != Meanings.Count - 1)
						builder.Append(", ");
					else
						builder.Append('.');
				}
				builder.AppendLine();
			}

			if (Examples != null && Examples.Count > 0)
			{
				for (int i = 0; i < level + 1; i++)
					builder.Append(indent);
				builder.Append("Examples: ");
				builder.AppendLine();
				for (int i = 0; i < Examples.Count; i++)
					Examples[i].ToString(builder, level, formatting, indent);
			}
		}
	}
}
