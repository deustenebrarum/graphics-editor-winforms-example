namespace Paint;

public interface IInstrument
{
    void OnMouseDown(object sender, MouseEventArgs e);
    void OnMouseUp(object sender, MouseEventArgs e);
    void OnMouseMove(object sender, MouseEventArgs e);
    Pen Pen { get; set; }
}

