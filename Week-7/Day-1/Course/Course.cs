namespace Course
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public bool Status { get; set; }
    }
}

/*
*    List<Course> courses = new List<Course>()
*    {
*       new Course(){Id=1, Name="C#", Duration=40, Status=true},
*       new Course(){Id=2, Name="ASP.NET", Duration=30, Status=true},
*       new Course(){Id=3, Name="SQL", Duration=20, Status=false},
*    }
*/

