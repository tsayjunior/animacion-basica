using escenarioProgramGrafica.recursos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.negocio
{
    class objetos : IObjeto
    {
        public float[] vertices;
        public uint[] indices;
        Color4 color;
        Vector3 centroDeOrigen;

        int VertexBufferObject;//objeto de bufer de vertices VBO
        int ElementBufferObject; // EBO
        int VertexArrayObject; //VAO

        shader shader;

        Matrix4 model; //rotacion
        Matrix4 projection; //escalacion  //donde translation * projection
        float escala;
        Matrix4 translation;//translacion
        Matrix4 view;//vista de camara

        Vector3 position;
        Vector3 front;
        Vector3 up;


        bool rotacion;
        bool traslacion;
        bool escalacion;
        bool casa;

        List<objetos> parte = new List<objetos>();

        public objetos()
        {

        }
        //setter
        public void setterCentroOrigen(Vector3 centro)
        {
            this.centroDeOrigen = centro;
        }
        public void setterShader(string vert, string frag)
        {
            shader = new shader(vert, frag);//instancio shader
            shader.Use();
        }
        public void setterColor(Color4 color)
        {
            this.color = color;
            shader.setColor(color);
        }
        public void setterRotacion(string XYZ, float angulo)// poner x o y o z y el angulo al cual rotar
        {
            switch (XYZ)
            {
                case "x":
                    model = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angulo)); //rotacion
                    break;
                case "y":
                    model = Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angulo)); //rotacion
                    break;
                case "z":
                    model = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angulo)); //rotacion
                    break;

            }

        }
        public void setterRotEnSuPuntoDeRef(string xyz, float angulo)
        {
            switch (xyz)
            {
                case "x":
                    model = Matrix4.CreateTranslation(-centroDeOrigen);
                    model = model * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centroDeOrigen);
                    break;
                case "y":
                    model = Matrix4.CreateTranslation(-centroDeOrigen);
                    model = model * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centroDeOrigen);
                    break;
                case "z":
                    model = Matrix4.CreateTranslation(-centroDeOrigen);
                    model = model * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centroDeOrigen);
                    break;

            }
        }
        public void setterTranslacion(float x, float y, float z)//mueve segun el punto de origen 0,0
        {
            translation = Matrix4.CreateTranslation(x, y, z);
            projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                800 / 600, 0.1f, 100.0f);//escalacion
        }
        public void setterTranslacion2(float x, float y, float z) //mueve desde donde este el objeto
        {
            translation = translation * Matrix4.CreateTranslation(x, y, z);
            projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                800 / 600, 0.1f, 100.0f);//escalacion
        }

        public void setterEscalacion(float escala) //projection o escalacion
        {
            this.escala = escala;
            projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                800 / 600, 0.1f, 100.0f);//escalacion
        }
        public void setterPosition(float x, float y, float z)//posicion de la camara
        {
            this.position = new Vector3(x, y, z);
        }
        public void setterFront(float x, float y, float z)
        {
            this.front = new Vector3(x, y, z);
        }
        public void setterUp(float x, float y, float z)
        {
            this.up = new Vector3(x, y, z);
        }
        public void setterView(Vector3 pos, Vector3 front, Vector3 up)
        {
            this.view = Matrix4.LookAt(pos, /*position + */front, up);
        }
        public void setterEscala(float esc)
        {
            this.escala = esc;
        }
        public void setterMatrix4()
        {
            shader.SetMatrix4("model", model);
            shader.SetMatrix4("view", view);
            shader.SetMatrix4("projection", projection);
        }
        public void setterParte(objetos obj)
        {
            parte.Add(obj);
        }
        public objetos getterParte(int i)
        {
            return parte[i];
        }

        public void inicializar(float[] vertice, uint[] indice, Color4 color, Vector3 centro)
        {
            this.vertices = vertice;
            this.indices = indice;
            setterCentroOrigen(centro);
            inicializarbufferes();

            setterShader("recursos/shaders/shader.vert", "recursos/shaders/shader.frag");
            setterColor(color);

            setterPosition(0.0f, 1f, 4);//posicion de la camara
            setterFront(0, 0.8f, 0);//hacia donde mira
            setterUp(0, 1, 0);

            setterEscala(45);
            //view = Matrix4.LookAt(position, /*position + */front, up);
            setterView(position, front, up);
            setterRotacion("z", 0);
            setterTranslacion(0, 0, 0);
            setterEscalacion(escala);
            rotacion = true;
            traslacion = true;
            escalacion = false;
            //casa = true;
        }
        public void inicializarbufferes()
        {
            VertexBufferObject = GL.GenBuffer();
            ElementBufferObject = GL.GenBuffer();
            VertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(VertexArrayObject); ////habilitamos el VA0
            //enlaza VBO con buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, VertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
            //enlaza el ebo con el buffer 
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ElementBufferObject);
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
        }
        public void dibuja()
        {
            setterMatrix4();
            shader.Use();
            //setUniforms();
            GL.BindVertexArray(VertexArrayObject);
            //dibuja

            GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, 0);

        }
        public void destroy()
        { // borra los buffers creados al cerrar el programa
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);// lo enlaza a nulo
            GL.DeleteBuffer(VertexBufferObject);//borra vbo

            shader.Dispose();//elimina shader
        }
        // ************************funciones del todo con sus partes
        public void dibujar()
        {
            dibuja();
            foreach (objetos partes in parte)
            {
                partes.dibuja();
            }
        }

        public void destroys()
        {
            destroy();
            foreach (objetos partes in parte)
            {
                partes.destroy();
            }
        }


        public void translacion(float x, float y, float z) //traslada todo, con sus partes
        {
            setterTranslacion(x, y, z);
            foreach (objetos partes in parte)
            {
                partes.setterTranslacion(x, y, z);
            }
        }
        public void translacion2(float x, float y, float z) //traslada todo, con sus partes desde donde este
        {
            setterTranslacion2(x, y, z);
            foreach (objetos partes in parte)
            {
                partes.setterTranslacion2(x, y, z);
            }
        }

        public void escalation(float x) //escala todo, con sus partes
        {
            setterEscalacion(x);
            foreach (objetos partes in parte)
            {
                partes.setterEscalacion(x);
            }
        }
        //TRANSFORMACIONES PARA USAR EN TECLADO
        public void Trasladar(string direccion)
        {
            if (traslacion)
            {
                switch (direccion)
                {
                    case "xpositivo":
                        translation = translation * Matrix4.CreateTranslation(0.01f, 0.0f, 0.0f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("x+");
                        break;
                    case "xnegativo":
                        translation = translation * Matrix4.CreateTranslation(-0.01f, 0.0f, 0.0f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("x-");
                        break;
                    case "ypositivo":
                        translation = translation * Matrix4.CreateTranslation(0.0f, 0.01f, 0.0f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("y+");
                        break;
                    case "ynegativo":
                        translation = translation * Matrix4.CreateTranslation(0.0f, -0.01f, 0.0f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("y-");
                        break;
                    case "zpositivo":
                        translation = translation * Matrix4.CreateTranslation(0.0f, 0.0f, 0.01f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("z+");
                        break;
                    case "znegativo":
                        translation = translation * Matrix4.CreateTranslation(0.0f, 0.0f, -0.01f);
                        projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        Console.WriteLine("z-");
                        break;
                    default:
                        Console.WriteLine("no hay esa opcion");
                        break;
                }
            }
        }
        public void escalar(string direccion)
        {
            if (escalacion)
            {
                switch (direccion)
                {
                    case "ypositivo":
                        if (escala > 1)
                        {
                            escala = escala - 1;
                            projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        }
                        break;
                    case "ynegativo":
                        if (escala < 179)
                        {
                            escala = escala + 1;
                            projection = translation * Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(escala),
                    800 / 600, 0.1f, 100.0f);//escalacion;
                        }
                        break;
                    default:
                        Console.WriteLine("no hay esa opcion");
                        break;
                }
            }
        }
        public void rotar(string direccion)
        {
            if (rotacion)
            {
                switch (direccion)
                {
                    case "xpositivo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        break;
                    case "xnegativo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        break;
                    case "ypositivo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        break;
                    case "ynegativo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(-1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        break;
                    case "zpositivo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        Console.WriteLine(model);
                        break;
                    case "znegativo":
                        model *= Matrix4.CreateTranslation(-centroDeOrigen);
                        model = model * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(-1)); //rotacion
                        model *= Matrix4.CreateTranslation(centroDeOrigen);
                        break;
                    default:
                        Console.WriteLine("no hay esa opcion");
                        break;
                }
            }
        }
        public void escogerTransformacion(string transf)
        {
            switch (transf)
            {
                case ("rotar"):
                    rotacion = true;
                    traslacion = false;
                    escalacion = false;
                    break;
                case ("trasladar"):
                    rotacion = false;
                    traslacion = true;
                    escalacion = false;
                    break;
                case ("escalar"):
                    rotacion = false;
                    traslacion = false;
                    escalacion = true;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        public void rotar2(string xyz, float angulo, Vector3 centro)
        {
            switch (xyz)
            {
                case "x":
                    model = Matrix4.CreateTranslation(-centro);
                    model = model * Matrix4.CreateRotationX(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centro);
                    break;
                case "y":
                    model = Matrix4.CreateTranslation(-centro);
                    model = model * Matrix4.CreateRotationY(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centro);
                    break;
                case "z":
                    model = Matrix4.CreateTranslation(-centro);
                    model = model * Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(angulo)); //rotacion
                    model *= Matrix4.CreateTranslation(centro);
                    break;

            }
        }

    }
}
