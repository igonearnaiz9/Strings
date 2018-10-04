using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Escribe un programa que te calcule la largura de un string.

            //string nombre;

            //Console.WriteLine("Dame un nombre");
            //nombre = Console.ReadLine();
            //Console.WriteLine(nombre.Length);

            //Console.ReadLine();

            ////Escribe un programa que nos cuente el número de vocales en un string.

            //string texto;
            //int vocales = 0;

            //Console.WriteLine("Dame una frase");
            //texto = Console.ReadLine();


            //for (int i = 0; i < texto.Length; i++)   //analizamos la palabra letra por letra; 
            //                                        //lo hacemos tantas veces como larga sea la palabra
            //                                        //cada vuelta añadimos una unidad
            //{
            //    if(texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
            //        //los caracteres se ponen con una comilla (la de debajo de ?)
            //        //con texto[] accedemos a los caracteres
            //    {
            //        vocales++;// va sumando las vocales
            //    }
            //}

            //Console.WriteLine("La palabra "+ texto + " tiene "+ vocales + " vocales");



            //Console.ReadLine();

            //Escribe un programa que te calcule el total de palabras que hay en un string.

            //string frase;
            //int palabras = 1;

            //Console.WriteLine("Dame una frase");
            //frase = Console.ReadLine();


            //for (int i = 0; i < frase.Length; i++)   
            //{
            //    if (frase[i] == ' ' )

            //    {
            //        palabras++;
            //    }
            //}

            //Console.WriteLine("La frase " + frase + " tiene " + palabras + " palabras");
            //Console.ReadLine();



            //Escribe un programa que copia un string a otro string.

            //string a;
            //string b;
            //Console.WriteLine("Dame una frase");
            //a = Console.ReadLine();

            //b = string.Copy(a);
            //Console.WriteLine(b);

            //Console.ReadLine();

            //Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.

            //string frase1;

            //Console.WriteLine("Dame una frase");
            //frase1 = Console.ReadLine();

            //for (int i = 0; i < frase1.Length; i++)//analizamos letra por letra
            //{
            //    if (frase1[i] >= 'a' && frase1[i] <= 'z') // si las letras son minúsculas
            //    {
            //       frase1=frase1.ToUpper(); //me lo convierte en mayusculas
            //    }
            //    else
            //    {
            //        frase1 = frase1.ToLower();//al revés
            //    }
            //}
            //Console.WriteLine(frase1);// no hay que meterlo dentro del for porque si no me lo escribe
            //tantas veces conmo caracteres tiene la frase

            //Console.ReadLine();


            //Escribe un programa que evalúe si un string contiene la letra ‘r’.

            //string frase5;
            //bool tiener = false;

            //Console.WriteLine("Dame una frase");
            //frase5 = Console.ReadLine();

            //  for (int i = 0; i < frase1.Length; i++) //analizamos letra por letra
            //{
            //    if (frase5[i] == 'r'||frase5[i] == 'R')
            //    {
            //            tiener = true; //si tiene r
            //    }
            //} // la llave aquí porque si no me repite las soluciones
            //if (tiener)   
            //    {
            //        Console.WriteLine("La frase contiene r");
            //    }
            //else
            //    {
            //        Console.WriteLine("La frase  no contiene r");
            //    }
            //Console.ReadLine();



            //Escribe un programa el que dada una frase sacará su carácter central. Nota:
            //Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            //Si es impar deberá sacar su único carácter central.

            //string frase6;
            //int letras;
            //bool par;

            //Console.WriteLine("Dame una frase");
            //frase6 = Console.ReadLine();

            //letras = frase6.Length; //ya me da la largura sin necesidad de hacer un for, no necesito lo de abajo
            //                        //for (int i = 0; i < frase6.Length; i++)
            //                        //{
            //                        //    letras++;
            //                        //}
            //if (letras %2==0)
            //{
            //    par = true;
            //    Console.WriteLine(" "+frase6[(letras / 2)] + frase6[((letras / 2)+ 1)]);
            //    //Console.WriteLine(frase6[(letras / 2)] + frase6[((letras / 2)+ 1)]);
            //    //entiende que quieres la suma de 2 caracteres en codigo ascii
            //    //para que no pase le añadimos una cadena de texto al principio
            //}
            //else
            //{
            //    Console.WriteLine(frase6[letras / 2]);
            //}
            //Console.ReadLine();




            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. 
            //Para que la contraseña sea correcta deberá cumplir estas directivas:
            //Debe tener 8 caracteres como mínimo.
            //La contraseña deberá contener números.
            //Deberá contener al menos dos dígitos. 

            //string password;
            //bool correcto = false;
            //int digitos = 0;

            //do
            //{
            //    Console.WriteLine("Introduce tu contraseña");
            //    password = Console.ReadLine();

            //    if (password.Length >= 8)
            //    {
            //        for (int j = 0; j < password.Length; j++)
            //        {
            //            if ((password[j] >= '0' || password[j] <= '9') == true)
            //            // if(char.IsDigit(password[j])==true)
            //            {
            //                digitos++;//me está contando cuantos dígitos hay
            //            }
            //            if (digitos >= 2)
            //            {
            //                correcto = true; //no se pone el mensaje porque lo repite,  sólo esta parte es la condición correcta
            //            }
            //        }
            //    }
            //    if (correcto == false) //tengo que hacer esta condición para que me imprima el mensaje
            //        {
            //            Console.WriteLine("La contraseña no es válida");
            //        }

            //} while (correcto==false);

            //Console.WriteLine("La contraseña tiene una estructura correcta");

            //Console.ReadLine();



            //Escribe un programa que al meter tres números por teclado identifique el mínimo y el máximo
            //(usa el método correspondiente). 

            //int num31;
            //int num32;
            //int num33;
            //int max;
            //int min;

            //Console.WriteLine("Introduce un número");
            //num31 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce un número");
            //num32 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce un número");
            //num33 = Convert.ToInt32(Console.ReadLine());


            //max= Math.Max(num31, num32);
            //min = Math.Min(num31, num32);

            //if (max< num33)
            //{
            //    max = num33;
            //}

            //    Console.WriteLine("El máximo es: "+ max);
            //if (min < num33)
            //{
            //    min = min;
            //}

            //Console.WriteLine("El mínimo es: "+min );

            // Console.ReadLine();

            //Escribe un programa que muestre la fecha de hoy.

            //DateTime fecha;

            //fecha = DateTime.Today;
            //Console.WriteLine(fecha);
            //Console.ReadLine();










        }
    }
}