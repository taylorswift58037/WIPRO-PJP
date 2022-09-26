using System;
using System.Collections.Generic;

namespace MOvieTicket
{
    #region ExceptionNamespace
    namespace Exceptions
    {
        public class InvalidScreenCountException : Exception
        {
            public InvalidScreenCountException(string message) : base(message)
            {

            }
        }
        public class InvalidMovieTypeException : Exception
        {
            public InvalidMovieTypeException(string message) : base(message)
            {

            }
        }
    }
    #endregion

    #region RandomClass
    public class RandomGenerator
    {
        public static Random R = new Random();
    }
    #endregion

    #region InterfaceIAdmin
    interface IAdmin
    {
        bool AddTheatre(Theatre obj);
        bool UpdateTheatre(Theatre obj);
        bool AddMovie(Movie obj);
        bool UpdateMovie(Movie obj);
        bool AddShow(Show obj);
        bool UpdateShow(Show obj);
        bool DeleteShow(int ShowID);
        bool AddAgent(User obj);
        List<Theatre> GetAllTheatres();
        List<Movie> GetAllMovies();
        List<Show> GetAllShows();
    }
    #endregion

    #region MovieTicketingClass
    class MovieTicketing
    {
        public static List<User> UserInformation = new List<User>();
        public static List<Theatre> Theatres = new List<Theatre>();
        public static List<Movie> Movies = new List<Movie>();
        public static List<Show> shows = new List<Show>();
        public static List<Booking> Bookings = new List<Booking>();

        public MovieTicketing()
        {
            User user = new User("Admin", "Admin", "Admin");
            UserInformation = new List<User>();
            UserInformation.Add(user);
        }

        public void AdminMenu()
        {
            int choice;
            int BookingID = 0;
            int MovieID = 0;
            int TheatreID = 0;
            int ShowID = 0;
            do
            {
                Console.WriteLine("Which of the following actions would you like to perform?");
                Console.WriteLine("1. Add Theatre\n2. Update Theatre\n3. Add Movie\n4. Update Movie\n5. Add Show\n6. Update Show\n7. Delete Show\n8. Display theatres\n9. Display Movies\n10. Display Shows\n11. Add Agent\n12. Book Ticket\n13. Print Tickets\n14. Exit");
                choice = GetChoice();
                Administrator adm = new Administrator();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Theatre name");
                        string TheatreName = Console.ReadLine();
                        Console.WriteLine("Enter City name");
                        string CityName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter the Number of seats in the theatre");
                        int NumberOfScreens = Convert.ToInt32(Console.ReadLine());
                        Theatre theatre = new Theatre(TheatreName, CityName, Address, NumberOfScreens);
                        TheatreID = theatre.TheatreID;
                        Console.WriteLine();
                        adm.AddTheatre(theatre);
                        break;
                    case 2:
                        Console.WriteLine("Enter Theatre name");
                        string TN = Console.ReadLine();
                        Console.WriteLine("Enter City name");
                        string CN = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string ADD = Console.ReadLine();
                        Console.WriteLine("Enter the Number of seats in the theatre");
                        int NOS = Convert.ToInt32(Console.ReadLine());
                        Theatre TH = new Theatre(TN, CN, ADD, NOS);
                        TheatreID = TH.TheatreID;
                        Console.WriteLine();
                        adm.UpdateTheatre(TH);
                        break;
                    case 3:
                        Console.WriteLine("Enter a movie name");
                        string MovieName = Console.ReadLine();
                        Console.WriteLine("Enter the director name");
                        string Director = Console.ReadLine();
                        Console.WriteLine("Enter the Producers' name");
                        string Producer = Console.ReadLine();
                        Console.WriteLine("Enter the cast of the movie in order of their role weightage");
                        string Cast = Console.ReadLine();
                        Console.WriteLine("Enter the duration of the movie");
                        double Durations = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the story of the movie");
                        string Story = Console.ReadLine();
                        Console.WriteLine("Is the movie 'Upcoming' or 'Running'?");
                        string Type = Console.ReadLine();
                        Movie movie = new Movie(MovieName, Director, Producer, Cast, Durations, Story, Type);
                        MovieID = movie.MovieID;
                        adm.AddMovie(movie);
                        break;
                    case 4:
                        Console.WriteLine("Enter a movie name");
                        string MN = Console.ReadLine();
                        Console.WriteLine("Enter the director name");
                        string DIR = Console.ReadLine();
                        Console.WriteLine("Enter the Producers' name");
                        string PROD = Console.ReadLine();
                        Console.WriteLine("Enter the cast of the movie in order of their role weightage");
                        string CAST = Console.ReadLine();
                        Console.WriteLine("Enter the duration of the movie");
                        double DUR = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the story of the movie");
                        string STORY = Console.ReadLine();
                        Console.WriteLine("Is the movie 'Upcoming' or 'Running'?");
                        string TYPE = Console.ReadLine();
                        Movie mov = new Movie(MN, DIR, PROD, CAST, DUR, STORY, TYPE);
                        MovieID = mov.MovieID;
                        adm.UpdateMovie(mov);
                        break;
                    case 5:
                        string Name;
                        if (Movies.Count >= 2)
                        {
                            Console.WriteLine("Enter the name of the movie for which you want to add show details");
                            Name = Console.ReadLine();
                            for (int i = 0; i < Movies.Count; i++)
                            {
                                var v = Movies[i];
                                if (v.MovieName == Name)
                                {
                                    MovieID = v.MovieID;
                                }
                            }
                        }
                        string City;
                        if (Theatres.Count >= 2)
                        {
                            Console.WriteLine("Enter the name of the Theatre for which you want to add show details");
                            Name = Console.ReadLine();
                            Console.WriteLine("Enter the city of the theatre for which you want to add show details");
                            City = Console.ReadLine();
                            for (int i = 0; i < Movies.Count; i++)
                            {
                                var v = Theatres[i];
                                if (v.TheatreName.Equals(Name, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    TheatreID = v.TheatreID;
                                }
                            }
                        }

                        Console.WriteLine("Enter the date of first show");
                        DateTime StartDate = Convert.ToDateTime(Console.ReadLine());
                        DateTime EndDate = StartDate.AddDays(30);
                        Console.WriteLine("Enter the Platinum Seat Rate for the show");
                        decimal PlatinumSeatRate = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the Gold Seat Rate for the show");
                        decimal GoldSeatRate = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the Silver Seat Rate for the show");
                        decimal SilverSeatRate = Convert.ToDecimal(Console.ReadLine());
                        Screen screen = new Screen();
                        if (MovieID == 0 || TheatreID == 0)
                        {
                            Console.WriteLine("Enter movie and Theatre details before entering Show details");
                            Console.WriteLine();
                            break;
                        }

                        Show show = new Show(MovieID, TheatreID, Screen.ScreenID, StartDate, EndDate, PlatinumSeatRate, GoldSeatRate, SilverSeatRate);
                        ShowID = show.ShowID;
                        adm.AddShow(show);
                        break;
                    case 6:
                        Console.WriteLine("Enter the date of first show");
                        DateTime SD = Convert.ToDateTime(Console.ReadLine());
                        DateTime ED = SD.AddDays(30);
                        Console.WriteLine("Enter the Platinum Seat Rate for the show");
                        decimal PSR = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the Gold Seat Rate for the show");
                        decimal GSR = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter the Silver Seat Rate for the show");
                        decimal SSR = Convert.ToDecimal(Console.ReadLine());
                        Show sh = new Show(MovieID, TheatreID, Screen.ScreenID, SD, ED, PSR, GSR, SSR);
                        adm.UpdateShow(sh);
                        break;
                    case 7:
                        Console.WriteLine("Enter the ShowID of the show which you want to delete");
                        int DelShowID = Convert.ToInt32(Console.ReadLine());
                        adm.DeleteShow(DelShowID);
                        break;
                    case 8:
                        List<Theatre> TheatreList = adm.GetAllTheatres();
                        foreach (var v in TheatreList)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Theatre Name is: {0}", v.TheatreName);
                            Console.WriteLine("City Name is {0}", v.CityName);
                            Console.WriteLine("Address = {0}", v.Address);
                            Console.WriteLine("Number of Screens in the theatre = {0}", v.NumberofScreens);
                            Console.WriteLine();
                        }
                        break;
                    case 9:
                        List<Movie> MovieList = adm.GetAllMovies();
                        foreach (var v in MovieList)
                        {
                            Console.WriteLine("Movie Name is: {0}", v.MovieName);
                            Console.WriteLine("Director of the movie is: {0}", v.Director);
                            Console.WriteLine("Producers' Name is: {0}", v.Producer);
                            Console.WriteLine("Cast of the movie includes : {0}", v.Cast);
                            Console.WriteLine("Story of the movie is: {0}", v.Story);
                            Console.WriteLine("The Movie is {0} mins long", v.Duration);
                            Console.WriteLine("The movie is {0}", v.Type);
                        }
                        break;
                    case 10:
                        List<Show> ShowList = adm.GetAllShows();
                        foreach (var v in ShowList)
                        {
                            Console.WriteLine("Date of the first show is: {0}", v.StartDate);
                            Console.WriteLine("Date of the Last show is: {0}", v.EndDate);
                            Console.WriteLine("Movie ID : {0}", v.MovieID);
                            Console.WriteLine("Screen ID : {0}", v.ScreenID);
                            Console.WriteLine("Show ID : {0}", v.ShowID);
                            Console.WriteLine("Theatre ID : {0}", v.TheatreID);
                            Console.WriteLine("Platinum seat rates are : {0}", v.PlatinumSeatRate);
                            Console.WriteLine("Gold seat rates are : {0}", v.GoldSeatRate);
                            Console.WriteLine("Silver seat rates are : {0}", v.SilverSeatRate);
                        }
                        break;
                    case 11:
                        Console.WriteLine("Enter Username");
                        string Username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string Password = Console.ReadLine();
                        Console.WriteLine("Enter User Type");
                        string UserType = Console.ReadLine();
                        User user = new User(Username, Password, UserType);
                        adm.AddAgent(user);
                        break;
                    case 12:
                        string N;
                        if (Movies.Count >= 2)
                        {
                            Console.WriteLine("Enter the name of the movie for which you want to add show details");
                            N = Console.ReadLine();
                            for (int i = 0; i < Movies.Count; i++)
                            {
                                var v = Movies[i];
                                if (v.MovieName == N)
                                {
                                    MovieID = v.MovieID;
                                }
                            }
                        }
                        string C;
                        if (Theatres.Count >= 2)
                        {
                            Console.WriteLine("Enter the name of the Theatre for which you want to add show details");
                            N = Console.ReadLine();
                            Console.WriteLine("Enter the city of the theatre for which you want to add show details");
                            C = Console.ReadLine();
                            for (int i = 0; i < Movies.Count; i++)
                            {
                                var v = Theatres[i];
                                if (v.TheatreName.Equals(N, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    TheatreID = v.TheatreID;
                                }
                            }
                        }

                        Screen scr = new Screen();
                        Console.WriteLine("Which seat type do you want to book?\nWe offer platinum, gold and silver tier seats");
                        string SeatTier = Console.ReadLine();
                        Console.WriteLine("How many seats would you like");
                        int NumberOfSeats = Convert.ToInt32(Console.ReadLine());

                        int OldLength = Booking.SeatNumbers.Count;
                        for (int i = 0; i < NumberOfSeats; i++)
                        {
                            int k = 0;
                            do
                            {
                                if (scr.Seats[k] == "Vacant")
                                {
                                    scr.Seats[k] = "Reserved";
                                    Booking.SeatNumbers.Add(k);
                                    break;
                                }
                                k++;
                            } while (k < 50);
                        }

                        int NewLength = Booking.SeatNumbers.Count;
                        if (NewLength - OldLength == NumberOfSeats)
                        {
                            Console.WriteLine("{0} {1} Tier seats are available and have been locked for you!\n", NumberOfSeats, SeatTier);
                            Console.WriteLine("List of Reserved and vacant seats is:");
                            int count = 0;
                            for (int x = 0; x < 50; x++)
                            {
                                if (scr.Seats[x].Equals("Reserved", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine("There are {0} Reserved and {1} vacant seats available\n", count, 50 - count);
                            Console.WriteLine("The following seat numbers have been locked for you");
                            for (int h = 0; h < NumberOfSeats; h++)
                            {
                                Console.WriteLine(Booking.SeatNumbers[h]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0} number of seats are not available. Try leaving a friend at home", NumberOfSeats);
                        }

                        Console.WriteLine("Enter your name now.");
                        string CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter your email address now");
                        string Email = Console.ReadLine();
                        Booking booking = new Booking(ShowID, CustomerName, NumberOfSeats, SeatTier, Email);
                        booking.BookingStatus = "Booked";
                        BookingID = booking.BookingID;
                        adm.BookTicket(booking);
                        break;
                    case 13:
                        adm.PrintTicket(BookingID);
                        break;
                    case 14:
                        Environment.Exit(-1);
                        break;

                }
            } while (choice <= 14);
        }

        public void AgentMenu()
        {
            int BookingID = 0;
            int choice;
            string ChosenMovie;
            Administrator adm = new Administrator();

            string MovieName1 = "War";
            string Director1 = "Bassi Paji";
            string Producer1 = "HRK Productions";
            string Cast1 = "HRK, Tiger";
            double Duration1 = 145;
            string Story1 = "Action, Crime";
            string Type1 = "Running";
            Movie movie1 = new Movie(MovieName1, Director1, Producer1, Cast1, Duration1, Story1, Type1);
            adm.AddMovie(movie1);

            string MovieName = "Corona Virus";
            string Director = "WHO";
            string Producer = "China PLA";
            string Cast = "Xi Jinpin, Donald Trump";
            double Duration = 164;
            string Story = "Movie about how the earth came to standstill but china was running and how china is going to become the superpower";
            string Type = "Running";
            Movie movie = new Movie(MovieName, Director, Producer, Cast, Duration, Story, Type);
            adm.AddMovie(movie);
            do
            {

                Console.WriteLine("Which of the following actions would you like to perform?");
                Console.WriteLine("1. View Shows\n2. New Tickets\n3. Print Ticket\n4. Exit");
                choice = GetChoice();
                switch (choice)
                {
                    case 1:
                        List<Show> ShowList = adm.GetAllShows();
                        Console.WriteLine("Enter the name of the movie which you want to watch");
                        List<Movie> MoviesList = adm.GetAllMovies();
                        foreach (var v in MoviesList)
                        {
                            Console.WriteLine("Movie Name is: {0}", v.MovieName);
                            Console.WriteLine("Director of the movie is: {0}", v.Director);
                            Console.WriteLine("Producers' Name is: {0}", v.Producer);
                            Console.WriteLine("Cast of the movie includes : {0}", v.Cast);
                            Console.WriteLine("Story of the movie is: {0}", v.Story);
                            Console.WriteLine("The Movie is {0} mins long", v.Duration);
                            Console.WriteLine("The movie is {0}", v.Type);
                            Console.WriteLine();
                        }
                        ChosenMovie = Console.ReadLine();

                        break;
                    case 2:
                        Screen scr = new Screen();
                        Console.WriteLine("Which seat type do you want to book?\nWe offer platinum, gold and silver tier seats");
                        string SeatTier = Console.ReadLine();
                        Console.WriteLine("How many seats would you like");
                        int NumberOfSeats = Convert.ToInt32(Console.ReadLine());

                        int OldLength = Booking.SeatNumbers.Count;
                        for (int i = 0; i < NumberOfSeats; i++)
                        {
                            int k = 0;
                            do
                            {
                                if (scr.Seats[k] == "Vacant")
                                {
                                    scr.Seats[k] = "Reserved";
                                    Booking.SeatNumbers.Add(k);
                                    break;
                                }
                                k++;
                            } while (k < 50);
                        }

                        int NewLength = Booking.SeatNumbers.Count;
                        if (NewLength - OldLength == NumberOfSeats)
                        {
                            Console.WriteLine("{0} {1} Tier seats are available and have been locked for you!\n", NumberOfSeats, SeatTier);
                            Console.WriteLine("List of Reserved and vacant seats is:");
                            int count = 0;
                            for (int x = 0; x < 50; x++)
                            {
                                if (scr.Seats[x].Equals("Reserved", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine("There are {0} Reserved and {1} vacant seats available\n", count, 50 - count);
                            Console.WriteLine("The following seat numbers have been locked for you");
                            for (int h = 0; h < NumberOfSeats; h++)
                            {
                                Console.WriteLine(Booking.SeatNumbers[h]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("{0} number of seats are not available. Try leaving a friend at home", NumberOfSeats);
                        }

                        Console.WriteLine("Enter your name now.");
                        string CustomerName = Console.ReadLine();
                        Console.WriteLine("Enter your email address now");
                        string Email = Console.ReadLine();
                        Show SHOW = new Show();
                        Booking booking = new Booking(SHOW.ShowID, CustomerName, NumberOfSeats, SeatTier, Email);
                        BookingID = booking.BookingID;
                        adm.BookTicket(booking);
                        break;
                    case 3:
                        adm.PrintTicket(BookingID);
                        break;
                    case 4:
                        Environment.Exit(-1);
                        break;
                }
            } while (choice != 4);
        }

        public int GetChoice()
        {
            Console.WriteLine("Please enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public string Login()
        {
            Console.WriteLine("Enter Username");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();

            foreach (var v in UserInformation)
            {
                if (v.UserName == Username && v.Password == Password)
                {
                    return v.UserType;
                }
                if (Username != "" && Password != "")
                {
                    return "Agent";
                }
            }
            return null;
        }
    }
    #endregion

    #region AdministratorClass
    class Administrator : TicketBooking, IAdmin
    {
        MovieTicketing MT = new MovieTicketing();
        #region AddTheatre
        public bool AddTheatre(Theatre obj)
        {
            if (obj.TheatreName == "" || obj.CityName == "" || obj.Address == "")
            {
                Console.WriteLine("The theatre details should not be empty");
            }
            if (obj == null)
            {
                throw new NullReferenceException("The theatre details should not be null");
            }
            if (obj.NumberofScreens <= 0)
            {
                throw new Exceptions.InvalidScreenCountException("Invalid Screen Count. The number of seats should not be less than or equal to zero");
            }
            else
            {
                MovieTicketing.Theatres.Add(obj);
                return true; //DONT FORGET TO ADD THE CHECKER WHICH VERIFIES IF THE LIST ACTUALLY GOT POPULATED
            }
        }
        #endregion

        #region UpdateTheatre
        public bool UpdateTheatre(Theatre obj)
        {
            for (int i = 0; i < MovieTicketing.Theatres.Count; i++)
            {
                var v = MovieTicketing.Theatres[i];

                if ((v.TheatreName.Equals(obj.TheatreName, StringComparison.InvariantCultureIgnoreCase)) && (v.CityName.Equals(obj.CityName, StringComparison.InvariantCultureIgnoreCase)) && (v.Address.Equals(obj.Address, StringComparison.InvariantCultureIgnoreCase)))
                {
                    Console.WriteLine("Theatre details are available in the database:");
                    Console.WriteLine("Theatre name is {0}", v.TheatreName);
                    Console.WriteLine("City name is {0}", v.CityName);
                    Console.WriteLine("Address is {0}", v.Address);
                    Console.WriteLine("Number of screens are {0}", v.NumberofScreens);
                    Console.WriteLine("Enter the updated theatre details");

                    Console.WriteLine("Enter new/old Theatre name");
                    string TheatreName = Console.ReadLine();
                    Console.WriteLine("Enter new/old Address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter new/old City name");
                    string Cityname = Console.ReadLine();
                    if (Cityname == "" || address == "" || TheatreName == "")
                    {
                        Console.WriteLine("Theatre details should not be empty");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Enter Number of seats");
                        int NOS = Convert.ToInt32(Console.ReadLine());
                        if (NOS <= 0)
                        {
                            throw new Exceptions.InvalidScreenCountException("Invalid Screen Count. The number of seats should not be less than or equal to zero");
                        }

                        else
                        {
                            int Index = 0;
                            Theatre theatre = new Theatre(TheatreName, Cityname, address, NOS);
                            for (int I = 0; i < MovieTicketing.Theatres.Count; i++)
                            {
                                var V = MovieTicketing.Theatres[I];
                                if (V.TheatreName == obj.TheatreName && V.Address == obj.Address)
                                {
                                    Index = i;
                                }
                            }
                            MovieTicketing.Theatres.RemoveAt(Index);
                            MovieTicketing.Theatres.Insert(Index, theatre);
                        }
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("No matching theatres in the database");
                }
            }

            return false;
        }
        #endregion

        #region AddMovie
        public bool AddMovie(Movie obj)
        {
            if (obj.MovieName == "" || obj.Producer == "" || obj.Story == "" || obj.Director == "" || obj.Cast == "")
            {
                Console.WriteLine("The Movie details should not be empty");
                return false;
            }
            if (obj == null)
            {
                throw new NullReferenceException("The Movie details should not be null");
            }

            if (obj.Duration <= 0)
            {
                Console.WriteLine("The Movie details should not be empty");
                return false;
            }
            if ((obj.Type.Equals("running", StringComparison.InvariantCultureIgnoreCase)) || (obj.Type.Equals("upcoming", StringComparison.InvariantCultureIgnoreCase)))
            {
                MovieTicketing.Movies.Add(obj);
                return true; //DONT FORGET TO ADD THE CHECKER WHICH VERIFIES IF THE LIST ACTUALLY GOT POPULATED
            }
            else
            {
                throw new Exceptions.InvalidMovieTypeException("Invalid Movie type. The movie type should be either 'Running' or 'Upcoming'");

            }
        }
        #endregion

        #region UpdateMovie
        public bool UpdateMovie(Movie obj)
        {
            for (int i = 0; i < MovieTicketing.Movies.Count; i++)
            {
                var v = MovieTicketing.Movies[i];

                if ((v.MovieName == obj.MovieName) && (v.Producer == obj.Producer) && (v.Story == obj.Story) && (v.Director == obj.Director) && (v.Cast == obj.Cast))
                {
                    Console.WriteLine("\nMovie details are available in the database:");
                    Console.WriteLine("Movie name is {0}", v.MovieName);
                    Console.WriteLine("Producer is {0}", v.Producer);
                    Console.WriteLine("Directed by {0}", v.Director);
                    Console.WriteLine("Cast of the movie includes {0}", v.Cast);
                    Console.WriteLine("Story of the movie is {0}", v.Story);
                    Console.WriteLine("Movie is {0}", v.Type);
                    Console.WriteLine("Duration of the Movie is {0}", v.Duration);
                    Console.WriteLine("\nEnter the updated Movie details");

                    Console.WriteLine("Enter the old/updated Movie Name");
                    string movieName = Console.ReadLine();
                    Console.WriteLine("Enter the old/updated Producer Name");
                    string producer = Console.ReadLine();
                    Console.WriteLine("Enter the old/updated Director Name");
                    string director = Console.ReadLine();
                    Console.WriteLine("Enter the old/updated Story details");
                    string story = Console.ReadLine();
                    Console.WriteLine("Enter the old/updated Cast members");
                    string cast = Console.ReadLine();
                    Console.WriteLine("Enter the old/update Duration");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the old/update Movie Type i.e 'Running' or 'Upcoming'");
                    string type = Console.ReadLine();
                    if (movieName == "" || producer == "" || director == "" || story == "" || cast == "" || type == "")
                    {
                        Console.WriteLine("Movie details should not be empty");
                        return false;
                    }
                    else
                    {
                        if (duration <= 0)
                        {
                            throw new Exceptions.InvalidScreenCountException("Invalid Screen Count. The number of seats should not be less than or equal to zero");
                        }

                        else
                        {
                            int Index = 0;
                            Movie movie = new Movie(movieName, director, producer, cast, duration, story, type);
                            for (int I = 0; I < MovieTicketing.Movies.Count; I++)
                            {
                                var V = MovieTicketing.Movies[I];
                                if (V.MovieName == obj.MovieName && V.Producer == obj.Producer && v.Director == obj.Director)
                                {
                                    Index = I;
                                }
                            }
                            MovieTicketing.Movies.RemoveAt(Index);
                            MovieTicketing.Movies.Insert(Index, movie);
                        }
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("No matching movies in the database. Update not possible");
                }
            }
            return false;
        }
        #endregion

        #region AddShow
        public bool AddShow(Show obj)
        {
            Console.WriteLine();
            if (obj.EndDate == null || obj.MovieID == 0 || obj.ScreenID == 0 || obj.StartDate == null || obj.TheatreID == 0 || obj.GoldSeatRate == 0 || obj.PlatinumSeatRate == 0 || obj.SilverSeatRate == 0)
            {
                Console.WriteLine("The Show details should not be empty");
                return false;
            }
            if (obj == null)
            {
                throw new NullReferenceException("The Show details should not be null");
            }

            if (Screen.ScreenID == obj.ScreenID)
            {
                MovieTicketing.shows.Add(obj);
                return true;
            }
            else
            {
                Console.WriteLine("Inappropriate data found");
                return false;
            }
        }
        #endregion

        #region UpdateShow
        public bool UpdateShow(Show obj)
        {
            for (int i = 0; i < MovieTicketing.shows.Count; i++)
            {
                var v = MovieTicketing.shows[i];

                if ((v.StartDate == obj.StartDate) && (v.EndDate == obj.EndDate) && (v.GoldSeatRate == obj.GoldSeatRate) && (v.PlatinumSeatRate == obj.PlatinumSeatRate) && (v.SilverSeatRate == obj.SilverSeatRate))
                {
                    Console.WriteLine("Movie details are available in the database:");
                    Console.WriteLine("Show start date is {0}", v.StartDate);
                    Console.WriteLine("Shows' end date is {0}", v.EndDate);
                    Console.WriteLine("Price of Gold tier seats is {0}", v.GoldSeatRate);
                    Console.WriteLine("price of Platinum tier seats is by {0}", v.PlatinumSeatRate);
                    Console.WriteLine("Price of Silver tier seats is {0}", v.SilverSeatRate);

                    Console.WriteLine("\nEnter the updated Show details");
                    //specify what is being entered

                    Console.WriteLine("Enter old/updated First show date");
                    DateTime Start = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter old/updated Last show date");
                    DateTime End = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter old/updated Platinum seat rate");
                    decimal Platinum = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter old/updated Gold Seat rate");
                    decimal Gold = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Enter old/updated Silver Seat rate");
                    decimal Silver = Convert.ToDecimal(Console.ReadLine());

                    if (Start == null || End == null || Platinum <= 0 || Gold <= 0 || Silver <= 0)
                    {
                        Console.WriteLine("Show details should not be empty");
                        return false;
                    }
                    else
                    {
                        int Index = 0;
                        Show SHOW = new Show(obj.MovieID, obj.TheatreID, obj.ScreenID, Start, End, Platinum, Gold, Silver);
                        for (int I = 0; I < MovieTicketing.shows.Count; I++)
                        {
                            var V = MovieTicketing.shows[I];
                            if (V.EndDate == obj.EndDate && V.StartDate == obj.StartDate && V.PlatinumSeatRate == obj.PlatinumSeatRate && V.GoldSeatRate == obj.GoldSeatRate)
                            {
                                Index = I;
                            }
                        }
                        MovieTicketing.shows.RemoveAt(Index);
                        MovieTicketing.shows.Insert(Index, SHOW);
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("No matching Shows in the database. Update not possible");
                }
            }
            return false;
        }
        #endregion

        #region DeleteShow
        public bool DeleteShow(int ShowID) //MIGHT BE A PPOBLEM HERE. RESOLVE IN THE END
        {
            int index = 0;
            foreach (var v in MovieTicketing.shows)
            {
                if (v.ShowID == ShowID)
                {
                    MovieTicketing.shows.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
        #endregion

        #region AddAgent
        public bool AddAgent(User obj)
        {
            if (obj.UserName == "" || obj.Password == "" || obj.UserType == "")
            {
                Console.WriteLine("The User information should not be empty");
                return false;
            }
            if (obj == null)
            {
                throw new NullReferenceException("The User details should not be null");
            }
            else
            {
                MovieTicketing.UserInformation.Add(obj);
                return true;
            }
        }
        #endregion

        public List<Theatre> GetAllTheatres()
        {
            return MovieTicketing.Theatres;
        }
        public List<Movie> GetAllMovies()
        {
            return MovieTicketing.Movies;
        }
        public List<Show> GetAllShows()
        {
            return MovieTicketing.shows;
        }
    }
    #endregion

    #region TicketBookingClass
    abstract class TicketBooking
    {
        public int BookTicket(Booking obj)
        {
            if (obj.ShowID == 0 || obj.CustomerName == "" || obj.NumberOfSeats <= 0 || obj.SeatType == "" || obj.Email == "")
            {
                Console.WriteLine("Booking Details can't be empty");
                Console.WriteLine(obj.ShowID);
                Console.WriteLine(obj.CustomerName);
                Console.WriteLine(obj.Email);
                Console.WriteLine(obj.NumberOfSeats);
                Console.WriteLine(obj.SeatType);
                return -1;
            }
            else
            {
                MovieTicketing.Bookings.Add(obj);
                return obj.BookingID;
            }
        }
        public void PrintTicket(int BookingId)
        {
            int TheatID = 0;
            int ScrID = 0;
            string MovName = "";
            if (BookingId > 0)
            {
                for (int x = 0; x < MovieTicketing.Bookings.Count; x++)
                {
                    var v = MovieTicketing.Bookings[x];
                    for (int y = 0; y < MovieTicketing.shows.Count; y++)
                    {
                        var h = MovieTicketing.shows[y];
                        if (h.ShowID == v.ShowID)
                        {
                            TheatID = h.TheatreID;
                            ScrID = h.ScreenID;
                            for (int z = 0; z < MovieTicketing.Movies.Count; z++)
                            {
                                var a = MovieTicketing.Movies[z];
                                if (a.MovieID == h.MovieID)
                                {
                                    MovName = a.MovieName;
                                }

                            }
                        }
                    }
                    string s = " ";
                    for (int n = 0; n < Booking.SeatNumbers.Count; n++)
                    {
                        s = s + " " + Booking.SeatNumbers[n];
                    }

                    if (v.BookingID == BookingId)
                    {
                        Console.WriteLine("\nBooking ID:        Booking Date:           Customer Name:");
                        Console.WriteLine("{0}              {1}    {2}", BookingId, v.BookingDate, v.CustomerName);
                        Console.WriteLine("\nSeats:               Seat type:          Seat Numbers:");
                        Console.WriteLine("{0}                     {1}           {2}", v.NumberOfSeats, v.SeatType, s);
                        Console.WriteLine("\nMovie Name:          Show ID:            Theatre ID/Screen ID:");
                        Console.WriteLine("{0}                  {1}                 {2}/{3}", MovName, v.ShowID, TheatID, ScrID);
                        Console.WriteLine("\nAmount Paid:                             Booking Status");
                        Console.WriteLine("{0}                                      {1}\n", v.Amount, v.BookingStatus);
                    }
                }
            }
            else
            {
                Console.WriteLine("Booking ID should be a non negative value");
            }
        }
        void DisplayShows()
        {
            foreach (var v in MovieTicketing.shows)
            {
                Console.WriteLine(v.StartDate);
                Console.WriteLine(v.EndDate);
            }
        }
    }
    #endregion

    #region MovieClass
    class Movie
    {
        public int MovieID;

        #region MovieName
        private string _MovieName;
        public string MovieName
        {
            get { return _MovieName; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Movie name is empty. Try again\n");
                    _MovieName = "No name specified";
                }
                else
                {
                    _MovieName = value;
                }
            }
        }
        #endregion

        #region Director
        private string _Director;
        public string Director
        {
            get { return _Director; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Director name is empty. Try again");
                    _Director = "No name specified";
                }
                else
                {
                    _Director = value;
                }
            }
        }
        #endregion

        #region Producer
        private string _Producer;
        public string Producer
        {
            get { return _Producer; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Producer name is empty. Try again");
                    _Producer = "No name specified";
                }
                else
                {
                    _Producer = value;
                }
            }
        }
        #endregion

        #region Cast
        private string _Cast;
        public string Cast
        {
            get { return _Cast; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Cast names are empty. Try again");
                    _Cast = "No names specified";
                }
                else
                {
                    _Cast = value;
                }
            }
        }
        #endregion

        #region Duration
        private double _Duration;
        public double Duration
        {
            get
            {
                return _Duration;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid duartion entered");
                }
                else
                {
                    _Duration = value;
                }
            }
        }
        #endregion

        #region Story
        private string _Story;
        public string Story
        {
            get { return _Story; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Story field is empty. Try again");
                    _Story = "No story or description given";
                }
                else
                {
                    _Story = value;
                }
            }
        }
        #endregion

        #region Type
        private string _Type;
        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                if (value.Equals("running", StringComparison.InvariantCultureIgnoreCase) || value.Equals("upcoming", StringComparison.InvariantCultureIgnoreCase))
                {
                    _Type = value;
                }
                else
                {
                    Console.WriteLine("Status of movie not specified. Assigning default value\n");
                    _Type = "running";
                }
            }
        }//Running or upcoming
        #endregion

        public Movie(string MOVIENAME, string DIRECTOR, string PROD, string CAST, double DUR, string STORY, string TYPE)
        {
            MovieName = MOVIENAME;
            Director = DIRECTOR;
            Producer = PROD;
            Cast = CAST;
            Duration = DUR;
            Story = STORY;
            Type = TYPE;
            MovieID = RandomGenerator.R.Next(10000);
        }
        public void DisplayMovieDetails()
        {
            Console.WriteLine("Movie ID is {0}", MovieID);
            Console.WriteLine("Movie Name is {0}", MovieName);
            Console.WriteLine("Directed by {0}", Director);
            Console.WriteLine("Producer is {0}", Producer);
            Console.WriteLine("Cast is {0}", Cast);
            Console.WriteLine("Duration of the movie is {0} mins", Duration);
            Console.WriteLine("Plot of the movie = {0}", Story);
            Console.WriteLine("Type of the movie = {0}\n", Type);
        }

    }
    #endregion

    #region TheatreClass
    public class Theatre
    {
        public int TheatreID;

        #region TheatreName
        private string _TheatreName;
        public string TheatreName
        {
            get
            {
                return _TheatreName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Theatre name is empty. Try again\n");
                    _TheatreName = "No name specified";
                }
                else
                {
                    _TheatreName = value;
                }
            }
        }
        #endregion

        #region CityName
        private string _CityName;
        public string CityName
        {
            get
            {
                return _CityName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("City name is empty. Try again\n");
                    _CityName = "No name specified";
                }
                else
                {
                    _CityName = value;
                }
            }
        }
        #endregion

        #region Address
        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Address field is empty. Try again\n");
                    _Address = "No address specified";
                }
                else
                {
                    _Address = value;
                }
            }
        }
        #endregion

        #region NumberOfScreens
        private int _NumberofScreens;
        public int NumberofScreens
        {
            get
            {
                return _NumberofScreens;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Number of screens cannot be less than 1. Try again");
                    _NumberofScreens = 1;
                }
                else
                {
                    _NumberofScreens = value;
                }
            }
        }
        #endregion

        List<Screen> Screens;

        public Theatre(string theatrename, string cityname, string address, int numberofscreens)
        {
            TheatreID = RandomGenerator.R.Next(10000);
            TheatreName = theatrename;
            CityName = cityname;
            Address = address;
            NumberofScreens = numberofscreens;
            Screens = new List<Screen>(numberofscreens);
        }
        public void DisplayTheatreDetails()
        {
            Console.WriteLine("Theatre ID is {0}", TheatreID);
            Console.WriteLine("Name of the theatre is {0}", TheatreName);
            Console.WriteLine("Name of the city is {0}", CityName);
            Console.WriteLine("Address of the theatre is {0}", Address);
            Console.WriteLine("Number of screens are {0}", NumberofScreens);
        }
    }
    #endregion

    #region ScreenClass
    public class Screen
    {
        public static int ScreenID;
        //In the below sortedlist, the int represents the number of seats and the string represents "Vacant" or "Reserved" 
        public SortedList<int, string> Seats = new SortedList<int, string>();
        public Screen()
        {
            ScreenID = RandomGenerator.R.Next(1000, 10000);
            for (int i = 0; i < 50; i++)
            {
                Seats.Add(i, "Vacant");
            }
        }
    }
    #endregion

    #region ShowClass
    public class Show
    {
        public int ShowID;
        public int MovieID;
        public int TheatreID;
        public int ScreenID;
        public DateTime StartDate;
        public DateTime EndDate;

        #region PlatinumSeatRate
        private decimal _PlatinumSeatRate;
        public decimal PlatinumSeatRate
        {
            get
            {
                return _PlatinumSeatRate;
            }
            set
            {
                if (value != 0)
                {
                    _PlatinumSeatRate = value;
                }
            }
        }
        #endregion

        #region GoldSeatRate
        private decimal _GoldSeatRate;
        public decimal GoldSeatRate
        {
            get
            {
                return _GoldSeatRate;
            }
            set
            {
                if (value != 0)
                {
                    _GoldSeatRate = value;
                }
            }
        }
        #endregion

        #region SilverSeatRate
        private decimal _SilverSeatRate;
        public decimal SilverSeatRate
        {
            get
            {
                return _SilverSeatRate;
            }
            set
            {
                if (value != 0)
                {
                    _SilverSeatRate = value;
                }
            }
        }
        #endregion

        public Show()
        {
            ShowID = RandomGenerator.R.Next(10000);
        }
        public Show(int MI, int TI, int SI, DateTime START, DateTime END, decimal PLAT, decimal GOLD, decimal SILVER)
        {
            ShowID = RandomGenerator.R.Next(10000);
            MovieID = MI;
            TheatreID = TI;
            ScreenID = SI;
            StartDate = START;
            EndDate = END;
            PlatinumSeatRate = PLAT;
            GoldSeatRate = GOLD;
            SilverSeatRate = SILVER;
        }

        public void DisplayShowDetails()
        {
            Console.WriteLine("Show ID is {0}", ShowID);
            Console.WriteLine("Movie ID is {0}", MovieID);
            Console.WriteLine("Theatre ID = {0}", TheatreID);
            Console.WriteLine("ScreenID = {0}", ScreenID);
            Console.WriteLine("First show is on {0}", StartDate);
            Console.WriteLine("Last Show of the movie is on {0}", EndDate);
            Console.WriteLine("Platinum seats of the movie costs {0}", PlatinumSeatRate);
            Console.WriteLine("Gold seats of the movie costs {0}", GoldSeatRate);
            Console.WriteLine("Silver seats of the movie costs {0}\n", SilverSeatRate);
        }
    }
    #endregion

    #region UserClass
    public class User
    {

        #region UserName
        private string _UserName;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Username is empty. Try again");
                    _UserName = "No_name_specified";
                }
                else
                {
                    _UserName = value;
                }
            }
        }
        #endregion

        #region Password
        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Password is invalid. Try again");
                }
                else
                {
                    _Password = value;
                }
            }
        }
        #endregion

        #region UserType
        private string _UserType;
        public string UserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                if (value.Equals("ADMIN", StringComparison.InvariantCultureIgnoreCase) || value.Equals("AGENT", StringComparison.InvariantCultureIgnoreCase))
                {
                    _UserType = value;
                }
            }
        }
        #endregion

        public User(string user, string pass, string type)
        {
            UserName = user;
            Password = pass;
            UserType = type;
        }
    }
    #endregion

    #region BookingClass
    public class Booking
    {
        public int BookingID;
        public DateTime BookingDate = DateTime.Today;
        public int ShowID;

        #region CustomerName
        private string _CustomerName;
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Customer name is empty. Try again\n");
                    _CustomerName = "No_name";
                }
                else
                {
                    _CustomerName = value;
                }
            }
        }
        #endregion

        #region NumberOfSeats
        private int _NumberOfSeats;
        public int NumberOfSeats
        {
            get
            {
                return _NumberOfSeats;
            }
            set
            {
                if (value >= 1 || value <= 4)
                {
                    _NumberOfSeats = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of seats. Cannot be more than 4\nAssigning default value of 1");
                }
            }
        }
        #endregion

        #region SeatType
        private string _SeatType;
        public string SeatType
        {
            get
            {
                return _SeatType;
            }
            set
            {
                if (value.Equals("platinum", StringComparison.InvariantCultureIgnoreCase) || value.Equals("gold", StringComparison.InvariantCultureIgnoreCase) || value.Equals("silver", StringComparison.InvariantCultureIgnoreCase))
                {
                    _SeatType = value;
                }
                else
                {
                    Console.WriteLine("Invalid Seat type");
                }
            }
        }
        #endregion

        #region Amount
        public decimal Amount;

        #endregion

        #region Email
        private string _Email;
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Email address is empty. Try again\n");
                }
                else
                {
                    _Email = value;
                }
            }
        }
        #endregion

        public string BookingStatus;

        public static List<int> SeatNumbers = new List<int>();
        public Booking(int SI, string CN, int NOS, string ST, string MAIL)
        {
            BookingID = RandomGenerator.R.Next(1000, 10000);
            ShowID = SI;
            CustomerName = CN;
            NumberOfSeats = NOS;
            SeatType = ST;
            Email = MAIL;
            for (int i = 0; i < MovieTicketing.shows.Count; i++)
            {
                var v = MovieTicketing.shows[i];
                if (v.ShowID == ShowID)
                {
                    if (SeatType.Equals("platinum", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Amount = NumberOfSeats * v.PlatinumSeatRate;
                    }
                    if (SeatType.Equals("gold", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Amount = NumberOfSeats * v.GoldSeatRate;
                    }
                    if (SeatType.Equals("silver", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Amount = NumberOfSeats * v.SilverSeatRate;
                    }
                }
            }
        }
    }
    #endregion

    #region ProgramClass
    public class program
    {
        static void Main(string[] args)
        {
            Theatre t1 = new Theatre("Payal", "Jamshedpur", "Angreezi Medium", 7);
            t1.DisplayTheatreDetails();
            MovieTicketing MT = new MovieTicketing();
            string LoginType = MT.Login();
            if (LoginType == null || LoginType == "")
            {
                Console.WriteLine("Invalid username OR password. Please try again");
                LoginType = MT.Login();
            }
            if (LoginType.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))
            {
                MT.AdminMenu();
            }
            if (LoginType.Equals("Agent", StringComparison.InvariantCultureIgnoreCase))
            {
                MT.AgentMenu();
            }

        }
    }
    #endregion
}
