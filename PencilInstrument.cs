namespace Paint;

public class PencilInstrument(
    PictureBox pictureBox, Pen pen, int size)
    : IInstrument
{
    private bool _isDrawing = false;
    private Point? _lastPoint = null;
    public Pen Pen { get; set; } = pen;

    public void OnMouseDown(object sender, MouseEventArgs e)
    {
        _isDrawing = true;
        _lastPoint = e.Location;
    }

    public void OnMouseUp(object sender, MouseEventArgs e)
    {
        _lastPoint = null;
        _isDrawing = false;
    }

    public void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (
            !_isDrawing || pictureBox.Image == null ||
            !_lastPoint.HasValue
        )
            return;
        Image image = new Bitmap(
            pictureBox.Image.Width,
            pictureBox.Image.Height
        );
        using Graphics graphics = Graphics.FromImage(
            image
        );
        graphics.DrawImage(pictureBox.Image, 0, 0);
        graphics.DrawLine(
            Pen, 
            _lastPoint.Value,
            e.Location
        );
        _lastPoint = e.Location;
        pictureBox.Image.Dispose();
        pictureBox.Image = image;
    }
}
