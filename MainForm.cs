namespace Paint;

public partial class MainForm : Form
{
    IInstrument? _instrument;

    public MainForm()
    {
        InitializeComponent();

        _picture.MouseMove += OnPictureMouseMove;

        OnPencilChoosen(this, new EventArgs());
    }

    private void OnPictureMouseMove(object sender, MouseEventArgs e)
    {
        _coordsLabel.Text = $"X: {e.X}, Y: {e.Y}";
    }

    private void CreateNewImage(object sender, EventArgs e)
    {
        Size size = new(300, 300);
        Bitmap image = new(size.Width, size.Height);
        using Graphics graphics = Graphics.FromImage(image);

        graphics.FillRectangle(
            Brushes.White, 0, 0,
            size.Width, size.Height
        );

        _picture.Image?.Dispose();
        _picture.Image = image;
        _picture.ClientSize = size;
    }

    private void OnPencilChoosen(object sender, EventArgs e)
    {
        if (_picture.Image == null)
            return;
        ChoosePencil();
    }

    void ChoosePencil()
    {
        _instrument = new PencilInstrument(
            _picture,
            new Pen(Color.Black), 5
        );
    }

    private void _picture_MouseDown(object sender, MouseEventArgs e)
    {
        _instrument?.OnMouseDown(sender, e);
    }

    private void _picture_MouseMove(object sender, MouseEventArgs e)
    {
        _instrument?.OnMouseMove(sender, e);
    }

    private void _picture_MouseUp(object sender, MouseEventArgs e)
    {
        _instrument?.OnMouseUp(sender, e);
    }
}
