namespace TALLER_ESTRELLA
{
    partial class frmStar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.lblEscalar = new System.Windows.Forms.Label();
            this.lblTrasladar = new System.Windows.Forms.Label();
            this.lblrotar = new System.Windows.Forms.Label();
            this.trbEscalar = new System.Windows.Forms.TrackBar();
            this.btnStartTranslation = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnizquierda = new System.Windows.Forms.Button();
            this.grbPicStar = new System.Windows.Forms.GroupBox();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.grbInput.SuspendLayout();
            this.grbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscalar)).BeginInit();
            this.grbPicStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.btnReset);
            this.grbInput.Controls.Add(this.btnCalculate2);
            this.grbInput.Controls.Add(this.btnCalculate);
            this.grbInput.Controls.Add(this.txtRatio);
            this.grbInput.Controls.Add(this.lblRatio);
            this.grbInput.Location = new System.Drawing.Point(12, 28);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(246, 168);
            this.grbInput.TabIndex = 1;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "ENTRADA";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 122);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(231, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Limpiar antes de Ejecutar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.Location = new System.Drawing.Point(125, 68);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(112, 48);
            this.btnCalculate2.TabIndex = 3;
            this.btnCalculate2.Text = "STAR STUDENT";
            this.btnCalculate2.UseVisualStyleBackColor = true;
            this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 68);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 48);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "STAR INGE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(76, 31);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(100, 22);
            this.txtRatio.TabIndex = 1;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(7, 31);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(47, 16);
            this.lblRatio.TabIndex = 0;
            this.lblRatio.Text = "Radio:";
            this.lblRatio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.lblEscalar);
            this.grbActions.Controls.Add(this.lblTrasladar);
            this.grbActions.Controls.Add(this.lblrotar);
            this.grbActions.Controls.Add(this.trbEscalar);
            this.grbActions.Controls.Add(this.btnStartTranslation);
            this.grbActions.Controls.Add(this.btnDerecha);
            this.grbActions.Controls.Add(this.btnizquierda);
            this.grbActions.Location = new System.Drawing.Point(12, 202);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(245, 236);
            this.grbActions.TabIndex = 2;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Acciones";
            // 
            // lblEscalar
            // 
            this.lblEscalar.AutoSize = true;
            this.lblEscalar.Location = new System.Drawing.Point(100, 175);
            this.lblEscalar.Name = "lblEscalar";
            this.lblEscalar.Size = new System.Drawing.Size(69, 16);
            this.lblEscalar.TabIndex = 6;
            this.lblEscalar.Text = "ESCALAR";
            // 
            // lblTrasladar
            // 
            this.lblTrasladar.AutoSize = true;
            this.lblTrasladar.Location = new System.Drawing.Point(81, 94);
            this.lblTrasladar.Name = "lblTrasladar";
            this.lblTrasladar.Size = new System.Drawing.Size(89, 16);
            this.lblTrasladar.TabIndex = 5;
            this.lblTrasladar.Text = "TRASLADAR";
            // 
            // lblrotar
            // 
            this.lblrotar.AutoSize = true;
            this.lblrotar.Location = new System.Drawing.Point(100, 18);
            this.lblrotar.Name = "lblrotar";
            this.lblrotar.Size = new System.Drawing.Size(55, 16);
            this.lblrotar.TabIndex = 4;
            this.lblrotar.Text = "ROTAR";
            // 
            // trbEscalar
            // 
            this.trbEscalar.Location = new System.Drawing.Point(6, 194);
            this.trbEscalar.Name = "trbEscalar";
            this.trbEscalar.Size = new System.Drawing.Size(233, 56);
            this.trbEscalar.TabIndex = 3;
            this.trbEscalar.Scroll += new System.EventHandler(this.trbEscalar_Scroll);
            // 
            // btnStartTranslation
            // 
            this.btnStartTranslation.Location = new System.Drawing.Point(84, 128);
            this.btnStartTranslation.Name = "btnStartTranslation";
            this.btnStartTranslation.Size = new System.Drawing.Size(75, 23);
            this.btnStartTranslation.TabIndex = 2;
            this.btnStartTranslation.Text = "TRASLADAR";
            this.btnStartTranslation.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(129, 46);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "DERECHA";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnizquierda
            // 
            this.btnizquierda.Location = new System.Drawing.Point(34, 46);
            this.btnizquierda.Name = "btnizquierda";
            this.btnizquierda.Size = new System.Drawing.Size(75, 23);
            this.btnizquierda.TabIndex = 0;
            this.btnizquierda.Text = "IZQUIERDA";
            this.btnizquierda.UseVisualStyleBackColor = true;
            this.btnizquierda.Click += new System.EventHandler(this.btnizquierda_Click);
            // 
            // grbPicStar
            // 
            this.grbPicStar.Controls.Add(this.picStar);
            this.grbPicStar.Location = new System.Drawing.Point(264, 28);
            this.grbPicStar.Name = "grbPicStar";
            this.grbPicStar.Size = new System.Drawing.Size(524, 410);
            this.grbPicStar.TabIndex = 3;
            this.grbPicStar.TabStop = false;
            this.grbPicStar.Text = "ESTRELLA";
            // 
            // picStar
            // 
            this.picStar.Location = new System.Drawing.Point(6, 31);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(512, 379);
            this.picStar.TabIndex = 0;
            this.picStar.TabStop = false;
            // 
            // frmStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbPicStar);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.grbInput);
            this.Name = "frmStar";
            this.Text = "ESTRELLA";
            this.Load += new System.EventHandler(this.frmStar_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbActions.ResumeLayout(false);
            this.grbActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbEscalar)).EndInit();
            this.grbPicStar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.GroupBox grbPicStar;
        private System.Windows.Forms.Label lblEscalar;
        private System.Windows.Forms.Label lblTrasladar;
        private System.Windows.Forms.Label lblrotar;
        private System.Windows.Forms.TrackBar trbEscalar;
        private System.Windows.Forms.Button btnStartTranslation;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnizquierda;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Button btnReset;
    }
}