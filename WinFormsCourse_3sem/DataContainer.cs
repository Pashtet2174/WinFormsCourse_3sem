namespace WinFormsCourse_3sem
{
    public class DataContainer
    {
        public List<Cinema> Cinemas { get; set; }
        public List<Film> Films { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Rent> Rents { get; set; }

        public DataContainer()
        {
            Cinemas = new List<Cinema>();
            Films = new List<Film>();
            Vendors = new List<Vendor>();
            Rents = new List<Rent>();
        }
    }
}