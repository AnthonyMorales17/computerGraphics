using System.Drawing;
using System.Windows.Forms;

namespace TALLER_ESTRELLA
{
    internal class CTrasladar
    {
        private PictureBox pictureBox;

        public void InicializarTraslacion(PictureBox pb)
        {
            pictureBox = pb;
        }

        public void MoverA(CEstrella estrella, PointF nuevaPosicion)
        {
            estrella.Centro = nuevaPosicion;
            pictureBox?.Invalidate();
        }

        public void MoverRelativo(CEstrella estrella, float deltaX, float deltaY)
        {
            estrella.Centro = new PointF(
                estrella.Centro.X + deltaX,
                estrella.Centro.Y + deltaY
            );
            pictureBox?.Invalidate();
        }

        public void MoverArriba(CEstrella estrella, float distancia = 10)
        {
            MoverRelativo(estrella, 0, -distancia);
        }

        public void MoverAbajo(CEstrella estrella, float distancia = 10)
        {
            MoverRelativo(estrella, 0, distancia);
        }

        public void MoverIzquierda(CEstrella estrella, float distancia = 10)
        {
            MoverRelativo(estrella, -distancia, 0);
        }

        public void MoverDerecha(CEstrella estrella, float distancia = 10)
        {
            MoverRelativo(estrella, distancia, 0);
        }
    }
}