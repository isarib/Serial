namespace Serial
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.modoDeComando = new System.Windows.Forms.TabPage();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.Scales = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.LabelTempo = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.LabelCoomando = new System.Windows.Forms.Label();
            this.modoFuncional = new System.Windows.Forms.TabPage();
            this.read = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.LabelLeitura = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.labelPortName = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelStopBit = new System.Windows.Forms.Label();
            this.modoCalibracao = new System.Windows.Forms.TabPage();
            this.labelGanho = new System.Windows.Forms.Label();
            this.labelOffSet = new System.Windows.Forms.Label();
            this.numericUpDownGanho = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.Enviar = new System.Windows.Forms.Button();
            this.Gravar = new System.Windows.Forms.Button();
            this.LerCalib = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.modoDeComando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            this.modoFuncional.SuspendLayout();
            this.modoCalibracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.modoDeComando);
            this.tabControl1.Controls.Add(this.modoCalibracao);
            this.tabControl1.Controls.Add(this.modoFuncional);
            this.tabControl1.Location = new System.Drawing.Point(36, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // modoDeComando
            // 
            this.modoDeComando.AutoScroll = true;
            this.modoDeComando.BackColor = System.Drawing.Color.White;
            this.modoDeComando.Controls.Add(this.checkBoxCR);
            this.modoDeComando.Controls.Add(this.Scales);
            this.modoDeComando.Controls.Add(this.numericUpDownQuantidade);
            this.modoDeComando.Controls.Add(this.numericUpDownTempo);
            this.modoDeComando.Controls.Add(this.LabelTempo);
            this.modoDeComando.Controls.Add(this.Enviar);
            this.modoDeComando.Controls.Add(this.Command);
            this.modoDeComando.Controls.Add(this.LabelQuantidade);
            this.modoDeComando.Controls.Add(this.LabelCoomando);
            this.modoDeComando.Location = new System.Drawing.Point(4, 22);
            this.modoDeComando.Name = "modoDeComando";
            this.modoDeComando.Padding = new System.Windows.Forms.Padding(3);
            this.modoDeComando.Size = new System.Drawing.Size(277, 367);
            this.modoDeComando.TabIndex = 0;
            this.modoDeComando.Text = "Comando ";
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Location = new System.Drawing.Point(10, 215);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(50, 17);
            this.checkBoxCR.TabIndex = 44;
            this.checkBoxCR.Text = "+ CR";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            // 
            // Scales
            // 
            this.Scales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scales.FormattingEnabled = true;
            this.Scales.Location = new System.Drawing.Point(10, 148);
            this.Scales.Name = "Scales";
            this.Scales.Size = new System.Drawing.Size(121, 21);
            this.Scales.TabIndex = 42;
            this.Scales.DropDown += new System.EventHandler(this.Scales_DropDown);
            this.Scales.SelectionChangeCommitted += new System.EventHandler(this.Scales_SelectionChangeCommitted);
            this.Scales.Click += new System.EventHandler(this.Scales_Click);
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(10, 94);
            this.numericUpDownQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantidade.TabIndex = 41;
            this.numericUpDownQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.Location = new System.Drawing.Point(10, 175);
            this.numericUpDownTempo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTempo.Name = "numericUpDownTempo";
            this.numericUpDownTempo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTempo.TabIndex = 40;
            this.numericUpDownTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelTempo
            // 
            this.LabelTempo.AutoSize = true;
            this.LabelTempo.Location = new System.Drawing.Point(40, 132);
            this.LabelTempo.Name = "LabelTempo";
            this.LabelTempo.Size = new System.Drawing.Size(48, 13);
            this.LabelTempo.TabIndex = 39;
            this.LabelTempo.Text = "Intervalo";
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(10, 46);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(121, 20);
            this.Command.TabIndex = 35;
            this.Command.ModifiedChanged += new System.EventHandler(this.Command_ModifiedChanged);
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Location = new System.Drawing.Point(33, 78);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.LabelQuantidade.TabIndex = 34;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // LabelCoomando
            // 
            this.LabelCoomando.AutoSize = true;
            this.LabelCoomando.Location = new System.Drawing.Point(36, 30);
            this.LabelCoomando.Name = "LabelCoomando";
            this.LabelCoomando.Size = new System.Drawing.Size(52, 13);
            this.LabelCoomando.TabIndex = 33;
            this.LabelCoomando.Text = "Comando";
            // 
            // modoFuncional
            // 
            this.modoFuncional.BackColor = System.Drawing.Color.White;
            this.modoFuncional.Controls.Add(this.read);
            this.modoFuncional.Location = new System.Drawing.Point(4, 22);
            this.modoFuncional.Name = "modoFuncional";
            this.modoFuncional.Padding = new System.Windows.Forms.Padding(3);
            this.modoFuncional.Size = new System.Drawing.Size(277, 367);
            this.modoFuncional.TabIndex = 1;
            this.modoFuncional.Text = "Funcional";
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(32, 27);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 0;
            this.read.Text = "Ler";
            this.read.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(753, 79);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(53, 26);
            this.Clear.TabIndex = 43;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.MouseCaptureChanged += new System.EventHandler(this.Clear_Click);
            // 
            // LabelLeitura
            // 
            this.LabelLeitura.AutoSize = true;
            this.LabelLeitura.Location = new System.Drawing.Point(356, 92);
            this.LabelLeitura.Name = "LabelLeitura";
            this.LabelLeitura.Size = new System.Drawing.Size(39, 13);
            this.LabelLeitura.TabIndex = 37;
            this.LabelLeitura.Text = "Leitura";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox.Location = new System.Drawing.Point(359, 108);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(447, 367);
            this.richTextBox.TabIndex = 36;
            this.richTextBox.Text = "";
            // 
            // StopBits
            // 
            this.StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Location = new System.Drawing.Point(36, 27);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(121, 21);
            this.StopBits.TabIndex = 29;
            this.StopBits.DropDown += new System.EventHandler(this.StopBits_DropDown);
            this.StopBits.SelectionChangeCommitted += new System.EventHandler(this.StopBits_SelectionChangeCommitted);
            this.StopBits.Click += new System.EventHandler(this.StopBits_Click);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.LightGreen;
            this.Connect.Enabled = false;
            this.Connect.Location = new System.Drawing.Point(707, 25);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(99, 23);
            this.Connect.TabIndex = 32;
            this.Connect.Text = "Conectar ";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FormattingEnabled = true;
            this.Port.Location = new System.Drawing.Point(558, 27);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(121, 21);
            this.Port.TabIndex = 31;
            this.Port.DropDown += new System.EventHandler(this.Port_DropDown);
            this.Port.SelectionChangeCommitted += new System.EventHandler(this.Port_SelectionChangeCommitted);
            this.Port.Click += new System.EventHandler(this.Port_Click);
            // 
            // Parity
            // 
            this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity.FormattingEnabled = true;
            this.Parity.Location = new System.Drawing.Point(390, 27);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 21);
            this.Parity.TabIndex = 30;
            this.Parity.DropDown += new System.EventHandler(this.Parity_DropDown);
            this.Parity.SelectionChangeCommitted += new System.EventHandler(this.Parity_SelectionChangeCommitted);
            this.Parity.Click += new System.EventHandler(this.Parity_Click);
            // 
            // BaudRate
            // 
            this.BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Location = new System.Drawing.Point(209, 27);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 21);
            this.BaudRate.TabIndex = 28;
            this.BaudRate.DropDown += new System.EventHandler(this.BaudRate_DropDown);
            this.BaudRate.SelectionChangeCommitted += new System.EventHandler(this.BaudRate_SelectionChangeCommitted);
            this.BaudRate.Click += new System.EventHandler(this.BaudRate_Click);
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(598, 11);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(32, 13);
            this.labelPortName.TabIndex = 27;
            this.labelPortName.Text = "Porta";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(426, 11);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(49, 13);
            this.labelParity.TabIndex = 26;
            this.labelParity.Text = "Paridade";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(236, 11);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(61, 13);
            this.labelBaudRate.TabIndex = 25;
            this.labelBaudRate.Text = "Baud Rate ";
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStopBit.Location = new System.Drawing.Point(71, 11);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(52, 13);
            this.labelStopBit.TabIndex = 24;
            this.labelStopBit.Text = "Stop Bits ";
            // 
            // modoCalibracao
            // 
            this.modoCalibracao.Controls.Add(this.LerCalib);
            this.modoCalibracao.Controls.Add(this.Gravar);
            this.modoCalibracao.Controls.Add(this.numericUpDownOffset);
            this.modoCalibracao.Controls.Add(this.numericUpDownGanho);
            this.modoCalibracao.Controls.Add(this.labelOffSet);
            this.modoCalibracao.Controls.Add(this.labelGanho);
            this.modoCalibracao.Location = new System.Drawing.Point(4, 22);
            this.modoCalibracao.Name = "modoCalibracao";
            this.modoCalibracao.Size = new System.Drawing.Size(277, 367);
            this.modoCalibracao.TabIndex = 2;
            this.modoCalibracao.Text = "Calibração";
            this.modoCalibracao.UseVisualStyleBackColor = true;
            // 
            // labelGanho
            // 
            this.labelGanho.AutoSize = true;
            this.labelGanho.Location = new System.Drawing.Point(34, 29);
            this.labelGanho.Name = "labelGanho";
            this.labelGanho.Size = new System.Drawing.Size(42, 13);
            this.labelGanho.TabIndex = 0;
            this.labelGanho.Text = "Ganho ";
            // 
            // labelOffSet
            // 
            this.labelOffSet.AutoSize = true;
            this.labelOffSet.Location = new System.Drawing.Point(190, 29);
            this.labelOffSet.Name = "labelOffSet";
            this.labelOffSet.Size = new System.Drawing.Size(35, 13);
            this.labelOffSet.TabIndex = 1;
            this.labelOffSet.Text = "Offset";
            // 
            // numericUpDownGanho
            // 
            this.numericUpDownGanho.DecimalPlaces = 4;
            this.numericUpDownGanho.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownGanho.Location = new System.Drawing.Point(20, 56);
            this.numericUpDownGanho.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGanho.Name = "numericUpDownGanho";
            this.numericUpDownGanho.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownGanho.TabIndex = 2;
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.DecimalPlaces = 4;
            this.numericUpDownOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownOffset.Location = new System.Drawing.Point(162, 56);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownOffset.TabIndex = 3;
            // 
            // Enviar
            // 
            this.Enviar.Enabled = false;
            this.Enviar.Location = new System.Drawing.Point(20, 254);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 38;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Gravar
            // 
            this.Gravar.Enabled = false;
            this.Gravar.Location = new System.Drawing.Point(20, 112);
            this.Gravar.Name = "Gravar";
            this.Gravar.Size = new System.Drawing.Size(75, 23);
            this.Gravar.TabIndex = 39;
            this.Gravar.Text = "Gravar";
            this.Gravar.UseVisualStyleBackColor = true;
            // 
            // LerCalib
            // 
            this.LerCalib.Location = new System.Drawing.Point(162, 112);
            this.LerCalib.Name = "LerCalib";
            this.LerCalib.Size = new System.Drawing.Size(75, 23);
            this.LerCalib.TabIndex = 40;
            this.LerCalib.Text = "Ler";
            this.LerCalib.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(818, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.labelStopBit);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.LabelLeitura);
            this.Controls.Add(this.labelPortName);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.StopBits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Serial";
            this.tabControl1.ResumeLayout(false);
            this.modoDeComando.ResumeLayout(false);
            this.modoDeComando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            this.modoFuncional.ResumeLayout(false);
            this.modoCalibracao.ResumeLayout(false);
            this.modoCalibracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage modoDeComando;
        private System.Windows.Forms.CheckBox checkBoxCR;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox Scales;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.NumericUpDown numericUpDownTempo;
        private System.Windows.Forms.Label LabelTempo;
        private System.Windows.Forms.Label LabelLeitura;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label LabelQuantidade;
        private System.Windows.Forms.Label LabelCoomando;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.TabPage modoFuncional;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TabPage modoCalibracao;
        private System.Windows.Forms.Label labelOffSet;
        private System.Windows.Forms.Label labelGanho;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.NumericUpDown numericUpDownGanho;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Gravar;
        private System.Windows.Forms.Button LerCalib;
    }
}

