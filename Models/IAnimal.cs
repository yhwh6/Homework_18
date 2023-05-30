namespace Homework_18.Models
{
    internal interface IAnimal
    {
        bool IsClassAppointed { get; }
        bool IsSpeciesAppointed { get; }
        int ID { get; }

        void CreateNewAnimal(string speciesName, string speciesDescription);
        void SetSpeciesAppointed(bool isAppointed);
        string ToString();
    }
}
