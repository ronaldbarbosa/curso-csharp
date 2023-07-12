HashSet<int> courseA = new HashSet<int>();
HashSet<int> courseB = new HashSet<int>();
HashSet<int> courseC = new HashSet<int>();

Console.Write("How many students for course A? ");
int numberCourseA = int.Parse(Console.ReadLine());
for  (int i = 0; i < numberCourseA; i++)
{
    int studentNumber = int.Parse(Console.ReadLine());
    courseA.Add(studentNumber);
}

Console.Write("How many students for course B? ");
int numberCourseB = int.Parse(Console.ReadLine());
for (int i = 0; i < numberCourseB; i++)
{
    int studentNumber = int.Parse(Console.ReadLine());
    courseB.Add(studentNumber);
}

Console.Write("How many students for course C? ");
int numberCourseC = int.Parse(Console.ReadLine());
for (int i = 0; i < numberCourseC; i++)
{
    int studentNumber = int.Parse(Console.ReadLine());
    courseC.Add(studentNumber);
}

Console.WriteLine($"Total students: {courseA.Union(courseB.Union(courseC)).Count()}");