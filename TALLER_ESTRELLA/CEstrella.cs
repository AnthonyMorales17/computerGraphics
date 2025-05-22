using System;
using System.Drawing;

namespace TALLER_ESTRELLA
{
    public class CEstrella
    {
        private float radio;
        private PointF centro;
        private float angulo;
        private float escala;

        public CEstrella(float radio, PointF centro)
        {
            this.radio = radio;
            this.centro = centro;
            this.angulo = 0;
            this.escala = 1.0f;
        }

        public float Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public PointF Centro
        {
            get { return centro; }
            set { centro = value; }
        }

        public float Angulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

        public float Escala
        {
            get { return escala; }
            set { escala = value; }
        }

        public PointF[] ObtenerPuntos()
        {
            PointF[] puntos = new PointF[10]; // 5 puntos externos + 5 internos
            float radioInterno = radio * 0.4f; // Radio interno es 40% del externo
            float radioActual = radio * escala;
            float radioInternoActual = radioInterno * escala;

            for (int i = 0; i < 10; i++)
            {
                float anguloActual = (float)(angulo + (i * Math.PI / 5) - Math.PI / 2);
                float r = (i % 2 == 0) ? radioActual : radioInternoActual;

                puntos[i] = new PointF(
                    centro.X + (float)(r * Math.Cos(anguloActual)),
                    centro.Y + (float)(r * Math.Sin(anguloActual))
                );
            }
            return puntos;
        }

        public void Dibujar(Graphics g, Pen lapiz)
        {
            PointF[] puntos = ObtenerPuntos();
            g.DrawPolygon(lapiz, puntos);
        }

        public void DibujarCompleta(Graphics g, Pen lapiz)
        {
            PointF[] puntos = new PointF[10];
            float radioInterno = radio * 0.5f;
            float radioExterno = radio;

            // CORRECCIÓN: usar el ángulo de rotación de la estrella
            double anguloActual = angulo - Math.PI / 2; // Aplicar rotación
            double paso = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                float r = (i % 2 == 0) ? radioExterno * escala : radioInterno * escala;
                puntos[i] = new PointF(
                    centro.X + (float)(r * Math.Cos(anguloActual)),
                    centro.Y + (float)(r * Math.Sin(anguloActual))
                );
                anguloActual += paso;
            }

            // Dibuja el contorno de la estrella
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(lapiz, puntos[i], puntos[(i + 1) % 10]);
            }

            // Dibuja líneas desde el centro hacia todos los vértices
            foreach (PointF p in puntos)
            {
                g.DrawLine(lapiz, centro, p);
            }

            // Dibuja líneas entre puntas alternas (conectando cada 4)
            for (int i = 0; i < 10; i++)
            {
                g.DrawLine(lapiz, puntos[i], puntos[(i + 4) % 10]);
            }
        }
    }
}