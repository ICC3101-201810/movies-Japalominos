namespace Almacenamiento_de_peliculas
{
    partial class ListaGeneral
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
            this.ListaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListaBox
            // 
            this.ListaBox.FormattingEnabled = true;
            this.ListaBox.Location = new System.Drawing.Point(12, 15);
            this.ListaBox.Name = "ListaBox";
            this.ListaBox.Size = new System.Drawing.Size(776, 420);
            this.ListaBox.TabIndex = 0;
            // 
            // ListaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaBox);
            this.Name = "ListaGeneral";
            this.Text = "ListaGeneral";
            this.Load += new System.EventHandler(this.ListaGeneral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaBox;
    }
}