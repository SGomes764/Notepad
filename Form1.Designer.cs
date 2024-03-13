namespace NotePad__
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuFicheiro = new System.Windows.Forms.ToolStripSplitButton();
            this.menuEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.menuFormatar = new System.Windows.Forms.ToolStripSplitButton();
            this.menuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFicheiroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditarSelecinarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlinhamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlinhamentoEsqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlinhamentoCentro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlinhamentoDireita = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTexto = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiro,
            this.menuEditar,
            this.menuFormatar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuFicheiro
            // 
            this.menuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiroNovo,
            this.menuFicheiroAbrir,
            this.menuFicheiroGuardar,
            this.toolStripSeparator1,
            this.menuFicheiroSair});
            this.menuFicheiro.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiro.Image")));
            this.menuFicheiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFicheiro.Name = "menuFicheiro";
            this.menuFicheiro.Size = new System.Drawing.Size(95, 34);
            this.menuFicheiro.Text = "Ficheiro";
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarCortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.toolStripSeparator2,
            this.menuEditarSelecinarTudo,
            this.menuEditarProcurar});
            this.menuEditar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditar.Image")));
            this.menuEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(83, 34);
            this.menuEditar.Text = "Editar";
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarLetra,
            this.menuFormatarCores,
            this.menuAlinhamento});
            this.menuFormatar.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatar.Image")));
            this.menuFormatar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(101, 34);
            this.menuFormatar.Text = "Formatar";
            // 
            // menuFicheiroNovo
            // 
            this.menuFicheiroNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroNovo.Image")));
            this.menuFicheiroNovo.Name = "menuFicheiroNovo";
            this.menuFicheiroNovo.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroNovo.Text = "Novo";
            this.menuFicheiroNovo.Click += new System.EventHandler(this.menuFicheiroNovo_Click);
            // 
            // menuFicheiroAbrir
            // 
            this.menuFicheiroAbrir.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroAbrir.Image")));
            this.menuFicheiroAbrir.Name = "menuFicheiroAbrir";
            this.menuFicheiroAbrir.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroAbrir.Text = "Abrir";
            this.menuFicheiroAbrir.Click += new System.EventHandler(this.menuFicheiroAbrir_Click);
            // 
            // menuFicheiroGuardar
            // 
            this.menuFicheiroGuardar.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroGuardar.Image")));
            this.menuFicheiroGuardar.Name = "menuFicheiroGuardar";
            this.menuFicheiroGuardar.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroGuardar.Text = "Guardar";
            this.menuFicheiroGuardar.Click += new System.EventHandler(this.menuFicheiroGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuFicheiroSair
            // 
            this.menuFicheiroSair.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroSair.Image")));
            this.menuFicheiroSair.Name = "menuFicheiroSair";
            this.menuFicheiroSair.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroSair.Text = "Sair";
            this.menuFicheiroSair.Click += new System.EventHandler(this.menuFicheiroSair_Click);
            // 
            // menuEditarCortar
            // 
            this.menuEditarCortar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCortar.Image")));
            this.menuEditarCortar.Name = "menuEditarCortar";
            this.menuEditarCortar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCortar.Text = "Cortar";
            this.menuEditarCortar.Click += new System.EventHandler(this.menuEditarCortar_Click);
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCopiar.Image")));
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCopiar.Text = "Copiar";
            this.menuEditarCopiar.Click += new System.EventHandler(this.menuEditarCopiar_Click);
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarColar.Image")));
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarColar.Text = "Colar";
            this.menuEditarColar.Click += new System.EventHandler(this.menuEditarColar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // menuEditarSelecinarTudo
            // 
            this.menuEditarSelecinarTudo.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarSelecinarTudo.Image")));
            this.menuEditarSelecinarTudo.Name = "menuEditarSelecinarTudo";
            this.menuEditarSelecinarTudo.Size = new System.Drawing.Size(194, 36);
            this.menuEditarSelecinarTudo.Text = "Selecionar tudo";
            this.menuEditarSelecinarTudo.Click += new System.EventHandler(this.menuEditarSelecinarTudo_Click);
            // 
            // menuEditarProcurar
            // 
            this.menuEditarProcurar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarProcurar.Image")));
            this.menuEditarProcurar.Name = "menuEditarProcurar";
            this.menuEditarProcurar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarProcurar.Text = "Procurar";
            this.menuEditarProcurar.Click += new System.EventHandler(this.menuEditarProcurar_Click);
            // 
            // menuFormatarLetra
            // 
            this.menuFormatarLetra.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarLetra.Image")));
            this.menuFormatarLetra.Name = "menuFormatarLetra";
            this.menuFormatarLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarLetra.Text = "Letra";
            this.menuFormatarLetra.Click += new System.EventHandler(this.menuFormatarLetra_Click);
            // 
            // menuFormatarCores
            // 
            this.menuFormatarCores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarCoresLetra,
            this.menuFormatarCoresFundo});
            this.menuFormatarCores.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCores.Image")));
            this.menuFormatarCores.Name = "menuFormatarCores";
            this.menuFormatarCores.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCores.Text = "Cores";
            // 
            // menuAlinhamento
            // 
            this.menuAlinhamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlinhamentoEsqueda,
            this.menuAlinhamentoCentro,
            this.menuAlinhamentoDireita});
            this.menuAlinhamento.Image = ((System.Drawing.Image)(resources.GetObject("menuAlinhamento.Image")));
            this.menuAlinhamento.Name = "menuAlinhamento";
            this.menuAlinhamento.Size = new System.Drawing.Size(194, 36);
            this.menuAlinhamento.Text = "Alinhamento";
            // 
            // menuFormatarCoresLetra
            // 
            this.menuFormatarCoresLetra.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCoresLetra.Image")));
            this.menuFormatarCoresLetra.Name = "menuFormatarCoresLetra";
            this.menuFormatarCoresLetra.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresLetra.Text = "Letra";
            this.menuFormatarCoresLetra.Click += new System.EventHandler(this.menuFormatarCoresLetra_Click);
            // 
            // menuFormatarCoresFundo
            // 
            this.menuFormatarCoresFundo.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatarCoresFundo.Image")));
            this.menuFormatarCoresFundo.Name = "menuFormatarCoresFundo";
            this.menuFormatarCoresFundo.Size = new System.Drawing.Size(194, 36);
            this.menuFormatarCoresFundo.Text = "Fundo";
            this.menuFormatarCoresFundo.Click += new System.EventHandler(this.menuFormatarCoresFundo_Click);
            // 
            // menuAlinhamentoEsqueda
            // 
            this.menuAlinhamentoEsqueda.Image = ((System.Drawing.Image)(resources.GetObject("menuAlinhamentoEsqueda.Image")));
            this.menuAlinhamentoEsqueda.Name = "menuAlinhamentoEsqueda";
            this.menuAlinhamentoEsqueda.Size = new System.Drawing.Size(194, 36);
            this.menuAlinhamentoEsqueda.Text = "Esquerda";
            this.menuAlinhamentoEsqueda.Click += new System.EventHandler(this.menuAlinhamentoEsqueda_Click);
            // 
            // menuAlinhamentoCentro
            // 
            this.menuAlinhamentoCentro.Image = ((System.Drawing.Image)(resources.GetObject("menuAlinhamentoCentro.Image")));
            this.menuAlinhamentoCentro.Name = "menuAlinhamentoCentro";
            this.menuAlinhamentoCentro.Size = new System.Drawing.Size(194, 36);
            this.menuAlinhamentoCentro.Text = "Centro";
            this.menuAlinhamentoCentro.Click += new System.EventHandler(this.menuAlinhamentoCentro_Click);
            // 
            // menuAlinhamentoDireita
            // 
            this.menuAlinhamentoDireita.Image = ((System.Drawing.Image)(resources.GetObject("menuAlinhamentoDireita.Image")));
            this.menuAlinhamentoDireita.Name = "menuAlinhamentoDireita";
            this.menuAlinhamentoDireita.Size = new System.Drawing.Size(194, 36);
            this.menuAlinhamentoDireita.Text = "Direita";
            this.menuAlinhamentoDireita.Click += new System.EventHandler(this.menuAlinhamentoDireita_Click);
            // 
            // rbTexto
            // 
            this.rbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTexto.Location = new System.Drawing.Point(0, 37);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(784, 704);
            this.rbTexto.TabIndex = 1;
            this.rbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbTexto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MyNotepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton menuFicheiro;
        private System.Windows.Forms.ToolStripSplitButton menuEditar;
        private System.Windows.Forms.ToolStripSplitButton menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroSair;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEditarSelecinarTudo;
        private System.Windows.Forms.ToolStripMenuItem menuEditarProcurar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCores;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresFundo;
        private System.Windows.Forms.ToolStripMenuItem menuAlinhamento;
        private System.Windows.Forms.ToolStripMenuItem menuAlinhamentoEsqueda;
        private System.Windows.Forms.ToolStripMenuItem menuAlinhamentoCentro;
        private System.Windows.Forms.ToolStripMenuItem menuAlinhamentoDireita;
        private System.Windows.Forms.RichTextBox rbTexto;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

