using Homework_18.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Homework_18.Services
{
    internal class IClassConverter : JsonConverter<IClass>
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;

        public override IClass ReadJson(JsonReader reader, Type objectType, IClass existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            string className = jsonObject["ClassName"]?.Value<string>();

            if (string.IsNullOrEmpty(className))
                throw new JsonSerializationException("ClassName is missing.");

            IClass animal;
            switch (className)
            {
                case "Bird":
                    animal = new Bird();
                    break;
                case "Mammal":
                    animal = new Mammal();
                    break;
                case "Amphibian":
                    animal = new Amphibian();
                    break;
                case "NullClass":
                    animal = new NullClass();
                    break;
                default:
                    throw new JsonSerializationException($"Unknown class: {className}");
            }

            serializer.Populate(jsonObject.CreateReader(), animal);
            return animal;
        }

        public override void WriteJson(JsonWriter writer, IClass value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    internal class JsonDbLoad : IDbLoad
    {
        public void Load(DataBase dataBase, string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                List<IClass> animals = JsonConvert.DeserializeObject<List<IClass>>(json, new IClassConverter());
                dataBase.Animals = animals;
            }
        }
    }
}