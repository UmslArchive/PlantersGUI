using System.Data;

namespace PlantersGUI
{
    public class Table
    {
        public string title;
        public string indepVariable, depVariable;
        public decimal refreshRate;

        public DataTable data;

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

            //Init.
            InitializeDataTable();

        }

        //TODO: add data link for live data display in continueForm.

        //Function exports a table into a .csv file.
        public void ExportCSV()
        {

        }

        private void InitializeDataTable()
        {
            //Instantiate object.
            data = new DataTable();

            //Set the name of the table.
            data.TableName = title;

            //Add the columns.
            data.Columns.Add(indepVariable, typeof(string));
            data.Columns.Add(depVariable, typeof(string));


            //Tables can be created in two different ways. The table that propagates will have only two columns -- time and userVar.
            //That is to say, if the user selects time as the independent variable, then time will be x-axis
            //and the user variable will be y-axis on a chart. If user selects two user variables as the indep and dep variables in table config form,
            //then the table that propagates from such a configuration should contain three columns -- time, userVar1, userVar2. 
            //Everything should be time stamped.
            
            
        }
    }
}
