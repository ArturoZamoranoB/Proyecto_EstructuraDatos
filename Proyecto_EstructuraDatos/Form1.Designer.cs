namespace Proyecto_EstructuraDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Futbol = new System.Windows.Forms.Button();
            this.btn_Beisbol = new System.Windows.Forms.Button();
            this.btn_Basquetbol = new System.Windows.Forms.Button();
            this.btn_Voleibol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Cyan;
            this.Titulo.Location = new System.Drawing.Point(144, 100);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(579, 111);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "DEPORTES";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Futbol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Beisbol, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Basquetbol, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Voleibol, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(274, 323);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 95);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_Futbol
            // 
            this.btn_Futbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Futbol.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Futbol.Location = new System.Drawing.Point(4, 3);
            this.btn_Futbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Futbol.Name = "btn_Futbol";
            this.btn_Futbol.Size = new System.Drawing.Size(161, 39);
            this.btn_Futbol.TabIndex = 0;
            this.btn_Futbol.Text = "Futbol";
            this.btn_Futbol.UseVisualStyleBackColor = true;
            this.btn_Futbol.Click += new System.EventHandler(this.btn_Futbol_Click);
            // 
            // btn_Beisbol
            // 
            this.btn_Beisbol.Location = new System.Drawing.Point(4, 50);
            this.btn_Beisbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Beisbol.Name = "btn_Beisbol";
            this.btn_Beisbol.Size = new System.Drawing.Size(161, 41);
            this.btn_Beisbol.TabIndex = 2;
            this.btn_Beisbol.Text = "Beisbol";
            this.btn_Beisbol.UseVisualStyleBackColor = true;
            this.btn_Beisbol.Click += new System.EventHandler(this.btn_Beisbol_Click);
            // 
            // btn_Basquetbol
            // 
            this.btn_Basquetbol.Location = new System.Drawing.Point(173, 50);
            this.btn_Basquetbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Basquetbol.Name = "btn_Basquetbol";
            this.btn_Basquetbol.Size = new System.Drawing.Size(161, 39);
            this.btn_Basquetbol.TabIndex = 4;
            this.btn_Basquetbol.Text = "Basquetbol";
            this.btn_Basquetbol.UseVisualStyleBackColor = true;
            this.btn_Basquetbol.Click += new System.EventHandler(this.btn_Basquetbol_Click);
            // 
            // btn_Voleibol
            // 
            this.btn_Voleibol.Location = new System.Drawing.Point(173, 3);
            this.btn_Voleibol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Voleibol.Name = "btn_Voleibol";
            this.btn_Voleibol.Size = new System.Drawing.Size(161, 41);
            this.btn_Voleibol.TabIndex = 3;
            this.btn_Voleibol.Text = "Voleibol";
            this.btn_Voleibol.UseVisualStyleBackColor = true;
            this.btn_Voleibol.Click += new System.EventHandler(this.btn_Voleibol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Futbol;
        private System.Windows.Forms.Button btn_Beisbol;
        private System.Windows.Forms.Button btn_Voleibol;
        private System.Windows.Forms.Button btn_Basquetbol;
    }
}

