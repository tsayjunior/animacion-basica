using escenarioProgramGrafica.negocio.partes_del_escenario;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class miEscenario : escenario
    {
        public miEscenario()
        {
            setterParte(new campo());
            escena1();
        }
        
        public void inicializar(int i)//inicializa todos los objetos, en la escena dada por variable i
        {
            setterEscenaParte(i, new montañas());//0
            setterEscenaParte(i, new montañas());//1
            getterEscena(i).setterParte(new montañas());//2
            getterEscena(i).setterParte(new arbol());//3
            getterEscena(i).setterParte(new arbol());//4
            getterEscena(i).setterParte(new arbol());//5
            getterEscena(i).setterParte(new arbol());//6
            getterEscena(i).setterParte(new arbol());//7
            getterEscena(i).setterParte(new rocas());//8
            getterEscena(i).setterParte(new rocas());//9
            getterEscena(i).setterParte(new rocas());//10
            getterEscena(i).setterParte(new rocas());//11
            getterEscena(i).setterParte(new rocas());//12
            //arboles
            getterEscenaParte(i, 0).translacion(-2.39f, 0, -2f);
            getterEscenaParte(i, 1).translacion(-0.51f, 0.5f, -3);
            getterEscenaParte(i, 1).setterEscalacion(29);
            getterEscenaParte(i, 2).translacion(0.79f, 0, -2f);
            //
            getterEscenaParte(i, 3).translacion(-1.5f, 0, -1);
            getterEscenaParte(i, 4).translacion(-0.1f, 0.0f, -1);
            getterEscenaParte(i, 5).translacion(1.9f, 0, -3f);
            getterEscenaParte(i, 6).translacion(0.4f, 0.0f, -3);
            getterEscenaParte(i, 7).translacion(1.7f, 0, 1.5f);
            getterEscenaParte(i, 8).translacion(-0.5f, -0.0f, 1.6f);
            getterEscenaParte(i, 9).translacion(-1.3f, -0.0f, -0.5f);
            getterEscenaParte(i, 10).translacion(-0.7f, -0.0f, -1f);
            getterEscenaParte(i, 11).translacion(0.9f, -0.0f, -1f);
            getterEscenaParte(i, 12).translacion(0.9f, 0, 1.6f);
        }
        public void escena1()
        {
            setterEscena(new escenario());//0
            inicializar(0);
            getterEscena(0).trasladar2(5.2f, 0, 0);
        }

        //float time;
        int aux;
        public void moverEscena1()
        {
            aux++;
            getterEscena(0).trasladar2(-0.01f, 0, 0);
                if (aux > 950)
                {
                    getterEscena(0).Destroys();
                    borrarEscena(0);
                    escena1();
                     aux = 0;
                }         
        }    
    }
}
