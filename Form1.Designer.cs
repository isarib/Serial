namespace Serial
{
    partial class Form1
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.labelStopBit = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelPortName = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.Port = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.LabelCoomando = new System.Windows.Forms.Label();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelLeitura = new System.Windows.Forms.Label();
            this.Enviar = new System.Windows.Forms.Button();
            this.LabelTempo = new System.Windows.Forms.Label();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.Scales = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // labelStopBit
            // 
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(58, 45);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(52, 13);
            this.labelStopBit.TabIndex = 0;
            this.labelStopBit.Text = "Stop Bits ";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(215, 45);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(61, 13);
            this.labelBaudRate.TabIndex = 2;
            this.labelBaudRate.Text = "Baud Rate ";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(393, 45);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(49, 13);
            this.labelParity.TabIndex = 3;
            this.labelParity.Text = "Paridade";
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Location = new System.Drawing.Point(566, 45);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(32, 13);
            this.labelPortName.TabIndex = 4;
            this.labelPortName.Text = "Porta";
            // 
            // Parity
            // 
            this.Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity.FormattingEnabled = true;
            this.Parity.Location = new System.Drawing.Point(354, 61);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 21);
            this.Parity.TabIndex = 6;
            this.Parity.DropDown += new System.EventHandler(this.Parity_DropDown);
            this.Parity.SelectionChangeCommitted += new System.EventHandler(this.Parity_SelectionChangeCommitted);
            this.Parity.Click += new System.EventHandler(this.Parity_Click);
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FormattingEnabled = true;
            this.Port.Location = new System.Drawing.Point(520, 61);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(121, 21);
            this.Port.TabIndex = 7;
            this.Port.DropDown += new System.EventHandler(this.Port_DropDown);
            this.Port.SelectionChangeCommitted += new System.EventHandler(this.Port_SelectionChangeCommitted);
            this.Port.Click += new System.EventHandler(this.Port_Click);
            // 
            // Connect
            // 
            this.Connect.Enabled = false;
            this.Connect.Location = new System.Drawing.Point(689, 59);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(99, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Conectar ";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // BaudRate
            // 
            this.BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Location = new System.Drawing.Point(184, 61);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 21);
            this.BaudRate.TabIndex = 5;
            this.BaudRate.DropDown += new System.EventHandler(this.BaudRate_DropDown);
            this.BaudRate.SelectionChangeCommitted += new System.EventHandler(this.BaudRate_SelectionChangeCommitted);
            this.BaudRate.Click += new System.EventHandler(this.BaudRate_Click);
            // 
            // StopBits
            // 
            this.StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Location = new System.Drawing.Point(25, 61);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(121, 21);
            this.StopBits.TabIndex = 5;
            this.StopBits.DropDown += new System.EventHandler(this.StopBits_DropDown);
            this.StopBits.SelectionChangeCommitted += new System.EventHandler(this.StopBits_SelectionChangeCommitted);
            this.StopBits.Click += new System.EventHandler(this.StopBits_Click);
            // 
            // LabelCoomando
            // 
            this.LabelCoomando.AutoSize = true;
            this.LabelCoomando.Location = new System.Drawing.Point(41, 143);
            this.LabelCoomando.Name = "LabelCoomando";
            this.LabelCoomando.Size = new System.Drawing.Size(52, 13);
            this.LabelCoomando.TabIndex = 9;
            this.LabelCoomando.Text = "Comando";
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Location = new System.Drawing.Point(41, 212);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.LabelQuantidade.TabIndex = 10;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(25, 159);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(121, 20);
            this.Command.TabIndex = 11;
            this.Command.ModifiedChanged += new System.EventHandler(this.Command_ModifiedChanged);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(174, 159);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(590, 228);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "";
            // 
            // LabelLeitura
            // 
            this.LabelLeitura.AutoSize = true;
            this.LabelLeitura.Location = new System.Drawing.Point(241, 143);
            this.LabelLeitura.Name = "LabelLeitura";
            this.LabelLeitura.Size = new System.Drawing.Size(39, 13);
            this.LabelLeitura.TabIndex = 14;
            this.LabelLeitura.Text = "Leitura";
            // 
            // Enviar
            // 
            this.Enviar.Enabled = false;
            this.Enviar.Location = new System.Drawing.Point(44, 364);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 15;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // LabelTempo
            // 
            this.LabelTempo.AutoSize = true;
            this.LabelTempo.Location = new System.Drawing.Point(42, 275);
            this.LabelTempo.Name = "LabelTempo";
            this.LabelTempo.Size = new System.Drawing.Size(48, 13);
            this.LabelTempo.TabIndex = 16;
            this.LabelTempo.Text = "Intervalo";
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.Location = new System.Drawing.Point(25, 324);
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
            this.numericUpDownTempo.TabIndex = 18;
            this.numericUpDownTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(25, 228);
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
            this.numericUpDownQuantidade.TabIndex = 19;
            this.numericUpDownQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Scales
            // 
            this.Scales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scales.FormattingEnabled = true;
            this.Scales.Location = new System.Drawing.Point(25, 297);
            this.Scales.Name = "Scales";
            this.Scales.Size = new System.Drawing.Size(121, 21);
            this.Scales.TabIndex = 20;
            this.Scales.DropDown += new System.EventHandler(this.Scales_DropDown);
            this.Scales.SelectionChangeCommitted += new System.EventHandler(this.Scales_SelectionChangeCommitted);
            this.Scales.Click += new System.EventHandler(this.Scales_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(711, 127);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(53, 26);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Scales);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.numericUpDownTempo);
            this.Controls.Add(this.LabelTempo);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.LabelLeitura);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.LabelQuantidade);
            this.Controls.Add(this.LabelCoomando);
            this.Controls.Add(this.StopBits);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.labelPortName);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelStopBit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.Label LabelCoomando;
        private System.Windows.Forms.Label LabelQuantidade;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label LabelLeitura;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Label LabelTempo;
        private System.Windows.Forms.NumericUpDown numericUpDownTempo;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.ComboBox Scales;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Clear;
    }
}

