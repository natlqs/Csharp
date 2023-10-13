using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 朝夕_WPF_数据采集与监控项目.Base
{
    internal static class ExtendClass
    {
        public static float ByteArraysToFloat(this byte[] value)
        {
            float fValue = 0f;
            uint nRest = ((uint)value[2])*256
                + ((uint)value[3])*256 + 
                65536 * (((uint)value[0])*256 + ((uint)value[1]));
            unsafe
            {
                float* ptemp;
                ptemp = (float*)(&nRest);
                fValue = *ptemp;
            }
            return fValue;

        }
    }
}
