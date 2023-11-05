using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.MovementStrategy;
namespace SelfPropelledArtilleryUnit
{
    /// <summary>
    /// Форма работы с объектом "Установка с вооружением"
    /// </summary>
    public partial class FormSelfPropelledArtilleryUnit : Form
    {
        /// <summary>
        /// Поле-объект для прорисовки объекта
        /// </summary>
        private DrawningUsta? _drawningUsta;
        /// <summary>
        /// Стратегия перемещения
        /// </summary>
        private AbstractStrategy? _abstractStrategy;

        /// <summary>
        /// Выбранная установка
        /// </summary>
        public DrawningUsta? SelectedUsta { get; private set; }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormSelfPropelledArtilleryUnit()
        {
            InitializeComponent();
            _abstractStrategy = null;
            SelectedUsta = null;

        }
        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
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
        /// Обработка нажатия кнопки "Создать арт. установку с вооружением"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateUstaBat_Click(object sender, EventArgs e)
        {
            Random random = new();

            Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            //TODO выбор основного цвета
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            Color dopColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            //TODO выбор дополнительного цвета
            ColorDialog dialog_dop = new();
            if (dialog_dop.ShowDialog() == DialogResult.OK)
            {
                dopColor = dialog_dop.Color;
            }

            _drawningUsta = new DrawningUstaBat(random.Next(100, 300),
            random.Next(1000, 3000),
            color,
            dopColor,
            Convert.ToBoolean(random.Next(0, 2)), Convert.ToBoolean(random.Next(0, 2)),
            pictureBoxUsta.Width, pictureBoxUsta.Height);
            _drawningUsta.SetPosition(random.Next(10, 100), random.Next(10,
            100));
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать арт. установку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateUsta_Click(object sender, EventArgs e)
        {
            Random random = new();
            Color color = Color.FromArgb(random.Next(0, 256),
            random.Next(0, 256), random.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }

            _drawningUsta = new DrawningUsta(random.Next(100, 300),
            random.Next(1000, 3000),
            color,
            pictureBoxUsta.Width, pictureBoxUsta.Height);
            _drawningUsta.SetPosition(random.Next(10, 100), random.Next(10,
            100));
            Draw();
        }
        /// <summary>
        /// Изменение положения установки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Обработка нажатия кнопки "Шаг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStep_Click(object sender, EventArgs e)
        {
            if (_drawningUsta == null)
            {
                return;
            }
            if (comboBoxStrategy.Enabled)
            {
                _abstractStrategy = comboBoxStrategy.SelectedIndex
                switch
                {
                    0 => new MoveToCenter(),
                    1 => new MoveToBorder(),
                    _ => null,
                };
                if (_abstractStrategy == null)
                {
                    return;
                }
                _abstractStrategy.SetData(new
                DrawningObjectUsta(_drawningUsta), pictureBoxUsta.Width,
                pictureBoxUsta.Height);
                comboBoxStrategy.Enabled = false;
            }
            if (_abstractStrategy != null)
            {
                _abstractStrategy.MakeStep();
                Draw();

                if (_abstractStrategy.GetStatus() == Status.Finish)
                {
                    comboBoxStrategy.Enabled = true;
                    _abstractStrategy = null;
                }
            }


        }

        private void ButtonSelectUsta_Click(object sender, EventArgs e)
        {
            SelectedUsta = _drawningUsta;
            DialogResult = DialogResult.OK;
        }
    }
}
