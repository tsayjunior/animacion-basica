using escenarioProgramGrafica.negocio.partes_del_escenario;
using OpenTK.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class escenasDelPerro : escenario
    {

        public escenasDelPerro()
        {
            setterParte(new perro()); //0

            escena1();
            escena2();
            escena3();
            escena4();
            escena5();
            escena6();
            escena7();
            escena8();
        }

        public void escena1()
        {
            setterEscena(new escenario());// 0
            getterEscena(0).setterParte(new perro());

            ////cola hacia abajo
            getterEscena(0).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("x", 60);
            ////pierna trasera izquierda
            getterEscenaParte(0, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -10);

            getterEscenaParte(0, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -15);
            getterEscenaParte(0, 0).getterParte(15).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(0, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 25);
            getterEscenaParte(0, 0).getterParte(16).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(0, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(0, 0).getterParte(17).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna trasera derecha
            getterEscena(0).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -10);

            getterEscena(0).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -33);
            getterEscenaParte(0, 0).getterParte(11).setterTranslacion2(-0.02f, 0, 0);

            getterEscenaParte(0, 0).getterParte(12).setterTranslacion2(-0.07f, 0.01f, 0);

            getterEscenaParte(0, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 18);
            getterEscenaParte(0, 0).getterParte(13).setterTranslacion2(-0.07f, 0.005f, 0);
            //// pierna delantera izquierda
            getterEscena(0).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", -10);

            getterEscena(0).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", -15);
            getterEscena(0).getterParte(0).getterParte(7).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(0, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 25);
            getterEscena(0).getterParte(0).getterParte(8).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscena(0).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(0).getterParte(0).getterParte(9).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna delantera derecha

            getterEscenaParte(0, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", 5);

            getterEscenaParte(0, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(0, 0).getterParte(3).setterTranslacion2(0.005f, 0, 0);

            getterEscenaParte(0, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(0, 0).getterParte(4).translacion2(0.029f, 0.0f, 0);

            getterEscenaParte(0, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(0, 0).getterParte(5).setterTranslacion2(0.04f, 0.005f, 0);

        }
        public void escena2()
        {
            setterEscena(new escenario());//1
            getterEscena(1).setterParte(new perro());//lista de partes 0

            ////cola hacia abajo
            getterEscena(1).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", 60);
            ////pierna trasera izquierda
            getterEscenaParte(1, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -10);

            getterEscenaParte(1, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -15);
            getterEscenaParte(1, 0).getterParte(15).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(1, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 25);
            getterEscenaParte(1, 0).getterParte(16).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(1, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(1, 0).getterParte(17).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna trasera derecha
            getterEscena(1).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -10);

            getterEscena(1).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -33);
            getterEscenaParte(1, 0).getterParte(11).setterTranslacion2(-0.02f, 0, 0);

            getterEscenaParte(1, 0).getterParte(12).setterTranslacion2(-0.07f, 0.01f, 0);

            getterEscenaParte(1, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 18);
            getterEscenaParte(1, 0).getterParte(13).setterTranslacion2(-0.07f, 0.005f, 0);
            //// pierna delantera izquierda
            getterEscena(1).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", -10);

            getterEscena(1).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", -15);
            getterEscena(1).getterParte(0).getterParte(7).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(1, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 25);
            getterEscena(1).getterParte(0).getterParte(8).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscena(1).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(1).getterParte(0).getterParte(9).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna delantera derecha

            getterEscenaParte(1, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", 5);

            getterEscenaParte(1, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(1, 0).getterParte(3).setterTranslacion2(0.005f, 0, 0);

            getterEscenaParte(1, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(1, 0).getterParte(4).translacion2(0.029f, 0.0f, 0);

            getterEscenaParte(1, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 15);
            getterEscenaParte(1, 0).getterParte(5).setterTranslacion2(0.04f, 0.005f, 0);
            //// cabeza
            getterEscenaParte(1, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(1, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);

           
        }
        public void escena3()
        {
            setterEscena(new escenario());// 2
            setterEscenaParte(2, new perro());

            ////cola hacia abajo
            getterEscena(2).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", 40);
            ////pierna trasera izquierda
            getterEscenaParte(2, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -20);

            getterEscenaParte(2, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(2, 0).getterParte(15).setterTranslacion2(-0.02f, 0, 0);

            getterEscenaParte(2, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 25);
            getterEscenaParte(2, 0).getterParte(16).setterTranslacion2(-0.05f, 0.02f, 0);

            getterEscenaParte(2, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(2, 0).getterParte(17).setterTranslacion2(-0.03f, 0.02f, 0);
            ////pierna trasera derecha
            getterEscena(2).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -23);
            getterEscenaParte(2, 0).getterParte(10).setterTranslacion2(0.01f, 0.005f, 0);

            getterEscena(2).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(2, 0).getterParte(11).setterTranslacion2(-0.009f, 0.01f, 0);

            getterEscenaParte(2, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", -25);
            getterEscenaParte(2, 0).getterParte(12).setterTranslacion2(-0.06f, 0.025f, 0);

            getterEscenaParte(2, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", -15);
            getterEscenaParte(2, 0).getterParte(13).setterTranslacion2(-0.085f, 0.02f, 0);
            //////////// pierna delantera izquierda
            getterEscena(2).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", 10);
            getterEscena(2).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(2).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(2).getterParte(0).getterParte(7).setterTranslacion2(0.0f, 0.01f, 0);

            getterEscenaParte(2, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(2).getterParte(0).getterParte(8).setterTranslacion2(0.05f, 0.018f, 0);

            getterEscena(2).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", -10);
            getterEscena(2).getterParte(0).getterParte(9).setterTranslacion2(0.07f, 0.02f, 0);
            ////////////pierna delantera derecha
            getterEscenaParte(2, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", -10);

            getterEscenaParte(2, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", -10);
            getterEscenaParte(2, 0).getterParte(3).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(2, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", -10);
            getterEscenaParte(2, 0).getterParte(4).translacion2(-0.029f, 0.0f, 0);

            getterEscenaParte(2, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 10);
            getterEscenaParte(2, 0).getterParte(5).setterTranslacion2(-0.039f, 0.0f, 0);
            //////////// cabeza
            getterEscenaParte(2, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(2, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);
        }
        public void escena4()
        {
            setterEscena(new escenario());//3
            setterEscenaParte(3, new perro());//0
            
            ////cola hacia abajo
            getterEscena(3).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", -10);
            ////pierna trasera izquierda
            getterEscenaParte(3, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -5);

            getterEscenaParte(3, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -15);
            getterEscenaParte(3, 0).getterParte(15).setterTranslacion2(-0.0f, 0, 0);

            getterEscenaParte(3, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(3, 0).getterParte(16).setterTranslacion2(-0.02f, 0.01f, 0);

            getterEscenaParte(3, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(3, 0).getterParte(17).setterTranslacion2(0.005f, 0.01f, 0);
            ////pierna trasera derecha
            getterEscena(3).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -23);
            getterEscenaParte(3, 0).getterParte(10).setterTranslacion2(0.01f, 0.005f, 0);

            getterEscena(3).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(3, 0).getterParte(11).setterTranslacion2(-0.009f, 0.01f, 0);

            getterEscenaParte(3, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", -0);
            getterEscenaParte(3, 0).getterParte(12).setterTranslacion2(-0.05f, 0.023f, 0);

            getterEscenaParte(3, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", -0);
            getterEscenaParte(3, 0).getterParte(13).setterTranslacion2(-0.05f, 0.02f, 0);
            ////////////// pierna delantera izquierda
            getterEscena(3).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", 10);
            getterEscena(3).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(3).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(3).getterParte(0).getterParte(7).setterTranslacion2(0.0f, 0.01f, 0);

            getterEscenaParte(3, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(3).getterParte(0).getterParte(8).setterTranslacion2(0.05f, 0.018f, 0);

            getterEscena(3).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 30);
            getterEscena(3).getterParte(0).getterParte(9).setterTranslacion2(0.08f, 0.02f, 0);
            //////////////pierna delantera derecha

            ////getterEscenaParte(3, 0).getterParte(2).setterTranslacion2(0.5f, 0, 0);
            ////getterEscenaParte(3, 0).getterParte(4).setterTranslacion2(0.5f, 0, 0);
            ////getterEscenaParte(3, 0).getterParte(5).setterTranslacion2(0.5f, 0, 0);
            ////getterEscenaParte(3, 0).getterParte(3).setterTranslacion2(0.5f, 0, 0);
            getterEscenaParte(3, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", -20);

            getterEscenaParte(3, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", -25);
            getterEscenaParte(3, 0).getterParte(3).setterTranslacion2(-0.02f, 0, 0);

            getterEscenaParte(3, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", -28);
            getterEscenaParte(3, 0).getterParte(4).translacion2(-0.065f, 0.0f, 0);

            getterEscenaParte(3, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(3, 0).getterParte(5).setterTranslacion2(-0.09f, 0.01f, 0);
            //////////// cabeza
            getterEscenaParte(3, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(3, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);
        }
        public void escena5()
        {
            setterEscena(new escenario());//4
            setterEscenaParte(4, new perro());//0

            ////cola hacia abajo
            getterEscena(4).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", 60);
            ////pierna trasera izquierda
            getterEscenaParte(4, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -25);

            getterEscenaParte(4, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -25);
            getterEscenaParte(4, 0).getterParte(15).setterTranslacion2(-0.02f, 0, 0);

            getterEscenaParte(4, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(4, 0).getterParte(16).setterTranslacion2(-0.06f, 0.01f, 0);

            getterEscenaParte(4, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(4, 0).getterParte(17).setterTranslacion2(-0.085f, 0.01f, 0);
            ////pierna trasera derecha
            getterEscena(4).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", 10);
            //getterEscenaParte(4, 0).getterParte(10).setterTranslacion2(0.01f, 0.005f, 0);

            getterEscena(4).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", 0);
            getterEscenaParte(4, 0).getterParte(11).setterTranslacion2(0.0f, 0.0f, 0);

            getterEscenaParte(4, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(4, 0).getterParte(12).setterTranslacion2(0.01f, 0.0f, 0);

            getterEscenaParte(4, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(4, 0).getterParte(13).setterTranslacion2(0.03f, 0.0f, 0);
            ////////////// pierna delantera izquierda
            getterEscena(4).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", 15);
            getterEscena(4).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(4).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", 15);
            //getterEscena(4).getterParte(0).getterParte(7).setterTranslacion2(-0.0f, 0.0f, 0);

            getterEscenaParte(4, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 15);
            getterEscena(4).getterParte(0).getterParte(8).setterTranslacion2(0.02f, 0.0f, 0);

            getterEscena(4).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 50);
            getterEscena(4).getterParte(0).getterParte(9).setterTranslacion2(0.035f, 0.0f, 0);
            //////////////pierna delantera derecha

            //getterEscenaParte(4, 0).getterParte(2).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(4, 0).getterParte(3).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(4, 0).getterParte(4).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(4, 0).getterParte(5).setterTranslacion2(0.5f, 0, 0);

            getterEscenaParte(4, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", -15);

            getterEscenaParte(4, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", -10);
            getterEscenaParte(4, 0).getterParte(3).setterTranslacion2(-0.015f, 0, 0);

            getterEscenaParte(4, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(4, 0).getterParte(4).translacion2(-0.04f, 0.0f, 0);

            getterEscenaParte(4, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(4, 0).getterParte(5).setterTranslacion2(-0.06f, 0.0f, 0);
            //////////// cabeza
            getterEscenaParte(4, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(4, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);
        }
        public void escena6()
        {
            setterEscena(new escenario());//5
            setterEscenaParte(5, new perro());//0

            ////cola hacia abajo
            getterEscena(5).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", 40);
            ////pierna trasera izquierda
            getterEscenaParte(5, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -15);

            getterEscenaParte(5, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -15);
            getterEscenaParte(5, 0).getterParte(15).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(5, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(5, 0).getterParte(16).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(5, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(5, 0).getterParte(17).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna trasera derecha
            getterEscena(5).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(5, 0).getterParte(10).setterTranslacion2(0.018f, 0.0f, 0);

            getterEscena(5).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(5, 0).getterParte(11).setterTranslacion2(0.0f, 0.0f, 0);

            getterEscenaParte(5, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(5, 0).getterParte(12).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(5, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(5, 0).getterParte(13).setterTranslacion2(-0.01f, 0.0f, 0);
            ////////////// pierna delantera izquierda
            getterEscena(5).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", 0);
            //getterEscena(5).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(5).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", 0);
            //getterEscena(5).getterParte(0).getterParte(7).setterTranslacion2(-0.0f, 0.0f, 0);

            getterEscenaParte(5, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", 0);
            getterEscena(5).getterParte(0).getterParte(8).setterTranslacion2(0.0f, 0.0f, 0);

            getterEscena(5).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 50);
            getterEscena(5).getterParte(0).getterParte(9).setterTranslacion2(-0.0f, 0.0f, 0);
            //////////////pierna delantera derecha

            //getterEscenaParte(5, 0).getterParte(2).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(5, 0).getterParte(3).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(5, 0).getterParte(4).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(5, 0).getterParte(5).setterTranslacion2(0.5f, 0, 0);

            getterEscenaParte(5, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(5, 0).getterParte(2).setterTranslacion2(0, 0.01f, 0);

            getterEscenaParte(5, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(5, 0).getterParte(3).setterTranslacion2(0.025f, 0.01f, 0);

            getterEscenaParte(5, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(5, 0).getterParte(4).translacion2(0.08f, 0.02f, 0);

            getterEscenaParte(5, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(5, 0).getterParte(5).setterTranslacion2(0.1f, 0.03f, 0);
            //////////// cabeza
            getterEscenaParte(5, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(5, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);
        }
        public void escena7()
        {
            setterEscena(new escenario());//6
            setterEscenaParte(6, new perro());

            ////cola hacia abajo
            getterEscena(6).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", -10);
            ////pierna trasera izquierda
            getterEscenaParte(6, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -5);

            getterEscenaParte(6, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -5);
            getterEscenaParte(6, 0).getterParte(15).setterTranslacion2(-0.01f, 0, 0);

            getterEscenaParte(6, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(6, 0).getterParte(16).setterTranslacion2(-0.01f, 0.01f, 0);

            getterEscenaParte(6, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 40);
            getterEscenaParte(6, 0).getterParte(17).setterTranslacion2(0.02f, 0.02f, 0);
            ////pierna trasera derecha
            getterEscena(6).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(6, 0).getterParte(10).setterTranslacion2(0.018f, 0.0f, 0);

            getterEscena(6).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(6, 0).getterParte(11).setterTranslacion2(0.0f, 0.0f, 0);

            getterEscenaParte(6, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", 0);
            getterEscenaParte(6, 0).getterParte(12).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(6, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(6, 0).getterParte(13).setterTranslacion2(-0.025f, 0.0f, 0);
            ////////////// pierna delantera izquierda
            getterEscena(6).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", -20);
            //getterEscena(6).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(6).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", -20);
            getterEscena(6).getterParte(0).getterParte(7).setterTranslacion2(-0.01f, 0.0f, 0);

            getterEscenaParte(6, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", -20);
            getterEscena(6).getterParte(0).getterParte(8).setterTranslacion2(-0.045f, 0.0f, 0);

            getterEscena(6).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", 40);
            getterEscena(6).getterParte(0).getterParte(9).setterTranslacion2(-0.06f, 0.01f, 0);
            //////////////pierna delantera derecha

            //getterEscenaParte(6, 0).getterParte(2).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(6, 0).getterParte(3).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(6, 0).getterParte(4).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(6, 0).getterParte(5).setterTranslacion2(0.5f, 0, 0);

            getterEscenaParte(6, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(6, 0).getterParte(2).setterTranslacion2(0, 0.01f, 0);

            getterEscenaParte(6, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(6, 0).getterParte(3).setterTranslacion2(0.025f, 0.01f, 0);

            getterEscenaParte(6, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(6, 0).getterParte(4).translacion2(0.06f, 0.02f, 0);

            getterEscenaParte(6, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(6, 0).getterParte(5).setterTranslacion2(0.08f, 0.01f, 0);
            //////////// cabeza
            getterEscenaParte(6, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(6, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);

        }
        public void escena8()
        {
            setterEscena(new escenario());//7
            setterEscenaParte(7, new perro());//0

            ////cola hacia abajo
            getterEscena(7).getterParte(0).getterParte(0).setterRotEnSuPuntoDeRef("z", 60);
            ////pierna trasera izquierda
            getterEscenaParte(7, 0).getterParte(14).setterRotEnSuPuntoDeRef("z", -5);
            getterEscenaParte(7, 0).getterParte(14).setterTranslacion2(0.01f, 0, 0);

            getterEscenaParte(7, 0).getterParte(15).setterRotEnSuPuntoDeRef("z", -5);
            getterEscenaParte(7, 0).getterParte(15).setterTranslacion2(-0.0f, 0, 0);

            getterEscenaParte(7, 0).getterParte(16).setterRotEnSuPuntoDeRef("z", 30);
            getterEscenaParte(7, 0).getterParte(16).setterTranslacion2(-0.01f, 0.01f, 0);

            getterEscenaParte(7, 0).getterParte(17).setterRotEnSuPuntoDeRef("z", 40);
            getterEscenaParte(7, 0).getterParte(17).setterTranslacion2(0.02f, 0.02f, 0);
            ////pierna trasera derecha
            getterEscena(7).getterParte(0).getterParte(10).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(7, 0).getterParte(10).setterTranslacion2(-0.0f, 0.01f, 0);

            getterEscena(7).getterParte(0).getterParte(11).setterRotEnSuPuntoDeRef("z", -30);
            getterEscenaParte(7, 0).getterParte(11).setterTranslacion2(-0.03f, 0.01f, 0);

            getterEscenaParte(7, 0).getterParte(12).setterRotEnSuPuntoDeRef("z", 10);
            getterEscenaParte(7, 0).getterParte(12).setterTranslacion2(-0.08f, 0.02f, 0);

            getterEscenaParte(7, 0).getterParte(13).setterRotEnSuPuntoDeRef("z", 20);
            getterEscenaParte(7, 0).getterParte(13).setterTranslacion2(-0.070f, 0.01f, 0);
            ////////////// pierna delantera izquierda
            getterEscena(7).getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", 20);
            //getterEscena(7).getterParte(0).getterParte(6).setterTranslacion2(-0.01f, 0, 0);

            getterEscena(7).getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", 25);
            getterEscena(7).getterParte(0).getterParte(7).setterTranslacion2(0.02f, 0.0f, 0);

            getterEscenaParte(7, 0).getterParte(8).setterRotEnSuPuntoDeRef("z", -20);
            getterEscena(7).getterParte(0).getterParte(8).setterTranslacion2(0.05f, 0.02f, 0);

            getterEscena(7).getterParte(0).getterParte(9).setterRotEnSuPuntoDeRef("z", -50);
            getterEscena(7).getterParte(0).getterParte(9).setterTranslacion2(0.03f, 0.02f, 0);
            //////////////pierna delantera derecha

            //getterEscenaParte(7, 0).getterParte(2).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(7, 0).getterParte(3).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(7, 0).getterParte(4).setterTranslacion2(0.5f, 0, 0);
            //getterEscenaParte(7, 0).getterParte(5).setterTranslacion2(0.5f, 0, 0);

            //getterEscenaParte(7, 0).getterParte(2).setterRotEnSuPuntoDeRef("z", 0);
            //getterEscenaParte(7, 0).getterParte(2).setterTranslacion2(0, 0.0f, 0);

            //getterEscenaParte(7, 0).getterParte(3).setterRotEnSuPuntoDeRef("z", 0);
            //getterEscenaParte(7, 0).getterParte(3).setterTranslacion2(0.025f, 0.0f, 0);

            //getterEscenaParte(7, 0).getterParte(4).setterRotEnSuPuntoDeRef("z", 20);
            //getterEscenaParte(7, 0).getterParte(4).translacion2(0.06f, 0.02f, 0);

            getterEscenaParte(7, 0).getterParte(5).setterRotEnSuPuntoDeRef("z", 50);
            getterEscenaParte(7, 0).getterParte(5).setterTranslacion2(-0.01f, 0.0f, 0);
            //////////// cabeza
            getterEscenaParte(7, 0).getterParte(1).setterRotEnSuPuntoDeRef("z", -20);
            getterEscenaParte(7, 0).getterParte(1).setterTranslacion2(-0.02f, 0.0f, 0);

        }
    }
}
