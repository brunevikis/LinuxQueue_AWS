
namespace LinuxQueueGUI
{
    partial class FormGerMaq
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
            this.lv_GerMaq = new System.Windows.Forms.ListView();
            this.Node_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo_Col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_cancela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_GerMaq
            // 
            this.lv_GerMaq.CheckBoxes = true;
            this.lv_GerMaq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Node_Col,
            this.Modelo_Col,
            this.Tipo_Col});
            this.lv_GerMaq.FullRowSelect = true;
            this.lv_GerMaq.GridLines = true;
            this.lv_GerMaq.HideSelection = false;
            this.lv_GerMaq.Location = new System.Drawing.Point(62, 110);
            this.lv_GerMaq.Name = "lv_GerMaq";
            this.lv_GerMaq.Size = new System.Drawing.Size(356, 179);
            this.lv_GerMaq.TabIndex = 0;
            this.lv_GerMaq.UseCompatibleStateImageBehavior = false;
            this.lv_GerMaq.View = System.Windows.Forms.View.Details;
            // 
            // Node_Col
            // 
            this.Node_Col.Text = "Cluster";
            // 
            // Modelo_Col
            // 
            this.Modelo_Col.Text = "Modelo";
            this.Modelo_Col.Width = 119;
            // 
            // Tipo_Col
            // 
            this.Tipo_Col.Text = "Tipo";
            this.Tipo_Col.Width = 111;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(482, 110);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_cancela
            // 
            this.btn_cancela.Location = new System.Drawing.Point(482, 166);
            this.btn_cancela.Name = "btn_cancela";
            this.btn_cancela.Size = new System.Drawing.Size(75, 23);
            this.btn_cancela.TabIndex = 2;
            this.btn_cancela.Text = "CANCELAR";
            this.btn_cancela.UseVisualStyleBackColor = true;
            this.btn_cancela.Click += new System.EventHandler(this.btn_cancela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Os clusters marcados serão habilitados para uso";
            // 
            // FormGerMaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancela);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.lv_GerMaq);
            this.Name = "FormGerMaq";
            this.Text = "Gerenciar Maquinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_GerMaq;
        private System.Windows.Forms.ColumnHeader Node_Col;
        private System.Windows.Forms.ColumnHeader Modelo_Col;
        private System.Windows.Forms.ColumnHeader Tipo_Col;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancela;
        private System.Windows.Forms.Label label1;
    }
}