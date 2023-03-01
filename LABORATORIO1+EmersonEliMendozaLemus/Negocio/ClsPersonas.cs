using LABORATORIO1_EmersonEliMendozaLemus.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace LABORATORIO1_EmersonEliMendozaLemus.Negocio
{
    public class ClsPersonas

    {
        public String calcularIMC(Personas personas) {
            double pro = personas.Peso /
             Math.Pow(personas.Altura, 2);
                if (pro <= 24)
                
                {
                    return "Tu peso es ideal";
                } return " tu tienes Sobre peso";


            }
        public string EsMayorDeEdad(Personas edad)

        {
            if (edad.Edad < 18) {
                return "Tu eres menor  de edad";

            }return "Tu eres mayor de edad";
        }
        }
        
         
        
    }

