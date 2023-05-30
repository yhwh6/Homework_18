namespace Homework_18.Models
{
    internal class Amphibian : Animal, IClass
    {
        public Amphibian()
        {
            ClassName = "Amphibian";
            ClassDescription = "Can live in water and on the land";
            IsClassAppointed = true;
        }
        public IClass GetClass()
        {
            Amphibian animal = this;
            return animal;
        }
    }
}
