
using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.Generics;
using SelfPropelledArtilleryUnit.MovementStrategy;
using Microsoft.Extensions.Logging;



namespace SelfPropelledArtilleryUnit
{
    /// <summary>
    /// Форма для работы с набором объектов класса DrawningUsta
    /// </summary>
    public partial class FormSelfPropelledArtilleryUnitCollection : Form
    {
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly UstaGenericStorage _storage;
        /// <summary>
        /// Логер
        /// </summary>
        private readonly ILogger _logger;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormSelfPropelledArtilleryUnitCollection(ILogger<FormSelfPropelledArtilleryUnitCollection> logger)
        {
            InitializeComponent();
            _storage = new UstaGenericStorage(pictureBoxCollection.Width,
            pictureBoxCollection.Height);
        }
        /// <summary>
        /// Заполнение listBoxObjects
        /// </summary>
        private void ReloadObjects()
        {
            int index = listBoxStorage.SelectedIndex;
            listBoxStorage.Items.Clear();
            for (int i = 0; i < _storage.Keys.Count; i++)
            {
                listBoxStorage.Items.Add(_storage.Keys[i]);
            }
            if (listBoxStorage.Items.Count > 0 && (index == -1 || index
            >= listBoxStorage.Items.Count))
            {
                listBoxStorage.SelectedIndex = 0;
            }
            else if (listBoxStorage.Items.Count > 0 && index > -1 &&
            index < listBoxStorage.Items.Count)
            {
                listBoxStorage.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Добавление набора в коллекцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxStorageName.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning("Пустое название набора");
                return;
            }
            _storage.AddSet(textBoxStorageName.Text);
            ReloadObjects();
            _logger.LogInformation($"Добавлен набор:{ textBoxStorageName.Text}");

        }
        /// <summary>
        /// Выбор набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxStorage_SelectedIndexChanged(object sender,
        EventArgs e)
        {
            pictureBoxCollection.Image =
            _storage[listBoxStorage.SelectedItem?.ToString() ?? string.Empty]?.ShowUsta();
        }
        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelObject_Click(object sender, EventArgs e)
        {
            if (listBoxStorage.SelectedIndex == -1)
            {
                _logger.LogWarning("Удаление невыбранного набора");
                return;
            }
            string name = listBoxStorage.SelectedItem.ToString() ?? string.Empty;
            if (MessageBox.Show($"Удалить объект {listBoxStorage.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                _storage.DelSet(listBoxStorage.SelectedItem.ToString()
                ?? string.Empty);
                ReloadObjects();
                _logger.LogInformation($"Удален набор: {name}");

            }
        }
        /// <summary>
        /// Добавление объекта в набор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUsta_Click(object sender, EventArgs e)
        {
            if (listBoxStorage.SelectedIndex == -1)
            {
                return;
            }

            var formSelfPropelledArtilleryUnitConfig = new FormSelfPropelledArtilleryUnitConfig();

            formSelfPropelledArtilleryUnitConfig.AddEvent(usta =>
            {
                var obj = _storage[listBoxStorage.SelectedItem.ToString() ?? string.Empty];
                if (obj == null)
                {
                    _logger.LogWarning("Добавление пустого объекта");
                    return;
                }
                try
                {
                    _ = obj + usta;

                    MessageBox.Show("Объект добавлен");
                    pictureBoxCollection.Image = obj.ShowUsta();
                    _logger.LogInformation($"Добавлен объект в набор {listBoxStorage.SelectedItem.ToString()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить объект");
                    _logger.LogWarning($"{ex.Message} в наборе {listBoxStorage.SelectedItem.ToString()}");
                }
            });

            formSelfPropelledArtilleryUnitConfig.Show();
        }


        /// <summary>
        /// Удаление объекта из набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveUsta_Click(object sender, EventArgs e)
        {
            if (listBoxStorage.SelectedIndex == -1)
            {
                _logger.LogWarning("Удаление объекта из несуществующего набора");
                return;
            }
            var obj = _storage[listBoxStorage.SelectedItem.ToString() ??
            string.Empty];
            if (obj == null)
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxNumber.Text);
            if (obj - pos != null)
            {
                MessageBox.Show("Объект удален");
                pictureBoxCollection.Image = obj.ShowUsta();
                _logger.LogInformation($"Удален объект из набора {listBoxStorage.SelectedItem.ToString()}");
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
                _logger.LogWarning($"Не удалось удалить объект из набора {listBoxStorage.SelectedItem.ToString()}");

            }
        }
        /// <summary>
        /// Обновление рисунка по набору
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefreshCollection_Click(object sender, EventArgs
        e)
        {
            if (listBoxStorage.SelectedIndex == -1)
            {
                return;
            }
            var obj = _storage[listBoxStorage.SelectedItem.ToString() ??
            string.Empty];
            if (obj == null)
            {
                return;
            }
            pictureBoxCollection.Image = obj.ShowUsta();
        }

        /// <summary>
        /// Обработка нажатия "Сохранение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Сохранение наборов в файл {saveFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Не удалось сохранить наборы с ошибкой: {ex.Message}");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия "Загрузка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage.LoadData(openFileDialog.FileName);
                    ReloadObjects();
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Загрузились наборы из файла {openFileDialog.FileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не загрузилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _logger.LogWarning($"Не удалось сохранить наборы с ошибкой: {ex.Message}");
                }
            }
        }


    }
}

