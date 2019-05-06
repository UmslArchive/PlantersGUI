using System;
using System.Data;
using System.Collections.Generic;

namespace PlantersGUI
{
    public class Table
    {
        public string title;
        public string indepVariable, depVariable;
        public decimal refreshRate;

        public List<int> data = new List<int>();

        //Constructor.
        public Table(string titleString, string indep, string dep, decimal refresh, string unit)
        {
            title = titleString;
            indepVariable = indep;
            depVariable = dep;

            //Refresh Rate in milliseconds.
            switch (unit)
            {
                case "Second(s)":
                    refreshRate = refresh * 1000.0M;
                    break;

                case "Minute(s)":
                    refreshRate = refresh * 1000.0M * 60.0M;
                    break;

                case "Hour(s)":
                    refreshRate = refresh * 1000.0M * 60.0M * 60.0M;
                    break;

                case "Day(s)":
                    refreshRate = refresh * 1000.0M * 60.0M * 60.0M * 24.0M;
                    break;

                default:
                    refreshRate = 1000.0M; //One second.
                    break;
            }

            //Spoof Hydration Data.
            Random rand = new Random();
            for(int i = 0; i < 15; ++i)
            {
                //Determine + or -
                int select = rand.Next(2);

                //Add 15 seconds of data.
                if(select > 0)
                    data.Add(1000 + rand.Next(42));
                else
                    data.Add(1000 - rand.Next(42));
            }

            //Drop value to between 500 to 800 over 5 seconds.
            for(int i = 0; i < 5; ++i)
            {
                data.Add(900 - i * 75 + rand.Next(42));
            }

            //Slowly drop over 60 seconds.
            for(int i = 0; i < 60; ++i)
            {
                data.Add(700 - i * 2 + rand.Next(10));
            }

            //Hold steady for one hour. (water has now been dispensed.)
            for(int i = 0; i < 3600; ++i)
            {
                int select = rand.Next(2);
                if (select > 0)
                    data.Add(600 + rand.Next(42));
                else
                    data.Add(600 - rand.Next(42));
            }
        }

        //TODO: add data link for live data display in continueForm.

        //Function exports a table into a .csv file.
        public void export()
        {

        }

        public void update()
        {

        }
    }
}
