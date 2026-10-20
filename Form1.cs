using System.IO.Ports;

namespace _3NLIDTS_DiegoGuerrero_7;

public partial class Form1 : Form
{
    public SerialPort ArduinoPort { get; }

    public Form1()
    {
        InitializeComponent();
        ArduinoPort = new System.IO.Ports.SerialPort();
        ArduinoPort.PortName = "COM7";
        ArduinoPort.BaudRate = 9600;
        ArduinoPort.Open();
        // Manejadores de Eventos
        this.FormClosing += CerrandoForm1;
        this.btnEncender.Click += btnEncender_Click;
        this.btnApagar.Click += btnApagar_Click;
    }

    private void CerrandoForm1(object? sender, EventArgs e)
    {
        if (ArduinoPort.IsOpen)
        {
            ArduinoPort.Close();
        }
    }

    private void btnEncender_Click(object? sender, EventArgs e)
    {
        ArduinoPort.Write("a");
    }

    private void btnApagar_Click(object? sender, EventArgs e)
    {
        ArduinoPort.Write("b");
    }
}
