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
        public string name;
        public DeviceIO linkedDevice;
        public Constraint constraint;
        public ConstraintSetting constraintSetting;

        //Constructor.
        public UserVariable(string idString, string varName, decimal cVal, string setting)
        {
            //Set string variables.
            name = varName;

            //Link the IO device.
            if (LinkIODevice() != 0)
                MessageBox.Show("Device Link Error.");            
                       
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
        }

        //Link an IO device to a user variable.
        private int LinkIODevice()
        {
            return 0;
        }
    }
}
