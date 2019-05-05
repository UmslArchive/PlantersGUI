using System;
using System.Collections.Generic;

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
        public string id;
        public string varName;
        public Constraint constraint;
        public ConstraintSetting currentSetting;

        //Constructor.
        public Device(string idString, string var, decimal cVal, string setting)
        {
            //Set string variables.
            id = idString;
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

                default: //case "="
                    currentSetting = ConstraintSetting.EQUAL;
                    break;
            }

            //Set the constraint.
            constraint = new Constraint(cVal, currentSetting);
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
