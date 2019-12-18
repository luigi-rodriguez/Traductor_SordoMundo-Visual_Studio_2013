//      LIBRERIAS
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor_de_Señas
{
    public partial class INDEX : Form
    {

// Constructor
        public INDEX()
        {
            InitializeComponent();
            //centra formulario
            this.CenterToParent();
        }

//Imagen Inicial AL CARGAR FORMULARIO
        private void INDEX_Load(object sender, EventArgs e)
        {
            //  SE LE DA LA DIRECCION DE LA IMAGEN DEInicio
            P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\INICIO.PNG");
        }// FIN DEL METODO INDEX_Load

// ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ EVENTOS ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~
        // EVENTO KeyUp ( AL PRESIONAR LA TECLA )
        private void textBUsca_KeyPress(object sender, KeyPressEventArgs e)
        {
        // INSTANCIAR EL METODO IMGS
             this.IMGS();
        }// FIN DEL Evento KeyPress

        // EVENTO KeyUp ( AL SOLTAR LA TECLA )
        private void textBUscar_KeyUp(object sender, KeyEventArgs e)
        {
        // INSTANCIAR EL METODO IMGS
             this.IMGS();
        }// FIN DEL Evento KeyUp


// ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ METODO PARA IMAGENES ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~ ~~~~~~~~~~~~~~~~
        public void IMGS()
        {
        // CICLO PARA RECORRER LAS LETRAS   (   tipio de dato, elemento en lista(o Arreglo)   )
            foreach (char textBUscar in textBUsca.Text)
            {
                // BUSQUEDA EN SECUENCIA
                if ((textBUscar == 'A') || (textBUscar == 'a'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_A.PNG");

                } // FIN DEL IF A
                if ((textBUscar == 'B') || (textBUscar == 'b'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_B.PNG");

                } // FIN DEL IF B
                if ((textBUscar == 'C') || (textBUscar == 'c'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_C.PNG");

                } // FIN DEL IF C
                
                if ((textBUscar == 'D') || (textBUscar == 'd'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_D.PNG");

                } // FIN DEL IF  D
                if ((textBUscar == 'E') || (textBUscar == 'e'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_E.PNG");

                } // FIN DEL IF E
                if ((textBUscar == 'F') || (textBUscar == 'f'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_F.PNG");

                } // FIN DEL IF F
                if ((textBUscar == 'G') || (textBUscar == 'g'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_G.PNG");

                } // FIN DEL IF G
                if ((textBUscar == 'H') || (textBUscar == 'h'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_H.PNG");

                } // FIN DEL IF H
                if ((textBUscar == 'I') || (textBUscar == 'i'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_I.PNG");

                } // FIN DEL IF I
                if ((textBUscar == 'J') || (textBUscar == 'j'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_J.PNG");

                } // FIN DEL IF J
                if ((textBUscar == 'K') || (textBUscar == 'k'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_K.PNG");

                } // FIN DEL IF K
                if ((textBUscar == 'L') || (textBUscar == 'l'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_L.PNG");

                } // FIN DEL IF L

                if ((textBUscar == 'M') || (textBUscar == 'm'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_M.PNG");

                } // FIN DEL IF M
                if ((textBUscar == 'N') || (textBUscar == 'n'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_N.PNG");

                } // FIN DEL IF N
                if ((textBUscar == 'Ñ') || (textBUscar == 'ñ'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_Ñ.PNG");

                } // FIN DEL IF Ñ
                if ((textBUscar == 'O') || (textBUscar == 'o'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_O.PNG");

                } // FIN DEL IF O
                if ((textBUscar == 'P') || (textBUscar == 'p'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_P.PNG");

                }
                if ((textBUscar == 'Q') || (textBUscar == 'q'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_Q.PNG");

                } // FIN DEL IF Q
                if ((textBUscar == 'R') || (textBUscar == 'r'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_R.PNG");

                } // FIN DEL IF R
                
                if ((textBUscar == 'S') || (textBUscar == 's'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_S.PNG");

                } // FIN DEL IF S
                if ((textBUscar == 'T') || (textBUscar == 't'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_T.PNG");

                } // FIN DEL IF T
                if ((textBUscar == 'U') || (textBUscar == 'u'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_U.PNG");

                } // FIN DEL IF U
                if ((textBUscar == 'V') || (textBUscar == 'v'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_V.PNG");

                } // FIN DEL IF V
                if ((textBUscar == 'W') || (textBUscar == 'w'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_W.PNG");

                } // FIN DEL IF W
                if ((textBUscar == 'X') || (textBUscar == 'x'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_X.PNG");

                }
                if ((textBUscar == 'Y') || (textBUscar == 'y'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_Y.PNG");

                } // FIN DEL IF Y
                if ((textBUscar == 'Z') || (textBUscar == 'z'))
                {
                    //  SE LE DA LA DIRECCION DE LA IMAGEN
                    P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_Z.PNG");

                } // FIN DEL IF Z

            }// FIN DEL FOREACH

// ~~~~~~~~~~~~~    ~~~~~~~~~~~~~    ~~~~~~~~~~~~~    ~~~~~~~~~~~~~    Imgs con 2 letras    ~~~~~~~~~~~~~    ~~~~~~~~~~~~~    ~~~~~~~~~~~~~
            if ((textBUsca.Text == ""))
            {
                //  SE LE DA LA DIRECCION DE LA IMAGEN
                P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\INICIO.PNG");

            } // FIN DEL IF espacio en blanco

            if ((textBUsca.Text == "ch") || (textBUsca.Text == "CH"))
            {
                //  SE LE DA LA DIRECCION DE LA IMAGEN
                P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_CH.PNG");
            } // FIN DEL IF CH

            if ((textBUsca.Text == "ll") || (textBUsca.Text == "LL"))
            {
                //  SE LE DA LA DIRECCION DE LA IMAGEN
                P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_LL.PNG");
            } // FIN DEL IF LL
            
            if ((textBUsca.Text == "rr") || (textBUsca.Text == "RR"))
            {
                //  SE LE DA LA DIRECCION DE LA IMAGEN
                P_Box.Image = Image.FromFile(@"C:\Users\josel\Documents\Visual Studio 2013\Projects\Traductor_de_Señas\Traductor_de_Señas\bin\IMG_Señas\IMG_RR.PNG");
            } // FIN DEL IF RR

        }// FIN DEL METODO PARA IMAGENES
    }

}
