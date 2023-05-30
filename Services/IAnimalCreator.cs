using Homework_18.Models;

namespace Homework_18.Services
{
    internal interface IAnimalCreator
    {
        IClass Create<T>(string speciesName, string speciesDescription = "")
            where T : class, IClass, new();
    }
}
