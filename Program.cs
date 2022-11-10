using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HolaBuenasTardes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string usuarioAcceso,direccionUsuario, apellidoUsuario, celularUsuario, perfilUsuario, contraseña, confirmarContraseña;
            byte edadUsuario;
            //personalizacion de la consola
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();


            //pregunta de la edad
            Console.WriteLine("Ingresa tu edad, despues presione ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());
            //aqui empieza el if
            if (edadUsuario >= 18)
            {
                //pedir datos al usuario
                Console.WriteLine("Ingresa tu nombre");
                usuarioAcceso = Console.ReadLine();
                Console.WriteLine("Ingresa tu apellido");
                apellidoUsuario = Console.ReadLine();


                Console.WriteLine("ingresa tu perfil de Facebook");
                perfilUsuario = Console.ReadLine();
                Console.WriteLine("ingresa tu celular");
                celularUsuario = Console.ReadLine();

                Console.WriteLine("cual es tu direccion?(calle ,colonia y codigo postal)");
                direccionUsuario = Console.ReadLine();


                Console.WriteLine("Ingresa tu contraseña");
                contraseña = Console.ReadLine();
                Console.WriteLine("confirma tu contraseña");
                confirmarContraseña = Console.ReadLine();

                //muestra de datos
                

             
                if (contraseña == confirmarContraseña)
                {
                    Console.Clear();
                    Console.WriteLine("\n nombre:{0} \n apellido:{1} \n celular:{2} \n direccion:{3} \n perfil del usuario:{4}",usuarioAcceso,apellidoUsuario,celularUsuario,direccionUsuario,perfilUsuario);

                    Random aleatorio = new Random();
                    int codigo = aleatorio.Next(1000, 9999);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("el codigo es:" + codigo);


                }
                else
                {//si la contraseña es incorrecta o no coincide se mostraran los datos
                 //mas no el codigo de acceso y le pedira l usuario que repita el formulario
                    Console.Clear();
                    Console.WriteLine("contraseña no validada,repita el formulario");
                    Thread.Sleep(3000);
                    return;
                }

                

            } 
            else { Console.WriteLine("No eres mayor de edad , no puedes completar el registro"); }






            


            Console.ReadKey();
        }
    }
}
