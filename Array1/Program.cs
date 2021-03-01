using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Un programa que pida al usuario 4 números, los 
            //memorice (utilizando un array), calcule su media aritmética 
            //y después muestre en pantalla la media y los datos tecleados

            // double[] num=new double[4];
            // double sum=0, med;
            // for (int i=0; i<4; i++)
            // {
            //     Console.WriteLine("Digite un número {0}: ",i+1);
            //     num[i]=Convert.ToDouble(Console.ReadLine());
            //     sum+=num[i];
            // }
            // med=sum/4;
            // Console.Clear();
            // Console.WriteLine("Los números ingresados son: ");
            // for (int x=0; x<4; x++)
            // {
            //     Console.WriteLine("({0}) ",num[x]);
                
            // }
            // Console.WriteLine("Y la media aritmética es: {0}",med);
            // Console.ReadKey();
            //______________________________________________________________________

            //2. Un programa que pida al usuario 5 números 
            //reales (pista: necesitarás un array de "float") y 
            //luego los muestre en el orden contrario al que se introdujeron.

            // float[] a= new float[5];
            // for (int i=0; i<5; i++)
            // {
            //     Console.WriteLine("Digite un número {0}: ",i+1); 
            //     a[i]=float.Parse(Console.ReadLine());
            // }
            // Array.Reverse(a);
            // Console.Clear();
            // for (int x=0; x<5; x++)
            // {
            //     Console.WriteLine("({0}) ",a[x]);
            // }
           
            // Console.ReadKey();
            //___________________________________________________________________

            //3. Un programa que almacene en un array el 
            //número de días que tiene cada mes (supondremos que 
            //es un año no bisiesto), pida al usuario que le indique 
            //un mes (1=enero, 12=diciembre) y muestre en pantalla 
            //el número de días que tiene ese mes.

            // string[] ndias={
            // "", "Enero posee 31 días", "Febrero posee 28 días",
            // "Marzo posee 31 días", "Abril posee 30 días", "Mayo posee 31 días", "Junio posee 30 días", 
            // "Julio posee 31 días", "Agosto posee 31 días", "Septiembre posee 30 días",
            // "Octubre posee 31 días", "Nobiembre posee 30 días", "Diciembre posee 31 días"
            // };
            // int a;
            // Console.WriteLine("Digite un mes, (1=enero, 12=diciembre)");
            // a=int.Parse(Console.ReadLine());
            // Console.Clear();
            // if (a>0)
            // {
            //     if (a<13)
            //     {
            //         Console.WriteLine("{0}",ndias[a]);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Digite números del 1 al 12");
            //         Console.WriteLine("1=enero, 12=diciembre");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Digite números del 1 al 12");
            //     Console.WriteLine("1=enero, 12=diciembre");
            // }
            // Console.ReadKey();
            //______________________________________________________________________

            //4. Un programa que pida al usuario 10 números y luego calcule 
            //y muestre cuál es el mayor de todos ellos.

            // int[] datos = new int[11];
            // int i, mayor = 0, x = 0;
            // for (i = 0; i < 10; i++)
            // {
            //    Console.WriteLine("Digite el valor de la posicion {0}: ", (i + i));
            //    datos[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // while (x < 11) 
            // {
            // if (datos[x] > mayor)
            //    mayor = datos[x];
            //    x++;
            // }
            // Console.Clear();
            // Console.WriteLine("el mayor de los datos es: {0}", mayor);
            // Console.ReadKey();
            //_________________________________________________________________________

            //5. Un programa que prepare espacio para un máximo de 100 nombres.
            //El usuario deberá ir introduciendo un nombre cada vez, 
            //hasta que se pulse Intro sin teclear nada, momento en el que 
            //dejarán de pedirse más nombres y se mostrará en 
            //pantalla la lista de los nombres que se han introducido.

            // string[] nombre = new string[100];
            // int i = 0,b=0;
            // do
            // {
            //    Console.WriteLine("teclee un nombre");
            //    nombre[i] = Console.ReadLine();
            //    i=i+1;
            //    b=b+1;
            // }while (nombre[i-1] != "");
            // Console.WriteLine("fin");
            // for (i = 0; i < 99; i++);
            // Console.Clear();
            // Console.WriteLine("los nombres tecleados son los siguientes");
            // for (int y=0; y<b; y++)
            // {
            //     Console.WriteLine("{0}",nombre[y]);
            // }
            //___________________________________________________________________

            //6. Un programa que permita guardar datos de "imágenes" 
            //(ficheros de ordenador que contengan fotografías o cualquier 
            //otro tipo de información gráfica). De cada imagen se debe guardar: 
            //nombre (texto), ancho en píxeles (por ejemplo 2000), alto en píxeles 
            //(por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El programa 
            //debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando 
            //su capacidad esté llena). Debe permitir las opciones: añadir una ficha 
            //nueva, ver todas las fichas (número y nombre de cada imagen), buscar la 
            //ficha que tenga un cierto nombre.

            // string[] ima=new string[700];
            // string[] anc=new string[700];
            // string[] alt=new string[700];
            // double[] tam=new double[700];
            // int a,i=0, j=0, h=0, k=0, l=0;
            // string b;
            // do
            // {
            //     Console.WriteLine("Elija una opción");
            //     Console.WriteLine("(0) Para salir");
            //     Console.WriteLine("(1) añadir una ficha nueva");
            //     Console.WriteLine("(2) ver fichas almacenadas");
            //     Console.WriteLine("(3) Buscar ficha");              
            //     a=int.Parse(Console.ReadLine());
            //     Console.Clear();
            //     if (a==1)
            //     {
            //         do
            //         { 

            //             Console.WriteLine("Digite nombre de imagen");
            //             Console.WriteLine("Pulse (s) para volver a menú");
            //             ima[i]=Console.ReadLine();
            //             i++;
            //             if (ima[i-1]=="s")
            //             {
            //                 i--;
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Digite ancho de pixeles");
            //                 anc[j]=Console.ReadLine();
            //                 j++;
            //                 Console.WriteLine("Digite alto de pixeles");
            //                 alt[h]=Console.ReadLine();
            //                 h++;
            //                 Console.WriteLine("Digite tamaño en kb");
            //                 tam[k]=Convert.ToDouble(Console.ReadLine());
            //                 k++;
            //             }
            //             Console.Clear();
            //         }while(ima[i] != "s");
            //     }
            //     if (a==2)
            //     {
            //         for (int x=0; x<i; x++)
            //         {
            //             Console.WriteLine(ima[x]);
            //             Console.WriteLine("{0}*{1} Pixeles",anc[x], alt[x]);
            //             Console.WriteLine("Pesa {0}Kb",tam[x]);
            //             Console.WriteLine("--•--•--•--•--•--•--•--•--•--•--•--•--•--•--•--•--");
            //         }
            //         Console.WriteLine("Pulse (enter) para volver a menú");
            //         Console.ReadLine();
            //     }
            //     if (a==3)
            //     {
            //         Console.WriteLine("Digite nombre de ficha");
            //         b=Console.ReadLine();
            //         for (int v=0; v<i; v++)
            //         {
                        
            //             if (ima[v]==b)
            //             {

            //                 Console.Clear();
            //                 Console.WriteLine(ima[l]);
            //                 Console.WriteLine("{0}*{1} Pixeles",anc[l], alt[l]);
            //                 Console.WriteLine("Pesa {0}Kb",tam[l]);
            //                 Console.WriteLine("--•--•--•--•--•--•--•--•--•--•--•--•--•--•--•--•--");
            //             }
            //             l++;
            //         }
            //         Console.ReadLine();
            //     }
            // }while(a!=0);
            //__________________________________________________________________________

            //7. Un programa que te pida tu nombre y lo muestre en 
            //pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, 
            //si tu nombre es "Juan", debería aparecer en pantalla "J u a n".

            // Console.WriteLine("Digite su nombre");
            // string nombre = Console.ReadLine();
            // char[] nom = nombre.ToCharArray();
            // foreach (char i in nom)
            // {

            //     Console.Write("{0} ", i);
            // }
            //__________________________________________________________________________

            //8. Crear un programa que defina un array de 5 elementos 
            //de tipo float que representen las alturas de 5 personas.
            //Obtener el promedio de las mismas. Contar cuántas personas 
            //son más altas que el promedio y cuántas más bajas.

            //IMPORTANTE!!!!!.
            //PARA EJECUTAR ESTE EJERCICIO TODO, ABSOLUTAMENTE TODO EXEPTO EL 
            //EJERCICIO DEBE ESTAR BAJO COMENTARIO 

            // using System;
            // using System.Collections;
            // using System.Linq;
            // using System.Text;
            // namespace ejercicioocho
            // {
            //     class PruebaVector2
            //     {
            //         private float[] alturas;
            //         private float promedio;

            //         public void Cargar() 
            //         {
            //             alturas=new float[5];
            //             for (int f = 0; f < 5; f++)
            //             {
            //                 Console.Write("Ingrese la altura de la persona:");
            //                 string linea = Console.ReadLine();
            //                 alturas[f] = float.Parse(linea);
            //             }
            //         }
            //         public void CalcularPromedio() 
            //         {
            //             float suma;
            //             suma=0;
            //             for(int f=0; f < 5; f++) 
            //             {
            //                 suma=suma+alturas[f];
            //             }
            //             promedio=suma/5;
            //             Console.WriteLine("Promedio de alturas:"+promedio);
            //         }
            //         public void MayoresMenores() 
            //         {
            //             int may=0,men=0,iprom=0;
            //             for(int f = 0; f < 5; f++) 
            //             {
            //                 if (alturas[f] > promedio) 
            //                 {
	        //                     may++;
            //                 }
            //                 else
            //                 {
            //                     if (alturas[f] < promedio) 
            //                     {
            //                        men++;
            //                     }
            //                     else
            //                     {
            //                         if (alturas[f]==promedio)
            //                         {
            //                             iprom++;
            //                         }
            //                     }
            //                 }
            //             }
            //             Console.Clear();
            //             Console.WriteLine("Cantidad de personas mayores al promedio: "+may);
            //             Console.WriteLine("Cantidad de personas menores al promedio: "+men);
            //             Console.WriteLine("Cantidad de personas igual al promedio: "+iprom);
                        
            //         }
            //         static void Main(string[] args)
            //         {
            //             PruebaVector2 pv2 = new PruebaVector2();
            //             pv2.Cargar();
            //             pv2.CalcularPromedio();
            //             pv2.MayoresMenores();
            //             Console.ReadKey();
            //         }
            
            //     }                  
            // } 
            //__________________________________________________________________________

            //9. Crear una clase que permita ingresar valores enteros 
            //por teclado y nos muestre la tabla de multiplicar de dicho 
            //valor. Finalizar el programa al ingresar el -1.

            // int a,b,i;
            // do
            // {
            //     Console.WriteLine("Digite un número");
            //     a=int.Parse(Console.ReadLine());
            //     Console.Clear();
            //     if (a > -1)
            //     {
            //         for (i = 1; i<11; i++)
            //         {
            //             b=a*i;
            //             Console.WriteLine("{0}*{1} = {2}",a,i,b);
            //         } 
            //         Console.ReadLine();  
            //     }
            //     Console.Clear();
            // }while (a !> -1);

            //__________________________________________________________________________

            //10. Confeccionar una clase que permita carga el nombre 
            //y la edad de una persona. Mostrar los datos cargados. 
            //Imprimir un mensaje si es mayor de edad (edad>=18).

            //IMPORTANTE!!!!!.
            //PARA EJECUTAR ESTE EJERCICIO TODO, ABSOLUTAMENTE TODO EXEPTO EL 
            //EJERCICIO DEBE ESTAR BAJO COMENTARIO

            // using System;
            // using System.Collections;
            // using System.Linq;
            // using System.Text;

            // namespace PruebaClase1
            // {
            //     class Persona 
            //     { 
            //         private string nombre;
            //         private int edad;

            //         public void Inicializar()
            //         {
            //             Console.Write("Ingrese el nombre: ");
            //             nombre = Console.ReadLine();
            //             string linea;
            //             Console.Write("Ingrese la edad: ");
            //             linea = Console.ReadLine();
            //             edad = int.Parse(linea);
            //         }

            //         public void Imprimir()
            //         {
            //             Console.Write("Nombre: ");
            //             Console.WriteLine(nombre);
            //             Console.Write("Edad: ");
            //             Console.WriteLine(edad);
            //         }

            //         public void EsMayorEdad()
            //         {
            //             if (edad >= 18)
            //             {
            //                 Console.WriteLine("Es mayor de edad");
            //             }
            //             else
            //             {
            //                 Console.WriteLine("No es mayor de edad");
            //             }
            //             Console.ReadKey();
            //         }


            //         static void Main(string[] args)
            //         {
            //             Persona per1 = new Persona();
            //             per1.Inicializar();
            //             Console.Clear();
            //             per1.Imprimir();
            //             per1.EsMayorEdad();
            //         }
            //     }
            // }
 
        }
    }
}
