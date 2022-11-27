namespace AdoNetWindow.Model
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }

        public override String ToString()
        {
            return $"[{StudentId}]{StudentName}({Address})";
        }

    }

    
}