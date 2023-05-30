using Homework_18.Models;
using System.Collections.Generic;

namespace Homework_18.Services
{
    internal class DataBaseTest : IDbLoad
    {
        public void Load(DataBase dataBase, string fileName)
        {
            IAnimalCreator animalCreator = new Creator();
            Animal.SetLastID(0);

            var cat = animalCreator.Create<Mammal>("Cat", "Schrödinger's cat");
            var salamander = animalCreator.Create<Amphibian>("Salamander", "Newt");
            var crow = animalCreator.Create<Bird>("Crow", "Black");
            var cheburashka = animalCreator.Create<NullClass>("Cheburashka", "What are you?");

            List<IClass> animals = new List<IClass>
            {
                cat,
                salamander,
                crow,
                cheburashka
            };

            dataBase.Animals = animals;
        }
    }
}
