namespace CalcTotalJeton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentJetonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startStackNum = new System.Windows.Forms.NumericUpDown();
            this.totalPlayerNum = new System.Windows.Forms.NumericUpDown();
            this.bountyPerPlayerNum = new System.Windows.Forms.NumericUpDown();
            this.valueBountyNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bountyInGameNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.calculJetonLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pseudoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jetonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bountyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jetonAddNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bountyAddNum = new System.Windows.Forms.NumericUpDown();
            this.Label145481 = new System.Windows.Forms.Label();
            this.pseudoAddTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.infoGB = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalJetonLabel = new System.Windows.Forms.Label();
            this.calculerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startStackNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayerNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyPerPlayerNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBountyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyInGameNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetonAddNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyAddNum)).BeginInit();
            this.infoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentJetonLabel
            // 
            this.currentJetonLabel.AutoSize = true;
            this.currentJetonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentJetonLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.currentJetonLabel.Location = new System.Drawing.Point(700, 402);
            this.currentJetonLabel.Name = "currentJetonLabel";
            this.currentJetonLabel.Size = new System.Drawing.Size(24, 20);
            this.currentJetonLabel.TabIndex = 1;
            this.currentJetonLabel.Text = "...";
            this.currentJetonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de joueurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de bounty par joueurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stack de départ";
            // 
            // startStackNum
            // 
            this.startStackNum.Location = new System.Drawing.Point(44, 39);
            this.startStackNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.startStackNum.Name = "startStackNum";
            this.startStackNum.Size = new System.Drawing.Size(232, 20);
            this.startStackNum.TabIndex = 5;
            this.startStackNum.ValueChanged += new System.EventHandler(this.startStackNum_ValueChanged);
            // 
            // totalPlayerNum
            // 
            this.totalPlayerNum.Location = new System.Drawing.Point(44, 89);
            this.totalPlayerNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalPlayerNum.Name = "totalPlayerNum";
            this.totalPlayerNum.Size = new System.Drawing.Size(232, 20);
            this.totalPlayerNum.TabIndex = 6;
            this.totalPlayerNum.ValueChanged += new System.EventHandler(this.totalPlayerNum_ValueChanged);
            // 
            // bountyPerPlayerNum
            // 
            this.bountyPerPlayerNum.Location = new System.Drawing.Point(40, 145);
            this.bountyPerPlayerNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.bountyPerPlayerNum.Name = "bountyPerPlayerNum";
            this.bountyPerPlayerNum.Size = new System.Drawing.Size(236, 20);
            this.bountyPerPlayerNum.TabIndex = 7;
            this.bountyPerPlayerNum.ValueChanged += new System.EventHandler(this.bountyPerPlayerNum_ValueChanged);
            // 
            // valueBountyNum
            // 
            this.valueBountyNum.Location = new System.Drawing.Point(40, 200);
            this.valueBountyNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.valueBountyNum.Name = "valueBountyNum";
            this.valueBountyNum.Size = new System.Drawing.Size(236, 20);
            this.valueBountyNum.TabIndex = 9;
            this.valueBountyNum.ValueChanged += new System.EventHandler(this.valueBountyNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valeur du bounty";
            // 
            // bountyInGameNum
            // 
            this.bountyInGameNum.Location = new System.Drawing.Point(40, 258);
            this.bountyInGameNum.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bountyInGameNum.Name = "bountyInGameNum";
            this.bountyInGameNum.Size = new System.Drawing.Size(236, 20);
            this.bountyInGameNum.TabIndex = 11;
            this.bountyInGameNum.ValueChanged += new System.EventHandler(this.bountyInGameNum_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bounty encore en jeu";
            // 
            // calculJetonLabel
            // 
            this.calculJetonLabel.AutoSize = true;
            this.calculJetonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculJetonLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.calculJetonLabel.Location = new System.Drawing.Point(700, 461);
            this.calculJetonLabel.Name = "calculJetonLabel";
            this.calculJetonLabel.Size = new System.Drawing.Size(24, 20);
            this.calculJetonLabel.TabIndex = 12;
            this.calculJetonLabel.Text = "...";
            this.calculJetonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pseudoCol,
            this.jetonCol,
            this.bountyCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 446);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // pseudoCol
            // 
            this.pseudoCol.HeaderText = "Pseudo";
            this.pseudoCol.Name = "pseudoCol";
            // 
            // jetonCol
            // 
            this.jetonCol.HeaderText = "Jeton";
            this.jetonCol.Name = "jetonCol";
            // 
            // bountyCol
            // 
            this.bountyCol.HeaderText = "Bounty";
            this.bountyCol.Name = "bountyCol";
            // 
            // jetonAddNum
            // 
            this.jetonAddNum.Location = new System.Drawing.Point(285, 33);
            this.jetonAddNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.jetonAddNum.Name = "jetonAddNum";
            this.jetonAddNum.Size = new System.Drawing.Size(177, 20);
            this.jetonAddNum.TabIndex = 18;
            this.jetonAddNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jetonAddNum_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Jeton";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bounty";
            // 
            // bountyAddNum
            // 
            this.bountyAddNum.Location = new System.Drawing.Point(481, 32);
            this.bountyAddNum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.bountyAddNum.Name = "bountyAddNum";
            this.bountyAddNum.Size = new System.Drawing.Size(98, 20);
            this.bountyAddNum.TabIndex = 19;
            this.bountyAddNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bountyAddNum_KeyPress);
            // 
            // Label145481
            // 
            this.Label145481.AutoSize = true;
            this.Label145481.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label145481.Location = new System.Drawing.Point(105, 9);
            this.Label145481.Name = "Label145481";
            this.Label145481.Size = new System.Drawing.Size(69, 20);
            this.Label145481.TabIndex = 18;
            this.Label145481.Text = "Pseudo";
            // 
            // pseudoAddTB
            // 
            this.pseudoAddTB.Location = new System.Drawing.Point(12, 32);
            this.pseudoAddTB.Name = "pseudoAddTB";
            this.pseudoAddTB.Size = new System.Drawing.Size(251, 20);
            this.pseudoAddTB.TabIndex = 17;
            this.pseudoAddTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pseudoAddTB_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(12, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(567, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "AJOUTER";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // infoGB
            // 
            this.infoGB.Controls.Add(this.label3);
            this.infoGB.Controls.Add(this.label1);
            this.infoGB.Controls.Add(this.label2);
            this.infoGB.Controls.Add(this.startStackNum);
            this.infoGB.Controls.Add(this.totalPlayerNum);
            this.infoGB.Controls.Add(this.bountyPerPlayerNum);
            this.infoGB.Controls.Add(this.label4);
            this.infoGB.Controls.Add(this.valueBountyNum);
            this.infoGB.Controls.Add(this.label5);
            this.infoGB.Controls.Add(this.bountyInGameNum);
            this.infoGB.Location = new System.Drawing.Point(585, 12);
            this.infoGB.Name = "infoGB";
            this.infoGB.Size = new System.Drawing.Size(310, 296);
            this.infoGB.TabIndex = 21;
            this.infoGB.TabStop = false;
            this.infoGB.Text = "Info start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Jeton en jeu (normalement)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(661, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Calcul jeton joueur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(649, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total de jeton possible";
            // 
            // totalJetonLabel
            // 
            this.totalJetonLabel.AutoSize = true;
            this.totalJetonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalJetonLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalJetonLabel.Location = new System.Drawing.Point(700, 340);
            this.totalJetonLabel.Name = "totalJetonLabel";
            this.totalJetonLabel.Size = new System.Drawing.Size(24, 20);
            this.totalJetonLabel.TabIndex = 24;
            this.totalJetonLabel.Text = "...";
            this.totalJetonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculerButton
            // 
            this.calculerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculerButton.Location = new System.Drawing.Point(585, 508);
            this.calculerButton.Name = "calculerButton";
            this.calculerButton.Size = new System.Drawing.Size(310, 23);
            this.calculerButton.TabIndex = 26;
            this.calculerButton.Text = "CALCULER";
            this.calculerButton.UseVisualStyleBackColor = true;
            this.calculerButton.Click += new System.EventHandler(this.calculerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 538);
            this.Controls.Add(this.calculerButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalJetonLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.infoGB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pseudoAddTB);
            this.Controls.Add(this.Label145481);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bountyAddNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.jetonAddNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calculJetonLabel);
            this.Controls.Add(this.currentJetonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcul de jetons | TheGeogeo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startStackNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayerNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyPerPlayerNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueBountyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyInGameNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetonAddNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bountyAddNum)).EndInit();
            this.infoGB.ResumeLayout(false);
            this.infoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentJetonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startStackNum;
        private System.Windows.Forms.NumericUpDown totalPlayerNum;
        private System.Windows.Forms.NumericUpDown bountyPerPlayerNum;
        private System.Windows.Forms.NumericUpDown valueBountyNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bountyInGameNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label calculJetonLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn jetonCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bountyCol;
        private System.Windows.Forms.NumericUpDown jetonAddNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown bountyAddNum;
        private System.Windows.Forms.Label Label145481;
        private System.Windows.Forms.TextBox pseudoAddTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox infoGB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalJetonLabel;
        private System.Windows.Forms.Button calculerButton;
    }
}

