using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class rocas : objetos
    {
        float[] vertices = {
            -0.4f, 0.1f, 0.0f,//0
            -0.3f, 0.1f, 0.0f,//1
            -0.2f, 0.0f, 0.0f, //2
            -0.2f, -0.1f, 0.0f, //3
            -0.3f, -0.2f, 0.0f, //4
            -0.4f, -0.2f, 0.0f, //5
            -0.5f, -0.1f, 0.0f, //6
            -0.5f, 0.0f, 0.0f, //7
            //cuadrado del centro en +z
            -0.4f, 0.0f, 0.1f,//8
            -0.3f, 0.0f, 0.1f, //9
            -0.3f, -0.1f, 0.1f, //10
            -0.4f, -0.1f, 0.1f, //11
            //cuadrado del centro -z
            -0.4f, 0.0f, -0.1f,//12
            -0.3f, 0.0f, -0.1f, //13
            -0.3f, -0.1f, -0.1f, //14
            -0.4f, -0.1f, -0.1f, //15

        };
        uint[] indices =
        {
            0, 1, 8,
            8, 9, 1,
            1, 2, 9,
            2, 9, 10,
            2, 3, 10,
            3, 10, 4,
            10, 11, 4,
            4, 5, 11,
            5, 6, 11,
            6, 8, 11,
            6, 7, 8,
            7, 8, 0,

            8, 9, 10,
            8, 10, 11,

            0, 1, 12,
            8, 13, 1,
            1, 2, 13,
            2, 13, 14,
            2, 3, 14,
            3, 14, 4,
            14, 15, 4,
            4, 5, 15,
            5, 6, 15,
            6, 12, 15,
            6, 7, 12,
            7, 12, 0,

            12, 13, 15,
            13, 14, 15
        };
        Color4 color = new Color4(037, 034, 027, 1);
        Vector3 centro = new Vector3(-0.35f, -0.05f, 0.0f);
        public rocas() : base()
        {
            base.inicializar(vertices, indices, color, centro);
        }

    }
}
