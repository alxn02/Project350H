public class StudentGroup
{

    private List<String> GroupContainer;
    private int numStudents;
    private String GroupName;

    public StudentGroup(String TeamName, int sizeGroup)
    {
        GroupName = TeamName;
        numStudents=sizeGroup;
        GroupContainer = new List<String>(sizeGroup);
    }
    public void AddStudent(string StudName)
    {
        GroupContainer.Add(StudName);
    }
    public void StudentList()
    {
        foreach (String student in GroupContainer)
        {
            Console.WriteLine(student);
        }
    }
            //+ StudentSize() : int
            //+ NameofGroup() : string
            //+ StudentPositionName(int) : string

    public int StudentSize()
    {
        return GroupContainer.Count;
    }
    
    public string NameofGroup()
    {
        return GroupName;
    }

    public string StudentPositionName(int position)
    {
        if (position >= 0 && position < GroupContainer.Count)
        {
            return GroupContainer[position];
        }
        else
        {
            return "Invalid position";
        }
    }

}
class Program
{
    static void Main()
    {
        //Make students groups and stuff here
        StudentGroup group1 = new StudentGroup("Team alpha", 3);
        group1.AddStudent("Maria");
        group1.AddStudent("James");
        group1.AddStudent("Cheryl");

        Console.WriteLine("Group name: " + group1.NameofGroup());
        Console.WriteLine("Group size: " + group1.StudentSize());

        Console.WriteLine("Student at position 1: " + group1.StudentPositionName(1));
        Console.WriteLine("Student at position 5: " + group1.StudentPositionName(5));

        Console.WriteLine("\nAll Students:");
        group1.StudentList();
    }
}
