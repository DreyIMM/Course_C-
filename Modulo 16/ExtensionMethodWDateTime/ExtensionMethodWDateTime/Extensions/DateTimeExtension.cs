using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExtensionMethodWDateTime.Extensions
{
    static class DateTimeExtension
    {


        //colocando meus extension methdos

        //o que determina que esse metodo é extensão do tipo dateTime (É o primeiro parametro no metodo que precisa ter o this
        public static string ElapsedTime(this DateTime thisObjs)
        {
            //tempo decorrido em mil.segundos

            TimeSpan duration = DateTime.Now - thisObjs.Date;

           if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else{

                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days" ;


            }

        }
        


    }
}
