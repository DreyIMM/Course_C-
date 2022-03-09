using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoSet.Entities
{
    internal class Students
    {
        public int Cod_Studentes { get; set; }

      

        public Students(int cod_Studentes)
        {
            Cod_Studentes = cod_Studentes;
          
        }

        public override int GetHashCode()
        {
            return Cod_Studentes.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Students))
            {
                return false;
            }

            Students students = (Students)obj;
            return Cod_Studentes.Equals(students.Cod_Studentes);



        }



    }
}
