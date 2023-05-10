namespace FrontToBack.Models
{
    public class AboutInfos:BaseEntity
    {
        public string Icon { get; set; }
        public string TitleInfo { get; set; }
        public string DescriptionInfo { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
