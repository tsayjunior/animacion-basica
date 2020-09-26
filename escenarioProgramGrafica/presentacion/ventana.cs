﻿using escenarioProgramGrafica.negocio;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace escenarioProgramGrafica.presentacion
{
    class ventana : GameWindow
    {
        
        miEscenario escenario;
        escenasDelPerro escenasDelPerro;
        public ventana(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 170f, 228f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            escenario = new miEscenario();
            escenasDelPerro = new escenasDelPerro();

            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            escenario.dibujar();
            escenario.moverEscena1(0, 0.1f);
            //Thread.Sleep(500);
            escenasDelPerro.dibujarEscenas(0.1f);//le pasamos el tiempo en segundo
            //escenario2.dibujarEscenaNumero(2);

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
            if (input.IsKeyDown(Key.R))
            {
                //presionando R pone en true mi rotacion
                //escenario.activarTransformacion("rotar");
                escenario.getterParte(14).getterParte(11).rotar("zpositivo");
            }
            if (input.IsKeyDown(Key.T))
            {
                //presionando T pone en true mi traslacion
                //escenario.activarTransformacion("trasladar");

            }
            if (input.IsKeyDown(Key.E))
            {
                //presionando E pone en true mi escalacion
                //escenario.activarTransformacion("escalar");
            }
            if (input.IsKeyDown(Key.Right))
            {
                //escenario.hacertransformacion("xpositivo");
                escenario.trasladar2(0.01f, 0, 0);
            }

            if (input.IsKeyDown(Key.Left))
            {
                //escenario.hacertransformacion("xnegativo");
                escenario.trasladar2(-0.01f, 0, 0);
            }

            if (input.IsKeyDown(Key.Up))
            {
                //escenario.hacertransformacion("ypositivo");
                escenario.trasladar2(0.0f, 0.01f, 0);
            }

            if (input.IsKeyDown(Key.Down))
            {
                //escenario.hacertransformacion("ynegativo");
                escenario.trasladar2(0.0f, -0.01f, 0);
            }
            if (input.IsKeyDown(Key.Keypad9))
            {
                //presionando numero 9 se mueve, rota o esala hacia el eje Z positivo
                //escenario.hacertransformacion("zpositivo");
            }
            if (input.IsKeyDown(Key.Keypad1))
            {
                    //presionando numero 1 se mueve, rota o esala hacia el eje Z negativo
                    //escenario.hacertransformacion("znegativo");

            }
                base.OnUpdateFrame(e);
        }
        protected override void OnUnload(EventArgs e)
        {

            //escenario.destroyEscenario();
            escenario.Destroys();
            escenasDelPerro.Destroys();
            base.OnUnload(e);
        }
    }
}