using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.MovementStrategy;
using SelfPropelledArtilleryUnit.DrawningObjects;
namespace SelfPropelledArtilleryUnit.Generics

{
    internal class UstaGenericStorage
    {
        /// <summary>
        /// Словарь (хранилище)
        /// </summary>
        readonly Dictionary<string, UstaGenericCollection<DrawningUsta,
        DrawningObjectUsta>> _ustaStorages;
        /// <summary>
        /// Возвращение списка названий наборов
        /// </summary>
        public List<string> Keys => _ustaStorages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Разделитель для записи ключа и значения элемента словаря
        /// </summary>
        private static readonly char _separatorForKeyValue = '|';
        /// <summary>
        /// Разделитель для записей коллекции данных в файл
        /// </summary>
        private readonly char _separatorRecords = ';';
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly char _separatorForObject = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public UstaGenericStorage(int pictureWidth, int pictureHeight)
        {
            _ustaStorages = new Dictionary<string,
            UstaGenericCollection<DrawningUsta, DrawningObjectUsta>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void AddSet(string name)
        {
            // TODO Прописать логику для добавления
            if (!_ustaStorages.ContainsKey(name))
            {
                var ustaCollection = new UstaGenericCollection<DrawningUsta, DrawningObjectUsta>(_pictureWidth, _pictureHeight);
                _ustaStorages.Add(name, ustaCollection);
            }
        }
        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void DelSet(string name)
        {
            // TODO Прописать логику для удаления
            if (_ustaStorages.ContainsKey(name))
            {
                _ustaStorages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к набору
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public UstaGenericCollection<DrawningUsta, DrawningObjectUsta>? this[string ind]
        {
            get
            {
                // TODO Продумать логику получения набора
                if (_ustaStorages.ContainsKey(ind))
                {
                    return _ustaStorages[ind];
                }
                return null;

            }
        }
        /// <summary>
        /// Сохранение информации по установкам в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - сохранение прошло успешно, false - ошибка при сохранении данных</returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StringBuilder data = new();
            foreach (KeyValuePair<string, UstaGenericCollection<DrawningUsta, DrawningObjectUsta>> record in _ustaStorages)
            {
                StringBuilder records = new();
                foreach (DrawningUsta? elem in record.Value.GetUsta)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key}{_separatorForKeyValue}{records}");
            }
            if (data.Length == 0)
            {
                return false;
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write($"UstaStorage{Environment.NewLine}{data}");
            }

            return true;
        }

        /// <summary>
        /// Загрузка информации по установкам в хранилище из файла
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - загрузка прошла успешно, false - ошибка при загрузке данных</returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string cheker = reader.ReadLine();
                if (cheker == null)
                {
                    return false;
                }
                if (!cheker.StartsWith("UstaStorage"))
                {
                    return false;
                }
                _ustaStorages.Clear();
                string strs;
                bool firstinit = true;
                while ((strs = reader.ReadLine()) != null)
                {
                    if (strs == null && firstinit)
                    {
                        return false;
                    }
                    if (strs == null)
                    {
                        return false;
                    }
                    firstinit = false;
                    string name = strs.Split(_separatorForKeyValue)[0];
                    UstaGenericCollection<DrawningUsta, DrawningObjectUsta> collection = new(_pictureWidth, _pictureHeight);
                    foreach (string data in strs.Split(_separatorForKeyValue)[1].Split(_separatorRecords))
                    {
                        DrawningUsta? usta =
                        data?.CreateDrawningUsta(_separatorForObject, _pictureWidth, _pictureHeight);
                        if (usta != null)
                        {
                            int? result = collection + usta;
                            if (result == null || result.Value == -1)
                            {
                                return false;
                            }
                        }
                    }
                    _ustaStorages.Add(name, collection);
                }
                return true;
            }
        }
    }
}

