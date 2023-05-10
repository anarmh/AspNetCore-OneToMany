using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public int Id { get; set; }
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
        public List<Project> Projects { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
