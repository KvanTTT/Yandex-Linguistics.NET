using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YandexLinguistics.NET.Predictor
{
	public class PredictorService : YandexService
	{
		public static readonly IReadOnlyList<Language> Languages = new []
		{
			Language.Ru,
			Language.En,
			Language.Pl,
			Language.Uk,
			Language.De,
			Language.Fr,
			Language.Es,
			Language.It,
			Language.Tr,
			Language.Az,
			Language.Be,
			Language.Bg,
			Language.Cs,
			Language.Ro,
			Language.Sr,
			Language.Ca,
			Language.Da,
			Language.El,
			Language.Et,
			Language.Fi,
			Language.Hu,
			Language.Lt,
			Language.Lv,
			Language.Mhr,
			Language.Mk,
			Language.Mrj,
			Language.Nl,
			Language.No,
			Language.Pt,
			Language.Sk,
			Language.Sl,
			Language.Sq,
			Language.Sv,
			Language.Tt,
			Language.Hr,
			Language.Hy
		};

		public PredictorService(string predictorKey, string baseUrl = "https://predictor.yandex.net/api/v1/predict.json/")
			: base(predictorKey, baseUrl)
		{
		}

		public async Task<IReadOnlyList<Language>> GetLanguagesAsync()
		{
			var request = CreateRequestBuilder("getLangs");
			var strs = await GetAndDeserializeAsync<List<string>>(request).ConfigureAwait(false);
			var languages = (Language[])Enum.GetValues(typeof(Language));
			Language[] result = languages.Where(lang => strs.Contains(lang.ToString().ToLowerInvariant())).ToArray();
			return result;
		}

		public Task<CompleteResponse> CompleteAsync(Language language, string q, int limit = 1)
		{
			var request = CreateRequestBuilder("complete");
			AddParameter(request, "lang", language.ToString().ToLowerInvariant());
			AddParameter(request, "q", q);
			AddParameter(request, "limit", limit.ToString());

			return GetAndDeserializeAsync<CompleteResponse>(request);
		}
	}
}
