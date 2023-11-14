string month = Console.ReadLine();
int night = int.Parse(Console.ReadLine());

decimal studioPrice = 50.00M;
decimal apartmentPrice = 65.00M;
decimal studioRent = 0.00M;
decimal apartmentRent = 0.00M;

switch (month)
{
    case "May":
    case "October":
        studioPrice = 50.00M;
        apartmentPrice = 65.00M;
        studioRent = studioPrice * night;
        apartmentRent = apartmentPrice * night;
        if (night > 14)
        {
            studioRent *= 0.70M;
            apartmentRent *= 0.90M;
        }
        else if (night > 7)
        {
            studioRent *= 0.95M;
        }
        break;
    case "June":
    case "September":
        studioPrice = 75.20M;
        apartmentPrice = 68.70M;
        studioRent = studioPrice * night;
        apartmentRent = apartmentPrice * night;
        if (night > 14)
        {
            studioRent *= 0.80M;
            apartmentRent *= 0.90M;
        }
           break;
    case "July":
    case "August":
        studioPrice = 76.00M;
        apartmentPrice = 77.00M;
        studioRent = studioPrice * night;
        apartmentRent = apartmentPrice * night;
        if (night > 14)
        {
            
            apartmentRent *= 0.90M;
        
        }
        break;
        string studioInfo = string.Format($"Studio: {decimal.Round(studioRent, 2)}");
        string apartmentInfo = string.Format($"Apartment: {decimal.Round(apartmentRent, 2)}");

}
