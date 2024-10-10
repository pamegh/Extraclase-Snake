namespace ExtraSnake
{
    partial class Inicio
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
            this.comboNiveles = new System.Windows.Forms.ComboBox();
            this.bDificultad = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.imagenInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // comboNiveles
            // 
            this.comboNiveles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboNiveles.FormattingEnabled = true;
            this.comboNiveles.ItemHeight = 16;
            this.comboNiveles.Items.AddRange(new object[] {
            "FACIL",
            "MEDIO",
            "DIFICIL"});
            this.comboNiveles.Location = new System.Drawing.Point(34, 309);
            this.comboNiveles.Name = "comboNiveles";
            this.comboNiveles.Size = new System.Drawing.Size(181, 24);
            this.comboNiveles.TabIndex = 4;
            this.comboNiveles.SelectedIndexChanged += new System.EventHandler(this.comboNiveles_SelectedIndexChanged);
            // 
            // bDificultad
            // 
            this.bDificultad.BackgroundImage = global::ExtraSnake.Properties.Resources.pngtree_buttons_game_yellow_png_image_75817641;
            this.bDificultad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDificultad.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDificultad.Location = new System.Drawing.Point(34, 257);
            this.bDificultad.Name = "bDificultad";
            this.bDificultad.Size = new System.Drawing.Size(181, 57);
            this.bDificultad.TabIndex = 5;
            this.bDificultad.Text = "Dificultad";
            this.bDificultad.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.BackgroundImage = global::ExtraSnake.Properties.Resources.ilustracion_boton_reproduccion_1083548_1908__1_;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.Location = new System.Drawing.Point(34, 165);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(181, 86);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // imagenInicio
            // 
            this.imagenInicio.Image = global::ExtraSnake.Properties.Resources.unnamed;
            this.imagenInicio.InitialImage = null;
            this.imagenInicio.Location = new System.Drawing.Point(12, -15);
            this.imagenInicio.Name = "imagenInicio";
            this.imagenInicio.Size = new System.Drawing.Size(776, 453);
            this.imagenInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenInicio.TabIndex = 0;
            this.imagenInicio.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDificultad);
            this.Controls.Add(this.comboNiveles);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.imagenInicio);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenInicio;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ComboBox comboNiveles;
        private System.Windows.Forms.Button bDificultad;
    }
}