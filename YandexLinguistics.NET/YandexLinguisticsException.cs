using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public class YandexLinguisticsException : Exception
	{
		public readonly int Code;
		public readonly string Message;

		public YandexLinguisticsException(Error error)
		{
			Code = error.Code;
			Message = error.Message;
		}

		public YandexLinguisticsException(int code, string message)
		{
			Code = code;
			Message = message;
		}

		public override string ToString()
		{
			return string.Format("code={0} message={1}", Code, Message);
		}
	}
}
