using OpenTK.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class escenario
    {
        List<objetos> partes = new List<objetos>();
        int i = 1;
        int time;
        List<escenario> escenas = new List<escenario>();
        public void setterParte(objetos part)
        {
            partes.Add(part);
        }
        public objetos getterParte(int i)
        {
            return partes[i];
        }
        public void dibujar()
        {
            foreach(objetos parte in partes)
            {
                parte.dibujar();
            }
        }
        public void destroy()
        {
            foreach (objetos parte in partes)
            {
                parte.destroys();
            }
        }
        public void escalar(float escala)
        {
            foreach (objetos parte in partes)
            {
                parte.escalation(escala);
            }
        }
        public void trasladar(float x, float y, float z)//traslada todo el escenario segun el punto de origen
        {
            foreach (objetos parte in partes)
            {
                parte.translacion(x, y, z);
            }
        }
        public void trasladar2(float x, float y, float z)//traslada todo el escenario desde donde este
        {
            foreach (objetos parte in partes)
            {
                parte.translacion2(x, y, z);
            }
        }
       //*************** metodos de la lista de escenario**********
        public void setterEscena(escenario part)
        {
            escenas.Add(part);
        }
        public escenario getterEscena(int i)
        {
            return escenas[i];
        }
        public void borrarEscena(int i)//borra elemento de la lista en la posicion i
        {
            escenas.Remove(escenas[i]);
        }
        public int cantidadEscenas()
        {
            return escenas.Count();
        }
        public void Destroys()//destruye todo, incluyendo mi lista de escenario
        {
            destroy();
            foreach(escenario parte in escenas)
            {
                parte.destroy();
            }
        }
        public void dibujarEscenaNumero(int i)//dibuja la escena segun la posicion que le demos, ya sea la escena 1, o la 2, etc
        {
            escenas[i - 1].dibujar();
        }
        public void dibujarEscenas(float segundos)//dibuja todas las escenas segun el tiempo en segundo le demos
        {
            time++;
            if (time > segundos * 30)
            {
                time = 0;
                i++;
                if (i > cantidadEscenas())
                {
                    i = 1;
                }
            }
            dibujarEscenaNumero(i);

        }
        public void setterEscenaParte(int i, objetos obj)
        {//inserta a la lista de escenas, una nueva parte, ejemplo a la lista de escenas, en la posicion 0, le añade
            //un nuevo objeto a la lista de partes
            getterEscena(i).setterParte(obj);
        }
        public objetos getterEscenaParte(int a, int b)
        {//muestra de la lista de partes, la parte en la posicion b, de la lista de escenas, la escena en la posicion a
            return getterEscena(a).getterParte(b);
        }
       
    
    }
}
