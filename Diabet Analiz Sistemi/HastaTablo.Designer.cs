﻿namespace Diabet_Analiz_Sistemi
{
    partial class HastaTablo
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polyuriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polydipsiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suddenweightlossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weaknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polyphagiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genitalthrushDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualblurringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtchingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırrıtabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedHealingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialParesisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muscleStiffnessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alopeciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obesityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veriSinifiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriSinifiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.polyuriaDataGridViewTextBoxColumn,
            this.polydipsiaDataGridViewTextBoxColumn,
            this.suddenweightlossDataGridViewTextBoxColumn,
            this.weaknessDataGridViewTextBoxColumn,
            this.polyphagiaDataGridViewTextBoxColumn,
            this.genitalthrushDataGridViewTextBoxColumn,
            this.visualblurringDataGridViewTextBoxColumn,
            this.ıtchingDataGridViewTextBoxColumn,
            this.ırrıtabilityDataGridViewTextBoxColumn,
            this.delayedHealingDataGridViewTextBoxColumn,
            this.partialParesisDataGridViewTextBoxColumn,
            this.muscleStiffnessDataGridViewTextBoxColumn,
            this.alopeciaDataGridViewTextBoxColumn,
            this.obesityDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veriSinifiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tıklanan Veriyi Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tıklanan Veriyi Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Yaş";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // polyuriaDataGridViewTextBoxColumn
            // 
            this.polyuriaDataGridViewTextBoxColumn.DataPropertyName = "Polyuria";
            this.polyuriaDataGridViewTextBoxColumn.HeaderText = "Aşırı İdrar";
            this.polyuriaDataGridViewTextBoxColumn.Name = "polyuriaDataGridViewTextBoxColumn";
            // 
            // polydipsiaDataGridViewTextBoxColumn
            // 
            this.polydipsiaDataGridViewTextBoxColumn.DataPropertyName = "Polydipsia";
            this.polydipsiaDataGridViewTextBoxColumn.HeaderText = "Aşırı Susuzluk";
            this.polydipsiaDataGridViewTextBoxColumn.Name = "polydipsiaDataGridViewTextBoxColumn";
            // 
            // suddenweightlossDataGridViewTextBoxColumn
            // 
            this.suddenweightlossDataGridViewTextBoxColumn.DataPropertyName = "Sudden_weight_loss";
            this.suddenweightlossDataGridViewTextBoxColumn.HeaderText = "Ani Kilo Kaybı";
            this.suddenweightlossDataGridViewTextBoxColumn.Name = "suddenweightlossDataGridViewTextBoxColumn";
            // 
            // weaknessDataGridViewTextBoxColumn
            // 
            this.weaknessDataGridViewTextBoxColumn.DataPropertyName = "weakness";
            this.weaknessDataGridViewTextBoxColumn.HeaderText = "Aşırı Zayıflık";
            this.weaknessDataGridViewTextBoxColumn.Name = "weaknessDataGridViewTextBoxColumn";
            // 
            // polyphagiaDataGridViewTextBoxColumn
            // 
            this.polyphagiaDataGridViewTextBoxColumn.DataPropertyName = "Polyphagia";
            this.polyphagiaDataGridViewTextBoxColumn.HeaderText = "Aşırı İştah";
            this.polyphagiaDataGridViewTextBoxColumn.Name = "polyphagiaDataGridViewTextBoxColumn";
            // 
            // genitalthrushDataGridViewTextBoxColumn
            // 
            this.genitalthrushDataGridViewTextBoxColumn.DataPropertyName = "Genital_thrush";
            this.genitalthrushDataGridViewTextBoxColumn.HeaderText = "Genital Mantar";
            this.genitalthrushDataGridViewTextBoxColumn.Name = "genitalthrushDataGridViewTextBoxColumn";
            // 
            // visualblurringDataGridViewTextBoxColumn
            // 
            this.visualblurringDataGridViewTextBoxColumn.DataPropertyName = "visual_blurring";
            this.visualblurringDataGridViewTextBoxColumn.HeaderText = "Bulanık Görme";
            this.visualblurringDataGridViewTextBoxColumn.Name = "visualblurringDataGridViewTextBoxColumn";
            // 
            // ıtchingDataGridViewTextBoxColumn
            // 
            this.ıtchingDataGridViewTextBoxColumn.DataPropertyName = "Itching";
            this.ıtchingDataGridViewTextBoxColumn.HeaderText = "Kaşıntı";
            this.ıtchingDataGridViewTextBoxColumn.Name = "ıtchingDataGridViewTextBoxColumn";
            // 
            // ırrıtabilityDataGridViewTextBoxColumn
            // 
            this.ırrıtabilityDataGridViewTextBoxColumn.DataPropertyName = "Irrıtability";
            this.ırrıtabilityDataGridViewTextBoxColumn.HeaderText = "Sinirlilik";
            this.ırrıtabilityDataGridViewTextBoxColumn.Name = "ırrıtabilityDataGridViewTextBoxColumn";
            // 
            // delayedHealingDataGridViewTextBoxColumn
            // 
            this.delayedHealingDataGridViewTextBoxColumn.DataPropertyName = "delayed_Healing";
            this.delayedHealingDataGridViewTextBoxColumn.HeaderText = "Geç İyileşen Yaralar";
            this.delayedHealingDataGridViewTextBoxColumn.Name = "delayedHealingDataGridViewTextBoxColumn";
            // 
            // partialParesisDataGridViewTextBoxColumn
            // 
            this.partialParesisDataGridViewTextBoxColumn.DataPropertyName = "partial_Paresis";
            this.partialParesisDataGridViewTextBoxColumn.HeaderText = "Kas Erimesi";
            this.partialParesisDataGridViewTextBoxColumn.Name = "partialParesisDataGridViewTextBoxColumn";
            // 
            // muscleStiffnessDataGridViewTextBoxColumn
            // 
            this.muscleStiffnessDataGridViewTextBoxColumn.DataPropertyName = "muscle_Stiffness";
            this.muscleStiffnessDataGridViewTextBoxColumn.HeaderText = "Kaslarda Sertleşme";
            this.muscleStiffnessDataGridViewTextBoxColumn.Name = "muscleStiffnessDataGridViewTextBoxColumn";
            // 
            // alopeciaDataGridViewTextBoxColumn
            // 
            this.alopeciaDataGridViewTextBoxColumn.DataPropertyName = "Alopecia";
            this.alopeciaDataGridViewTextBoxColumn.HeaderText = "Saç Dökülmesi";
            this.alopeciaDataGridViewTextBoxColumn.Name = "alopeciaDataGridViewTextBoxColumn";
            // 
            // obesityDataGridViewTextBoxColumn
            // 
            this.obesityDataGridViewTextBoxColumn.DataPropertyName = "Obesity";
            this.obesityDataGridViewTextBoxColumn.HeaderText = "Obezite";
            this.obesityDataGridViewTextBoxColumn.Name = "obesityDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "_class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Diyabet Durumu";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // veriSinifiBindingSource
            // 
            this.veriSinifiBindingSource.DataSource = typeof(Diabet_Analiz_Sistemi.VeriSinifi);
            // 
            // HastaTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaTablo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriSinifiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource veriSinifiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polyuriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polydipsiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suddenweightlossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weaknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polyphagiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genitalthrushDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visualblurringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtchingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ırrıtabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedHealingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialParesisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscleStiffnessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alopeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obesityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
