﻿namespace Venda_Unifunec
{
    partial class ControleLogSistema
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sexo2 = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.venda_UnifunecDataSet = new Venda_Unifunec.Venda_UnifunecDataSet();
            this.controlelogsistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlelogsistemaTableAdapter = new Venda_Unifunec.Venda_UnifunecDataSetTableAdapters.controlelogsistemaTableAdapter();
            this.codcontroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codloginfkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Venda_Unifunec.Venda_UnifunecDataSetTableAdapters.loginTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_UnifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlelogsistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.controlelogsistemaBindingSource, "codlogin_fk", true));
            this.comboBox1.DataSource = this.loginBindingSource;
            this.comboBox1.DisplayMember = "usuario";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.ValueMember = "codlogin";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlelogsistemaBindingSource, "hora", true));
            this.textBox1.Location = new System.Drawing.Point(173, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 46;
            // 
            // Sexo2
            // 
            this.Sexo2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlelogsistemaBindingSource, "datalog", true));
            this.Sexo2.Location = new System.Drawing.Point(57, 25);
            this.Sexo2.Name = "Sexo2";
            this.Sexo2.Size = new System.Drawing.Size(110, 20);
            this.Sexo2.TabIndex = 45;
            // 
            // Codigo
            // 
            this.Codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlelogsistemaBindingSource, "codcontrole", true));
            this.Codigo.Enabled = false;
            this.Codigo.Location = new System.Drawing.Point(11, 25);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(35, 20);
            this.Codigo.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Editar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Apagar);
            this.groupBox1.Controls.Add(this.Novo);
            this.groupBox1.Controls.Add(this.Salvar);
            this.groupBox1.Location = new System.Drawing.Point(11, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 82);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botões de Navegação";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(6, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Cancelar.Location = new System.Drawing.Point(384, 39);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(87, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = ">|";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Editar.Location = new System.Drawing.Point(303, 53);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 8;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(87, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Apagar.Location = new System.Drawing.Point(222, 53);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(75, 23);
            this.Apagar.TabIndex = 7;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Novo
            // 
            this.Novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Novo.Location = new System.Drawing.Point(222, 24);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 5;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Salvar.Location = new System.Drawing.Point(303, 24);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 6;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcontroleDataGridViewTextBoxColumn,
            this.codloginfkDataGridViewTextBoxColumn,
            this.datalogDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.controlelogsistemaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Codigo_Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "DataLogin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Codigo:";
            // 
            // venda_UnifunecDataSet
            // 
            this.venda_UnifunecDataSet.DataSetName = "Venda_UnifunecDataSet";
            this.venda_UnifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlelogsistemaBindingSource
            // 
            this.controlelogsistemaBindingSource.DataMember = "controlelogsistema";
            this.controlelogsistemaBindingSource.DataSource = this.venda_UnifunecDataSet;
            // 
            // controlelogsistemaTableAdapter
            // 
            this.controlelogsistemaTableAdapter.ClearBeforeFill = true;
            // 
            // codcontroleDataGridViewTextBoxColumn
            // 
            this.codcontroleDataGridViewTextBoxColumn.DataPropertyName = "codcontrole";
            this.codcontroleDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codcontroleDataGridViewTextBoxColumn.Name = "codcontroleDataGridViewTextBoxColumn";
            this.codcontroleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codloginfkDataGridViewTextBoxColumn
            // 
            this.codloginfkDataGridViewTextBoxColumn.DataPropertyName = "codlogin_fk";
            this.codloginfkDataGridViewTextBoxColumn.HeaderText = "Codigo_Login";
            this.codloginfkDataGridViewTextBoxColumn.Name = "codloginfkDataGridViewTextBoxColumn";
            // 
            // datalogDataGridViewTextBoxColumn
            // 
            this.datalogDataGridViewTextBoxColumn.DataPropertyName = "datalog";
            this.datalogDataGridViewTextBoxColumn.HeaderText = "DataLogin";
            this.datalogDataGridViewTextBoxColumn.Name = "datalogDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.venda_UnifunecDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // ControleLogSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sexo2);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ControleLogSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleLogSistema";
            this.Load += new System.EventHandler(this.ControleLogSistema_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_UnifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlelogsistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Sexo2;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Venda_UnifunecDataSet venda_UnifunecDataSet;
        private System.Windows.Forms.BindingSource controlelogsistemaBindingSource;
        private Venda_UnifunecDataSetTableAdapters.controlelogsistemaTableAdapter controlelogsistemaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codloginfkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Venda_UnifunecDataSetTableAdapters.loginTableAdapter loginTableAdapter;
    }
}