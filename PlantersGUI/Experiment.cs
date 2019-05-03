using System;
using System.Collections.Generic;

namespace PlantersGUI
{
    public class Experiment
    {
        //Data.
        public List<Device> devices;
        public List<Table> tables;

        //Experiment initialization
        public Experiment()
        {
            //Initialize lists.
            devices = new List<Device>();
            tables = new List<Table>();

        }
         
        //Save currently open experiment to file.
        public void save()
        {

        }
    }
}
