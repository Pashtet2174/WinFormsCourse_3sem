using Course_3sem;

namespace WinFormsCourse_3sem
{
    public class DataContainer
    {
        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();
        public List<Film> Films { get; set; } = new List<Film>();
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();
        public List<Rent> Rents { get; set; } = new List<Rent>();
    }
}