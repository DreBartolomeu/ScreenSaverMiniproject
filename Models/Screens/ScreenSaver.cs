namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Windows.Forms;

public class ScreenSaver : Form
{

    // ******* Declare suas formas geométricas aqui (escopo global) *******

    Shape []Shapes = new Shape[20];

    // ********************************************************************

    private Timer ControlTimer;

    public ScreenSaver()
    {
        this.DoubleBuffered = true;                     // evita flickering
        this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
        this.BackColor = Color.Black;                   // Define a cor de background

        ControlTimer = new Timer();// Inicializa o temporizador de controle
        ControlTimer.Interval = 16;                     // 16 ms = ~60 fps
        // Controle da animação
        ControlTimer.Tick += (s, e) =>
        {

            // ****** Mova suas formas geométricas aqui ******

            foreach (Shape shape in Shapes)
                shape.Move(ClientSize.Width, ClientSize.Height);

            // ***********************************************

                Invalidate(); // Foça a tela a ser redesenhada.
        };
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // ****** Instancie suas formas geométricas aqui ******

        for (int i = 0; i < Shapes.Length / 4; i++)
        {
            Shapes[i] = new MyRectangle(ClientSize.Width, ClientSize.Height);
            Shapes[i + 5] = new MySquare(ClientSize.Width, ClientSize.Height);
            Shapes[i + 10] = new MyEllipse(ClientSize.Width, ClientSize.Height);
            Shapes[i + 15] = new MyCircle(ClientSize.Width, ClientSize.Height);
        }
        
        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // ****** Desenhe suas formas geométricas aqui *******

        foreach (Shape shape in Shapes)
            shape.Draw(e.Graphics);

        // ***************************************************

    }
}