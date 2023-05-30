namespace Homework_18.Models
{
    internal abstract class Animal : IAnimal
    {
        private static int lastID;

        public int ID { get; private set; }
        public string SpeciesName { get; set; }
        public string SpeciesDescription { get; set; }
        public string? ClassName { get; set; }
        public string? ClassDescription { get; set; }
        public bool IsClassAppointed { get; protected set; }
        public bool IsSpeciesAppointed { get; protected set; }
        

        public Animal()
        {
            IsClassAppointed = false;
            IsSpeciesAppointed = false;
        }

        public static void SetLastID(int id)
        {
            lastID = id;
        }

        public static int GetLastID()
        {
            return lastID;
        }

        public void CreateNewAnimal(string speciesName, string speciesDescription)
        {
            SpeciesName = speciesName;
            SpeciesDescription = speciesDescription;
            ID = lastID + 1;
            lastID = ID;
        }

        public void SetSpeciesAppointed(bool isAppointed = false)
        {
            IsSpeciesAppointed = isAppointed;
        }

        public override string ToString()
        {
            string categoryName, speciesName, speciesDescription;
            if (IsClassAppointed)
                categoryName = $"Class: {ClassName}";
            else
                categoryName = $"{ClassName}";

            if (IsSpeciesAppointed)
                speciesName = $"Species: {SpeciesName}";
            else
                speciesName = $"{SpeciesName}";

            if (!string.IsNullOrEmpty(SpeciesDescription))
                speciesDescription = $"Species description: {SpeciesDescription}.";
            else
                speciesDescription = "Empty";

            string str = $"Animal ID: {ID}, {categoryName}, {speciesName}{speciesDescription}";
            return str;
        }
    }
}