namespace Practica02_03
{
    partial class frmOperaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.btnDivision);
            this.grbGrupoA.Controls.Add(this.btnMultiplicacion);
            this.grbGrupoA.Controls.Add(this.btnResta);
            this.grbGrupoA.Controls.Add(this.lblResultado);
            this.grbGrupoA.Controls.Add(this.btnCalcular);
            this.grbGrupoA.Controls.Add(this.txtValorB);
            this.grbGrupoA.Controls.Add(this.txtValorA);
            this.grbGrupoA.Controls.Add(this.lblValorB);
            this.grbGrupoA.Controls.Add(this.lblValorA);
            this.grbGrupoA.Location = new System.Drawing.Point(35, 25);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(207, 200);
            this.grbGrupoA.TabIndex = 0;
            this.grbGrupoA.TabStop = false;
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(22, 40);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(41, 13);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(22, 69);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(41, 13);
            this.lblValorB.TabIndex = 1;
            this.lblValorB.Text = "Valor B";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(87, 32);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 2;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(87, 62);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(52, 127);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(38, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "+";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(22, 97);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(114, 127);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(38, 23);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(52, 156);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(38, 23);
            this.btnMultiplicacion.TabIndex = 7;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(114, 156);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(38, 23);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "frmOperaciones";
            this.Text = "Operaciones con Clases";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
    }
}

