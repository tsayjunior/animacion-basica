using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio.partes_del_escenario
{
    class campo : objetos
    {
        float[] vertices = {
            -4.5f, -0.25f, 4.5f,
            -4.5f, -0.25f, -4.5f,
            4.5f, -0.25f, -4.5f,
            4.5f, -0.25f, 4.5f
        };
        uint[] indices =
        {
            0, 1, 2,
            2, 3, 0
        };
        Color4 color = new Color4(0, 200, 0, 1);
        Vector3 centro = new Vector3(-0.35f, -0.05f, 0.0f);
        public campo() : base()
        {
            base.inicializar(vertices, indices, color, centro);
        }
    }
}
