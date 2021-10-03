using Microsoft.AspNetCore.Mvc;
using ANAGRAMA.Entities;
using System;
using System.Linq;

/*  Universidad Tecnologica Metropolitana
    Materia: Aplicaciones Web Orientadas a Servicios
    Maestro: Chuc Uc Joel Ivan
    Actividad 2, Ejercicio 3: Anagramas
    Alumno: Ac Ku Jimmi Leonel
    Cuatrimestre: 4
    Grupo: A
    Primer Parcial
*/

namespace ANAGRAMA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnagramController : ControllerBase
    {
        public string Post (Palabra palabra)
        {
            string yesana = "Si es un anagrama";
            string noana = "No es un anagrama";

            string num1 = palabra.word1.ToLower();
            string num2 = palabra.word2.ToLower();
            string num10 = String.Concat(num1.OrderBy(c=>c)).Replace(" ","");
            string num20 = String.Concat(num2.OrderBy(c=>c)).Replace(" ","");
            

            if (num10 == num20)
            {
                return yesana;
            }
            else
            {
                return noana;
            }
        }
    }
}