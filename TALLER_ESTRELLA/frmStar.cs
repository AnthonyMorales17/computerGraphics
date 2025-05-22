using System;
using System.Drawing;
using System.Windows.Forms;

namespace TALLER_ESTRELLA
{
    public partial class frmStar : Form
    {
        private CEstrella estrella;
        private CRotar rotador;
        private CEscalar escalador;
        private CTrasladar trasladador;
        private Pen lapiz;

        public frmStar()
        {
            InitializeComponent();
            InicializarComponentes();

            // Permitir que el formulario capture teclas
            this.KeyPreview = true;
            this.KeyDown += FrmStar_KeyDown;
        }

        private void InicializarComponentes()
        {
            rotador = new CRotar(0.2f);
            escalador = new CEscalar(0.1f, 3.0f);
            trasladador = new CTrasladar();
            lapiz = new Pen(Color.Black, 2);

            if (picStar != null)
            {
                picStar.Paint += PictureBox1_Paint;
                picStar.BackColor = Color.White;
            }

            if (trbEscalar != null)
            {
                trbEscalar.Minimum = 10;
                trbEscalar.Maximum = 300;
                trbEscalar.Value = 100;
                trbEscalar.TickFrequency = 25;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (estrella != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                estrella.DibujarCompleta(e.Graphics, lapiz);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(txtRatio.Text, out float radio) && radio > 0)
                {
                    PointF centro = new PointF(
                        picStar.Width / 2.0f,
                        picStar.Height / 2.0f
                    );

                    estrella = new CEstrella(radio, centro);
                    trasladador.InicializarTraslacion(picStar);

                    picStar.Invalidate();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un radio válido mayor que 0.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la estrella: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmStar_KeyDown(object sender, KeyEventArgs e)
        {
            if (estrella == null) return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    trasladador.MoverArriba(estrella);
                    break;
                case Keys.Down:
                    trasladador.MoverAbajo(estrella);
                    break;
                case Keys.Left:
                    trasladador.MoverIzquierda(estrella);
                    break;
                case Keys.Right:
                    trasladador.MoverDerecha(estrella);
                    break;
            }
        }

        private void trbEscalar_Scroll(object sender, EventArgs e)
        {
            if (estrella != null && trbEscalar != null)
            {
                escalador.EscalarPorcentaje(estrella, trbEscalar.Value / 3);
                picStar.Invalidate();
            }
        }

        private void btnizquierda_Click(object sender, EventArgs e)
        {
            if (estrella != null)
            {
                rotador.RotarIzquierda(estrella);
                picStar.Invalidate();
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (estrella != null)
            {
                rotador.RotarDerecha(estrella);
                picStar.Invalidate();
            }
        }



        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRatio.Text, out int radius) || radius <= 0)
            {
                MessageBox.Show("Ingrese un radio válido.");
                return;
            }

            Bitmap bmp = new Bitmap(picStar.Width, picStar.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Point center = new Point(picStar.Width / 2, picStar.Height / 2);

                int count = 4;
                CStarInsideStars estrellas = new CStarInsideStars(radius, count, center);
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    estrellas.Draw(g, pen);
                }
            }

            picStar.Image = bmp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReiniciarEstrella();
            CStarInsideStars helper = new CStarInsideStars(0, 0, Point.Empty);
            helper.InitializeData(txtRatio, picStar);
        }

        public void ReiniciarEstrella()
        {
            if (estrella != null && picStar != null)
            {
                estrella.Centro = new PointF(picStar.Width / 2.0f, picStar.Height / 2.0f);
                estrella.Angulo = 0;
                estrella.Escala = 1.0f;

                if (trbEscalar != null)
                    trbEscalar.Value = 100;

                picStar.Invalidate();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (lapiz != null)
                lapiz.Dispose();

            base.OnFormClosed(e);
        }

        private void frmStar_Load(object sender, EventArgs e)
        {

        }
    }
}
