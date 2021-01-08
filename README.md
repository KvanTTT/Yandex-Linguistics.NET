# Yandex Linguistics API .NET

## Currently implemented API

* [Yandex.Predictor](http://api.yandex.ru/predictor/)
* [Yandex.Dictionary](http://api.yandex.ru/dictionary/)
* [Yandex.Translate](http://api.yandex.ru/translate/)
* [Yandex.Speller](http://api.yandex.ru/speller/)

## Using

```csharp
// Create service object (predictor, dictionary, translator or speller) with an app key
var translator = new TranslatorService("xxx");

// Use async api call
var translation = translator.TranslateAsync("Семь раз отмерь, один раз отрежь",
  new LangPair(Lang.None, Lang.En), null, true).Result;

// Results are the following:
// translation.LangPair = LangPair.RuEn
// translation.Detected.Lang = Lang.Ru
// translation.Text = "Seven times, cut once"
```

One can use these API with default app keys or get them on this page: <https://yandex.com/dev/dictionary/keys/get/>

All API are covered with tests in YandexLinguistics.NET.Tests.

## License

Yandex-Linguistics.NET is licensed under the Apache 2.0 License.
