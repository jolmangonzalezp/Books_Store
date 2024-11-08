namespace FromLibrary
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.miBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.miMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoan,
            this.miBooks,
            this.miAuthor,
            this.miMembers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miLoan
            // 
            this.miLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLoan.Name = "miLoan";
            this.miLoan.Size = new System.Drawing.Size(57, 23);
            this.miLoan.Text = "Loan";
            this.miLoan.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // miBooks
            // 
            this.miBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.miBooks.Name = "miBooks";
            this.miBooks.Size = new System.Drawing.Size(66, 23);
            this.miBooks.Text = "Books";
            // 
            // miAuthor
            // 
            this.miAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.miAuthor.Name = "miAuthor";
            this.miAuthor.Size = new System.Drawing.Size(68, 23);
            this.miAuthor.Text = "Author";
            // 
            // miMembers
            // 
            this.miMembers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.miMembers.Name = "miMembers";
            this.miMembers.Size = new System.Drawing.Size(89, 23);
            this.miMembers.Text = "Members";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miLoan;
        private System.Windows.Forms.ToolStripMenuItem miBooks;
        private System.Windows.Forms.ToolStripMenuItem miAuthor;
        private System.Windows.Forms.ToolStripMenuItem miMembers;
    }
}

