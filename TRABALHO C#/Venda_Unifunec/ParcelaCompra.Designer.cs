namespace Venda_Unifunec
{
    partial class ParcelaCompra
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.venda_UnifunecDataSet = new Venda_Unifunec.Venda_UnifunecDataSet();
            this.parcelacompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcelacompraTableAdapter = new Venda_Unifunec.Venda_UnifunecDataSetTableAdapters.parcelacompraTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codparcelacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codsituacaofkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcomprafkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraprodutoTableAdapter = new Venda_Unifunec.Venda_UnifunecDataSetTableAdapters.compraprodutoTableAdapter();
            this.situacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoTableAdapter = new Venda_Unifunec.Venda_UnifunecDataSetTableAdapters.situacaoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_UnifunecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelacompraBindingSource, "datavencimento", true));
            this.textBox2.Location = new System.Drawing.Point(107, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 98;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelacompraBindingSource, "codparcelacompra", true));
            this.textBox1.Location = new System.Drawing.Point(1, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Data-Vence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Codigo_Situação:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parcelacompraBindingSource, "codsituacao_fk", true));
            this.comboBox2.DataSource = this.situacaoBindingSource;
            this.comboBox2.DisplayMember = "nomesituacao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(454, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 93;
            this.comboBox2.ValueMember = "codsituacao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Codigo_Compra:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.parcelacompraBindingSource, "codcompra_fk", true));
            this.comboBox1.DataSource = this.compraprodutoBindingSource;
            this.comboBox1.DisplayMember = "codcompra";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.ValueMember = "codcompra";
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
            this.groupBox1.Location = new System.Drawing.Point(47, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 87);
            this.groupBox1.TabIndex = 90;
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
            this.Cancelar.Location = new System.Drawing.Point(375, 39);
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
            this.Editar.Location = new System.Drawing.Point(294, 53);
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
            this.Apagar.Location = new System.Drawing.Point(213, 53);
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
            this.Novo.Location = new System.Drawing.Point(213, 24);
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
            this.Salvar.Location = new System.Drawing.Point(294, 24);
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
            this.codparcelacompraDataGridViewTextBoxColumn,
            this.datavencimentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.codsituacaofkDataGridViewTextBoxColumn,
            this.codcomprafkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parcelacompraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 89;
            // 
            // venda_UnifunecDataSet
            // 
            this.venda_UnifunecDataSet.DataSetName = "Venda_UnifunecDataSet";
            this.venda_UnifunecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parcelacompraBindingSource
            // 
            this.parcelacompraBindingSource.DataMember = "parcelacompra";
            this.parcelacompraBindingSource.DataSource = this.venda_UnifunecDataSet;
            // 
            // parcelacompraTableAdapter
            // 
            this.parcelacompraTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parcelacompraBindingSource, "valor", true));
            this.textBox3.Location = new System.Drawing.Point(213, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Valor:";
            // 
            // codparcelacompraDataGridViewTextBoxColumn
            // 
            this.codparcelacompraDataGridViewTextBoxColumn.DataPropertyName = "codparcelacompra";
            this.codparcelacompraDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codparcelacompraDataGridViewTextBoxColumn.Name = "codparcelacompraDataGridViewTextBoxColumn";
            // 
            // datavencimentoDataGridViewTextBoxColumn
            // 
            this.datavencimentoDataGridViewTextBoxColumn.DataPropertyName = "datavencimento";
            this.datavencimentoDataGridViewTextBoxColumn.HeaderText = "Data-Vencimento";
            this.datavencimentoDataGridViewTextBoxColumn.Name = "datavencimentoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // codsituacaofkDataGridViewTextBoxColumn
            // 
            this.codsituacaofkDataGridViewTextBoxColumn.DataPropertyName = "codsituacao_fk";
            this.codsituacaofkDataGridViewTextBoxColumn.HeaderText = "Codigo_Situação";
            this.codsituacaofkDataGridViewTextBoxColumn.Name = "codsituacaofkDataGridViewTextBoxColumn";
            // 
            // codcomprafkDataGridViewTextBoxColumn
            // 
            this.codcomprafkDataGridViewTextBoxColumn.DataPropertyName = "codcompra_fk";
            this.codcomprafkDataGridViewTextBoxColumn.HeaderText = "Codigo_Compra";
            this.codcomprafkDataGridViewTextBoxColumn.Name = "codcomprafkDataGridViewTextBoxColumn";
            // 
            // compraprodutoBindingSource
            // 
            this.compraprodutoBindingSource.DataMember = "compraproduto";
            this.compraprodutoBindingSource.DataSource = this.venda_UnifunecDataSet;
            // 
            // compraprodutoTableAdapter
            // 
            this.compraprodutoTableAdapter.ClearBeforeFill = true;
            // 
            // situacaoBindingSource
            // 
            this.situacaoBindingSource.DataMember = "situacao";
            this.situacaoBindingSource.DataSource = this.venda_UnifunecDataSet;
            // 
            // situacaoTableAdapter
            // 
            this.situacaoTableAdapter.ClearBeforeFill = true;
            // 
            // ParcelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ParcelaCompra";
            this.Text = "ParcelaCompra";
            this.Load += new System.EventHandler(this.ParcelaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venda_UnifunecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelacompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private Venda_UnifunecDataSet venda_UnifunecDataSet;
        private System.Windows.Forms.BindingSource parcelacompraBindingSource;
        private Venda_UnifunecDataSetTableAdapters.parcelacompraTableAdapter parcelacompraTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codparcelacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsituacaofkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomprafkDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraprodutoBindingSource;
        private Venda_UnifunecDataSetTableAdapters.compraprodutoTableAdapter compraprodutoTableAdapter;
        private System.Windows.Forms.BindingSource situacaoBindingSource;
        private Venda_UnifunecDataSetTableAdapters.situacaoTableAdapter situacaoTableAdapter;
    }
}