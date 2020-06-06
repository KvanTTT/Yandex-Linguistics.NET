namespace YandexLinguistics.NET
{
	public readonly struct Mistake
	{
		public readonly int Position;
		public readonly CharMistakeType Type;

		public Mistake(int position, CharMistakeType type)
		{
			Position = position;
			Type = type;
		}

		public override string ToString() => Position + ", " + Type;
	}
}
