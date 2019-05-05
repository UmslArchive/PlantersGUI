using System.Data;

namespace PlantersGUI
{
    public class Table
    {
        public string title;
        public string indepVariable, depVariable;
        public decimal refreshRate;

        //public DataTable dataTable;

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

            //Initialize dataTable.
            //dataTable = new DataTable(titleString);
            //dataTable.Columns.Add(indepVariable);
            //dataTable.Columns.Add(depVariable);
        }

        //TODO: add data link for live data display in continueForm.

        //Function exports a table into a .csv file.
        public void export()
        {

        }
    }
}
