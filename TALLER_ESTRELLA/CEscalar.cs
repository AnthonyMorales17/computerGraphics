using System;

namespace TALLER_ESTRELLA
{
    internal class CEscalar
    {
        private float escalaMinima;
        private float escalaMaxima;

        public CEscalar(float escalaMinima = 0.1f, float escalaMaxima = 3.0f)
        {
            this.escalaMinima = escalaMinima;
            this.escalaMaxima = escalaMaxima;
        }

        public float EscalaMinima
        {
            get { return escalaMinima; }
            set { escalaMinima = value; }
        }

        public float EscalaMaxima
        {
            get { return escalaMaxima; }
            set { escalaMaxima = value; }
        }

        public void EstablecerEscala(CEstrella estrella, float nuevaEscala)
        {
            // Limitar la escala dentro del rango permitido
            if (nuevaEscala < escalaMinima)
                nuevaEscala = escalaMinima;
            if (nuevaEscala > escalaMaxima)
                nuevaEscala = escalaMaxima;

            estrella.Escala = nuevaEscala;
        }

        public void EscalarPorcentaje(CEstrella estrella, int porcentaje)
        {
            // Convertir porcentaje (0-100) a escala (escalaMinima-escalaMaxima)
            float escala = escalaMinima + (escalaMaxima - escalaMinima) * (porcentaje / 100.0f);
            EstablecerEscala(estrella, escala);
        }

        public int ObtenerPorcentaje(CEstrella estrella)
        {
            // Convertir escala actual a porcentaje (0-100)
            float porcentaje = ((estrella.Escala - escalaMinima) / (escalaMaxima - escalaMinima)) * 100.0f;
            return (int)Math.Round(porcentaje);
        }

        public void Incrementar(CEstrella estrella, float incremento = 0.1f)
        {
            EstablecerEscala(estrella, estrella.Escala + incremento);
        }

        public void Decrementar(CEstrella estrella, float decremento = 0.1f)
        {
            EstablecerEscala(estrella, estrella.Escala - decremento);
        }

        public bool PuedeIncrementar(CEstrella estrella)
        {
            return estrella.Escala < escalaMaxima;
        }

        public bool PuedeDecrementar(CEstrella estrella)
        {
            return estrella.Escala > escalaMinima;
        }
    }
}