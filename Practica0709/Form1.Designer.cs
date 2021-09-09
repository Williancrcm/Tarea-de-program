
namespace Practica0709
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
            this.dgdata = new System.Windows.Forms.DataGridView();
            this.btfill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdata
            // 
            this.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata.Location = new System.Drawing.Point(296, 84);
            this.dgdata.Name = "dgdata";
            this.dgdata.Size = new System.Drawing.Size(510, 205);
            this.dgdata.TabIndex = 0;
            // 
            // btfill
            // 
            this.btfill.Location = new System.Drawing.Point(61, 84);
            this.btfill.Name = "btfill";
            this.btfill.Size = new System.Drawing.Size(137, 41);
            this.btfill.TabIndex = 1;
            this.btfill.Text = "GetStudents()";
            this.btfill.UseVisualStyleBackColor = true;
            this.btfill.Click += new System.EventHandler(this.btfill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 342);
            this.Controls.Add(this.btfill);
            this.Controls.Add(this.dgdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdata;
        private System.Windows.Forms.Button btfill;
    }
}

