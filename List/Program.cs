namespace List;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext db = new AppDbContext();
        bool info = false;
        bool result = false;
        bool all = false;
        string first = " ";
        int second;

        do
        {
            WriteLine("1.sisteme giris\n0.sistemnen cixis");
            string number = ReadLine();
            switch (number)
            {
                case "0":
                    WriteLine("Sistemnen cixdiz");
                    break;
                case "1":
                    WriteLine("Sisteme daxil olduz");
                    do
                    {
                        WriteLine("1.Hotel yarat(Name daxil et)\n2.Butun hotelleri gor\n3.Hotel sec");
                        string hotelNum = ReadLine();

                        switch (hotelNum)
                        {
                            case "1":
                                WriteLine("Hotel name daxil et");
                                string hotelName = ReadLine();
                                WriteLine($"{hotelName}:Adli hotel yaradildi");
                                Hotel hotel = new Hotel(hotelName);
                                break;
                            case "2":
                                WriteLine("Butun Hoteller");
                                foreach (var item in db.Showhotel())
                                {
                                    WriteLine(item.ToString());
                                }
                                break;
                            case "3":
                                WriteLine("Hotel sec(adini daxil et)");
                                string Selecthotel = ReadLine();
                                WriteLine($"{Selecthotel}:Adli hotel secildi");
                                do
                                {
                                    WriteLine("1.Room yarat(ad)\n2.Butun room lari gor\n3.Exit");
                                    string nameRoom = ReadLine();
                                    switch (nameRoom)
                                    {
                                        case "1":
                                            WriteLine("Room adi daxil et");
                                            string roomName = ReadLine();
                                            WriteLine("Room qiymeti et");
                                            int price = int.Parse(ReadLine());
                                            WriteLine("insan tutumu daxil et");
                                            double capacity = double.Parse(ReadLine());
                                            if (capacity > 0)
                                            {
                                                WriteLine("Otag yaradildi");
                                            }
                                            else
                                            {
                                                WriteLine("Otag yaradilmadi");
                                            }
                                            Room room = new Room(roomName, price, capacity);
                                            WriteLine("Room yardildi");
                                            WriteLine("rezerv edildi");
                                            db.Rezervation(roomName, capacity);
                                            break;
                                        case "2":
                                            WriteLine("Butun Otaglar");
                                            foreach (var item in db.Showroom())
                                            {
                                                WriteLine(item.ToString());
                                            }
                                            break;
                                        case "3":
                                            WriteLine("Exit");
                                            break;
                                        default:
                                            break;
                                    }
                                } while (!info);
                                break;
                            default:
                                break;
                        }
                    } while (!result);
                    break;
                default: break;
            }

        } while (!all);

    }
}