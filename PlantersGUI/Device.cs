namespace PlantersGUI
{
    public class Device
    {
        enum ConstraintSetting
        {
            LESS,
            GREATER,
            LESSEQUAL,
            GREATEREQUAL,
            EQUAL
        };

        //Data.
        public string id;
        public string varName;
        public double refreshRate;
        public double constraintValue;
        public int currentConstraintSetting;

        //Constructor.
        public Device()
        {

        }

        //Function that connects the device and assigns a name.
        public void connectDevice()
        {
            
        }

        public double readDevice()
        {
            return 0.0;
        }
    }
}
