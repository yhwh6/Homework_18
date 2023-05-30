using System.Collections.Generic;
using System.Text;
using Homework_18.Models;

namespace Homework_18.Services
{
    internal class DataBase
    {
        public List<IClass> Animals { get; set; }

        public DataBase()
        {
            Animals = new List<IClass>();
        }

        public void SaveData(IDbSave dataSave, string fileName)
        {
            dataSave.Save(this, fileName);
        }

        public void LoadData(IDbLoad dataLoad, string fileName)
        {
            dataLoad.Load(this, fileName);
        }

        public int GetLastID()
        {
            if (Animals.Count > 0)
            {
                IAnimal lastAnimal = Animals[Animals.Count - 1];
                if (lastAnimal != null)
                    return lastAnimal.ID;
            }

            return 0;
        }

        public override string ToString()
        {
            const int MaxSigns = 10;
            int count = Animals.Count < MaxSigns ? Animals.Count : MaxSigns;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringBuilder.AppendLine(Animals[i].ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
