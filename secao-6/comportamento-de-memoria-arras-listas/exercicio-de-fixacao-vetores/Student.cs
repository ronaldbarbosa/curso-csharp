namespace exercicio_de_fixacao_vetores
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}