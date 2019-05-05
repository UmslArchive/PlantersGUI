namespace PlantersGUI
{
    public class Device
    {
        public enum ConstraintSetting
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
        public decimal constraintValue;
        public ConstraintSetting currentSetting;

        //Constructor.
        public Device(string idString, string var, decimal cVal, ConstraintSetting setting)
        {
            id = idString;
            varName = var;
            constraintValue = cVal;
            currentSetting = setting;
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
