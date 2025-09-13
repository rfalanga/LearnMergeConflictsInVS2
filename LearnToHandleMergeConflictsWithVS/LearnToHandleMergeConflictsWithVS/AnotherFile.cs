namespace LearnToHandleMergeConflictsWithVS
{
    internal class AnotherFile
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;   // I want to keep this change, and remove the other one from the child branch
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
