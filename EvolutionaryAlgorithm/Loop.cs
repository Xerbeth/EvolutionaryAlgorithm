using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryAlgorithm
{
    /// <summary>
    /// Clase primaria para almacenar la sentencia y su valor 
    /// </summary>
    public class Loop
    {
        /// <summary>
        /// Propiedad para el número de la generation
        /// </summary>
        public int Generation { get; set; }

        /// <summary>
        /// Propiedad para la sentencia generada
        /// </summary>
        public string Sentence { get; set; }
        /// <summary>
        /// Valor de la sentencia, correspondiente al nivel de igualdad con el contenido de "Sentense"
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Mètodo Constructor de la clase Loop
        /// </summary>
        public Loop()
        {
            Generation = 1;
            Sentence = String.Empty;
            Value = 0;
        }
    }

    /// <summary>
    /// Clase para contener la lista de las sentencias y su valor 
    /// </summary>
    public class BankLoop
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Loop> BankLoops { get; set; }

        /// <summary>
        /// Mètodo Constructor de la clase BankLoop
        /// </summary>
        public BankLoop()
        {
            BankLoops = new List<Loop>();
        }

    }
}
