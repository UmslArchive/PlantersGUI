using System;
using System.Collections.Generic;

namespace PlantersGUI
{
    public class Experiment
    {
        //Data.
        public List<UserVariable> userVariables;
        public List<Table> tables;

        //Experiment initialization
        public Experiment()
        {
            //Initialize lists.
            userVariables = new List<UserVariable>();
            tables = new List<Table>();

        }
         
        //Save currently open experiment to file.
        public void save()
        {

        }
    }
}
