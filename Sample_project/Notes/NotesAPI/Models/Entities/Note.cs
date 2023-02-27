namespace NotesAPI.Models.Entities
{
    public class Note
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public string Description { get; set; } 

        public bool isVisible { get; set; }

    }
}
