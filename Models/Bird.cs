namespace Homework_18.Models
{
    internal class Bird : Animal, IClass
    {
        public Bird()
        {
            ClassName = "Bird";
            ClassDescription = "Are a group of warm-blooded vertebrates";
            IsClassAppointed = true;
        }
        public IClass GetClass()
        {
            Bird animal = this;
            return animal;
        }
    }
}
