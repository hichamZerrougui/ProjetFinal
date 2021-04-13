
namespace ProjetFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnvalidation = new System.Windows.Forms.Button();
            this.sourcecodecours = new System.Windows.Forms.TextBox();
            this.sourcenumcours = new System.Windows.Forms.TextBox();
            this.sourcetitrecours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES NOTES DES ETUDIANTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titre du Cours :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro du cours :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code du Cours :";
            // 
            // btnvalidation
            // 
            this.btnvalidation.Location = new System.Drawing.Point(457, 509);
            this.btnvalidation.Name = "btnvalidation";
            this.btnvalidation.Size = new System.Drawing.Size(160, 44);
            this.btnvalidation.TabIndex = 5;
            this.btnvalidation.Text = "Valider";
            this.btnvalidation.UseVisualStyleBackColor = true;
            this.btnvalidation.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourcecodecours
            // 
            this.sourcecodecours.Location = new System.Drawing.Point(348, 386);
            this.sourcecodecours.Name = "sourcecodecours";
            this.sourcecodecours.Size = new System.Drawing.Size(371, 30);
            this.sourcecodecours.TabIndex = 7;
            // 
            // sourcenumcours
            // 
            this.sourcenumcours.Location = new System.Drawing.Point(348, 283);
            this.sourcenumcours.Name = "sourcenumcours";
            this.sourcenumcours.Size = new System.Drawing.Size(371, 30);
            this.sourcenumcours.TabIndex = 8;
            // 
            // sourcetitrecours
            // 
            this.sourcetitrecours.Location = new System.Drawing.Point(348, 186);
            this.sourcetitrecours.Name = "sourcetitrecours";
            this.sourcetitrecours.Size = new System.Drawing.Size(371, 30);
            this.sourcetitrecours.TabIndex = 9;
            this.sourcetitrecours.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 624);
            this.Controls.Add(this.sourcetitrecours);
            this.Controls.Add(this.sourcenumcours);
            this.Controls.Add(this.sourcecodecours);
            this.Controls.Add(this.btnvalidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnvalidation;
        private System.Windows.Forms.TextBox sourcecodecours;
        private System.Windows.Forms.TextBox sourcenumcours;
        private System.Windows.Forms.TextBox sourcetitrecours;
    }
}

