namespace StudentManagement.Models
{
    public class StudentStoreDatabaseSettings : iStudentStoreDatabaseSettings
    {
        public string StudentCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty; 
    }
}
