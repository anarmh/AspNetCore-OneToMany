namespace FrontToBack.Models
{
    public class Testimonial:BaseEntity
    {
        public string Description { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Position { get; set; }
    }
}
