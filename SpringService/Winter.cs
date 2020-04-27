using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Winter
    {

        static Sign Capricorn { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("12/22/0001"), //>=
            endDate = DateTime.Parse("01/20/0001"), //<
            name = SignType.Capricorn
        };
        static Sign Sagittarius { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("12/01/0001"),
            endDate = DateTime.Parse("12/22/0001"),
            name = SignType.Saggitarius
        };
        static Sign Aquarius { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("01/20/0001"),
            endDate = DateTime.Parse("02/19/0001"),
            name = SignType.Aquarius
        };
        static Sign Pisces { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("02/19/0001"),
            endDate = DateTime.Parse("03/01/0001"),
            name = SignType.Pisces
        };


        public static string GetZodiacSign(string input)
        {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1); //sets to year 0001

            if (dt.Date >= Capricorn.startDate && dt.Date < Capricorn.endDate)
                return Capricorn.name.ToString();
            if (dt.Date >= Sagittarius.startDate && dt.Date < Sagittarius.endDate)
                return Sagittarius.name.ToString();
            if (dt.Date >= Aquarius.startDate && dt.Date < Aquarius.endDate)
                return Aquarius.name.ToString();
            if (dt.Date >= Pisces.startDate && dt.Date < Pisces.endDate)
                return Pisces.name.ToString();


            return "InvalidRequest";
        }
    }
}
