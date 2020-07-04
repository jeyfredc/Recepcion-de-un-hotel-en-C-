using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;

namespace HotelWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int opcion;
            string elec;
            string elecs;
            string planOp;
            string factura;
            string nombre;
            int opcionCama=0;
            int opcionPlan = 0;
            int randomNumber = new Random().Next(1, 1000);
            string fechaIngreso;
            string fechaSalida;
            DateTime fecha = DateTime.Now;
            int cedula;
            int dia;
            int adultos;
            int niños;
            int camaDoble=0;
            int camaSencilla=0;
            int pra = 30000;//precio x adulto sm
            int prn = 5000;//precio x niño sm
            int sm = 100000;//Precio Santa Marta
            int cd = 30000;//Precio Cama Doble sm
            int cs = 15000;//Precio Cama Sencilla sm
            int pd = 6000;//Precio desayuno sm
            int prab = 3000;//precio x adulto bq
            int prnb = 5000;//precio x niño bq
            int bq = 80000;//Precio Barranquilla
            int cb = 20000;//Precio Cama Doble bq
            int cbs = 10000;//Precio Cama Sencilla bq
            int pdb = 4000;//Precio desayuno bq
            int ct = 120000;//Precio Cartagena
            int prac = 25000;//precio x adulto ct
            int prnc = 15000;//precio x niño ct
            int cbc = 32000;//Precio Cama Doble ct
            int csc = 22000;//Precio Cama Sencilla ct
            int pdc = 17000;//Precio desayuno bq
            int plan = 0;
            int numIngreso;
            int numSalida;

            Console.WriteLine(" ___________________________________________________________________________________________________________________");
            Console.WriteLine("|                                                                                                                   |");
            Console.WriteLine("|                                           HOTEL DE LA PROGRAMACION WEB                                            |");
            Console.WriteLine("|___________________________________________________________________________________________________________________|");

            Console.WriteLine(" ___________________________________________________________________________________________________________________");
            Console.WriteLine("|Bienvenido a nuestro hotel podras encontrar planes de hospedaje, bar, piscina, vista al mar y guias turisticos     |");
            Console.WriteLine("|queremos que tu visita sea inolvidable, a continuacion por favor selecciona la opcion que deseas consultar         |");
            Console.WriteLine("|___________________________________________________________________________________________________________________|\n");
            do
            {
                Console.WriteLine(" ___________________________________________________________________________________________________________________");
                Console.WriteLine("|                    valor dia "+ "                                                                                     |");
                Console.WriteLine("|1. Santa Marta.      $ " + sm +"                                                                                      |");
                Console.WriteLine("|2. Barranquilla.     $ " + bq +"                                                                                       |");
                Console.WriteLine("|3. Cartagena.        $ " + ct +"                                                                                      |");
                Console.WriteLine("|4. Salir del menú" + "                                                                                                  |");
                Console.WriteLine("|___________________________________________________________________________________________________________________|");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("por favor indique fecha de ingreso en formato yyyy/mm/dd, no incluya caracteres especiales, puntos o comas");
                        fechaIngreso = Console.ReadLine();

                        numIngreso = Int32.Parse(fechaIngreso);

                        Console.WriteLine("por favor indique fecha de salida en formato yyyy/mm/dd,no incluya caracteres especiales, puntos o comas");
                        fechaSalida = Console.ReadLine();

                        numSalida = Int32.Parse(fechaSalida);

                        Console.WriteLine("por favor ingrese numero de adultos. Valor por adulto de ->" + pra);
                        adultos = int.Parse(Console.ReadLine());

                        Console.WriteLine("por favor ingrese numero de niños. Valor por niño de ----->" + prn);
                        niños = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Por favor seleccione tipo de cama y numero que requiere para la habitacion, no debe exceder mas de 3 camas dobles o mas de 3 sencillas");
                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                    valor unitario " + "                                                                                |");
                            Console.WriteLine("|1. Cama Doble.        $ " + cd + "                                                                                      |");
                            Console.WriteLine("|2. Cama Sencilla.     $ " + cs + "                                                                                      |");
                            Console.WriteLine("|3. Salir                                                                                                           |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionCama = int.Parse(Console.ReadLine());

                            switch (opcionCama)
                            {
                                case 1:
                                    do
                                    {
                                        Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                        camaDoble = int.Parse(Console.ReadLine());
                                        if (camaDoble > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaDoble > 4);
                                    break;

                                case 2:

                                    Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                    camaSencilla = int.Parse(Console.ReadLine());

                                    do
                                    {
                                        if (camaSencilla > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaSencilla > 4);
                                    break;
                                case 3:

                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }

                        } while (opcionCama > 3);


                        do
                        {
                            Console.WriteLine("por favor seleccione SI/NO para incluir bar y servicio de habitaciones\n");

                            elec = Console.ReadLine();

                            if (elec == "SI")
                            {
                                do
                                {
                                    Console.WriteLine("\nEn el desayuno, comer como un rey. Cada mañana de 07:00 a 10:30, le ofrecemos un copioso y variado desayuno buffet... " +
                                    "pasteles, tortas, panqueques, ensalada de fruta fresca, cereales, yogur, chacuteria, queso y muchas otras especialidades son seleccionados " +
                                    "y preparadas con esmero.... También puede pedir un de desayuno continental en la habitación entre las 6:30 am y las 11... Precio: $" + pd + " por persona y día\n" +
                                    "¿desea agregar el servicio de desayuno a su cuenta? SI/NO\n");

                                    elecs = Console.ReadLine();

                                    if (elecs == "SI")
                                    {
                                        Console.WriteLine("Esperamos que disfrute nuestros desayunos y su estadia en el hotel de la programacion web");
                                    }
                                    else if (elecs == "NO")
                                    {
                                        pd = 0;
                                        Console.WriteLine("Le recomendamos comer en el hotel o cerca del hotel para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                                    }
                                } while (elecs != "SI" && elecs != "NO");
                            }
                            else if (elec == "NO")
                            {
                                Console.WriteLine("Le recomendamos comer en el hotel o cerca del hotel para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                            }
                        } while (elec != "SI" && elec != "NO");

                        do
                        {
                            Console.WriteLine("\nPor favor elige uno de nuestros paquetes turisticos, por este mes no haremos cobro por persona, si no en combo. Aprovecha(^_^)");

                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                                             valor unitario                                                        |");
                            Console.WriteLine("|1. Tayrona, ancestral y mágico.               $300.000                                                             |");
                            Console.WriteLine("|2. Acuario y Museo del Mar de El Rodadero     $210.000                                                             |");
                            Console.WriteLine("|3. Mamancana, aventura y relajación           $150.000                                                             |");
                            Console.WriteLine("|4. Salir, no deseo adquirir ningun plan                                                                            |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionPlan = int.Parse(Console.ReadLine());

                            switch (opcionPlan)
                            {
                                case 1:

                                    Console.WriteLine("\nUsted eligio Tayrona, ancestral y mágico, El parque ofrece playas como Arrecifes, " +
                                        "La Piscina, Cabo San Juan, Cañaveral, algunas con servicio de cabañas y otras con\n zonas de camping, " +
                                        "servicio de baños y restaurantes. Se recomienda mínimo tres días para conocer esta región y realizar " +
                                        "caminatas, careteo, buceo y recorrer\n los vestigios arqueológicos de Pueblito, una antigua ciudad del " +
                                        "pueblo Tayrona.");
                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Tayrona");
                                            plan = 300000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 2:

                                    Console.WriteLine("\nUsted eligio Acuario y Museo del Mar de El Rodadero, Se encuentra a diez minutos en lancha " +
                                        "desde El Rodadero. Cuenta con un ‘show’ de delfines y lobos marinos. En este lugar pueden observarse más de " +
                                        "100 especies de peces, tortugas marinas, reptiles, entre otros. También cuenta con una exposición de piezas " +
                                        "arqueológicas únicas de la cultura tayrona incluye el transporte en lancha.");
                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Acuario");
                                            plan = 210000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 3:

                                    Console.WriteLine("\nUsted eligio Mamancana, aventura y relajación, Esta reserva natural privada de bosque seco tropical" +
                                        " espinoso ofrece servicios de deportes extremos como canopy, muro de escalada, rappel, ciclomontañismo y travesías " +
                                        "en vehículos 4x4. Este lugar tiene un diseño ancestral inspirado en las tribus indígenas de la región y definido por +" +
                                        "el uso de piedras, madera y paja, que recrea un ambiente único que hace de la estadía una experiencia inolvidable." +
                                        "");

                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Mamancana");
                                            plan = 150000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");
                                    break;
                                case 4:
                                    plan = 0;
                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }
                        } while (opcionPlan > 4);

                        pra = pra * adultos;
                        prn = prn * niños;
                        cd = cd * camaDoble;
                        cs = cs * camaSencilla;
                        dia = (numSalida - numIngreso);

                        do
                        {
                            Console.WriteLine("\nDesea la emision de su factura On-Line digite SI/NO\n");

                            factura = Console.ReadLine();

                            if (factura == "SI")
                            {
                                Console.WriteLine("\nPor favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\nPor favor digite su numero de cedula\n");
                                cedula = Int32.Parse(Console.ReadLine());


                                Console.WriteLine(" ___________________________________________________________________________________________________________________");
                                Console.WriteLine("|                                                  RAZON SOCIAL                                                     |");
                                Console.WriteLine("|                                           HOTEL DE LA PROGRAMACION WEB                                            |");
                                Console.WriteLine("|                                                NIT. 850.523.123-5                                                 |");
                                Console.WriteLine("|FACTURA NO." + randomNumber + "                                 Fecha de impresion de la factura " + fecha + "                  |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");
                                Console.WriteLine("|                                                                                                                   |");
                                Console.WriteLine("|A nombre de: " + nombre + "                                                                               |");
                                Console.WriteLine("|Cedula: " + cedula + "                                                                                                 |");
                                Console.WriteLine("|Sede Santa Marta                                                                                                   |");
                                Console.WriteLine("|FECHA DE INGRESO        " + fechaIngreso + "                     FECHA DE SALIDA       " + fechaSalida + "                                |");
                                Console.WriteLine("|Dias confirmados        " + dia + "                            Valor Total $ " + (sm * dia) + "                                          |");
                                Console.WriteLine("|No. de adultos.        " + adultos + "                             Valor Total $ " + pra + "                                           |");
                                Console.WriteLine("|No. de niños.          " + niños + "                             Valor Total $ " + prn + "                                           |");
                                Console.WriteLine("|No. de camas dobles.   " + camaDoble + "                             Valor Total $ " + cd + "                                           |");
                                Console.WriteLine("|No. de camas sencillas." + camaSencilla + "                             Valor Total $ " + cs + "                                               |");
                                Console.WriteLine("|INCLUYO DESAYUNO " + elec + "                          Valor Total Adultos $ " + (pd * adultos * dia) + "                                           |");
                                Console.WriteLine("|                                               Valor Total Niños $ " + (pd * niños * dia) + "                                           |");
                                Console.WriteLine("|Eligio plan turistico No.  " + opcionPlan + "                        Valor Total  $ " + plan + "                                          |");
                                Console.WriteLine("|                                       valor total de la factura $" + (pra + prn + cd + cs + (pd * adultos * dia) + (pd * niños * dia) + plan + (sm * dia)) + "                                          |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            }
                            else if (factura == "NO")
                            {

                                Console.WriteLine("su factura es la No." + randomNumber);

                                Console.WriteLine("\n Por favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\n Por favor digite su numero de cedula\n");
                                cedula = int.Parse(Console.ReadLine());

                                Console.WriteLine("\n Recuerde pasar a efecty o baloto, indique su numero de cedula y nombre completo para realizar el pago\n");

                                Console.WriteLine("\n Gracias por su compra señor/a " + nombre + ", esperamos que disfrute su estadia en nuestro hotel en la sede Santa Marta (^_^) \n");
                            }
                        } while (factura != "SI" && factura != "NO");
                 
                        break;//TERMINA CASO 1
                        
                    case 2:

                        Console.WriteLine("por favor indique fecha de ingreso en formato yyyy/mm/dd, no incluya caracteres especiales, puntos o comas");
                        fechaIngreso = Console.ReadLine();

                        numIngreso = Int32.Parse(fechaIngreso);

                        Console.WriteLine("por favor indique fecha de salida en formato yyyy/mm/dd,no incluya caracteres especiales, puntos o comas");
                        fechaSalida = Console.ReadLine();

                        numSalida = Int32.Parse(fechaSalida);

                        Console.WriteLine("por favor ingrese numero de adultos. Valor por adulto de ->" + prab);
                        adultos = int.Parse(Console.ReadLine());

                        Console.WriteLine("por favor ingrese numero de niños. Valor por niño de ----->" + prnb);
                        niños = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Por favor seleccione tipo de cama y numero que requiere para la habitacion, no debe exceder mas de 3 camas dobles o mas de 3 sencillas");
                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                    valor unitario " + "                                                                                |");
                            Console.WriteLine("|1. Cama Doble.        $ " + cb + "                                                                                      |");
                            Console.WriteLine("|2. Cama Sencilla.     $ " + cbs + "                                                                                      |");
                            Console.WriteLine("|3. Salir                                                                                                           |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionCama = int.Parse(Console.ReadLine());

                            switch (opcionCama)
                            {
                                case 1:
                                    do
                                    {
                                        Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                        camaDoble = int.Parse(Console.ReadLine());
                                        if (camaDoble > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaDoble > 4);
                                    break;

                                case 2:

                                    Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                    camaSencilla = int.Parse(Console.ReadLine());

                                    do
                                    {
                                        if (camaSencilla > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaSencilla > 4);
                                    break;
                                case 3:

                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }

                        } while (opcionCama > 3);


                        do
                        {
                            Console.WriteLine("por favor seleccione SI/NO para incluir bar y servicio de habitaciones\n");

                            elec = Console.ReadLine();

                            if (elec == "SI")
                            {
                                do
                                {
                                    Console.WriteLine("\nLos servicios e instalaciones del Hotel de la programacion web Barranquilla son los que hacen un hotel " +
                                        "de referencia en el norte de Barranquilla\n tanto para los viajes de negocios, los de incentivos y congresos, " +
                                        "así como celebraciones de bodas, fiestas y aniversarios.\n Los desayunos son de 6:00 Am hasta las 10:30 AM Precio: $" + pdb + " por persona y día\n" +
                                    "¿desea agregar el servicio de desayuno a su cuenta? SI/NO\n");

                                    elecs = Console.ReadLine();

                                    if (elecs == "SI")
                                    {
                                        Console.WriteLine("Esperamos que disfrute nuestros desayunos y su estadia en el hotel de la programacion web");
                                    }
                                    else if (elecs == "NO")
                                    {
                                        pdb = 0;
                                        Console.WriteLine("Le recomendamos comer en el hotel o cerca del mismo para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                                    }
                                } while (elecs != "SI" && elecs != "NO");
                            }
                            else if (elec == "NO")
                            {
                                Console.WriteLine("Le recomendamos comer en el hotel o cerca del mismo para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                            }
                        } while (elec != "SI" && elec != "NO");

                        do
                        {
                            Console.WriteLine("\nPor favor elige uno de nuestros paquetes turisticos, por este mes no haremos cobro por persona, si no en combo. Aprovecha(^_^)");

                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                                             valor unitario                                                        |");
                            Console.WriteLine("|1. Recorrido panoramico.                      $234.000                                                             |");
                            Console.WriteLine("|2. Barranquilla Express                       $366.000                                                             |");
                            Console.WriteLine("|3. Encanto, cultura y sabores                 $177.000                                                             |");
                            Console.WriteLine("|4. Salir, no deseo adquirir ningun plan                                                                            |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionPlan = int.Parse(Console.ReadLine());

                            switch (opcionPlan)
                            {
                                case 1:

                                    Console.WriteLine("\nUsted eligio Recorrido panoramico, En este recorrido conoceremos tanto la parte histórico-colonial de " +
                                        "la ciudad, como su parte moderna. Realizaremos un recorrido en vehículo con aire acondicionado, pasando por el barrio de" +
                                        " El Prado (casas republicanas), el Museo del Caribe, el Teatro Amira de la Rosa, la Plaza de Aduanas, la Zona Industrial " +
                                        "(cumbiodromo), la Catedral Metropolitana, la Casa del Carnaval y el recorrido por los centros. comercial.");
                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Recorrido panoramico");
                                            plan = 234000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 2:

                                    Console.WriteLine("\nUsted eligio Barranquilla Express.Recorremos los principales lugares turísticos de Barranquilla como el hotel El Prado, el estadio de beisbol Edgar Rentería, la Casa del Carnaval, la Intendencia Fluvial, la ‘Ventana al Mundo’ y el Gran Malecón del Río, desde donde podrás apreciar la mejor vista al Río Magdalena..");
                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Barranquilla Express");
                                            plan = 366000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 3:

                                    Console.WriteLine("\nUsted eligio Encanto, cultura y sabores.  Disfruta recorrer las calles del centro de Barranquilla a pie, mientras conoces la cultura popular barranquillera y la herencia histórica que dejaron los inmigrantes en la arquitectura del centro de la ciudad. En el recorrido degustaremos los sabores típicos de la ciudad ");

                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Encanto, cultura y sabores");
                                            plan = 177000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");
                                    break;
                                case 4:
                                    plan = 0;
                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }
                        } while (opcionPlan > 4);

                        prab = prab * adultos;
                        prnb = prnb * niños;
                        cb = cb * camaDoble;
                        cbs = cbs * camaSencilla;
                        dia = (numSalida - numIngreso);

                        do
                        {
                            Console.WriteLine("\nDesea la emision de su factura On-Line digite SI/NO\n");

                            factura = Console.ReadLine();

                            if (factura == "SI")
                            {
                                Console.WriteLine("\nPor favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\nPor favor digite su numero de cedula\n");
                                cedula = Int32.Parse(Console.ReadLine());


                                Console.WriteLine(" ___________________________________________________________________________________________________________________");
                                Console.WriteLine("|                                                  RAZON SOCIAL                                                     |");
                                Console.WriteLine("|                                           HOTEL DE LA PROGRAMACION WEB                                            |");
                                Console.WriteLine("|                                                NIT. 850.523.123-5                                                 |");
                                Console.WriteLine("|FACTURA NO." + randomNumber + "                                 Fecha de impresion de la factura " + fecha + "                  |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");
                                Console.WriteLine("|                                                                                                                   |");
                                Console.WriteLine("|A nombre de: " + nombre +          "                                                                               |");
                                Console.WriteLine("|Cedula: " + cedula + "                                                                                                 |");
                                Console.WriteLine("|Sede: Barranquilla                                                                                                 |");
                                Console.WriteLine("|FECHA DE INGRESO        " + fechaIngreso + "                     FECHA DE SALIDA       " + fechaSalida + "                                |");
                                Console.WriteLine("|Dias confirmados        " + dia + "                            Valor Total $ " + (bq * dia) + "                                          |");
                                Console.WriteLine("|No. de adultos.        " + adultos + "                             Valor Total $ " + prab + "                                           |");
                                Console.WriteLine("|No. de niños.          " + niños + "                             Valor Total $ " + prnb + "                                           |");
                                Console.WriteLine("|No. de camas dobles.   " + camaDoble + "                             Valor Total $ " + cb + "                                           |");
                                Console.WriteLine("|No. de camas sencillas." + camaSencilla + "                             Valor Total $ " + cbs + "                                               |");
                                Console.WriteLine("|INCLUYO DESAYUNO " + elec + "                          Valor Total Adultos $ " + (pdb * adultos * dia) + "                                           |");
                                Console.WriteLine("|                                               Valor Total Niños $ " + (pdb * niños * dia) + "                                           |");
                                Console.WriteLine("|Eligio plan turistico No.  " + opcionPlan + "                        Valor Total  $ " + plan + "                                          |");
                                Console.WriteLine("|                                       valor total de la factura $" + (prab + prnb + cb + cbs + (pdb * adultos * dia) + (pdb * niños * dia) + plan + (bq * dia)) + "                                          |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            }
                            else if (factura == "NO")
                            {

                                Console.WriteLine("su factura es la No." + randomNumber);

                                Console.WriteLine("\n Por favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\n Por favor digite su numero de cedula\n");
                                cedula = int.Parse(Console.ReadLine());

                                Console.WriteLine("\n Recuerde pasar a efecty o baloto, indique su numero de cedula y nombre completo para realizar el pago\n");

                                Console.WriteLine("\n Gracias por su compra señor/a " + nombre + ", esperamos que disfrute su estadia en nuestro hotel en la sede Barramquilla (^_^) \n");
                            }
                        } while (factura != "SI" && factura != "NO");

                        break;//TERMINA CASO 2
                    case 3:
                        Console.WriteLine("por favor indique fecha de ingreso en formato yyyy/mm/dd, no incluya caracteres especiales, puntos o comas");
                        fechaIngreso = Console.ReadLine();

                        numIngreso = Int32.Parse(fechaIngreso);

                        Console.WriteLine("por favor indique fecha de salida en formato yyyy/mm/dd,no incluya caracteres especiales, puntos o comas");
                        fechaSalida = Console.ReadLine();

                        numSalida = Int32.Parse(fechaSalida);

                        Console.WriteLine("por favor ingrese numero de adultos. Valor por adulto de ->" + prac);
                        adultos = int.Parse(Console.ReadLine());

                        Console.WriteLine("por favor ingrese numero de niños. Valor por niño de ----->" + prnc);
                        niños = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Por favor seleccione tipo de cama y numero que requiere para la habitacion, no debe exceder mas de 3 camas dobles o mas de 3 sencillas");
                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                    valor unitario " + "                                                                                |");
                            Console.WriteLine("|1. Cama Doble.        $ " + cbc + "                                                                                      |");
                            Console.WriteLine("|2. Cama Sencilla.     $ " + csc + "                                                                                      |");
                            Console.WriteLine("|3. Salir                                                                                                           |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionCama = int.Parse(Console.ReadLine());

                            switch (opcionCama)
                            {
                                case 1:
                                    do
                                    {
                                        Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                        camaDoble = int.Parse(Console.ReadLine());
                                        if (camaDoble > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaDoble > 4);
                                    break;

                                case 2:

                                    Console.WriteLine("Usted eligio cama doble, por favor elija cuantas camas desea");
                                    camaSencilla = int.Parse(Console.ReadLine());

                                    do
                                    {
                                        if (camaSencilla > 4)
                                        {
                                            camaSencilla = 0;
                                            Console.WriteLine("Elija de 1 a 3, recuerde que el numero maximo es 3\n");
                                        }
                                    } while (camaSencilla > 4);
                                    break;
                                case 3:

                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }

                        } while (opcionCama > 3);


                        do
                        {
                            Console.WriteLine("por favor seleccione SI/NO para incluir bar y servicio de habitaciones\n");

                            elec = Console.ReadLine();

                            if (elec == "SI")
                            {
                                do
                                {
                                    Console.WriteLine("\nDeleite su paladar con la mejor comida nacional e internacional en un espacioso y moderno ambiente para 284 comensales," +
                                        " especial para deliciosos Desayunos y Almuerzos buffet. Y en la Cena con buffets temáticos variados según el día: Lunes: Mediterráneo, " +
                                        "Martes: Oriental, Miércoles: De Mar, Jueves: Típico Cartagenero, Viernes: Italiano, Sábado: Colombiano y Domingo: Mexicano.  Precio: $" + pdc + " por persona y día\n" +
                                    "¿desea agregar el servicio de desayuno a su cuenta? SI/NO\n");

                                    elecs = Console.ReadLine();

                                    if (elecs == "SI")
                                    {
                                        Console.WriteLine("Esperamos que disfrute nuestros desayunos y su estadia en el hotel de la programacion web");
                                    }
                                    else if (elecs == "NO")
                                    {
                                        pdb = 0;
                                        Console.WriteLine("Le recomendamos comer en el hotel o cerca del mismo para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                                    }
                                } while (elecs != "SI" && elecs != "NO");
                            }
                            else if (elec == "NO")
                            {
                                Console.WriteLine("Le recomendamos comer en el hotel o cerca del mismo para evitar que le vendan comidas que lo pueden enfermar a usted y a su familia, esperamos que disfrute su estadia\n");
                            }
                        } while (elec != "SI" && elec != "NO");

                        do
                        {
                            Console.WriteLine("\nPor favor elige uno de nuestros paquetes turisticos, por este mes no haremos cobro por persona, si no en combo. Aprovecha(^_^)");

                            Console.WriteLine(" ___________________________________________________________________________________________________________________");
                            Console.WriteLine("|                                             valor unitario                                                        |");
                            Console.WriteLine("|1. Punta arena.                               $350.000                                                             |");
                            Console.WriteLine("|2. Noche Blanca                               $420.000                                                             |");
                            Console.WriteLine("|3. Tour Manglares                             $220.000                                                             |");
                            Console.WriteLine("|4. Salir, no deseo adquirir ningun plan                                                                            |");
                            Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            opcionPlan = int.Parse(Console.ReadLine());

                            switch (opcionPlan)
                            {
                                case 1:

                                    Console.WriteLine("\nUsted eligio Punta arena. Ubicado en Tierra Bomba, es un destino muy recomendado ubicado en la zona insular de Cartagena de Indias; de arena suave y blanca, con ambiente tranquilo y hermoso");
                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Recorrido panoramico");
                                            plan = 350000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 2:

                                    Console.WriteLine("\nUsted eligio Noche Blanca. 3 horas a bordo del barco Bekia Eagle por toda la bahía de Cartagena.");
                                    Console.WriteLine("Incluye:");
                                    Console.WriteLine("Coctel de bienvenida");
                                    Console.WriteLine("Cena tipo buffet");
                                    Console.WriteLine("Bar abierto, sin cervezas; solo trago");
                                    Console.WriteLine("Show de bailarines");
                                    Console.WriteLine("Música");
                                    Console.WriteLine("Animación");
                                    Console.WriteLine("Salidas: sábados y jueves");
                                    Console.WriteLine("Desde las 7:30 pm");
                                    Console.WriteLine("Hasta las 11: pm");
                                    Console.WriteLine("Lugar de salida: muelle de la bodeguita");

                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Noche Blanca");
                                            plan = 420000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");

                                    break;
                                case 3:

                                    Console.WriteLine("\nUsted eligio Tour Manglares.  Este recorrido nos lleva al pequeño pueblo de pescadores de La Boquilla y es muy recomendable para los amantes de la naturaleza. Después de llegar a La Boquilla (unos 30 minutos del centro de la ciudad), tomaremos nuestra canoa y cruzaremos el bosque de manglares y la Ciénaga de Juan Polo. Nos dirigiremos a través de algunos túneles naturales de manglar (Túnel de la llegada, el amor y la felicidad). La palabra perfecta para describir este magnífico escenario es la paz. El bosque de manglar ofrece una gran flora y fauna. Entre otras cosas, podremos ver diferentes especies de aves y cangrejos y con un poco de suerte, garza s morenas, pelicano, un loro verde pueden aparecer en las riberas del río.");

                                    do
                                    {
                                        Console.WriteLine("\n¿desea confirmarlo? SI/NO\n");

                                        planOp = Console.ReadLine();

                                        if (planOp == "SI")
                                        {
                                            Console.WriteLine("\nEsperamos que disfrute nuestro plan turistico Tour Manglares");
                                            plan = 220000;
                                        }
                                        else if (planOp == "NO")
                                        {
                                            plan = 0;
                                        }
                                    } while (planOp != "SI" && planOp != "NO");
                                    break;
                                case 4:
                                    plan = 0;
                                    break;
                                default:
                                    Console.WriteLine("por favor ingrese un numero valido\n");
                                    break;
                            }
                        } while (opcionPlan > 4);

                        prac = prac * adultos;
                        prnc = prnc * niños;
                        cbc = cbc * camaDoble;
                        csc = csc * camaSencilla;
                        dia = (numSalida - numIngreso);

                        do
                        {
                            Console.WriteLine("\nDesea la emision de su factura On-Line digite SI/NO\n");

                            factura = Console.ReadLine();

                            if (factura == "SI")
                            {
                                Console.WriteLine("\nPor favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\nPor favor digite su numero de cedula\n");
                                cedula = Int32.Parse(Console.ReadLine());


                                Console.WriteLine(" ___________________________________________________________________________________________________________________");
                                Console.WriteLine("|                                                  RAZON SOCIAL                                                     |");
                                Console.WriteLine("|                                           HOTEL DE LA PROGRAMACION WEB                                            |");
                                Console.WriteLine("|                                                NIT. 850.523.123-5                                                 |");
                                Console.WriteLine("|FACTURA NO." + randomNumber + "                               Fecha de impresion de la factura " + fecha + "                     |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");
                                Console.WriteLine("|                                                                                                                   |");
                                Console.WriteLine("|A nombre de: " + nombre + "                                                                               |");
                                Console.WriteLine("|Cedula: " + cedula + "                                                                                                 |");
                                Console.WriteLine("|Sede: Barranquilla                                                                                                 |");
                                Console.WriteLine("|FECHA DE INGRESO        " + fechaIngreso + "                     FECHA DE SALIDA       " + fechaSalida + "                                |");
                                Console.WriteLine("|Dias confirmados        " + dia + "                            Valor Total $ " + (ct * dia) + "                                          |");
                                Console.WriteLine("|No. de adultos.        " + adultos + "                             Valor Total $ " + prac + "                                           |");
                                Console.WriteLine("|No. de niños.          " + niños + "                             Valor Total $ " + prnc + "                                           |");
                                Console.WriteLine("|No. de camas dobles.   " + camaDoble + "                             Valor Total $ " + cbc + "                                           |");
                                Console.WriteLine("|No. de camas sencillas." + camaSencilla + "                             Valor Total $ " + csc + "                                               |");
                                Console.WriteLine("|INCLUYO DESAYUNO " + elec + "                          Valor Total Adultos $ " + (pdc * adultos * dia) + "                                           |");
                                Console.WriteLine("|                                               Valor Total Niños $ " + (pdc * niños * dia) + "                                           |");
                                Console.WriteLine("|Eligio plan turistico No.  " + opcionPlan + "                        Valor Total  $ " + plan + "                                          |");
                                Console.WriteLine("|                                       valor total de la factura $" + (prac + prnc + cbc + csc + (pdc * adultos * dia) + (pdc * niños * dia) + plan + (ct * dia)) + "                                          |");
                                Console.WriteLine("|___________________________________________________________________________________________________________________|");

                            }
                            else if (factura == "NO")
                            {

                                Console.WriteLine("su factura es la No." + randomNumber);

                                Console.WriteLine("\n Por favor digite a nombre de quien se va a realizar la factura, nombres y apellidos completos\n");
                                nombre = Console.ReadLine();

                                Console.WriteLine("\n Por favor digite su numero de cedula\n");
                                cedula = int.Parse(Console.ReadLine());

                                Console.WriteLine("\n Recuerde pasar a efecty o baloto, indique su numero de cedula y nombre completo para realizar el pago\n");

                                Console.WriteLine("\n Gracias por su compra señor/a " + nombre + ", esperamos que disfrute su estadia en nuestro hotel en la sede Cartagena (^_^) \n");
                            }
                        } while (factura != "SI" && factura != "NO");
                        break;
                    case 4:
                        Console.WriteLine("Esperamos que vuelva pronto y le podamos colaborar en lo que desea.\n\nFeliz dia (^_^)\n");
                        Console.WriteLine("//-------------------------------------------------------------------------------------------------------//");
                        break;
                    default:
                        Console.WriteLine("por favor ingrese un numero valido\n");
                        break;
                }
            } while (opcion > 4);
            

        }
    }
}
