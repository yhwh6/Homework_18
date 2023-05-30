namespace Homework_18.Models
{
    internal class NullClass : Animal, IClass
    {
        public NullClass()
        {
            ClassName = "This class doesn't exist";
            ClassDescription = "Description for non existing class";
        }
        public IClass GetClass()
        {
            NullClass animal = this;
            return animal;
        }
    }
}
