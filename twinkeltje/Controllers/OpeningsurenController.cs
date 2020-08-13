using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace twinkeltje.Controllers
{
    public class OpeningsurenController : Controller
    {
        //hardcoded openingsdata;
        private string[] urenstart, urenstop, dagenvdweek;
        

        // GET
        public IActionResult Index()
        {
            urenstart = new string[7];
            urenstop = new string[7];
            dagenvdweek = new string[7];
            List<string[]> dataToGive = new List<string[]>();
            
            for (int i = 0; i < 7; i++)
                    {
                        switch (i)
                        {
                            case 0: urenstart[i] = "8:00";
                                urenstop[i] = "18:00";
                                dagenvdweek[i] = "Maandag";
                                break;
                            case 1: urenstart[i] = "Gesloten";
                                urenstop[i] = "Gesloten";
                                dagenvdweek[i] = "Dinsdag";
                                break;
                            case 2: urenstart[i] = "8:00";
                                urenstop[i] = "18:00";
                                dagenvdweek[i] = "Woensdag";
                                break;
                            case 3: urenstart[i] = "8:00";
                                urenstop[i] = "13:00";
                                dagenvdweek[i] = "Donderdag";
                                break;
                            case 4: urenstart[i] = "8:00";
                                urenstop[i] = "18:00";
                                dagenvdweek[i] = "Vrijdag";
                                break;
                            case 5: urenstart[i] = "8:00";
                                urenstop[i] = "17:00";
                                dagenvdweek[i] = "Zaterdag";
                                break;
                            case 6: urenstart[i] = "8:00";
                                urenstop[i] = "13:00";
                                dagenvdweek[i] = "Zondag";
                                break;
                        }
                    }

            dataToGive.Add(dagenvdweek);
            dataToGive.Add(urenstart);
            dataToGive.Add(urenstop);

            bool geopend = false;
            DateTime currentDate = DateTime.Now;
            if (currentDate.DayOfWeek != DayOfWeek.Tuesday)
            {
                if (currentDate.Hour > 8 && currentDate.Hour < 18 && currentDate.DayOfWeek == DayOfWeek.Monday || currentDate.DayOfWeek == DayOfWeek.Wednesday || currentDate.DayOfWeek == DayOfWeek.Friday)
                {
                    geopend = true;
                }
                if (currentDate.Hour > 8 && currentDate.Hour < 13 && currentDate.DayOfWeek == DayOfWeek.Thursday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(currentDate.Hour);
                    geopend = true;
                }
                if (currentDate.Hour > 8 && currentDate.Hour < 17 && currentDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    geopend = true;
                }
                
            }
            dataToGive.Add(new []{geopend.ToString()});
            return View(dataToGive);
        }
    }
}