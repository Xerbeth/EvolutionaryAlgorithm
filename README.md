# EvolutionaryAlgorithm
Algoritmo Evolutivo 

En este ejercicio se implementa un algoritmo evolutivo, los pasos se describen a continuación:
1. Se inicia con una cadena aleatoria de 30 caracteres.
2. Se Realizan 100 copias de la cadena inicial, teniendo en cuenta que cada carácter en la cadena copiada tendrá un 5% de
probabilidad de que sea reemplazado por un nuevo carácter aleatorio.
3. El sistema Compara cada una de las 100 cadenas generadas con el texto escrito referenciado como la generación perfecta, y da a cada
cadena un puntaje. El puntaje corresponde al número de caracteres en la cadena copiada que se corresponden con el
texto digitado.
4. Si alguna de las cadenas generadas tiene un puntaje perfecto, el algoritmo termina.
5. De otro modo, se toma la cadena (entre las 100 generadas) que tenga el puntaje más alto y se inicia desde el paso 2,
tomando dicha cadena como punto de partida.
6. Cada iteración del algoritmo se conoce como una Generación. Se mostrará en pantalla la cadena con el
puntaje más alto de cada generación.
7. Para propósitos de este algoritmo, un carácter es cualquier letra en mayúscula o un espacio en blanco aun así si le digita 
para la generación perfecta un caracter que no este cargado previamente, el sistema lo añadira al banco de caracteres para
utilizarlo en cada geración. 
8. Los caracteres correctos de cada generación no se bloquean, esto quiere decir que un carácter correcto se podría volver
incorrecto en las generaciones subsecuentes
