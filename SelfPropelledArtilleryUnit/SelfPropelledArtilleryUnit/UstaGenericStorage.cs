using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using SelfPropelledArtilleryUnit.Drawnings;
using SelfPropelledArtilleryUnit.MovementStrategy;
using SelfPropelledArtilleryUnit.DrawningObjects;
using SelfPropelledArtilleryUnit.Exceptions;

namespace SelfPropelledArtilleryUnit.Generics

{
    internal class UstaGenericStorage
    {
        /// <summary>
        /// Словарь (хранилище)
        /// </summary>
        readonly Dictionary<UstaCollectionInfo, UstaGenericCollection<DrawningUsta,
        DrawningObjectUsta>> _ustaStorages;
        /// <summary>
        /// Возвращение списка названий наборов
        /// </summary>
        public List<UstaCollectionInfo> Keys => _ustaStorages.Keys.ToList();
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
            _ustaStorages = new Dictionary<UstaCollectionInfo,
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
            if (!_ustaStorages.ContainsKey(new UstaCollectionInfo(name, string.Empty)))
            {
                var ustaCollection = new UstaGenericCollection<DrawningUsta, DrawningObjectUsta>(_pictureWidth, _pictureHeight);
                _ustaStorages.Add(new UstaCollectionInfo(name, string.Empty), ustaCollection);
            }
        }
        /// <summary>
        /// Удаление набора
        /// </summary>
        /// <param name="name">Название набора</param>
        public void DelSet(string name)
        {
            // TODO Прописать логику для удаления
            if (_ustaStorages.ContainsKey(new UstaCollectionInfo(name, string.Empty)))
            {
                _ustaStorages.Remove(new UstaCollectionInfo(name, string.Empty));
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
                UstaCollectionInfo indObj = new UstaCollectionInfo(ind, string.Empty);
                // TODO Продумать логику получения набора
                if (_ustaStorages.ContainsKey(indObj))
                {
                    return _ustaStorages[indObj];
                }
                return null;

            }
        }
        /// <summary>
        /// Сохранение информации по установкам в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - сохранение прошло успешно, false - ошибка при сохранении данных</returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            StringBuilder data = new();
            foreach (KeyValuePair<UstaCollectionInfo, UstaGenericCollection<DrawningUsta, DrawningObjectUsta>> record in _ustaStorages)
            {
                StringBuilder records = new();
                foreach (DrawningUsta? elem in record.Value.GetUsta)
                {
                    records.Append($"{elem?.GetDataForSave(_separatorForObject)}{_separatorRecords}");
                }
                data.AppendLine($"{record.Key.Name}{_separatorForKeyValue}{records}");
            }
            if (data.Length == 0)
            {
                throw new Exception("Невалидная операция, нет данных для сохранения");
            }

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write($"UstaStorage{Environment.NewLine}{data}");
            }
        }

        /// <summary>
        /// Загрузка информации по установкам в хранилище из файла
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns>true - загрузка прошла успешно, false - ошибка при загрузке данных</returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new Exception("Файл не найден");
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string cheker = reader.ReadLine();
                if (cheker == null)
                {
                    throw new Exception("Нет данных для загрузки");
                }
                if (!cheker.StartsWith("UstaStorage"))
                {
                    throw new Exception("Неверный формат ввода");
                }
                _ustaStorages.Clear();
                string strs;
                bool firstinit = true;
                while ((strs = reader.ReadLine()) != null)
                {
                    if (strs == null && firstinit)
                    {
                        throw new Exception("Нет данных для загрузки");
                    }
                    if (strs == null)
                    {
                        break;
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
                            try { _ = collection + usta; }
                            catch (UstaNotFoundException e)
                            {
                                throw e;
                            }
                            catch (StorageOverflowException e)
                            {
                                throw e;
                            }
                        }
                    }
                    _ustaStorages.Add(new UstaCollectionInfo(name, string.Empty), collection);
                }
            }
        }
    }
}

