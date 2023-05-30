namespace Homework_18.Models
{
    internal interface IClass: IAnimal
    {
        string? ClassName { get; set; }
        string? ClassDescription { get; set; }

        IClass GetClass();
    }
}
