using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    interface IObjeto
    {
        void inicializar(float[] vertice, uint[] indice, Color4 color, Vector3 centro);
        void setterCentroOrigen(Vector3 centro);
        void setterColor(Color4 color);
        void escalation(float escala);
        void translacion(float x, float y, float z);
        void setterRotacion(string XYZ, float angulo);
        void dibuja();
        void destroy();
        void setterParte(objetos obj);
        objetos getterParte(int i);
    }
}
