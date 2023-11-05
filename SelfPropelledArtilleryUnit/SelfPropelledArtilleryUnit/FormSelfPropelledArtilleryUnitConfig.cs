
using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.Entities;
using SelfPropelledArtilleryUnit;
using SelfPropelledArtilleryUnit.DrawningObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SelfPropelledArtilleryUnit
{
    /// <summary>
    /// Форма создания объекта
    /// </summary>
    public partial class FormSelfPropelledArtilleryUnitConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная установка
        /// </summary>
        DrawningUsta? _usta = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event Action<DrawningUsta> EventAddUsta;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormSelfPropelledArtilleryUnitConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            // TODO buttonCancel.Click with lambda
            buttonCancel.Click += (sender, e) => Close();
        }
        /// <summary>
        /// Отрисовать установку
        /// </summary>
        private void DrawUsta()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _usta?.SetPosition(5, 5);
            _usta?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev">Привязанный метод</param>
        public void AddEvent(Action<DrawningUsta> ev)
        {
            if (EventAddUsta == null)
            {
                EventAddUsta = new Action<DrawningUsta>(ev);
            }
            else
            {
                EventAddUsta += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label)?.DoDragDrop((sender as Label)?.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.Text) ?? false)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data?.GetData(DataFormats.Text).ToString())
            {
                case "labelSimpleObject":
                    _usta = new DrawningUsta((int)numericUpDownSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, pictureBoxObject.Width,
                   pictureBoxObject.Height);
                    break;
                case "labelModifiedObject":
                    _usta = new DrawningUstaBat((int)numericUpDownSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxBodyKit.Checked,
                   checkBoxPushka.Checked, pictureBoxObject.Width, pictureBoxObject.Height);
                    break;
            }
            DrawUsta();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel)?.DoDragDrop((sender as Panel)?.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        // TODO Реализовать логику смены цветов: основного и дополнительного (для продвинутого объекта)
        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_usta != null)
            {
                if (e.Data.GetDataPresent(typeof(Color)))
                {
                    _usta.EntityUsta.BodyColor = (Color)e.Data.GetData(typeof(Color));

                }
                DrawUsta();
            }
        }

        private void LabelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (_usta != null && _usta.EntityUsta is EntityUstaBat entityustabat)
            {
                labelDopColor.AllowDrop = true;
            }
            else
                labelDopColor.AllowDrop = false;

            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_usta != null && _usta.EntityUsta is EntityUstaBat entityustabat)
            {
                if (e.Data.GetDataPresent(typeof(Color)))
                {
                    entityustabat.AdditionalColor = (Color)e.Data.GetData(typeof(Color));

                }
                DrawUsta();
            }
        }
        /// <summary>
        /// Добавление установки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddUsta?.Invoke(_usta);
            Close();
        }
    }

}