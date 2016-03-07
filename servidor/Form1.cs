using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servidor
{
    public partial class Form1 : Form
    {
        
        string op1="";
        string op2="";
        string data="";

        public Form1()
        {
            InitializeComponent();
        }


        private void manejoCliente(TcpClient client) {


            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine("Moscú. Es el amanecer del 11 de marzo, finales del invierno, en 1933. La tierra sigue congelada en muchos lugares, y placas heladas se aferran a los lados rehuidos por el sol de las colinas y a las zonas en sombras.  Tú y tu compañero os encontráis en una situación un tanto peliaguda, ya que el burro que os llevaba hacia vuestro destino ha muerto congelado.  Estando en medio de la nada y anocheciendo a una velocidad pasmosa os fijáis en un cártel apenas visible y corroído por el oxido. Algo llamado JARKOV 37 se encuentra a menos de 10 km de donde os encontráis. Si queréis sobrevivir a la fría noche tendréis que caminar y rezar por que ese cartel tenga razón y podáis encontrar ayuda en ese lugar. " +
                "Tras una larga caminata llegáis a vuestro destino, una vieja central de maquinaria que parece estar abandonada.  Puede que no encontréis ayuda pero por lo menos podréis pasar la noche a cubierto y no morir congelados. Esta bastante oscuro y no estáis seguros pero parece que hay varios edificios en muy buenas condiciones. Algo parecido a una prisión se alza a vuestra izquierda mientras que ante vuestras narices se halla un enorme edificio de viviendas que no parece estar abandonado.  A su lado hay lo que parece ser un cobertizo de madera en mal estado. "+
                "Debéis llegar a un acuerdo entre los dos y escoger donde entrar. "+"Escoges la opción A y opinas que es mejor entrar en la prisión.  " + "O escoges la opción B y crees que sería más seguro entrar en el bloque de viviendas");
            sw.Flush();

            while (true)
            {
                try
                {
                    op1 = "";
                    op2 = "";
                    data = sr.ReadLine();
                    if (op1 == "")
                    {
                        op1 = data;

                        while (op2 == "")
                        {
                            // Thread.Sleep(100);
                        }
                    }
                    else if (op2 == "")
                    {
                        op2 = data;

                        while (op1 == "")
                        {
                            Thread.Sleep(100);
                        }
                    }



                    if (!(op1 == "A" && op2 == "A"))
                    {
                        sw.WriteLine("Despues de sopesar los pros y los contras os decantais por el bloque de viviendas. Desde el punto en el que estáis no podéis apreciar lo alto que es, pero por lo que veis suponéis que no tendrá más de 8 pisos de altura.  La puerta principal es grande y pesada y es necesaria la fuerza de los dos para poder moverla. Se abre lo suficiente como para que podáis pasar de uno en uno. "+
                            "Dentro está bastante oscuro pero por lo menos no parece que el edificio este en mal estado, al contrario que la prisión. Al cabo de un momento vuestra vista se adapta a la oscuridad que os rodea e intentáis buscar algo que pueda acabar con esta penumbra. Después de varios minutos buscando a tientas encontráis algo parecido a una linterna. Debe ser vuestro día de suerte porque cuando intentáis encenderla lo hace a la primera. Ahora que podéis ver un poco mejor comprobáis que el acceso a las escaleras esta totalmente obstruido por cientos de sillas, mesas y muebles de madera. No podéis subir pero por lo menos ahora no moriréis congelados. A vuestra derecha hay una puerta entreabierta que parece llevar a una especie de cobertizo antiguo.  Deberíais ir al cobertizo donde quizás podáis encontrar algo útil o es mejor quedarse a pasar la noche en el edificio rezando por que a la mañana siguiente podáis emprender el camino de vuelta a casa? "+
                           "Opción A para quedarse a pasar la noche y seguir por la mañana. Opción B para entrar en el cobertizo.Quizá haya algo útil. " );
                        sw.WriteLine("vivo");
                        sw.Flush();
                        op1 = "";
                        op2 = "";
                        data = sr.ReadLine();
                        if (op1 == "")
                        {
                            op1 = data;

                            while (op2 == "")
                            {
                                // Thread.Sleep(100);
                            }
                        }
                        else if (op2 == "")
                        {
                            op2 = data;

                            while (op1 == "")
                            {
                                Thread.Sleep(100);
                            }
                        }
                        if (!(op1 == "A" && op2 == "A"))
                        {
                            sw.WriteLine("Tras hablarlo, decidis ir al cobertizo. Lo primero que notáis nada mas emtrar es el fuerte olor que desprende. A que huele? Es un olor muy fuerte que os llega hasta el cerebro llegando a ser incomodo el respirar. Os cubrís la nariz y la boca como podéis y os fijáis en que algo no cuadra…. Al contrario que el resto de los edificios que parecen estar en mal estado este cobertizo parece que acabara de ser limpiado. Hay varias mesas con objetos que parecen sacados de un laboratorio sobre ellas. Al acercaros veis que hay varios viales distintos con sustancias de diferentes colores dentro de estos. No puede ser verdad. Maldecís vuestra mala suerte al daros cuenta de que acabáis de descubrir sin querer un laboratorio de drogas clandestino.  Tenéis que salir de aquí antes de que la gente que lleva este laboratorio os encuentre husmeando en donde no debéis. Pero por otra parte podríais esperar por ellos, quizás puedan prestaros algo de ayuda para volver. "+
                                "Opción A os quedáis a esperar por los traficantes. Quizás sean majos.  Opción B os largáis a toda pastilla de ahí. ");
                            sw.WriteLine("vivo");
                            sw.Flush();
                            op1 = "";
                            op2 = "";
                            data = sr.ReadLine();
                            if (op1 == "")
                            {
                                op1 = data;

                                while (op2 == "")
                                {
                                    // Thread.Sleep(100);
                                }
                            }
                            else if (op2 == "")
                            {
                                op2 = data;

                                while (op1 == "")
                                {
                                    Thread.Sleep(100);
                                }
                            }
                            if (!(op1 == "A" && op2 == "A"))
                            {
                                sw.WriteLine("Haciendo caso a la razon salis pitando. Tras salir corriendo como si no hubiera mañana, os paráis un momento para coger aire y veis un garaje abierto …. Con un coche dentro!!!!  Seguramente sea de los traficantes y funcione pero por otra parte los traficantes podrían estar ahí y coseros a tiros si ven algo que no les gusta. Es el momento de la verdad. Si entráis en el garaje quizás tengáis una oportunidad de sobrevivir. Sabéis que si os marcháis lo mas probable es que muráis congelados. "+
                                    "Opcion A, os arriesgáis a ir al garaje y rezáis por que no pase nada. Opcion B, os vais de ahí y rezáis para no morir congelados durante la noche. ");
                                sw.WriteLine("vivo");
                                sw.Flush();
                                op1 = "";
                                op2 = "";
                                data = sr.ReadLine();
                                if (op1 == "")
                                {
                                    op1 = data;

                                    while (op2 == "")
                                    {
                                        // Thread.Sleep(100);
                                    }
                                }
                                else if (op2 == "")
                                {
                                    op2 = data;

                                    while (op1 == "")
                                    {
                                        Thread.Sleep(100);
                                    }
                                }
                                if (!(op1 == "A" && op2 == "A"))
                                {
                                    sw.WriteLine("Sintiendo que lo mas inteligente es salir de este sitio, salis de alli como podeis intentando no ser vistos y haciendo el menor ruido posible. Una vez fuera respirais tranquilos otra vez. Os poneis a caminar para poner tierra de por medio entre ese sitio y vosotros. Pero la noche se acerca y las temperaturas bajan demasiado rapido. Intentando entrar en calor y sin conseguirlo os rendis al destino. Moris de hipotermia en el crudo invierno de Rusia. Que mala suerte. ESTAIS MUERTOS. FIN DEL JUEGO");
                                    sw.WriteLine("muerto");
                                    sw.Flush();


                                }
                                else {
                                    sw.WriteLine("Decidis que entrar en el garaje es la mejor opcion si quereis salir con vida de aqui. Echandole narices os plantais dentro del garaje esperando encontraros con vuestra peor pesadilla. Pero por sorpresa no hay nadie. El garaje esta vacio. Hay un coche que tiene las llaves puestas y parece que esta en buen estado. Rezas por que funcione y cuando al girar la llave en el contacto el motor empieza a rugir, los dos saltais de alegria. Os meteis en el coche y salis cagando leches de ahi. Que le den a Jarkov y a toda la gente que ahi esta. FELICIDADES. FIN DEL JUEGO");
                                    sw.WriteLine("muerto");
                                    sw.Flush();

                                }
                            }
                            else {
                                sw.WriteLine("Haciendo caso omiso a la razon decidis esperar por los traficantes. Resulta que no son majos para nada. Quien lo hubiera pensado. En cuanto os ven corren hacia vosotros y os aprisionan. Tras contarles la verdad de por que estais alli, ellos deciden que no podeis salir de alli con vida. Os cosen a balazos y se deshacen de vuestros cuerpos. Que mala idea esperar por ellos eh? ESTAIS MUERTOS. FIN DEL JUEGO");
                                sw.WriteLine("muerto");
                                sw.Flush();
                            }
                        }
                        else {
                            sw.WriteLine("Despues de darle muchas vueltas quedarse a pasar la noche bajo un techo parece la mejor soluccion. Os quedais en una esquina los dos junto para no pasar frio. Os quedais dormidos en minutos. Pero la noche es mas fria de lo que creiais y las temperaturas bajan rapidamente. El frio os sorprende durmiendo. Moris congelados debido a la hipotermia. Parece que esa no fue la mejor opcion. ESTAIS MUERTOS. FIN DEL JUEGO");
                            sw.WriteLine("muerto");
                            sw.Flush();
                        }

                    }
                    else
                    {
                        sw.WriteLine("Tras mucho debatir decidis que la prision es la mejor opcion.Entráis en ella y os dais cuenta de que ha sido un error. Todo esta destrozado, la mayoría de ventanas están rotas y hace tanto frio como si estuvierais fuera. Os dais una pequeña vuelta por el poco espacio que hay que no esta completamente destrozado para ver si podéis encontrar algo que os pueda servir de ayuda pero no tenéis esa suerte. Un brillo llama vuestra atención y veis que se trata de una trampilla medio oculta en el suelo. Es una especie de pasadizo que debía conectar la prisión con algún otro edificio. Apenas cabe por el un hombre y esta demasiado oscuro como para ver.  "
                            + "Tu y tu compañero discutís que hacer. Escoges la opción A y decides ir por la trampilla a investigar. O escoges la opción B y te das cuenta de que lo mejor es dar media vuelta e ir al bloque de viviendas.Al fin y al cabo parecía mucho mas seguro. ");

                        sw.WriteLine("vivo");
                        sw.Flush();
                        op1 = "";
                        op2 = "";
                        data = sr.ReadLine();
                        if (op1 == "")
                        {
                            op1 = data;

                            while (op2 == "")
                            {
                                // Thread.Sleep(100);
                            }
                        }
                        else if (op2 == "")
                        {
                            op2 = data;

                            while (op1 == "")
                            {
                                Thread.Sleep(100);
                            }
                        }
                        if (!(op1 == "A" && op2 == "A"))
                        {
                            sw.WriteLine("La logica dice que lo mejor es dar media vuelta y volver hacia el bloque de viviendas. Parecia mucho mas seguro. Empezais a caminar hacia la salida y en cuanto cerrais la puerta y os dais la vuelta, os dais de bruces con un bruto de 2 metros de alto. Porta una especie de linterna y en su otra mano lleva un arma de gran tamaño. Con una sonrisa burlona os tira al suelo y os pega un tiro en la cabeza a cada uno. El bruto se va silvando una cancion mientras vosotros os quedais tirados en el frio suelo. ESTAIS MUERTOS. FIN DEL JUEGO ");
                            sw.WriteLine("muerto");
                            sw.Flush();

                        }
                        else
                        {
                            sw.WriteLine("No queriendo discutir os meteis por la trampilla. Esta muy oscuro y apenas podeis ver nada. A tientas empezais a caminar por un estrecho pasillo nada comodo. A lo lejos parece que se escuchan ruidos pero no estais seguros de que puede ser que los este produciendo. Al dar un paso contra algo duro en el suelo, tropiezas y haces que los dos caigais al suelo. El fuerte ruido producido por vuestra caida hace que se haga el silencio. Alguien va hacia vosotros. Lleva una luz consigo. Apenas podeis verle el rostro pero se trata de un hombre grande y corpulento. En la otra mano lleva un arma. Intentais no hacer ruido pero en cuanto os ve os pega un tiro a cada uno. Eso os pasa por cotillas y meteros donde no os llaman. ESTAIS MUERTOS. FIN DEL JUEGO");
                            sw.WriteLine("muerto");
                            sw.Flush();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Error: {0}", error.ToString());
                    break;
                }
            }
        }

        private void abrirConexion() {
            TcpListener socket = new TcpListener(IPAddress.Any, 2000);
            socket.Start();
            while (true)
            {
                TcpClient cliente = socket.AcceptTcpClient(); 
                Thread t = new Thread(() => this.manejoCliente(cliente));
                t.Start();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            abrirConexion();
            
        }
    }
}
