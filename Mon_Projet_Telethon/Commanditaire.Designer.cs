
namespace Mon_Projet_Telethon
{
    partial class Commanditaire
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantitePrix = new System.Windows.Forms.TextBox();
            this.lblqte = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtIdPrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomCom = new System.Windows.Forms.TextBox();
            this.txtPrenomCom = new System.Windows.Forms.TextBox();
            this.txtIdCommanditaire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfficherPrix = new System.Windows.Forms.Button();
            this.btnAjouterPrix = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnAfficherCom = new System.Windows.Forms.Button();
            this.btnAjoutCom = new System.Windows.Forms.Button();
            this.btnQuiterCom = new System.Windows.Forms.Button();
            this.dataGridViewCom = new System.Windows.Forms.DataGridView();
            this.idcom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPrix = new System.Windows.Forms.DataGridView();
            this.IdPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(183, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 244);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantitePrix);
            this.groupBox2.Controls.Add(this.lblqte);
            this.groupBox2.Controls.Add(this.txtValeur);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtIdPrix);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(274, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 165);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Prix";
            // 
            // txtQuantitePrix
            // 
            this.txtQuantitePrix.Location = new System.Drawing.Point(104, 133);
            this.txtQuantitePrix.Name = "txtQuantitePrix";
            this.txtQuantitePrix.Size = new System.Drawing.Size(128, 23);
            this.txtQuantitePrix.TabIndex = 26;
            this.txtQuantitePrix.TextChanged += new System.EventHandler(this.txtQuantitePrix_TextChanged);
            // 
            // lblqte
            // 
            this.lblqte.AutoSize = true;
            this.lblqte.Location = new System.Drawing.Point(6, 136);
            this.lblqte.Name = "lblqte";
            this.lblqte.Size = new System.Drawing.Size(59, 15);
            this.lblqte.TabIndex = 25;
            this.lblqte.Text = "Quantité :";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(104, 96);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(128, 23);
            this.txtValeur.TabIndex = 24;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(104, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(128, 23);
            this.txtDescription.TabIndex = 23;
            // 
            // txtIdPrix
            // 
            this.txtIdPrix.Location = new System.Drawing.Point(104, 33);
            this.txtIdPrix.Name = "txtIdPrix";
            this.txtIdPrix.Size = new System.Drawing.Size(128, 23);
            this.txtIdPrix.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valeur (Prix) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID Prix :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomCom);
            this.groupBox1.Controls.Add(this.txtPrenomCom);
            this.groupBox1.Controls.Add(this.txtIdCommanditaire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 165);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Commanditaire";
            // 
            // txtNomCom
            // 
            this.txtNomCom.Location = new System.Drawing.Point(119, 99);
            this.txtNomCom.Name = "txtNomCom";
            this.txtNomCom.Size = new System.Drawing.Size(128, 23);
            this.txtNomCom.TabIndex = 15;
            // 
            // txtPrenomCom
            // 
            this.txtPrenomCom.Location = new System.Drawing.Point(119, 61);
            this.txtPrenomCom.Name = "txtPrenomCom";
            this.txtPrenomCom.Size = new System.Drawing.Size(128, 23);
            this.txtPrenomCom.TabIndex = 14;
            // 
            // txtIdCommanditaire
            // 
            this.txtIdCommanditaire.Location = new System.Drawing.Point(119, 27);
            this.txtIdCommanditaire.Name = "txtIdCommanditaire";
            this.txtIdCommanditaire.Size = new System.Drawing.Size(128, 23);
            this.txtIdCommanditaire.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Commanditaire:";
            // 
            // btnAfficherPrix
            // 
            this.btnAfficherPrix.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfficherPrix.Location = new System.Drawing.Point(710, 262);
            this.btnAfficherPrix.Name = "btnAfficherPrix";
            this.btnAfficherPrix.Size = new System.Drawing.Size(113, 26);
            this.btnAfficherPrix.TabIndex = 20;
            this.btnAfficherPrix.Text = "Afficher Prix";
            this.btnAfficherPrix.UseVisualStyleBackColor = true;
            this.btnAfficherPrix.Click += new System.EventHandler(this.btnAfficherPrix_Click);
            // 
            // btnAjouterPrix
            // 
            this.btnAjouterPrix.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterPrix.Location = new System.Drawing.Point(710, 60);
            this.btnAjouterPrix.Name = "btnAjouterPrix";
            this.btnAjouterPrix.Size = new System.Drawing.Size(113, 27);
            this.btnAjouterPrix.TabIndex = 19;
            this.btnAjouterPrix.Text = "Ajouter Prix";
            this.btnAjouterPrix.UseVisualStyleBackColor = true;
            this.btnAjouterPrix.Click += new System.EventHandler(this.btnAjouterPrix_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEffacer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEffacer.Location = new System.Drawing.Point(710, 118);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(113, 27);
            this.btnEffacer.TabIndex = 35;
            this.btnEffacer.Text = "Effacer ";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnAfficherCom
            // 
            this.btnAfficherCom.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfficherCom.Location = new System.Drawing.Point(1, 262);
            this.btnAfficherCom.Name = "btnAfficherCom";
            this.btnAfficherCom.Size = new System.Drawing.Size(182, 26);
            this.btnAfficherCom.TabIndex = 14;
            this.btnAfficherCom.Text = "Afficher Commanditaire";
            this.btnAfficherCom.UseVisualStyleBackColor = true;
            this.btnAfficherCom.Click += new System.EventHandler(this.btnAfficherCom_Click);
            // 
            // btnAjoutCom
            // 
            this.btnAjoutCom.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjoutCom.Location = new System.Drawing.Point(1, 60);
            this.btnAjoutCom.Name = "btnAjoutCom";
            this.btnAjoutCom.Size = new System.Drawing.Size(176, 27);
            this.btnAjoutCom.TabIndex = 13;
            this.btnAjoutCom.Text = "Ajouter Commanditaire";
            this.btnAjoutCom.UseVisualStyleBackColor = true;
            this.btnAjoutCom.Click += new System.EventHandler(this.btnAjoutCom_Click);
            // 
            // btnQuiterCom
            // 
            this.btnQuiterCom.BackColor = System.Drawing.Color.DarkGray;
            this.btnQuiterCom.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuiterCom.Location = new System.Drawing.Point(796, -1);
            this.btnQuiterCom.Name = "btnQuiterCom";
            this.btnQuiterCom.Size = new System.Drawing.Size(27, 31);
            this.btnQuiterCom.TabIndex = 16;
            this.btnQuiterCom.Text = "X";
            this.btnQuiterCom.UseVisualStyleBackColor = false;
            this.btnQuiterCom.Click += new System.EventHandler(this.btnQuiterCom_Click);
            // 
            // dataGridViewCom
            // 
            this.dataGridViewCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcom,
            this.prenom,
            this.nom});
            this.dataGridViewCom.Location = new System.Drawing.Point(1, 294);
            this.dataGridViewCom.Name = "dataGridViewCom";
            this.dataGridViewCom.RowTemplate.Height = 25;
            this.dataGridViewCom.Size = new System.Drawing.Size(319, 209);
            this.dataGridViewCom.TabIndex = 36;
            // 
            // idcom
            // 
            this.idcom.HeaderText = "ID Commanditaire";
            this.idcom.Name = "idcom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // dataGridViewPrix
            // 
            this.dataGridViewPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrix,
            this.description,
            this.valeur,
            this.quantitei,
            this.quantiter,
            this.com});
            this.dataGridViewPrix.Location = new System.Drawing.Point(326, 294);
            this.dataGridViewPrix.Name = "dataGridViewPrix";
            this.dataGridViewPrix.RowTemplate.Height = 25;
            this.dataGridViewPrix.Size = new System.Drawing.Size(497, 209);
            this.dataGridViewPrix.TabIndex = 37;
            // 
            // IdPrix
            // 
            this.IdPrix.HeaderText = "Id Prix";
            this.IdPrix.Name = "IdPrix";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // valeur
            // 
            this.valeur.HeaderText = "Valeur";
            this.valeur.Name = "valeur";
            // 
            // quantitei
            // 
            this.quantitei.HeaderText = "Quantité Init";
            this.quantitei.Name = "quantitei";
            // 
            // quantiter
            // 
            this.quantiter.HeaderText = "Quantité rest";
            this.quantiter.Name = "quantiter";
            // 
            // com
            // 
            this.com.HeaderText = "Commanditaire";
            this.com.Name = "com";
            // 
            // Commanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(827, 503);
            this.ControlBox = false;
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAfficherPrix);
            this.Controls.Add(this.dataGridViewPrix);
            this.Controls.Add(this.btnAjouterPrix);
            this.Controls.Add(this.btnAjoutCom);
            this.Controls.Add(this.btnAfficherCom);
            this.Controls.Add(this.dataGridViewCom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnQuiterCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Commanditaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commanditaire";
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuiterCom;
        private System.Windows.Forms.Button btnAfficherCom;
        private System.Windows.Forms.Button btnAjoutCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomCom;
        private System.Windows.Forms.TextBox txtPrenomCom;
        private System.Windows.Forms.TextBox txtIdCommanditaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantitePrix;
        private System.Windows.Forms.Label lblqte;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtIdPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAfficherPrix;
        private System.Windows.Forms.Button btnAjouterPrix;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.DataGridView dataGridViewCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridView dataGridViewPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitei;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn com;
    }
}