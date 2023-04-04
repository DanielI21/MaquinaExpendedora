using System;
using System.ComponentModel;

namespace MaquinaExpendedora
{
    public class View

    {
        static void Main(string[] args)
        {


            Console.WriteLine("PARQUESOFT"); 
            Console.WriteLine("BIENVENIDO A LA MAQUINA EXPENDEDORA"); // Mensaje de bienvenida

            //Definción de variables
            int opc;
            int opc2;


            Console.WriteLine("Selecciona una de las siguientes opciones:\n1.Cliente\n2.Provedor"); //Menu de opciones
            opc = Convert.ToInt32(Console.ReadLine());
            
            while (opc > 2 || opc < 1)  //Ciclo while  y Exception para prevenir errores al ingresar información
                try { 
            { 
                Console.WriteLine("Opcion equivocada, opciones disponibles son '1' o '2'");
                Console.WriteLine("Selecciona una de las siguientes opciones:\n1.Cliente\n2.Provedor");
                opc = Convert.ToInt32(Console.ReadLine());
            }
                }catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }



            switch (opc) 
            {
                case 1:
                    
                    
                    Console.WriteLine("Ha seleccionado la opcion 'cliente'");
                    Console.WriteLine("Elija una de las siguientes opciones:\n1.Chocorramo($2500 COP)\n2.Doritos($3000 COP)\n3.Jugo Hit($1500 COP)\n4.Chocolatina($1000 COP)");
                    opc2 = Convert.ToInt32(Console.ReadLine());
                    switch (opc2)
                    {
                        case 1:
                            int ingresaValorC;
                            int vuelto;
                            int valorChocorramo = 2500;
                            
                            Console.WriteLine("Ha seleccionado la opcion 'Chocorramo'\nIngrese el valor en COP con la que se pagará, sin puntos ni comas:");
                            ingresaValorC = Convert.ToInt32(Console.ReadLine());
                            vuelto = (ingresaValorC - valorChocorramo);
                            
                            Console.WriteLine("Retire el producto y el vuelto que es de: " + vuelto + " COP");
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            break;
                        case 2:
                            int ingresaValorD;
                            int vuelto_Dorito;
                            int valorDorito = 3000;

                            Console.WriteLine("Ha seleccionado la opcion 'Doritos'\nIngrese el valor en COP con la que se pagará, sin puntos ni comas:");
                            ingresaValorD = Convert.ToInt32(Console.ReadLine());
                            vuelto_Dorito = (ingresaValorD - valorDorito);

                            Console.WriteLine("Retire el producto y el vuelto que es de: " + vuelto_Dorito + " COP");
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            break;
                        case 3:
                            int ingresaValorJH;
                            int vuelto_Jugo_Hit;
                            int valorJH = 1500;

                            Console.WriteLine("Ha seleccionado la opcion 'Jugo Hit'\nIngrese el valor en COP con la que se pagará, sin puntos ni comas:");
                            ingresaValorJH = Convert.ToInt32(Console.ReadLine());
                            vuelto_Jugo_Hit = (ingresaValorJH - valorJH);

                            Console.WriteLine("Retire el producto y el vuelto que es de: " + vuelto_Jugo_Hit + " COP");
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            break;
                        case 4:
                            int ingresaValorCH;
                            int vuelto_Chocolatina;
                            int valorCH = 1000;

                            Console.WriteLine("Ha seleccionado la opcion 'Chocolatina'\nIngrese el valor en COP con la que se pagará, sin puntos ni comas:");
                            ingresaValorCH = Convert.ToInt32(Console.ReadLine());
                            vuelto_Chocolatina = (ingresaValorCH - valorCH);

                            Console.WriteLine("Retire el producto y el vuelto que es de: " + vuelto_Chocolatina + " COP");
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            break;
                        default:
                            // code block
                            break;
                    }


                    break;
                case 2:
                    string ingresaPassw;
                    string passw = "password";

                    Console.WriteLine("Ha seleccionado la opcion 'provedor'");
                    Console.Write("Digite la clave para avanzar y ver inventario:\n"); //Clave: password
                    ingresaPassw = Console.ReadLine();

                    if (ingresaPassw == passw) 
                    {
                        Console.WriteLine("Clave correcta");
                        Console.WriteLine("Lista de inventario:");
                        int uni_Chocorramo = 10;
                        int uni_Doritos = 14;
                        int uni_JH = 16;
                        int uni_Chocolatina = 13;

                        string[] inventario =
                            {
                            "Chocorramo, unidades:",
                            "Doritos, unidades:",
                            "Jugo Hit, unidades:",
                            "Chocolatina, unidades:"
                            };
                        Console.WriteLine(inventario[0] + uni_Chocorramo);
                        Console.WriteLine(inventario[1] + uni_Doritos);
                        Console.WriteLine(inventario[2] + uni_JH);
                        Console.WriteLine(inventario[3] + uni_Chocolatina);

                        int opc3;
                        int opc4;
                        int anadir_Chocorramo;
                        int anadir_Dorito;
                        int anadir_JH;
                        int anadir_CH;

                        Console.WriteLine("Desea rellenar inventario?\n1.SI\n2.NO");
                        opc3 = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            if (opc3 == 1)
                            {
                                Console.WriteLine("Elija un producto a añadir\n1.Chocorramo\n2.Doritos\n3.Jugo Hit\n4.Chocolatina");
                                opc4 = Convert.ToInt32(Console.ReadLine());
                                if (opc4 == 1)
                                {
                                    Console.WriteLine("Ingrese el número de unidades a añadir:");
                                    anadir_Chocorramo = Convert.ToInt32(Console.ReadLine());
                                    int nuevo_uni_Chocorramo;
                                    nuevo_uni_Chocorramo = (uni_Chocorramo + anadir_Chocorramo);
                                    Console.WriteLine("El número de unidades de chocorramo ahora es de: " + nuevo_uni_Chocorramo);
                                    Console.WriteLine("Gracias por su visita\nPresione enter para salir");
                                }
                                else if (opc4 == 2)
                                {
                                    Console.WriteLine("Ingrese el número de unidades a añadir:");
                                    anadir_Dorito = Convert.ToInt32(Console.ReadLine());
                                    int nuevo_uni_Doritos;
                                    nuevo_uni_Doritos = (uni_Doritos + anadir_Dorito);
                                    Console.WriteLine("El número de unidades de Doritos ahora es de: " + nuevo_uni_Doritos);
                                    Console.WriteLine("Gracias por su visita\nPresione enter para salir");
                                }
                                else if (opc4 == 3)
                                {
                                    Console.WriteLine("Ingrese el número de unidades a añadir:");
                                    anadir_JH = Convert.ToInt32(Console.ReadLine());
                                    int nuevo_uni_JH;
                                    nuevo_uni_JH = (uni_JH + anadir_JH);
                                    Console.WriteLine("El número de unidades de Jugos Hit ahora es de: " + nuevo_uni_JH);
                                    Console.WriteLine("Gracias por su visita\nPresione enter para salir");
                                }
                                else if (opc4 == 4)
                                {
                                    Console.WriteLine("Ingrese el número de unidades a añadir:");
                                    anadir_CH = Convert.ToInt32(Console.ReadLine());
                                    int nuevo_uni_CH;
                                    nuevo_uni_CH = (uni_Chocolatina + anadir_CH);
                                    Console.WriteLine("El número de unidades de Chocolatinas ahora es de: " + nuevo_uni_CH);
                                    Console.WriteLine("Gracias por su visita\nPresione enter para salir");

                                }
                                else
                                {
                                    Console.WriteLine("Opcion invalida intente de nuevo");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Gracias por su visita.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    Console.ReadKey();
                    break;
                default:
                    // code block
                    break;
            }

        }
    }
}

