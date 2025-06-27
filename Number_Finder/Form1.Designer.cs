namespace Number_Finder
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
            this.txtField = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.nmb_of_tries = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(336, 153);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(100, 20);
            this.txtField.TabIndex = 0;
            this.txtField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtField_KeyUp);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(349, 179);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(292, 137);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(189, 13);
            this.lblTask.TabIndex = 2;
            this.lblTask.Text = "Enter random number (1  -   1.000.000)";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(311, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nmb_of_tries
            // 
            this.nmb_of_tries.AutoSize = true;
            this.nmb_of_tries.Location = new System.Drawing.Point(446, 189);
            this.nmb_of_tries.Name = "nmb_of_tries";
            this.nmb_of_tries.Size = new System.Drawing.Size(35, 13);
            this.nmb_of_tries.TabIndex = 4;
            this.nmb_of_tries.Text = "label2";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(376, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "--";
            // 
            // lblRnd
            // 
            this.lblRnd.AutoSize = true;
            this.lblRnd.Location = new System.Drawing.Point(704, 53);
            this.lblRnd.Name = "lblRnd";
            this.lblRnd.Size = new System.Drawing.Size(13, 13);
            this.lblRnd.TabIndex = 6;
            this.lblRnd.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRnd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nmb_of_tries);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label nmb_of_tries;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRnd;
    }
}

