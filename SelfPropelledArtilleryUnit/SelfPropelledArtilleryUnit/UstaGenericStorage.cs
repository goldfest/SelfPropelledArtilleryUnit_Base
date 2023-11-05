using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

