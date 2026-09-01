namespace WindowsFormsShutdown
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCuentaAtras = new System.Windows.Forms.Label();
            this.radioButtonApagar = new System.Windows.Forms.RadioButton();
            this.radioButtonReiniciar = new System.Windows.Forms.RadioButton();
            this.radioButtonHibernar = new System.Windows.Forms.RadioButton();
            this.groupBoxTipoApagado = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTiempo = new System.Windows.Forms.TabPage();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.numericUpDownSegundos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoras = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDias = new System.Windows.Forms.NumericUpDown();
            this.tabPageFecha = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelResultado = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.groupBoxTipoApagado.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDias)).BeginInit();
            this.tabPageFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Location = new System.Drawing.Point(304, 428);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(78, 30);
            this.buttonExecutar.TabIndex = 0;
            this.buttonExecutar.Text = "Ejecutar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.button1_Click);
            //
            // buttonCancelar
            //
            this.buttonCancelar.Enabled = false;
            this.buttonCancelar.Location = new System.Drawing.Point(212, 428);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(86, 30);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            //
            // labelCuentaAtras
            //
            this.labelCuentaAtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCuentaAtras.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelCuentaAtras.Location = new System.Drawing.Point(15, 348);
            this.labelCuentaAtras.Name = "labelCuentaAtras";
            this.labelCuentaAtras.Size = new System.Drawing.Size(367, 55);
            this.labelCuentaAtras.TabIndex = 8;
            this.labelCuentaAtras.Text = "00:00:00";
            this.labelCuentaAtras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // radioButtonApagar
            // 
            this.radioButtonApagar.AutoSize = true;
            this.radioButtonApagar.Checked = true;
            this.radioButtonApagar.Location = new System.Drawing.Point(6, 19);
            this.radioButtonApagar.Name = "radioButtonApagar";
            this.radioButtonApagar.Size = new System.Drawing.Size(59, 17);
            this.radioButtonApagar.TabIndex = 1;
            this.radioButtonApagar.TabStop = true;
            this.radioButtonApagar.Text = "Apagar";
            this.radioButtonApagar.UseVisualStyleBackColor = true;
            this.radioButtonApagar.CheckedChanged += new System.EventHandler(this.radioButtonApagar_CheckedChanged);
            // 
            // radioButtonReiniciar
            // 
            this.radioButtonReiniciar.AutoSize = true;
            this.radioButtonReiniciar.Location = new System.Drawing.Point(71, 19);
            this.radioButtonReiniciar.Name = "radioButtonReiniciar";
            this.radioButtonReiniciar.Size = new System.Drawing.Size(66, 17);
            this.radioButtonReiniciar.TabIndex = 2;
            this.radioButtonReiniciar.Text = "Reiniciar";
            this.radioButtonReiniciar.UseVisualStyleBackColor = true;
            this.radioButtonReiniciar.CheckedChanged += new System.EventHandler(this.radioButtonReiniciar_CheckedChanged);
            //
            // radioButtonHibernar
            //
            this.radioButtonHibernar.AutoSize = true;
            this.radioButtonHibernar.Location = new System.Drawing.Point(143, 19);
            this.radioButtonHibernar.Name = "radioButtonHibernar";
            this.radioButtonHibernar.Size = new System.Drawing.Size(67, 17);
            this.radioButtonHibernar.TabIndex = 3;
            this.radioButtonHibernar.Text = "Hibernar";
            this.radioButtonHibernar.UseVisualStyleBackColor = true;
            this.radioButtonHibernar.CheckedChanged += new System.EventHandler(this.radioButtonHibernar_CheckedChanged);
            //
            // groupBoxTipoApagado
            //
            this.groupBoxTipoApagado.Controls.Add(this.radioButtonApagar);
            this.groupBoxTipoApagado.Controls.Add(this.radioButtonReiniciar);
            this.groupBoxTipoApagado.Controls.Add(this.radioButtonHibernar);
            this.groupBoxTipoApagado.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTipoApagado.Name = "groupBoxTipoApagado";
            this.groupBoxTipoApagado.Size = new System.Drawing.Size(269, 47);
            this.groupBoxTipoApagado.TabIndex = 3;
            this.groupBoxTipoApagado.TabStop = false;
            this.groupBoxTipoApagado.Text = "Tipo de apagado";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTiempo);
            this.tabControl.Controls.Add(this.tabPageFecha);
            this.tabControl.Location = new System.Drawing.Point(18, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(263, 240);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tabPageTiempo
            // 
            this.tabPageTiempo.Controls.Add(this.labelSegundos);
            this.tabPageTiempo.Controls.Add(this.labelMinutos);
            this.tabPageTiempo.Controls.Add(this.labelHoras);
            this.tabPageTiempo.Controls.Add(this.labelDias);
            this.tabPageTiempo.Controls.Add(this.numericUpDownSegundos);
            this.tabPageTiempo.Controls.Add(this.numericUpDownMinutos);
            this.tabPageTiempo.Controls.Add(this.numericUpDownHoras);
            this.tabPageTiempo.Controls.Add(this.numericUpDownDias);
            this.tabPageTiempo.Location = new System.Drawing.Point(4, 22);
            this.tabPageTiempo.Name = "tabPageTiempo";
            this.tabPageTiempo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTiempo.Size = new System.Drawing.Size(255, 214);
            this.tabPageTiempo.TabIndex = 0;
            this.tabPageTiempo.Text = "Por tiempo";
            this.tabPageTiempo.UseVisualStyleBackColor = true;
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Location = new System.Drawing.Point(1, 103);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(58, 13);
            this.labelSegundos.TabIndex = 7;
            this.labelSegundos.Text = "Segundos:";
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Location = new System.Drawing.Point(12, 78);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(47, 13);
            this.labelMinutos.TabIndex = 6;
            this.labelMinutos.Text = "Minutos:";
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(21, 49);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(38, 13);
            this.labelHoras.TabIndex = 5;
            this.labelHoras.Text = "Horas:";
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Location = new System.Drawing.Point(28, 22);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(31, 13);
            this.labelDias.TabIndex = 4;
            this.labelDias.Text = "Dias:";
            // 
            // numericUpDownSegundos
            // 
            this.numericUpDownSegundos.Location = new System.Drawing.Point(61, 103);
            this.numericUpDownSegundos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownSegundos.Name = "numericUpDownSegundos";
            this.numericUpDownSegundos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSegundos.TabIndex = 3;
            this.numericUpDownSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSegundos.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numericUpDownMinutos
            // 
            this.numericUpDownMinutos.Location = new System.Drawing.Point(61, 76);
            this.numericUpDownMinutos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMinutos.Name = "numericUpDownMinutos";
            this.numericUpDownMinutos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinutos.TabIndex = 2;
            this.numericUpDownMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMinutos.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numericUpDownHoras
            // 
            this.numericUpDownHoras.Location = new System.Drawing.Point(61, 46);
            this.numericUpDownHoras.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownHoras.Name = "numericUpDownHoras";
            this.numericUpDownHoras.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHoras.TabIndex = 1;
            this.numericUpDownHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownHoras.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numericUpDownDias
            // 
            this.numericUpDownDias.Location = new System.Drawing.Point(61, 20);
            this.numericUpDownDias.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownDias.Name = "numericUpDownDias";
            this.numericUpDownDias.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDias.TabIndex = 0;
            this.numericUpDownDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDias.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tabPageFecha
            // 
            this.tabPageFecha.Controls.Add(this.dateTimePicker);
            this.tabPageFecha.Controls.Add(this.monthCalendar);
            this.tabPageFecha.Location = new System.Drawing.Point(4, 22);
            this.tabPageFecha.Name = "tabPageFecha";
            this.tabPageFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFecha.Size = new System.Drawing.Size(255, 214);
            this.tabPageFecha.TabIndex = 1;
            this.tabPageFecha.Text = "Fecha Exacta";
            this.tabPageFecha.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(39, 177);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar.Location = new System.Drawing.Point(12, 12);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ValueChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(19, 312);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(126, 13);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Fecha de apagado Label";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(19, 409);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(54, 13);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Validando";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 470);
            this.Controls.Add(this.labelCuentaAtras);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBoxTipoApagado);
            this.Controls.Add(this.buttonExecutar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ShutDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipoApagado.ResumeLayout(false);
            this.groupBoxTipoApagado.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageTiempo.ResumeLayout(false);
            this.tabPageTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDias)).EndInit();
            this.tabPageFecha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelCuentaAtras;
        private System.Windows.Forms.RadioButton radioButtonApagar;
        private System.Windows.Forms.RadioButton radioButtonReiniciar;
        private System.Windows.Forms.RadioButton radioButtonHibernar;
        private System.Windows.Forms.GroupBox groupBoxTipoApagado;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTiempo;
        private System.Windows.Forms.TabPage tabPageFecha;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.NumericUpDown numericUpDownSegundos;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutos;
        private System.Windows.Forms.NumericUpDown numericUpDownHoras;
        private System.Windows.Forms.NumericUpDown numericUpDownDias;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelError;
    }
}

