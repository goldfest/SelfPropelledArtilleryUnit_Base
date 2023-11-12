
using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.Generics;
using SelfPropelledArtilleryUnit.MovementStrategy;



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
        /// Конструктор
        /// </summary>
        public FormSelfPropelledArtilleryUnitCollection()
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
                return;
            }
            _storage.AddSet(textBoxStorageName.Text);
            ReloadObjects();
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
                return;
            }
            if (MessageBox.Show($"Удалить объект {listBoxStorage.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                _storage.DelSet(listBoxStorage.SelectedItem.ToString()
                ?? string.Empty);
                ReloadObjects();
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
                if (listBoxStorage.SelectedIndex != -1)
                {
                    var obj = _storage[listBoxStorage.SelectedItem?.ToString() ?? string.Empty];
                    if (obj != null)
                    {
                        if (obj + usta != 1)
                        {
                            MessageBox.Show("Объект добавлен");
                            pictureBoxCollection.Image = obj.ShowUsta();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить объект");
                        }
                    }
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
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
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
                if (_storage.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (_storage.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Данные успешно загружены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadObjects();
                }
                else
                {
                    MessageBox.Show("Ошибка при загрузке данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

