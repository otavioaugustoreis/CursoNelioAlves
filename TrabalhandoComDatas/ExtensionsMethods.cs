using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    public static class ExtensionsMethods
    {
        //Método de extensão da classe DateTime
        public static int CompararDatasHoras(this DateTime thisObj, DateTime otherObj)
        {
            TimeSpan duration = thisObj.Subtract(otherObj);
            return ((int)duration.TotalHours);
        }

        public static int CompararDatasDias(this DateTime thisObj, DateTime otherObj)
        {
            TimeSpan duration = thisObj.Subtract(otherObj);
            return duration.Days;
        }
    }
}
