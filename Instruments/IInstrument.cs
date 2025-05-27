namespace StudentsPaint.Instruments;

public interface IInstrument
{
    Pen Pen { get; set; }
    void OnMouseDown(object sender, MouseEventArgs e);
    void OnMouseUp(object sender, MouseEventArgs e);
    void OnMouseMove(object sender, MouseEventArgs e);
}

