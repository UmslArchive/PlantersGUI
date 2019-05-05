namespace PlantersGUI
{
    public class Table
    {
        public string title;
        public string indepVariable, depVariable;
        public decimal refreshRate;

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
                    refreshRate = refresh * 1000;
                    break;

                case "Minute(s)":
                    refreshRate = refresh * 1000 * 60;
                    break;

                case "Hour(s)":
                    refreshRate = refresh * 1000 * 60 * 60;
                    break;

                case "Day(s)":
                    refreshRate = refresh * 1000 * 60 * 60 * 24;
                    break;

                default:
                    refreshRate = 1000.0M; //One second.
                    break;
            }
        }

        //TODO: add data link for live data display in continueForm.

        //Function exports a table into a .csv file.
        public void export()
        {

        }
    }
}
