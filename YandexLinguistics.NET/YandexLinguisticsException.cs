using System;

namespace YandexLinguistics.NET
{
	public class YandexLinguisticsException : Exception
	{
		public readonly int Code;

		public YandexLinguisticsException(YandexError error)
			: base(error.Message)
		{
			Code = error.Code;
		}

		public YandexLinguisticsException(int code, string message)
			: base(message)
		{
			Code = code;
		}

		public override string ToString()
		{
			return string.Format("code={0} message={1}", Code, Message);
		}
	}
}
