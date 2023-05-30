using Newtonsoft.Json;
using System.IO;

namespace Homework_18.Services
{
    internal class JsonDbSave : IDbSave
    {
        public void Save(DataBase dataBase, string fileName)
        {
            string json = JsonConvert.SerializeObject(dataBase.Animals);
            File.WriteAllText(fileName, json);
        }
    }
}
