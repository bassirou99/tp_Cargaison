namespace Bassirou_test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCargaison = new System.Windows.Forms.ListBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMarchandise = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcout = new System.Windows.Forms.TextBox();
            this.txtVolumeTotal = new System.Windows.Forms.TextBox();
            this.txtPoidsTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnup = new System.Windows.Forms.Button();
            this.txtbPoids = new System.Windows.Forms.TextBox();
            this.btnAddMarchandise = new System.Windows.Forms.Button();
            this.txtbVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNDEL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandise)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCargaison);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(405, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargaison";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbCargaison
            // 
            this.lbCargaison.FormattingEnabled = true;
            this.lbCargaison.ItemHeight = 19;
            this.lbCargaison.Location = new System.Drawing.Point(23, 221);
            this.lbCargaison.Name = "lbCargaison";
            this.lbCargaison.Size = new System.Drawing.Size(357, 308);
            this.lbCargaison.TabIndex = 8;
            this.lbCargaison.SelectedIndexChanged += new System.EventHandler(this.lbCargaison_SelectedIndexChanged_1);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Aerienne",
            "Routiére"});
            this.cboType.Location = new System.Drawing.Point(104, 76);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(179, 27);
            this.cboType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste Des Cargaisons";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(104, 31);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(179, 28);
            this.txtDistance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvMarchandise);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(485, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 546);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marchandise";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Liste Des Marchandises";
            // 
            // dgvMarchandise
            // 
            this.dgvMarchandise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarchandise.Location = new System.Drawing.Point(70, 253);
            this.dgvMarchandise.Name = "dgvMarchandise";
            this.dgvMarchandise.RowTemplate.Height = 24;
            this.dgvMarchandise.Size = new System.Drawing.Size(376, 272);
            this.dgvMarchandise.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtcout);
            this.groupBox4.Controls.Add(this.txtVolumeTotal);
            this.groupBox4.Controls.Add(this.txtPoidsTotal);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(315, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 158);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Coût";
            // 
            // txtcout
            // 
            this.txtcout.Enabled = false;
            this.txtcout.Location = new System.Drawing.Point(117, 115);
            this.txtcout.Name = "txtcout";
            this.txtcout.Size = new System.Drawing.Size(104, 28);
            this.txtcout.TabIndex = 10;
            // 
            // txtVolumeTotal
            // 
            this.txtVolumeTotal.Enabled = false;
            this.txtVolumeTotal.Location = new System.Drawing.Point(117, 69);
            this.txtVolumeTotal.Name = "txtVolumeTotal";
            this.txtVolumeTotal.Size = new System.Drawing.Size(104, 28);
            this.txtVolumeTotal.TabIndex = 9;
            // 
            // txtPoidsTotal
            // 
            this.txtPoidsTotal.Enabled = false;
            this.txtPoidsTotal.Location = new System.Drawing.Point(117, 22);
            this.txtPoidsTotal.Name = "txtPoidsTotal";
            this.txtPoidsTotal.Size = new System.Drawing.Size(104, 28);
            this.txtPoidsTotal.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Poids";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Volume";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNDEL);
            this.groupBox3.Controls.Add(this.btnup);
            this.groupBox3.Controls.Add(this.txtbPoids);
            this.groupBox3.Controls.Add(this.btnAddMarchandise);
            this.groupBox3.Controls.Add(this.txtbVolume);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(18, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 158);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nouvelle";
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(113, 112);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(57, 30);
            this.btnup.TabIndex = 8;
            this.btnup.Text = "UP";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // txtbPoids
            // 
            this.txtbPoids.Location = new System.Drawing.Point(113, 24);
            this.txtbPoids.Name = "txtbPoids";
            this.txtbPoids.Size = new System.Drawing.Size(104, 28);
            this.txtbPoids.TabIndex = 7;
            this.txtbPoids.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnAddMarchandise
            // 
            this.btnAddMarchandise.Location = new System.Drawing.Point(178, 112);
            this.btnAddMarchandise.Name = "btnAddMarchandise";
            this.btnAddMarchandise.Size = new System.Drawing.Size(57, 30);
            this.btnAddMarchandise.TabIndex = 6;
            this.btnAddMarchandise.Text = "Add";
            this.btnAddMarchandise.UseVisualStyleBackColor = true;
            this.btnAddMarchandise.Click += new System.EventHandler(this.btnAddMarchandise_Click);
            // 
            // txtbVolume
            // 
            this.txtbVolume.Location = new System.Drawing.Point(113, 69);
            this.txtbVolume.Name = "txtbVolume";
            this.txtbVolume.Size = new System.Drawing.Size(104, 28);
            this.txtbVolume.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Poids";
            // 
            // BTNDEL
            // 
            this.BTNDEL.Location = new System.Drawing.Point(40, 112);
            this.BTNDEL.Name = "BTNDEL";
            this.BTNDEL.Size = new System.Drawing.Size(67, 30);
            this.BTNDEL.TabIndex = 9;
            this.BTNDEL.Text = "DEL";
            this.BTNDEL.UseVisualStyleBackColor = true;
            this.BTNDEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TP Cargaison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandise)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbVolume;
        private System.Windows.Forms.TextBox txtVolumeTotal;
        private System.Windows.Forms.TextBox txtPoidsTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMarchandise;
        private System.Windows.Forms.DataGridView dgvMarchandise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbPoids;
        private System.Windows.Forms.ListBox lbCargaison;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcout;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button BTNDEL;
    }
}

