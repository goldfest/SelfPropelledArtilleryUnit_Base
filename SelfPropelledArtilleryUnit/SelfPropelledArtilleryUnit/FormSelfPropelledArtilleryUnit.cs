namespace SelfPropelledArtilleryUnit
{
    public partial class FormSelfPropelledArtilleryUnit : Form
    {
        private DrawningUsta? _drawningUsta;
        public FormSelfPropelledArtilleryUnit()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            if (_drawningUsta == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBoxUsta.Width,
            pictureBoxUsta.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawningUsta.DrawTransport(gr);
            pictureBoxUsta.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new();
            _drawningUsta = new DrawningUsta();
            _drawningUsta.Init(random.Next(100, 300), random.Next(1000, 3000),
            Color.FromArgb(30, 89, 69),
            Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
            Convert.ToBoolean(random.Next(0, 2)),
            Convert.ToBoolean(random.Next(0, 2)),
            pictureBoxUsta.Width,
            pictureBoxUsta.Height);
            _drawningUsta.SetPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (_drawningUsta == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _drawningUsta.MoveTransport(DirectionType.Up);
                    break;
                case "buttonDown":
                    _drawningUsta.MoveTransport(DirectionType.Down);
                    break;
                case "buttonLeft":
                    _drawningUsta.MoveTransport(DirectionType.Left);
                    break;
                case "buttonRight":
                    _drawningUsta.MoveTransport(DirectionType.Right);
                    break;
            }
            Draw();
        }

    }
}