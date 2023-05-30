using Homework_18.Models;

namespace Homework_18.Services
{
    internal class Creator : IAnimalCreator
    {
        public IClass Create<T>(string speciesName, string speciesDescription = "")
            where T : class, IClass, new()
        {
            bool isSpeciesAppointed = !string.IsNullOrEmpty(speciesName);
            speciesName ??= "This species doesn't exist";
            speciesDescription ??= "Description for non existing species";


            T animal = new();
            animal.CreateNewAnimal(speciesName, speciesDescription);
            animal.SetSpeciesAppointed(isSpeciesAppointed);

            return animal;
        }
    }
}
