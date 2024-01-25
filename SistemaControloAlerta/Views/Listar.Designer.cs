namespace SistemaControloAlerta.Forms
{
    partial class FrmListar
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
            this.DgvDEPA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDEPA)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDEPA
            // 
            this.DgvDEPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDEPA.Location = new System.Drawing.Point(77, 236);
            this.DgvDEPA.Name = "DgvDEPA";
            this.DgvDEPA.RowHeadersWidth = 51;
            this.DgvDEPA.RowTemplate.Height = 24;
            this.DgvDEPA.Size = new System.Drawing.Size(758, 297);
            this.DgvDEPA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(77, 182);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(677, 22);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnPesquisar.IconColor = System.Drawing.Color.Black;
            this.BtnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPesquisar.Location = new System.Drawing.Point(760, 182);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "iconButton1";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(972, 673);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDEPA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListar";
            this.Text = "Listar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDEPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDEPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private FontAwesome.Sharp.IconButton BtnPesquisar;
    }
}