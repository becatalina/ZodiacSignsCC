using System;
using SeasonsService.Models;

namespace SeasonsService
{
    public static class Spring
    {
        
        static Sign Piesces { get; set; } = new Sign() { 
            startDate = DateTime.Parse("03/01/0001"), //>=
            endDate = DateTime.Parse("03/21/0001"), //<
            name = SignType.Pisces };
        static Sign Aries { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("03/21/0001"),
            endDate = DateTime.Parse("04/20/0001"),
            name = SignType.Aries
        };
        static Sign Taurus { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("04/21/0001"),
            endDate = DateTime.Parse("05/21/0001"),
            name = SignType.Taurus
        };
        static Sign Gemini { get; set; } = new Sign()
        {
            startDate = DateTime.Parse("05/21/0001"),
            endDate = DateTime.Parse("06/01/0001"),
            name = SignType.Gemini
        };


        public static string GetZodiacSign(string input) {
            DateTime dt = DateTime.Parse(input);
            dt = dt.AddYears(0 - dt.Year + 1); //sets to year 0001

            if (dt.Date >= Piesces.startDate && dt.Date < Piesces.endDate)
                return Piesces.name.ToString();
            if (dt.Date >= Aries.startDate && dt.Date < Aries.endDate)
                return Aries.name.ToString();
            if (dt.Date >= Taurus.startDate && dt.Date < Taurus.endDate)
                return Taurus.name.ToString();
            if (dt.Date >= Gemini.startDate && dt.Date < Gemini.endDate)
                return Gemini.name.ToString();


            return "InvalidRequest";
        }
    }
}
