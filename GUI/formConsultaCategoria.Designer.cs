﻿namespace UI
{
    partial class formConsultaCategoria
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
            btnLocalizar=new Button();
            txtConsultaCategoria=new TextBox();
            lblCategoria=new Label();
            dtgvDados=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(558, 60);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(114, 23);
            btnLocalizar.TabIndex=0;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            btnLocalizar.Click+=btnLocalizar_Click_1;
            // 
            // txtConsultaCategoria
            // 
            txtConsultaCategoria.Location=new Point(12, 61);
            txtConsultaCategoria.Name="txtConsultaCategoria";
            txtConsultaCategoria.Size=new Size(540, 23);
            txtConsultaCategoria.TabIndex=1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize=true;
            lblCategoria.Location=new Point(12, 43);
            lblCategoria.Name="lblCategoria";
            lblCategoria.Size=new Size(58, 15);
            lblCategoria.TabIndex=2;
            lblCategoria.Text="Categoria";
            // 
            // dtgvDados
            // 
            dtgvDados.AllowUserToAddRows=false;
            dtgvDados.AllowUserToDeleteRows=false;
            dtgvDados.AllowUserToOrderColumns=true;
            dtgvDados.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDados.Location=new Point(12, 101);
            dtgvDados.Name="dtgvDados";
            dtgvDados.ReadOnly=true;
            dtgvDados.RowTemplate.Height=25;
            dtgvDados.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dtgvDados.Size=new Size(660, 348);
            dtgvDados.TabIndex=3;
            dtgvDados.CellDoubleClick+=dtgvDados_CellDoubleClick;
            // 
            // formConsultaCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 461);
            Controls.Add(dtgvDados);
            Controls.Add(lblCategoria);
            Controls.Add(txtConsultaCategoria);
            Controls.Add(btnLocalizar);
            Name="formConsultaCategoria";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Categoria";
            Load+=formConsultaCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocalizar;
        private TextBox txtConsultaCategoria;
        private Label lblCategoria;
        private DataGridView dtgvDados;
    }
}