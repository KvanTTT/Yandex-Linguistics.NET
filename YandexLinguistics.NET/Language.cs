using System.Text.Json.Serialization;

namespace YandexLinguistics.NET
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum Language
	{
		None = 0,

		Ru,
		En,
		Pl,
		Uk,
		De,
		Fr,
		Es,
		It,
		Tr,

		Az,
		Be,
		Bg,
		Cs,
		Ro,
		Sr,
		Ca,
		Da,
		El,
		Et,
		Fi,
		Hu,
		Lt,
		Lv,
		Mhr,
		Mk,
		Mrj,
		Nl,
		No,
		Pt,
		Sk,
		Sl,
		Sq,
		Sv,
		Tt,
		Hr,
		Hy,
		Zh
	}
}
