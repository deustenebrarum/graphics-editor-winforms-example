namespace StudentsPaint.Instruments;

public static class IInstrumentExtensions
{
    public static Image GetRedrawedBy(
        this Image image,
        Action<Graphics>? action = null
    )
    {
        Image newImage = new Bitmap(
            image.Width,
            image.Height
        );
        using Graphics graphics = Graphics.FromImage(
            newImage
        );
        graphics.DrawImage(image, 0, 0);

        action?.Invoke(graphics);

        return newImage;
    }
}

