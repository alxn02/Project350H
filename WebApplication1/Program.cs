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

}
class Program
{
    static void Main()
    {
        //Make students groups and stuff here
    }
}