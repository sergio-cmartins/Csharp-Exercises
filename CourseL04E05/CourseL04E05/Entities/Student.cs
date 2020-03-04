namespace CourseL04E05.Entities
{
    class Student
    {
        public string Name { get; set; }
        public double Grade01 { get; set; }
        public double Grade02 { get; set; }
        public double Grade03 { get; set; }

        public double FinalGrade()
        {
            return Grade01 + Grade02 + Grade03;
        }

        public bool Approved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public double MissingGrade()
        {
            if (Approved() == true)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGrade();
            }
        }
    }
}
