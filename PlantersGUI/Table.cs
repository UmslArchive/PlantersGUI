namespace PlantersGUI
{
    public class Table
    {
        public string title;
        public string indepVariable, depVariable;
        public decimal refreshRate;

        //Constructor.
        public Table(string titleString, string indep, string dep, decimal refresh)
        {
            title = titleString;
            indepVariable = indep;
            depVariable = dep;
            refreshRate = refresh;
        }

        //TODO: add data link for live data display in continueForm.

        //Function exports a table into a .csv file.
        public void export()
        {

        }
    }
}
