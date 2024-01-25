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
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtAreaAfect = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtNumOfic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpDataHoje = new System.Windows.Forms.DateTimePicker();
            this.DtpDataPrazo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(78, 66);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(568, 22);
            this.txtAssunto.TabIndex = 3;
            // 
            // txtAreaAfect
            // 
            this.txtAreaAfect.Location = new System.Drawing.Point(78, 484);
            this.txtAreaAfect.Name = "txtAreaAfect";
            this.txtAreaAfect.Size = new System.Drawing.Size(568, 22);
            this.txtAreaAfect.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 620);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(570, 22);
            this.textBox4.TabIndex = 6;
            // 
            // txtNumOfic
            // 
            this.txtNumOfic.Location = new System.Drawing.Point(76, 554);
            this.txtNumOfic.Name = "txtNumOfic";
            this.txtNumOfic.Size = new System.Drawing.Size(570, 22);
            this.txtNumOfic.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(75, 34);
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
            this.label3.Location = new System.Drawing.Point(75, 104);
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
            this.label4.Location = new System.Drawing.Point(75, 454);
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
            this.label5.Location = new System.Drawing.Point(75, 524);
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
            this.txtObs.Location = new System.Drawing.Point(73, 590);
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
            this.label7.Location = new System.Drawing.Point(777, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "PRAZO";
            // 
            // DtpDataHoje
            // 
            this.DtpDataHoje.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataHoje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataHoje.Location = new System.Drawing.Point(737, 64);
            this.DtpDataHoje.Name = "DtpDataHoje";
            this.DtpDataHoje.Size = new System.Drawing.Size(141, 22);
            this.DtpDataHoje.TabIndex = 14;
            // 
            // DtpDataPrazo
            // 
            this.DtpDataPrazo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataPrazo.Location = new System.Drawing.Point(737, 145);
            this.DtpDataPrazo.Name = "DtpDataPrazo";
            this.DtpDataPrazo.Size = new System.Drawing.Size(141, 22);
            this.DtpDataPrazo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(784, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "DATA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(569, 298);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Yellow;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(711, 205);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(187, 71);
            this.button_WOC1.TabIndex = 19;
            this.button_WOC1.Text = "SALVAR";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // FrmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1063, 726);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DtpDataPrazo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtpDataHoje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumOfic);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAreaAfect);
            this.Controls.Add(this.txtAssunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtAssunto;
        private TextBox txtAreaAfect;
        private TextBox textBox4;
        private TextBox txtNumOfic;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtObs;
        private Label label7;
        private DateTimePicker DtpDataHoje;
        private DateTimePicker DtpDataPrazo;
        private Label label8;
        private RichTextBox richTextBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}