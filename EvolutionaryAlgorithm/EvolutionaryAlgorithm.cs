using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionaryAlgorithm
{
    public class EvolutionaryAlgorithm
    {

        List<Loop> tempListBankLoop = new List<Loop>();

        /// <summary>
        /// Propiedad Sentencia Perfecta 
        /// </summary>
        private string Sentense = "ESTO ES UN ALGORITMO EVOLUTIVO";

        /// <summary>
        /// Cantidad de letras para formar la frase que contiene la variable Sentese, con 5% de probabilidad por letra
        /// </summary>
        private string Letters = " ABCDEFGHIJKLMNÑOPQRSTUVWXYZ123456789.*-/";

        /// <summary>
        /// Propiedad objeto clase Random
        /// </summary>
        Random Random_;

        /// <summary>
        /// Mètodo constructor
        /// </summary>
        public EvolutionaryAlgorithm()
        {
            Sentense = Sentense.ToUpper();
            Letters = Letters.ToUpper();
            Random_ = new Random();
            var chars = Sentense.ToCharArray();
        }

        /// <summary>
        /// Mètodo que devuelve una letra aleatoria de la cadena Letters 
        /// </summary>
        /// <returns> Caracter aleatorio contenido en la propiedad "Letters" </returns>
        private char RandomLetter()
        {
            int pos = Random_.Next(0, Letters.Length);
            return Letters[pos];
        }

        /// <summary>
        /// Mètodo para agregar el string aleatorio a la Sentence actual
        /// </summary>
        private string FillSentense()
        {

            char[] tempChar = Sentense.ToCharArray();

            for (int count = 0; count < Sentense.Length; count++)
            {
                tempChar[count] = RandomLetter();
            }

            return new string(tempChar);
        }

        /// <summary>
        /// Mètodo para calcular el puntaje de la sentencia 
        /// </summary>
        /// <param name="sentense"> Sentencia a calcular su puntaje con la propiedad "Sentense" </param>
        /// <returns> Puntaje obtenido </returns>
        private int GetScore(string sentense)
        {
            int score = 0;
            for (int pos = 0; pos < sentense.Length; pos++)
            {
                if (Sentense[pos] == sentense[pos])
                {
                    score += 1;
                }
            }

            return score;
        }

        /// <summary>
        /// Mètodo para la generaciòn
        /// </summary>
        /// <returns> Lista de Loop con la sentencia y su valor </returns>
        private List<Loop> FillBankLoop()
        {
            List<Loop> tempListBankLoop = new List<Loop>();

            for (int loop = 0; loop < 100; loop++)
            {
                Loop tempLoop = new Loop();
                tempLoop.Sentence = FillSentense();
                tempLoop.Value = GetScore(tempLoop.Sentence);
                tempListBankLoop.Add(tempLoop);

            }

            return tempListBankLoop;
        }

        /// <summary>
        /// Mètodo recursivo para obtener el loop con mejor score 
        /// </summary>
        /// <param name="generacion"> Lista de Loop </param>
        /// <param name="pos"> posiciòn en la lista </param>
        /// <param name="loop"> Mejor loop o loop actual </param>
        /// <returns> Mejor loop de la generaciòn </returns>
        private Loop BestLoop(List<Loop> generacion, int pos, Loop loop)
        {

            if (pos >= generacion.Count)
                return loop;

            else if (generacion[pos].Value > loop.Value)
            {
                loop = generacion[pos];
                return BestLoop(generacion, ++pos, loop);
            }

            return BestLoop(generacion, ++pos, loop);
        }

        /// <summary>
        /// Mètodo para acceder el mètodo recursivo BestLoop
        /// </summary>
        /// <param name="generacion"> Generaciòn actual </param>
        /// <returns> Mejor loop; Sentense con mayor value </returns>
        private Loop CallBestLoop(List<Loop> generacion)
        {
            return BestLoop(generacion, 0, generacion[0]);
        }

        /// <summary>
        /// Mètodo para obtener la probabilidad de cambiar el caracter
        /// </summary>
        /// <returns> True si la probabilidad fue 5% o false para no cambiar de forma aleatoria la letra </returns>
        private Boolean GetProbability()
        {
            int probability = Random_.Next(1, 100);
            if (probability <= 5)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para agregar caracteres faltantes contenidos en la cadena de la generación perfecta
        /// </summary>
        private void AddMissingCharacter(string cadena)
        {
            char[] tempChar = cadena.ToCharArray();
            for (int pos = 0; pos < cadena.Length; pos++)
            {
                if (!Letters.Contains(tempChar[pos].ToString()))
                {
                    Letters = Letters.Insert(Letters.Length, tempChar[pos].ToString());
                }
            }
        }

        /// <summary>
        /// Mètodo recursivo para generar copias y generaciones
        /// </summary>
        /// <param name="loop"> Objeto con la información de la mejor generación </param>
        /// <param name="generacion"> Número de la generación </param>
        /// <param name="ListBankLoop"> Lista con el mejor de cada generación </param>
        /// <returns> Lista con el mejor de cada generación </returns>
        private List<Loop> GenerateCopy(Loop loop, int generacion, List<Loop> ListBankLoop)
        {
            string tempString = loop.Sentence;
            List<Loop> tempListBankLoop = new List<Loop>();
            Loop tempLoop = new Loop();

            // Primera copia 
            if (loop.Value != Sentense.Length)
            {
                // 100 copias por cada generación 
                for (int loop_ = 0; loop_ < 100; loop_++)
                {
                    Loop tempLoop_ = new Loop();
                    char[] tempChar;
                    tempChar = tempString.ToCharArray();

                    // Se genera nueva cadena con probabilidad dl 5% de cambiar letras 
                    for (int count = 0; (count < Sentense.Length); count++)
                    {

                        // Si es true el return del mètodo GetProbability se cambia la letra en posiciòn 
                        if (GetProbability())
                        {
                            tempChar[count] = RandomLetter();
                        }

                    }

                    tempLoop_.Sentence = new string(tempChar);
                    tempLoop_.Value = GetScore(tempLoop_.Sentence);
                    tempListBankLoop.Add(tempLoop_);

                }

                // Mejor loop de la primera (1) generación
                tempLoop = CallBestLoop(tempListBankLoop);
                tempLoop.Generation = generacion;
                ListBankLoop.Add(tempLoop);
                Console.WriteLine("Generation: " + generacion + " - Mutation: " + tempLoop.Sentence + " - Score: " + tempLoop.Value);
                return GenerateCopy(tempLoop, ++generacion, ListBankLoop);
            }

            Console.WriteLine("End");
            return ListBankLoop;
        }

        /// <summary>
        /// Método que inicia el algoritmo evolutivo para obtener las generaciones 
        /// </summary>
        /// <param name="sentense"> Texto de la generación perfecta </param>
        /// <returns> Lista con el mejor de cada generación </returns>
        public List<Loop> InitAlgorithm(string sentense)
        {
            tempListBankLoop = new List<Loop>();

            EvolutionaryAlgorithm evolutionaryAlgorithm = new EvolutionaryAlgorithm();
            Loop loop = new Loop();

            evolutionaryAlgorithm.Sentense = sentense;
            evolutionaryAlgorithm.AddMissingCharacter(sentense);

            // 1. Iniciar con una cadena aleatoria de 30 caracteres.
            loop.Sentence = evolutionaryAlgorithm.FillSentense();
            loop.Value = evolutionaryAlgorithm.GetScore(loop.Sentence);

            // 2. Realizar 100 copias de la cadena inicial, teniendo en cuenta que cada carácter en la cadena copiada 
            // tendrá un 5% de probabilidad de que sea reemplazado por un nuevo carácter aleatorio.                       
            return evolutionaryAlgorithm.GenerateCopy(loop, 1, new List<Loop>());
        }

    }
}
