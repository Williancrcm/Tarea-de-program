
namespace Practica0709
{
    partial class Form2
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
            this.btfill = new System.Windows.Forms.Button();
            this.dgdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btfill
            // 
            this.btfill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btfill.Location = new System.Drawing.Point(52, 49);
            this.btfill.Name = "btfill";
            this.btfill.Size = new System.Drawing.Size(124, 40);
            this.btfill.TabIndex = 0;
            this.btfill.Text = "GetStudent()";
            this.btfill.UseVisualStyleBackColor = true;
            // 
            // dgdata
            // 
            this.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdata.Location = new System.Drawing.Point(249, 31);
            this.dgdata.Name = "dgdata";
            this.dgdata.Size = new System.Drawing.Size(507, 168);
            this.dgdata.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.dgdata);
            this.Controls.Add(this.btfill);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btfill;
        private System.Windows.Forms.DataGridView dgdata;
    }
}