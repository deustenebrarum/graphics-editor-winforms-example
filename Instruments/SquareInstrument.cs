namespace StudentsPaint.Instruments;

public class SquareInstrument(PictureBox picture, Pen pen)
    : IInstrument
{
    public Pen Pen { get; set; } = pen;
    private Point? _start;
    private Image _initialImage = default!;

    public void OnMouseDown(object sender, MouseEventArgs e) 
    {
        _start = e.Location;
        _initialImage = picture.Image.GetRedrawedBy();
    }

    public void OnMouseUp(object sender, MouseEventArgs e)
    {
        _start = null;
    }

    public void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (!_start.HasValue)
            return;
        var rectangle = new Rectangle
        {
            X = Math.Min(_start.Value.X, e.X),
            Y = Math.Min(_start.Value.Y, e.Y),
            Width = Math.Abs(_start.Value.X - e.X),
            Height = Math.Abs(_start.Value.Y - e.Y)
        };

        Image image = _initialImage.GetRedrawedBy(graphics =>
        {
            graphics.DrawRectangle(Pen, rectangle);
        });

        picture.Image.Dispose();
        picture.Image = image;
    }
}

