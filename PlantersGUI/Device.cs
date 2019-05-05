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
        public Device(string idString, string var, decimal cVal, string setting)
        {
            id = idString;
            varName = var;
            constraintValue = cVal;

            switch (setting)
            {
                case "=":
                    currentSetting = ConstraintSetting.EQUAL;
                    break;

                case ">":
                    currentSetting = ConstraintSetting.GREATER;
                    break;

                case "<":
                    currentSetting = ConstraintSetting.LESS;
                    break;

                case ">=":
                    currentSetting = ConstraintSetting.GREATEREQUAL;
                    break;

                case "<=":
                    currentSetting = ConstraintSetting.LESSEQUAL;
                    break;

                default:
                    currentSetting = ConstraintSetting.EQUAL;
                    break;
            }
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
