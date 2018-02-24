using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormStudy
{
    [Serializable]
        class PTData
    {

        public PTData()

        {

            PTID = 1;

            PTName = "None";

            PT_Data = 1.0;

        }

        public int PTID;

        public string PTName;

        public double PT_Data;

    }
}
