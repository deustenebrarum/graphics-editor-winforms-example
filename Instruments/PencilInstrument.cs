namespace StudentsPaint.Instruments;

public class PencilInstrument(
    PictureBox pictureBox, Pen pen)
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
        Image image = pictureBox.Image.GetRedrawedBy(graphics => {
            graphics.DrawLine(
                Pen,
                _lastPoint.Value,
                e.Location
            );
        });
        pictureBox.Image.Dispose();
        pictureBox.Image = image;
        _lastPoint = e.Location;
    }
}
