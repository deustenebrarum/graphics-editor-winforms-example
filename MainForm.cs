using StudentsPaint.Instruments;

namespace StudentsPaint;

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
            new Pen(Color.Black, int.Parse(_sizeTextBox.Text))
        );
    }
    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        if (_picture.Image == null)
            return;
        _instrument = new SquareInstrument(
            _picture,
            new Pen(_colorDialog.Color, int.Parse(_sizeTextBox.Text))
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

    private void OnColorChoosen(object sender, EventArgs e)
    {
        _colorDialog.ShowDialog();
        _colorButton.BackColor = _colorDialog.Color;
        if (_instrument == null)
            return;

        _instrument.Pen.Color = _colorDialog.Color;
    }

    private void SetSize(int size)
    {
        if (size < 0 || size > 300)
        {
            _sizeTextBox.Text = (_instrument?.Pen.Width ?? 1).ToString();
            return;
        }

        _sizeTextBox.Text = size.ToString();
        if (_instrument != null)
            _instrument.Pen.Width = size;
    }

    private void OnSizeChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_sizeTextBox.Text) ||
            !_sizeTextBox.Text.All(char.IsDigit))
        {
            _sizeTextBox.Text = (_instrument?.Pen.Width ?? 1).ToString();
            return;
        }
       SetSize(int.Parse(_sizeTextBox.Text));
    }
}
