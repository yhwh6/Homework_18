namespace Homework_18.Models
{
    internal class Mammal : Animal, IClass
    {
        public Mammal()
        {
            ClassName = "Mammal";
            ClassDescription = "They have milk-producing mammary glands for feeding their young";
            IsClassAppointed = true;
        }
        public IClass GetClass()
        {
            Mammal animal = this;
            return animal;
        }
    }
}