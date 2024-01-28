using System.Drawing;
using System.Windows.Forms;

namespace SistemaControloAlerta.Forms
{
    partial class FrmAdicionar
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
            this.TxtAreAfetada = new System.Windows.Forms.TextBox();
            this.TxtNInterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDataHoje = new System.Windows.Forms.DateTimePicker();
            this.DtpDataPrazo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.RtbCounteudoDespacho = new System.Windows.Forms.RichTextBox();
            this.BtnSalvar = new ePOSOne.btnProduct.Button_WOC();
            this.RtbAssunto = new System.Windows.Forms.RichTextBox();
            this.RtbObs = new System.Windows.Forms.RichTextBox();
            this.BtnCancelar = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // TxtAreAfetada
            // 
            this.TxtAreAfetada.Location = new System.Drawing.Point(78, 510);
            this.TxtAreAfetada.Name = "TxtAreAfetada";
            this.TxtAreAfetada.Size = new System.Drawing.Size(568, 22);
            this.TxtAreAfetada.TabIndex = 5;
            // 
            // TxtNInterno
            // 
            this.TxtNInterno.Location = new System.Drawing.Point(76, 580);
            this.TxtNInterno.Name = "TxtNInterno";
            this.TxtNInterno.Size = new System.Drawing.Size(570, 22);
            this.TxtNInterno.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(75, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ASSUNTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(75, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "CONTEÙDO DO DESPACHO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(75, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ÁREA AFECTADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(75, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "OF.INTERNO Nº";
            // 
            // txtObs
            // 
            this.txtObs.AutoSize = true;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.txtObs.Location = new System.Drawing.Point(73, 616);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(43, 18);
            this.txtObs.TabIndex = 12;
            this.txtObs.Text = "OBS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label7.Location = new System.Drawing.Point(778, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRAZO";
            // 
            // DtpDataHoje
            // 
            this.DtpDataHoje.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataHoje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataHoje.Location = new System.Drawing.Point(738, 55);
            this.DtpDataHoje.Name = "DtpDataHoje";
            this.DtpDataHoje.Size = new System.Drawing.Size(141, 22);
            this.DtpDataHoje.TabIndex = 14;
            // 
            // DtpDataPrazo
            // 
            this.DtpDataPrazo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataPrazo.Location = new System.Drawing.Point(738, 136);
            this.DtpDataPrazo.Name = "DtpDataPrazo";
            this.DtpDataPrazo.Size = new System.Drawing.Size(141, 22);
            this.DtpDataPrazo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(785, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "DATA";
            // 
            // RtbCounteudoDespacho
            // 
            this.RtbCounteudoDespacho.Location = new System.Drawing.Point(77, 161);
            this.RtbCounteudoDespacho.Name = "RtbCounteudoDespacho";
            this.RtbCounteudoDespacho.Size = new System.Drawing.Size(569, 298);
            this.RtbCounteudoDespacho.TabIndex = 18;
            this.RtbCounteudoDespacho.Text = "";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BorderColor = System.Drawing.Color.Yellow;
            this.BtnSalvar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(712, 196);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BtnSalvar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BtnSalvar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BtnSalvar.Size = new System.Drawing.Size(187, 71);
            this.BtnSalvar.TabIndex = 19;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.TextColor = System.Drawing.Color.White;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // RtbAssunto
            // 
            this.RtbAssunto.Location = new System.Drawing.Point(76, 55);
            this.RtbAssunto.Name = "RtbAssunto";
            this.RtbAssunto.Size = new System.Drawing.Size(570, 56);
            this.RtbAssunto.TabIndex = 20;
            this.RtbAssunto.Text = "";
            // 
            // RtbObs
            // 
            this.RtbObs.Location = new System.Drawing.Point(76, 646);
            this.RtbObs.Name = "RtbObs";
            this.RtbObs.Size = new System.Drawing.Size(570, 53);
            this.RtbObs.TabIndex = 21;
            this.RtbObs.Text = "";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BorderColor = System.Drawing.Color.Yellow;
            this.BtnCancelar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(712, 302);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BtnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BtnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BtnCancelar.Size = new System.Drawing.Size(187, 71);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1063, 739);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.RtbObs);
            this.Controls.Add(this.RtbAssunto);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.RtbCounteudoDespacho);
            this.Controls.Add(this.DtpDataPrazo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtpDataHoje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNInterno);
            this.Controls.Add(this.TxtAreAfetada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TxtAreAfetada;
        private TextBox TxtNInterno;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtObs;
        private Label label7;
        private DateTimePicker DtpDataHoje;
        private DateTimePicker DtpDataPrazo;
        private Label label8;
        private RichTextBox RtbCounteudoDespacho;
        private ePOSOne.btnProduct.Button_WOC BtnSalvar;
        private RichTextBox RtbAssunto;
        private RichTextBox RtbObs;
        private ePOSOne.btnProduct.Button_WOC BtnCancelar;
    }
}