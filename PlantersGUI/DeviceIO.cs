using System;

namespace PlantersGUI
{
    public class DeviceIO
    {

        //Data.
        string id;


        //Constructor.
        public DeviceIO(string idString)
        {
            id = idString;
        }
        

        //Returns true if connection is established with IO device.
        public bool HandshakeDevice()
        {
            return true;
        }

        //Returns read value of IO device.
        public decimal ReadValue()
        {
            return 0.0M;
        }
    }
}
