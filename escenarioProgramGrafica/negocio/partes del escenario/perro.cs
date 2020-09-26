using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio.partes_del_escenario
{
    class perro : objetos
    {
        float[] verticesTorso = {
            -0.5f, 0.1f, 0.0f, //0
            -0.2f, 0.1f, 0.0f, //1
            -0.2f, -0.0f, 0.0f, //2
            -0.5f, -0.0f, 0.0f, //3

            -0.5f, 0.1f, -0.2f, //4
            -0.2f, 0.1f, -0.2f, //5
            -0.2f, -0.0f, -0.2f, //6
            -0.5f, -0.0f, -0.2f, //7
            //cuello
            -0.2f, 0.05f, -0.075f, //8
            -0.2f, 0.1f, -0.075f, //9
            -0.15f, 0.1f, -0.075f, //10
            -0.15f, 0.05f, -0.075f, //11

            -0.2f, 0.05f, -0.125f, //12
            -0.2f, 0.1f, -0.125f, //13
            -0.15f, 0.1f, -0.125f, //14
            -0.15f, 0.05f, -0.125f, //15
        };
        uint[] indicesTorso =
        {
            0, 1, 2,
            0, 2, 3,
            4, 5, 6,
            4, 6, 7,
            0, 3, 4,
            7, 3, 4,
            1, 2, 5,
            5, 6, 2,
            6, 7, 3,
            2, 3, 6, 
            4, 5, 1,
            4, 1, 0,
            //cuello
            8, 9, 10,
            10, 11, 8,
            12, 13, 14,
            14, 15, 12,
            9, 13, 14,
            14, 9, 10,
            8, 12, 15,
            15, 8, 11,
            10, 11, 14,
            14, 15, 11,
            12, 13, 9,
            8, 9, 12,
            //cabeza

        };
        Color4 color = new Color4(117, 092, 072, 1);
        Vector3 centro = new Vector3(-0.35f, 0.05f, 0.0f);
        
        float[] verticesParte1Pierna =
        {
            -0.3f, -0.0f, 0.0f, //0
            -0.2f, -0.0f, 0.0f, //1
            -0.2f, -0.05f, 0.0f, //2
            -0.3f, -0.05f, 0.0f, //3

            -0.3f, -0.0f, -0.05f, //4
            -0.2f, -0.0f, -0.05f, //5
            -0.2f, -0.05f, -0.05f, //6
            -0.3f, -0.05f, -0.05f, //7
        };
        uint[] indicesParte1Pierna =
        {
            0, 1, 2,
            2, 3, 0,

            4, 5, 6,
            6, 7, 4,
            
            4,  7, 3,
            3, 0, 4,

            5, 6, 2,
            1, 2, 5,

            4, 5, 1,
            0, 1, 4,

            6, 7, 2,
            2, 3, 7
        };
        Vector3 centroParte1Pierna = new Vector3(-0.25f, 0.0f, 0.0f);
        Color4 colorParte1 = new Color4(117, 092, 072, 1);

        float[] verticesParte2Pierna =
        {
            -0.3f, -0.05f, 0.0f, //0
            -0.2f, -0.05f, 0.0f, //1
            -0.22f, -0.15f, 0.0f, //2
            -0.28f, -0.15f, 0.0f, //3

            -0.3f, -0.05f, -0.05f, //4
            -0.2f, -0.05f, -0.05f, //5
            -0.22f, -0.15f, -0.05f, //6
            -0.28f, -0.15f, -0.05f, //7
        };
        uint[] indicesParte2Pierna =
        {
            0, 1, 2,
            2, 3, 0,

            4, 5, 6,
            6, 7, 4,

            4,  7, 3,
            3, 0, 4,

            5, 6, 2,
            1, 2, 5,

            4, 5, 1,
            0, 1, 4,

            6, 7, 2,
            2, 3, 7
        };
        Vector3 centroParte2Pierna = new Vector3(-0.25f, -0.05f, 0.0f);
        Color4 colorParte2 = new Color4(117, 092, 072, 1);

        float[] verticesParte3Pierna =
        {
            -0.28f, -0.15f, 0.0f, //0
            -0.22f, -0.15f, 0.0f, //1
            -0.23f, -0.2f, 0.0f, //2
            -0.27f, -0.2f, 0.0f, //3

            -0.28f, -0.15f, -0.05f, //4
            -0.22f, -0.15f, -0.05f, //5
            -0.23f, -0.2f, -0.05f, //6
            -0.27f, -0.2f, -0.05f, //7
        };
        uint[] indicesParte3Pierna =
        {
            0, 1, 2,
            2, 3, 0,

            4, 5, 6,
            6, 7, 4,

            4,  7, 3,
            3, 0, 4,

            5, 6, 2,
            1, 2, 5,

            4, 5, 1,
            0, 1, 4,

            6, 7, 2,
            2, 3, 7
        };
        Vector3 centroParte3Pierna = new Vector3(-0.25f, -0.15f, 0.0f);
        Color4 colorParte3 = new Color4(117, 092, 072, 1);

        float[] verticesParte4Pierna =
        {
            -0.27f, -0.2f, 0.0f, //0
            -0.23f, -0.2f, 0.0f, //1
            -0.24f, -0.25f, 0.0f, //2
            -0.26f, -0.25f, 0.0f, //3

            -0.27f, -0.2f, -0.05f, //4
            -0.23f, -0.2f, -0.05f, //5
            -0.24f, -0.25f, -0.05f, //6
            -0.26f, -0.25f, -0.05f, //7
        };
        uint[] indicesParte4Pierna =
        {
            0, 1, 2,
            2, 3, 0,

            4, 5, 6,
            6, 7, 4,

            4,  7, 3,
            3, 0, 4,

            5, 6, 2,
            1, 2, 5,

            4, 5, 1,
            0, 1, 4,

            6, 7, 2,
            2, 3, 7
        };
        Vector3 centroParte4Pierna = new Vector3(-0.25f, -0.2f, 0.0f);
        Color4 colorParte4 = new Color4(117, 092, 072, 1);

        float[] verticesCola =
        {
            -0.5f, 0.1f, -0.1f, //0
            -0.65f, 0.08f, -0.08f, //1
            -0.65f, 0.12f, -0.1f, //2
            -0.65f, 0.08f, -0.12f //3
        };
        uint[] indicesCola =
        {
            0, 1, 2,
            0, 2, 3,
            0, 1, 3
        };
        Vector3 centroCola = new Vector3(-0.5f, 0.1f, -0.1f);
        Color4 colorCola = new Color4(80, 80, 80, 1);

        float[] verticesCabeza =
        {
            -0.15f, 0.15f, -0.05f, //0
            -0.15f, 0.05f, -0.05f, //1
            -0.05f, 0.06f, -0.075f, //2
            -0.05f, 0.09f, -0.075f, //3

            -0.15f, 0.15f, -0.15f, //0
            -0.15f, 0.05f, -0.15f, //1
            -0.05f, 0.06f, -0.125f, //2
            -0.05f, 0.09f, -0.125f, //3

        };
        uint[] indicesCabeza =
        {
            0, 1, 2,
            0, 2, 3,
            4, 5, 6,
            6, 7, 4,

            4, 0, 7,
            7, 3, 0,
            5, 6, 1,
            1, 2, 6,

            6, 7, 3,
            2, 3, 6,
            4, 5, 1,
            0, 1, 4

        };
        Vector3 centroCabeza = new Vector3(-0.15f, 0.075f, -0.1f);
        Color4 colorCabeza = new Color4(80, 80, 80, 1);

        Color4 colorPiernasIzquierdas = new Color4(076, 047, 039, 1);
        public perro()
        {
            base.inicializar(verticesTorso, indicesTorso, color, centro);
            //cola
            setterParte(new objetos()); //0 cola
            getterParte(0).inicializar(verticesCola, indicesCola, colorCola, centroCola);
            //cabeza
            setterParte(new objetos());//1 cabeza
            getterParte(1).inicializar(verticesCabeza, indicesCabeza, colorCabeza, centroCabeza);
            //pierna1 delantera derecha
            setterParte(new objetos()); //2
            getterParte(2).inicializar(verticesParte1Pierna, indicesParte1Pierna, colorParte1, centroParte1Pierna);
            setterParte(new objetos()); //3
            getterParte(3).inicializar(verticesParte2Pierna, indicesParte1Pierna, colorParte2, centroParte2Pierna);
            setterParte(new objetos()); //4
            getterParte(4).inicializar(verticesParte3Pierna, indicesParte1Pierna, colorParte3, centroParte3Pierna);
            setterParte(new objetos());//5
            getterParte(5).inicializar(verticesParte4Pierna, indicesParte1Pierna, colorParte4, centroParte4Pierna);
            //pierna 2 delantera izquierda
            setterParte(new objetos()); //6
            getterParte(6).inicializar(verticesParte1Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte1Pierna);
            setterParte(new objetos()); //7
            getterParte(7).inicializar(verticesParte2Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte2Pierna);
            setterParte(new objetos()); //8
            getterParte(8).inicializar(verticesParte3Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte3Pierna);
            setterParte(new objetos());//9
            getterParte(9).inicializar(verticesParte4Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte4Pierna);

            getterParte(6).translacion(0, 0, -0.15f);
            getterParte(7).translacion(0f, 0, -0.15f);
            getterParte(8).translacion(0f, 0, -0.15f);
            getterParte(9).translacion(0f, 0, -0.15f);

            //pierna 3 trasera derecha
            setterParte(new objetos()); //10
            getterParte(10).inicializar(verticesParte1Pierna, indicesParte1Pierna, colorParte1, centroParte1Pierna);
            setterParte(new objetos()); //11
            getterParte(11).inicializar(verticesParte2Pierna, indicesParte1Pierna, colorParte2, centroParte2Pierna);
            setterParte(new objetos()); //12
            getterParte(12).inicializar(verticesParte3Pierna, indicesParte1Pierna, colorParte3, centroParte3Pierna);
            setterParte(new objetos());//13
            getterParte(13).inicializar(verticesParte4Pierna, indicesParte1Pierna, colorParte4, centroParte4Pierna);

            getterParte(10).translacion(-0.2f, 0, 0);
            getterParte(11).translacion(-0.2f, 0, 0);
            getterParte(12).translacion(-0.2f, 0, 0);
            getterParte(13).translacion(-0.2f, 0, 0);


            //pierna 4 trasera izquierda
            setterParte(new objetos()); //14
            getterParte(14).inicializar(verticesParte1Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte1Pierna);
            setterParte(new objetos()); //15
            getterParte(15).inicializar(verticesParte2Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte2Pierna);
            setterParte(new objetos()); //16
            getterParte(16).inicializar(verticesParte3Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte3Pierna);
            setterParte(new objetos());//17
            getterParte(17).inicializar(verticesParte4Pierna, indicesParte1Pierna, colorPiernasIzquierdas, centroParte4Pierna);

            getterParte(14).translacion(-0.2f, 0, -0.15f);
            getterParte(15).translacion(-0.2f, 0, -0.15f);
            getterParte(16).translacion(-0.2f, 0, -0.15f);
            getterParte(17).translacion(-0.2f, 0, -0.15f);
        }
        public void caminar()
        {
            getterParte(0).setterRotEnSuPuntoDeRef("z", 60);
            ////pierna trasera izquierda
            getterParte(14).setterRotEnSuPuntoDeRef("z", -10);

            getterParte(15).setterRotEnSuPuntoDeRef("z", -15);
           getterParte(15).setterTranslacion2(-0.01f, 0, 0);

            getterParte(16).setterRotEnSuPuntoDeRef("z", 25);
            getterParte(16).setterTranslacion2(-0.03f, 0.01f, 0);

            getterParte(17).setterRotEnSuPuntoDeRef("z", 30);
            getterParte(17).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna trasera derecha
            getterParte(10).setterRotEnSuPuntoDeRef("z", -10);

            getterParte(11).setterRotEnSuPuntoDeRef("z", -33);
            getterParte(11).setterTranslacion2(-0.02f, 0, 0);

            getterParte(12).setterTranslacion2(-0.07f, 0.01f, 0);

            getterParte(13).setterRotEnSuPuntoDeRef("z", 18);
            getterParte(13).setterTranslacion2(-0.07f, 0.005f, 0);
            //// pierna delantera izquierda
            getterParte(0).getterParte(6).setterRotEnSuPuntoDeRef("z", -10);

            getterParte(0).getterParte(7).setterRotEnSuPuntoDeRef("z", -15);
            getterParte(0).getterParte(7).setterTranslacion2(-0.01f, 0, 0);

            getterParte(8).setterRotEnSuPuntoDeRef("z", 25);
            getterParte(8).setterTranslacion2(-0.03f, 0.01f, 0);

            getterParte(9).setterRotEnSuPuntoDeRef("z", 30);
            getterParte(9).setterTranslacion2(-0.01f, 0.01f, 0);
            ////pierna delantera derecha

            getterParte(2).setterRotEnSuPuntoDeRef("z", 5);

            getterParte(3).setterRotEnSuPuntoDeRef("z", 15);
            getterParte(3).setterTranslacion2(0.005f, 0, 0);

            getterParte(4).setterRotEnSuPuntoDeRef("z", 15);
            getterParte(4).translacion2(0.029f, 0.0f, 0);

            getterParte(5).setterRotEnSuPuntoDeRef("z", 15);
            getterParte(5).setterTranslacion2(0.04f, 0.005f, 0);

        }
    }
}
