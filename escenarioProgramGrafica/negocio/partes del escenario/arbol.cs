using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class arbol : objetos
    {
        float[] verticesTronco = {
            -0.6f, -0.2f, 0.0f, //0
            -1f, -0.2f, 0.0f,//1
            -0.9f, 0.0f, 0.0f, //2
            -0.9f, 0.5f, 0.0f, //3
            -0.7f, 0.5f, 0.0f, //4
            -0.7f, 0.0f, 0.0f, //5
            -0.9f, -0.2f, 0.0f, //6
            -0.7f, -0.2f,0.0f, //7

            -0.6f, -0.2f, -0.2f, //8 -----0
            -1f, -0.2f, -0.2f,//9
            -0.9f, 0.0f, -0.2f, //10
            -0.9f, 0.5f, -0.2f, //11
            -0.7f, 0.5f, -0.2f, //12
            -0.7f, 0.0f, -0.2f, //13
            -0.9f, -0.2f, -0.2f, //14
            -0.7f, -0.2f, -0.2f, //15
        };
        uint[] indicesTronco =
        {
            1, 2, 6,
            3, 6, 4,
            6, 7, 4,
            5, 7, 0,

            0, 8, 5,
            5, 8, 13,
            4, 5, 13,
            4, 12, 13,

            1, 2, 9,
            2, 9, 10,
            2, 3, 10,
            3, 10, 11,

            11, 12, 14,
            14, 12, 15,
            9, 10, 14,
            8, 13, 15,

            3, 11, 4,
            11, 12, 4,

            1, 9, 0,
            8, 9, 0
        };
        Color4 colorTronco = new Color4(194, 155, 97, 1);
        Vector3 centroTronco = new Vector3(-0.8f, 0.15f, -0.1f);

        float[] verticesRamas = {
            -0.9f, 0.5f, -0.2f, //0  ---- 2
            -0.7f, 0.5f, -0.2f, //1  -----3

            -0.9f, 0.5f, 0.0f, //2
            -0.7f, 0.5f, 0.0f, //3
            -0.5f, 0.7f, 0.0f, //4
            -0.5f, 0.8f, 0.0f, //5
            -0.7f, 1.0f, 0.0f, //6
            -0.9f, 1.0f, 0.0f, //7
            -1.1f, 0.8f, 0.0f, //8
            -1.1f, 0.7f, 0.0f, //9

            -0.9f, 0.7f, 0.1f, //10
            -0.9f, 0.8f, 0.1f, //11
            -0.7f, 0.8f, 0.1f, //12
            -0.7f, 0.7f, 0.1f, //13
///------el lado z negativo
            -0.5f, 0.7f, -0.2f, //14
            -0.5f, 0.8f, -0.2f, //15
            -0.7f, 1.0f, -0.2f, //16
            -0.9f, 1.0f, -0.2f, //17
            -1.1f, 0.8f, -0.2f, //18
            -1.1f, 0.7f, -0.2f, //19

            -0.9f, 0.7f, -0.3f, //20
            -0.9f, 0.8f, -0.3f, //21
            -0.7f, 0.8f, -0.3f, //22
            -0.7f, 0.7f, -0.3f, //23
        };
        uint[] indicesRamas =
        {
            9, 10, 2,
            8, 9, 10,
            8, 10, 11,
            7, 8, 11,
            6, 7, 11,
            6, 11, 12,
            5, 6, 12,
            12, 13, 5,
            4, 5, 13,
            3, 4, 13, 
            3, 13, 10,
            2, 3, 10,
            10, 11, 12,
            12, 13, 10,

            19, 20, 0,
            18, 19, 20,
            18, 20, 21,
            17, 18, 21,
            16, 17, 21,
            16, 21, 22,
            15, 16, 22,
            22, 23, 15,
            14, 15, 23,
            1, 14, 23,
            1, 23, 20,
            0, 1, 20,
            20, 21, 22,
            22, 23, 20,

            5, 15, 14,
            4, 14, 5,

            4, 14, 1,
            1, 3, 4,

            5, 15, 16,
            16, 5, 6,

            7, 17, 18,
            18, 8, 7,

            8, 18, 19,
            19, 9, 8,

            9, 19, 0,
            0, 2, 9,

            7, 17, 16,
            16, 6, 7,

            2, 0, 1,
            1, 3, 2
        };
        Color4 colorRamas = new Color4(0, 128, 0, 1);
        Vector3 centroRamas = new Vector3(-0.8f, 0.75f, -0.1f);

        Vector3 centroArbol = new Vector3(-0.8f, 0.4f, -0.1f);
        public arbol()
        {
            base.inicializar(verticesTronco, indicesTronco, colorTronco, centroTronco);
            setterParte(new objetos());
            getterParte(0).inicializar(verticesRamas, indicesRamas, colorRamas, centroRamas);
        }
        
    }
}
