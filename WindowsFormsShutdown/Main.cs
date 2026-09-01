using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsShutdown
{
    public partial class Main : Form
    {
        private TimeSpan tiempoApagado;
        private readonly Timer cuentaAtrasTimer;
        private DateTime objetivo;
        private string accionComando;

        // Color del contador cuando faltan mas de 30 segundos.
        private static readonly Color ColorNormal = Color.Black;
        // Color de alerta a partir de los 30 segundos restantes.
        private static readonly Color ColorAlerta = Color.Red;

        public Main()
        {
            InitializeComponent();
            this.cuentaAtrasTimer = new Timer { Interval = 1000 };
            this.cuentaAtrasTimer.Tick += this.CuentaAtrasTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Configurar();
            this.tiempoApagado = new TimeSpan();
            EjecutarShutdown("/a");
        }

        private void Configurar()
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valida() != string.Empty)
            {
                MessageBox.Show(Valida());
                return;
            }
            if (MessageBox.Show(CalcularSuma() + Environment.NewLine + "¿Esta seguro de continuar?", "El equipo " + AccionTexto().ToLower() + ".", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                IniciarCuentaAtras();
            }
        }

        private void IniciarCuentaAtras()
        {
            // La cuenta atras se gestiona dentro de la app (no con el "/t" de shutdown)
            // para poder mostrar el tiempo restante y permitir cancelarla.
            objetivo = DateTime.Now.Add(tiempoApagado);
            accionComando = AccionComando();

            HabilitarControles(false);
            ActualizarCuentaAtras(tiempoApagado);
            cuentaAtrasTimer.Start();
        }

        private void CuentaAtrasTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan restante = objetivo - DateTime.Now;
            if (restante <= TimeSpan.Zero)
            {
                cuentaAtrasTimer.Stop();
                ActualizarCuentaAtras(TimeSpan.Zero);
                EjecutarShutdown(accionComando);
                return;
            }

            ActualizarCuentaAtras(restante);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cuentaAtrasTimer.Stop();
            HabilitarControles(true);
            labelCuentaAtras.ForeColor = ColorNormal;
            labelCuentaAtras.Text = "00:00:00";
        }

        private void ActualizarCuentaAtras(TimeSpan restante)
        {
            labelCuentaAtras.Text = FormatearTiempo(restante);
            // A partir de los 30 segundos restantes el contador se muestra en rojo.
            labelCuentaAtras.ForeColor = restante.TotalSeconds <= 30 ? ColorAlerta : ColorNormal;
        }

        private static string FormatearTiempo(TimeSpan t)
        {
            if (t < TimeSpan.Zero) t = TimeSpan.Zero;
            return t.Days > 0
                ? string.Format("{0}d {1:00}:{2:00}:{3:00}", t.Days, t.Hours, t.Minutes, t.Seconds)
                : string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
        }

        private void HabilitarControles(bool habilitado)
        {
            buttonExecutar.Enabled = habilitado;
            buttonCancelar.Enabled = !habilitado;
            groupBoxTipoApagado.Enabled = habilitado;
            tabControl.Enabled = habilitado;
        }

        private string AccionComando()
        {
            if (radioButtonReiniciar.Checked) return "/r /f /t 0";
            if (radioButtonHibernar.Checked) return "/h";
            return "/s /f /t 0";
        }

        private static void EjecutarShutdown(string argumentos)
        {
            var psi = new ProcessStartInfo("shutdown", argumentos)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        private void radioButtonApagar_CheckedChanged(object sender, EventArgs e)
        {
            ValueChanged(null, null);
        }

        private void radioButtonReiniciar_CheckedChanged(object sender, EventArgs e)
        {
            ValueChanged(null, null);
        }

        private void radioButtonHibernar_CheckedChanged(object sender, EventArgs e)
        {
            ValueChanged(null, null);
        }

        private string AccionTexto()
        {
            if (radioButtonReiniciar.Checked) return "Reiniciara";
            if (radioButtonHibernar.Checked) return "Hibernara";
            return "Apagara";
        }

        private string CalcularSuma()
        {
            if (tabControl.SelectedTab == this.tabPageTiempo)
            {
                tiempoApagado = new TimeSpan(
                    int.Parse(numericUpDownDias.Value.ToString()),
                    int.Parse(numericUpDownHoras.Value.ToString()),
                    int.Parse(numericUpDownMinutos.Value.ToString()),
                    int.Parse(numericUpDownSegundos.Value.ToString()));
                labelResultado.Text = "La computadora se " + AccionTexto() + Environment.NewLine + "El dia " + DateTime.Now.Add(this.tiempoApagado).ToLongDateString() + " a las " + DateTime.Now.Add(this.tiempoApagado).ToLongTimeString();

            }
            else
            {
                DateTime fechaApagado = new DateTime(
                    monthCalendar.SelectionStart.Year,
                    monthCalendar.SelectionStart.Month,
                    monthCalendar.SelectionStart.Day,
                    dateTimePicker.Value.Hour,
                    dateTimePicker.Value.Minute,
                    dateTimePicker.Value.Second
                    );
                tiempoApagado = (fechaApagado - DateTime.Now);
                labelResultado.Text = "La computadora se " + AccionTexto() + Environment.NewLine + "El dia " + fechaApagado.ToLongDateString() + " a las " + fechaApagado.ToLongTimeString();

            }

            return labelResultado.Text;
        }

        private string Valida()
        {
            string mensaje = string.Empty;
            if (tiempoApagado.TotalSeconds >= 31536000)
            {
                mensaje += "El tiempo no puede ser mayor a 10 años.";
            }
            if (tiempoApagado.TotalSeconds <= 0)
            {
                mensaje += "El tiempo no puede ser menor a 1 segundo.";
            }

            return mensaje;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            CalcularSuma();
            labelError.Text = Valida();
        }
    }
}
