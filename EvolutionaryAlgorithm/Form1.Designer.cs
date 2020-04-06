namespace EvolutionaryAlgorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPerfectGeneration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVGeneration = new System.Windows.Forms.DataGridView();
            this.ClGeneration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMutation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeneration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evolutionary Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type the text of the perfect generation: ";
            // 
            // TbPerfectGeneration
            // 
            this.TbPerfectGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPerfectGeneration.Location = new System.Drawing.Point(38, 124);
            this.TbPerfectGeneration.MaxLength = 50;
            this.TbPerfectGeneration.Multiline = true;
            this.TbPerfectGeneration.Name = "TbPerfectGeneration";
            this.TbPerfectGeneration.Size = new System.Drawing.Size(1010, 40);
            this.TbPerfectGeneration.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(934, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate_Click);
            // 
            // DGVGeneration
            // 
            this.DGVGeneration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGeneration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClGeneration,
            this.ClMutation,
            this.ClScore});
            this.DGVGeneration.Location = new System.Drawing.Point(38, 224);
            this.DGVGeneration.Name = "DGVGeneration";
            this.DGVGeneration.RowHeadersWidth = 51;
            this.DGVGeneration.RowTemplate.Height = 24;
            this.DGVGeneration.Size = new System.Drawing.Size(1010, 271);
            this.DGVGeneration.TabIndex = 4;
            this.DGVGeneration.Visible = false;
            // 
            // ClGeneration
            // 
            this.ClGeneration.HeaderText = "Generation";
            this.ClGeneration.MinimumWidth = 6;
            this.ClGeneration.Name = "ClGeneration";
            this.ClGeneration.ReadOnly = true;
            this.ClGeneration.Width = 90;
            // 
            // ClMutation
            // 
            this.ClMutation.HeaderText = "Mutation";
            this.ClMutation.MinimumWidth = 6;
            this.ClMutation.Name = "ClMutation";
            this.ClMutation.ReadOnly = true;
            this.ClMutation.Width = 540;
            // 
            // ClScore
            // 
            this.ClScore.HeaderText = "Score";
            this.ClScore.MinimumWidth = 6;
            this.ClScore.Name = "ClScore";
            this.ClScore.ReadOnly = true;
            this.ClScore.Width = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 625);
            this.Controls.Add(this.DGVGeneration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TbPerfectGeneration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Evolutionary Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVGeneration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPerfectGeneration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGVGeneration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClGeneration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMutation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClScore;
    }
}

