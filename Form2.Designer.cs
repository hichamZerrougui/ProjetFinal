
namespace ProjetFinal
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.sourcenumetudiant = new System.Windows.Forms.TextBox();
            this.sourcenote = new System.Windows.Forms.TextBox();
            this.sourceprenom = new System.Windows.Forms.TextBox();
            this.sourcenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir les notes des Etudiants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numéro d\'etudiant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Note :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(454, 463);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(131, 41);
            this.Enregistrer.TabIndex = 6;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // sourcenumetudiant
            // 
            this.sourcenumetudiant.Location = new System.Drawing.Point(333, 133);
            this.sourcenumetudiant.Name = "sourcenumetudiant";
            this.sourcenumetudiant.Size = new System.Drawing.Size(179, 26);
            this.sourcenumetudiant.TabIndex = 7;
            // 
            // sourcenote
            // 
            this.sourcenote.Location = new System.Drawing.Point(333, 356);
            this.sourcenote.Name = "sourcenote";
            this.sourcenote.Size = new System.Drawing.Size(179, 26);
            this.sourcenote.TabIndex = 8;
            // 
            // sourceprenom
            // 
            this.sourceprenom.Location = new System.Drawing.Point(333, 286);
            this.sourceprenom.Name = "sourceprenom";
            this.sourceprenom.Size = new System.Drawing.Size(179, 26);
            this.sourceprenom.TabIndex = 9;
            // 
            // sourcenom
            // 
            this.sourcenom.Location = new System.Drawing.Point(333, 212);
            this.sourcenom.Name = "sourcenom";
            this.sourcenom.Size = new System.Drawing.Size(179, 26);
            this.sourcenom.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 586);
            this.Controls.Add(this.sourcenom);
            this.Controls.Add(this.sourceprenom);
            this.Controls.Add(this.sourcenote);
            this.Controls.Add(this.sourcenumetudiant);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.TextBox sourcenumetudiant;
        private System.Windows.Forms.TextBox sourcenote;
        private System.Windows.Forms.TextBox sourceprenom;
        private System.Windows.Forms.TextBox sourcenom;
    }
}