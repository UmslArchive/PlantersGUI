using System;
using System.Collections.Generic;

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

        public class Constraint
        {
            public decimal lowerBound;
            public decimal upperBound;

            public Constraint(decimal constraintValue, ConstraintSetting setting)
            {
                switch (setting)
                {
                    case ConstraintSetting.LESS:
                        lowerBound = System.Decimal.MinValue;
                        upperBound = constraintValue - 0.001M;
                        break;

                    case ConstraintSetting.GREATER:
                        lowerBound = constraintValue + 0.001M;
                        upperBound = System.Decimal.MaxValue;
                        break;

                    case ConstraintSetting.LESSEQUAL:
                        lowerBound = System.Decimal.MinValue;
                        upperBound = constraintValue;
                        break;

                    case ConstraintSetting.GREATEREQUAL:
                        lowerBound = constraintValue;
                        upperBound = System.Decimal.MaxValue;
                        break;

                    default: //case EQUAL.
                        lowerBound = constraintValue;
                        upperBound = constraintValue;
                        break;
                }
            }
        }

        //Data.
        public string deviceID;
        public string varName;
        public Constraint constraint;
        public ConstraintSetting currentSetting;

        //Constructor.
        public UserVariable(string idString, string var, decimal cVal, string setting)
        {
            //Set string variables.
            deviceID = idString;
            varName = var;

            //Set currentSetting based on passed setting string.
            switch (setting)
            {
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

                case "=":
                    currentSetting = ConstraintSetting.EQUAL;
                    break;
                   
                default: //Null case. (box unchecked)
                    currentSetting = ConstraintSetting.NULL;
                    break;
            }

            //Set the constraint.
            if (currentSetting != ConstraintSetting.NULL)
                constraint = new Constraint(cVal, currentSetting);
            else
                constraint = null;
        }

        //Function that connects the device and assigns a name.
        public void HandshakeDevice()
        {
            
        }
    }
}
