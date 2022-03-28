namespace Flappy_Birds1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Khaki;
            this.scoreText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(154, 353);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(81, 28);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "SCORE:0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipetop
            // 
            this.pipetop.Image = global::Flappy_Birds1.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(530, -17);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(58, 116);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_Birds1.Properties.Resources.rooster_icon;
            this.FlappyBird.Location = new System.Drawing.Point(103, 79);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(46, 39);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::Flappy_Birds1.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(313, 284);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(58, 88);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 2;
            this.pipebottom.TabStop = false;
            this.pipebottom.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Birds1.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-4, 339);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(494, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(400, 390);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipebottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox ground;
    }
}

