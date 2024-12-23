using Course_3sem;

namespace WinFormsCourse_3sem;

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ICinemaService cinemaService = new CinemaService();
            IFilmService filmService = new FilmService();
            IVendorService vendorService = new VendorService();
            IRentService rentService = new RentService();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(cinemaService,filmService,vendorService,rentService));
            
        }
    }