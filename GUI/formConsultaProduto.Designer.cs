﻿namespace UI
{
    partial class formConsultaProduto
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
            dtgvDados=new DataGridView();
            lblProduto=new Label();
            txtConsultaProduto=new TextBox();
            btnLocalizar=new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDados).BeginInit();
            SuspendLayout();
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
            dtgvDados.TabIndex=7;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize=true;
            lblProduto.Location=new Point(12, 43);
            lblProduto.Name="lblProduto";
            lblProduto.Size=new Size(103, 15);
            lblProduto.TabIndex=6;
            lblProduto.Text="Nome do Produto";
            // 
            // txtConsultaProduto
            // 
            txtConsultaProduto.Location=new Point(12, 61);
            txtConsultaProduto.Name="txtConsultaProduto";
            txtConsultaProduto.Size=new Size(540, 23);
            txtConsultaProduto.TabIndex=5;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location=new Point(558, 60);
            btnLocalizar.Name="btnLocalizar";
            btnLocalizar.Size=new Size(114, 23);
            btnLocalizar.TabIndex=4;
            btnLocalizar.Text="LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor=true;
            // 
            // formConsultaProduto
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(684, 461);
            Controls.Add(dtgvDados);
            Controls.Add(lblProduto);
            Controls.Add(txtConsultaProduto);
            Controls.Add(btnLocalizar);
            Name="formConsultaProduto";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Consulta de Produto";
            ((System.ComponentModel.ISupportInitialize)dtgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvDados;
        private Label lblProduto;
        private TextBox txtConsultaProduto;
        private Button btnLocalizar;
    }
}