using Meadow.Foundation.Graphics;

namespace MeadowCommonLib.Devices
{
    public class ILI9341Graphics
    {
        MicroGraphics _graphics;
        
        private readonly IGraphicsDisplay Display;

        public MicroGraphics Graphics { get { return _graphics; } set { _graphics = value; } }
             
        public ColorMode ColorMode { get; set; }

        public IFont Font { get; set; }

        public RotationType RotationType { get; set; }
                
        public ILI9341Graphics(
            IGraphicsDisplay display,
            IFont font,
            ColorMode colorMode = ColorMode.Format16bppRgb565,
            RotationType rotationType = RotationType.Normal
            )
        {
            ColorMode = colorMode;
            this.Display = display;
            Font = font;
            RotationType = rotationType;

            Initialize();
        }

        void Initialize()
        {
            _graphics = new MicroGraphics(Display)
            {
                Stroke = 1,
                CurrentFont = Font,
                Rotation = RotationType
            };

            _graphics.Clear(true);
            _graphics.Show();
        }

    }
}