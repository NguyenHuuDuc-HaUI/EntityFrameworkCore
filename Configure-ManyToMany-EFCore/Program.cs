namespace Configure_ManyToMany_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                //creates db if not exists 
                context.Database.EnsureCreated();

                //create entity objects
                var st1 = new Student() { Name = "Duc" };
                var co1 = new Course() { CourseName = "Training NET", Description = "FPT Software" };
                var sc1 = new StudentCourse() { Student = st1, Course = co1 };

                //add entitiy to the context
                context.StudentCourses.Add(sc1);

                //save data to the database tables
                context.SaveChanges();

                //var vd1 = context.Courses.Find(1);
                //context.Courses.Remove(vd1);
                //context.SaveChanges();

                //retrieve all the students from the database
                foreach (var s in context.Students)
                {
                    Console.WriteLine($"Student Name: {s.Name}");
                }
                foreach (var s in context.Courses)
                {
                    Console.WriteLine($"Course Name: {s.CourseName}, Description: {s.Description}");
                }
            }
        }
    }
}
