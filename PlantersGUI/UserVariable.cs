using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlantersGUI
{
    public class UserVariable //Better name for this class might be "UserVariable".
    {
        public enum ConstraintSetting
        {
            LESS,
            GREATER,
            LESSEQUAL,
            GREATEREQUAL,
            EQUAL,
            NULL
        };

        //Storage class for UserVariable upper and lower bounds.
        public class Constraint
        {
            public int lowerBound;
            public int upperBound;

            public Constraint(int constraintValue, ConstraintSetting setting)
            {
                switch (setting)
                {
                    case ConstraintSetting.LESS:
                        lowerBound = System.Int32.MinValue;
                        upperBound = constraintValue;
                        break;

                    case ConstraintSetting.GREATER:
                        lowerBound = constraintValue;
                        upperBound = System.Int32.MaxValue;
                        break;

                    case ConstraintSetting.LESSEQUAL:
                        lowerBound = System.Int32.MinValue;
                        upperBound = constraintValue;
                        break;

                    case ConstraintSetting.GREATEREQUAL:
                        lowerBound = constraintValue;
                        upperBound = System.Int32.MaxValue;
                        break;

                    default: //case EQUAL.
                        lowerBound = constraintValue;
                        upperBound = constraintValue;
                        break;
                }
            }

            public string Get()
            {
                if (lowerBound < 5000 && lowerBound > -5000)
                    return lowerBound.ToString();
                return upperBound.ToString();
            }
        }

        //Data.
        public string name;
        public DeviceIO linkedDevice;
        public Constraint constraint;
        public ConstraintSetting constraintSetting;

        //Constructor.
        public UserVariable(string idString, string varName, int cVal, string setting)
        {
            //Set string variables.
            name = varName;

            //Set constraintSetting based on passed setting string.
            switch (setting)
            {
                case ">":
                    constraintSetting = ConstraintSetting.GREATER;
                    break;

                case "<":
                    constraintSetting = ConstraintSetting.LESS;
                    break;

                case ">=":
                    constraintSetting = ConstraintSetting.GREATEREQUAL;
                    break;

                case "<=":
                    constraintSetting = ConstraintSetting.LESSEQUAL;
                    break;

                case "=":
                    constraintSetting = ConstraintSetting.EQUAL;
                    break;

                default: //Null case. (box unchecked)
                    constraintSetting = ConstraintSetting.NULL;
                    break;
            }

            //Set the constraint.
            if (constraintSetting != ConstraintSetting.NULL)
                constraint = new Constraint(cVal, constraintSetting);
            else
                constraint = null;

            //Link the device.
            linkedDevice = new DeviceIO(idString);
        }

        
    }
}
