namespace Almacenamiento_de_peliculas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PeliButton = new System.Windows.Forms.Button();
            this.ActorButton = new System.Windows.Forms.Button();
            this.DirectorButton = new System.Windows.Forms.Button();
            this.ProdButton = new System.Windows.Forms.Button();
            this.EstuButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PeliButton
            // 
            this.PeliButton.Location = new System.Drawing.Point(137, 206);
            this.PeliButton.Name = "PeliButton";
            this.PeliButton.Size = new System.Drawing.Size(98, 38);
            this.PeliButton.TabIndex = 0;
            this.PeliButton.Text = "Peliculas";
            this.PeliButton.UseVisualStyleBackColor = true;
            this.PeliButton.Click += new System.EventHandler(this.PeliButton_Click);
            // 
            // ActorButton
            // 
            this.ActorButton.Location = new System.Drawing.Point(241, 206);
            this.ActorButton.Name = "ActorButton";
            this.ActorButton.Size = new System.Drawing.Size(98, 38);
            this.ActorButton.TabIndex = 1;
            this.ActorButton.Text = "Actores";
            this.ActorButton.UseVisualStyleBackColor = true;
            // 
            // DirectorButton
            // 
            this.DirectorButton.Location = new System.Drawing.Point(345, 206);
            this.DirectorButton.Name = "DirectorButton";
            this.DirectorButton.Size = new System.Drawing.Size(98, 38);
            this.DirectorButton.TabIndex = 2;
            this.DirectorButton.Text = "Directores";
            this.DirectorButton.UseVisualStyleBackColor = true;
            // 
            // ProdButton
            // 
            this.ProdButton.Location = new System.Drawing.Point(449, 206);
            this.ProdButton.Name = "ProdButton";
            this.ProdButton.Size = new System.Drawing.Size(98, 38);
            this.ProdButton.TabIndex = 3;
            this.ProdButton.Text = "Productores";
            this.ProdButton.UseVisualStyleBackColor = true;
            // 
            // EstuButton
            // 
            this.EstuButton.Location = new System.Drawing.Point(553, 206);
            this.EstuButton.Name = "EstuButton";
            this.EstuButton.Size = new System.Drawing.Size(98, 38);
            this.EstuButton.TabIndex = 4;
            this.EstuButton.Text = "Estudios";
            this.EstuButton.UseVisualStyleBackColor = true;
            this.EstuButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(241, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 95);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EstuButton);
            this.Controls.Add(this.ProdButton);
            this.Controls.Add(this.DirectorButton);
            this.Controls.Add(this.ActorButton);
            this.Controls.Add(this.PeliButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PeliButton;
        private System.Windows.Forms.Button ActorButton;
        private System.Windows.Forms.Button DirectorButton;
        private System.Windows.Forms.Button ProdButton;
        private System.Windows.Forms.Button EstuButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

