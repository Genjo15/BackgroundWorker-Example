namespace BackgroundWorker
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnStartCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.pgbState = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de tours de boucle";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(184, 18);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            // 
            // btnStartCancel
            // 
            this.btnStartCancel.Location = new System.Drawing.Point(334, 16);
            this.btnStartCancel.Name = "btnStartCancel";
            this.btnStartCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStartCancel.TabIndex = 2;
            this.btnStartCancel.Text = "Démarrer";
            this.btnStartCancel.UseVisualStyleBackColor = true;
            this.btnStartCancel.Click += new System.EventHandler(this.btnStartCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgbState);
            this.groupBox1.Controls.Add(this.lbResult);
            this.groupBox1.Location = new System.Drawing.Point(30, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statut :";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(7, 20);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(65, 13);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "En attente...";
            // 
            // pgbState
            // 
            this.pgbState.Location = new System.Drawing.Point(10, 51);
            this.pgbState.Name = "pgbState";
            this.pgbState.Size = new System.Drawing.Size(363, 23);
            this.pgbState.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 173);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartCancel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnStartCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pgbState;
        private System.Windows.Forms.Label lbResult;
    }
}

