using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinMarketCap.NetStandard.Options
{
    public class DictionaryConverter<TKey, TValue> : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<TKey, TValue> result;

            if (reader.TokenType == JsonToken.StartArray)
            {
                JArray legacyArray = (JArray) JArray.ReadFrom(reader);

                result = legacyArray.ToDictionary(el => el["Key"].ToObject<TKey>(), el => el["Value"].ToObject<TValue>() );
            }
            else
            {
                result = (Dictionary<TKey, TValue>)  serializer.Deserialize(reader, typeof(IDictionary<TKey, TValue>));
            }

            return result;
        }

        public override void WriteJson(
            JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            // Uncomment when I find a dynamic solution to evaluate only property
            var result = typeof(IDictionary<TKey, TValue>).IsAssignableFrom(objectType);
            return typeof(IDictionary<TKey, TValue>).IsAssignableFrom(objectType);
            //return true;
        }

        public override bool CanWrite
        {
            get { return false; }
        }
    }
}
