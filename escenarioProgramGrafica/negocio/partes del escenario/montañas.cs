using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class montañas : objetos
    {
        float[] vertices = {
            -0.2f, -0.2f, 0.0f, //0
            0.7f, -0.2f, 0.0f, //1
            0.4f, 1.0f, -0.4f, //2
            0.4f, -0.2f, -0.8f, //3

            0.4f, -0.2f, 0.0f,//4
            1.3f, -0.2f, 0.0f, //5
            0.9f, 1.6f, -0.4f, //6
            0.9f, -0.2f, -0.8f //7
        };
        uint[] indices =
        {
            0, 1, 2,
            1, 2, 3,
            2, 3, 0,
            3, 0, 1,
            
            4, 5, 6,
            5, 6, 7,
            6, 7, 4, 
            4, 5, 7
        };
        Color4 color = new Color4(115, 66, 34, 1);
        Vector3 centro = new Vector3(0.55f, 0.7f, 0.0f);

        public montañas():base()
        {
            base.inicializar(vertices, indices, color, centro);
        }
    }
}
