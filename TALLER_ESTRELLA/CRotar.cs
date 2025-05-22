using System;

namespace TALLER_ESTRELLA
{
    internal class CRotar
    {
        private float incrementoAngulo;

        public CRotar(float incrementoAngulo = 0.3f) // Incremento más visible
        {
            this.incrementoAngulo = incrementoAngulo;
        }

        public float IncrementoAngulo
        {
            get { return incrementoAngulo; }
            set { incrementoAngulo = value; }
        }

        public void RotarIzquierda(CEstrella estrella)
        {
            estrella.Angulo -= incrementoAngulo;
            // Normalizar el ángulo entre 0 y 2π
            while (estrella.Angulo < 0)
                estrella.Angulo += (float)(2 * Math.PI);
        }

        public void RotarDerecha(CEstrella estrella)
        {
            estrella.Angulo += incrementoAngulo;
            // Normalizar el ángulo entre 0 y 2π
            while (estrella.Angulo >= 2 * Math.PI)
                estrella.Angulo -= (float)(2 * Math.PI);
        }

        public void EstablecerAngulo(CEstrella estrella, float nuevoAngulo)
        {
            estrella.Angulo = nuevoAngulo;
            // Normalizar el ángulo
            while (estrella.Angulo < 0)
                estrella.Angulo += (float)(2 * Math.PI);
            while (estrella.Angulo >= 2 * Math.PI)
                estrella.Angulo -= (float)(2 * Math.PI);
        }

        public float ObtenerAnguloEnGrados(CEstrella estrella)
        {
            return (float)(estrella.Angulo * 180.0 / Math.PI);
        }

        public void EstablecerAnguloEnGrados(CEstrella estrella, float anguloGrados)
        {
            estrella.Angulo = (float)(anguloGrados * Math.PI / 180.0);
            // Normalizar
            while (estrella.Angulo < 0)
                estrella.Angulo += (float)(2 * Math.PI);
            while (estrella.Angulo >= 2 * Math.PI)
                estrella.Angulo -= (float)(2 * Math.PI);
        }

        public void RotarContinuamente(CEstrella estrella, bool izquierda = false)
        {
            if (izquierda)
                RotarIzquierda(estrella);
            else
                RotarDerecha(estrella);
        }
    }
}
