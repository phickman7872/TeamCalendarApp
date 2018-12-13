namespace TeamCalendarApp.Models
{
    public class Department : TrackableObject
    {
        public int DepartmentId { get; set; }
        public int ManagerId { get; set; }
        public string Name { get; set; }
    }
}
