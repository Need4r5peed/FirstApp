using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp.Module7.Unit7.Task771
{
    public class Main_Task771
    {
        public static void Main()
        {
            Console.WriteLine("Программа завершена...");
        }
    }
    // Использую явное обозначение модификатора "internal" для классов (которое не обязательно, так как по умолчанию) - чтоб лучше воспринимать информацию при считывании доступа.
    // Также использую модификатор доступа "private" - для полей, свойств и методов вместо неявного private "по умолчанию", когда модификатор отсутствует.

    /// <summary>
    /// Структура верхнего уровня с модификатором общего доступа для объекта-коллекции "Адрес назначения заказа" || Ускоряет работу программы по доступу к данын || 
    /// Название "StructAddress" выбрано для удобства, чтоб выделить среди всех подобных однотипных названий.
    /// </summary>
    public struct StructAddress
    {
        //Свойство с модификатором общего доступа, хранящее строковое значение "Название города адреса назначения заказа",
        //выполняющее доступ к получению этого значения.
        public string City { get; }
        //Свойство с модификатором общего доступа, хранящее строковое значение "Название улицы адреса назначения заказа",
        //выполняющее доступ к получению этого значения.
        public string Street { get; }
        //Свойство с модификатором общего доступа, хранящее строковое значение "Номер дома адреса назначения заказа",
        //выполняющее доступ к получению этого значения.
        public string HouseNumber { get; }
        //Свойство с модификатором общего доступа, хранящее строковое значение "Номер дома адреса назначения заказа",
        //выполняющее доступ к получению этого значения.
        public string ApartmentNumber { get; }

        //Конструктор с модификатором общего доступа,
        //выполняющий стандартную инициализацию всех полей структуры StructAddress через строковые параметры: city, street, houseNumber, apartmentNumber.
        public StructAddress(string city, string street, string houseNumber, string apartmentNumber)
        {
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
        }

        /// <summary>
        /// Переопределение методовов, наследуемых от System.Object для изменения работы логики структуры и типов, связанных с этой структорой
        /// </summary>
        /// <returns></returns>
        //Переопределение метода с модификатором общего доступа,
        //выполняющего сборку адреса из составных частей (напрямую получаемых из полей структуры) в одну строку и возвращающего готовую строку адреса.
        public override string ToString() => $"н.п. {City}, ул. {Street}, д. {HouseNumber}, кв. {ApartmentNumber}";

        // Переопределение Equals для сравнения по значениям полей
        public override bool Equals(object obj)
        {
            if (obj is not StructAddress other)
                return false;

            return City == other.City &&
                    Street == other.Street &&
                    HouseNumber == other.HouseNumber &&
                    ApartmentNumber == other.ApartmentNumber;
        }

        // Переопределение GetHashCode для корректной работы Equals (используется для стркутур сложнее массива, к примеру словарей)
        public override int GetHashCode()
        {
            return HashCode.Combine(City, Street, HouseNumber, ApartmentNumber);
        }

        // Переопределение оператора == 
        public static bool operator ==(StructAddress left, StructAddress right)
        {
            return left.Equals(right);
        }

        // Переопределение оператора != 
        public static bool operator !=(StructAddress left, StructAddress right)
        {
            return !left.Equals(right);
        }
    }

    /// <summary>
    /// Абстрактный класс верхнего уровня с модификатором внутреннего доступа для объекта Пункт назначения доставки заказа
    /// </summary>
    internal abstract class DestinationDelivery
    {
        //Объявление поля с модификатором ограниченного доступа, хранящее "Адрес доставки" со значением по умолчанию.
        protected StructAddress _addressDelivery;
        //Абстрактное свойство с модификатором общего доступа,необходимое для реализации из наследникыо доступа к полю Address.
        public abstract StructAddress AddressDelivery { get; }
        //Виртуальное свойство с модификатором ограниченного доступа,необходимое для реализации внутри наследников доступа к изменению поля Address.
        protected virtual StructAddress Protected_addressDelivery { set { } }
        public DestinationDelivery(StructAddress address) => _addressDelivery = address;
        public DestinationDelivery(StructAddress address, CourierServiceCollection deliveryManager) : this(address)
        {
            Sending_addressDelivery(deliveryManager);
        }
        public abstract void Sending_addressDelivery(CourierServiceCollection deliveryManager);
    }

    /// <summary>
    /// Класс верхнего уровня с модификатором внутреннего доступа для объекта "Тип доставки заказа по пункту назначения: доставка на дом" (класс-наследник класса DestinationDelivery)
    /// </summary>
    internal class HomeDelivery : DestinationDelivery
    {
        //Реализация свойства с модификатором общего доступа, возвращающего значение ограниченного поля Address.
        public override StructAddress AddressDelivery => _addressDelivery;
        //Переоапределение свойства с модификатором ограниченного доступа, дающее доступ к изменению поля Address (для класса и наследников).
        protected override StructAddress Protected_addressDelivery
        {
            set
            {
                _addressDelivery = value;
                Console.WriteLine($"Через свойство HomeDelivery Поле Address изменено на: {_addressDelivery}");
            }
        }
        //Конструктор с модификатором общего доступа, выполняющий инициализацию поля Address через параметр address и выводящий сообщение об этом.
        public HomeDelivery(StructAddress address) : base(address) { Console.WriteLine($"Через конструктор HomeDelivery поле Address изменено на: {_addressDelivery}"); }
        public HomeDelivery(StructAddress address, CourierServiceCollection deliveryManager)
        : base(address, deliveryManager) { }
        public override void Sending_addressDelivery(CourierServiceCollection deliveryManager)
        {
            string isFound = deliveryManager.CourierServiceNameSearch(ref _addressDelivery);
            Console.WriteLine($"Адрес {_addressDelivery} обслуживат {isFound}");
        }
    }

    /// <summary>
    /// Класс верхнего уровня с модификатором внутреннего доступа для объекта "Тип доставки заказа по пункту назначения: доставка в пункт выдачи" (класс-наследник класса DestinationDelivery)
    /// </summary>
    internal class PickPointDelivery : DestinationDelivery
    {
        //Реализация свойства с модификатором общего доступа, возвращающего значение ограниченного поля Address.
        public override StructAddress AddressDelivery => _addressDelivery;
        //Сокрытие свойства с модификатором ограниченного доступа, дающее доступ к изменению поля Address.
        protected new StructAddress Protected_addressDelivery
        {
            set
            {
                _addressDelivery = value;
                Console.WriteLine($"Через свойство PickPointDelivery Поле Address изменено на: {_addressDelivery}");
            }
        }
        //Конструктор с модификатором общего доступа, выполняющий инициализацию поля Address через параметр address и выводящий сообщение об этом.
        public PickPointDelivery(StructAddress address) : base(address) { Console.WriteLine($"Через конструктор HomeDelivery поле Address изменено на: {_addressDelivery}"); }
        public PickPointDelivery(StructAddress address, CourierServiceCollection deliveryManager)
        : base(address, deliveryManager) { }
        public override void Sending_addressDelivery(CourierServiceCollection deliveryManager)
        {
            string isFound = deliveryManager.CourierServiceNameSearch(ref _addressDelivery);
            Console.WriteLine($"Адрес {_addressDelivery} обслуживат {isFound}");
        }
    }

    /// <summary>
    /// Класс верхнего уровня с модификатором внутреннего доступа для объекта "Тип доставки заказа по пункту назначения: доставка в розничный магазин" (класс-наследник класса DestinationDelivery)
    /// </summary>
    internal class ShopDelivery : DestinationDelivery
    {
        //Реализация свойства с модификатором общего доступа, возвращающего значение ограниченного поля Address.
        public override StructAddress AddressDelivery => _addressDelivery;
        //Сокрытие свойства с модификатором ограниченного доступа, дающее доступ к изменению поля Address.
        protected new StructAddress Protected_addressDelivery
        {
            set
            {
                _addressDelivery = value;
                Console.WriteLine($"Через свойство ShopDelivery Поле Address изменено на: {_addressDelivery}");
            }
        }
        //Конструктор с модификатором общего доступа, выполняющий инициализацию поля Address через параметр address и выводящий сообщение об этом.
        public ShopDelivery(StructAddress address) : base(address) { Console.WriteLine($"Через конструктор HomeDelivery поле Address изменено на: {_addressDelivery}"); }
        public ShopDelivery(StructAddress address, CourierServiceCollection deliveryManager)
        : base(address, deliveryManager) { }
        public override void Sending_addressDelivery(CourierServiceCollection deliveryManager)
        {
            string isFound = deliveryManager.CourierServiceNameSearch(ref _addressDelivery);
            Console.WriteLine($"Адрес {_addressDelivery} обслуживат {isFound}");
        }
    }

    /// <summary>
    /// Класс верхнего уровня с модификатором внутреннего доступа для объекта "Заказ"
    /// </summary>
    internal class Order<TDelivery, TStruct>
        where TDelivery : DestinationDelivery
        where TStruct : struct
    {
        //Поля и свойства без возможности изменить:
        //Свойство с модификатором общего доступа, хранящее интовое значение "Номер заказа",
        //выполняющее доступ к получению этого значения.
        public int _orderNumber { get; }
        //Свойство с модификатором общего доступа, хранящее интовое значение "Имя заказчика",
        //выполняющее доступ к получению этого значения.
        public string _orderName { get; }
        //Свойство с модификатором общего доступа, хранящее типа домашней доставки значение "Адрес заказа",
        //выполняющее доступ к получению этого значения.
        public HomeDelivery _orderAddress { get; }

        //Свойство с модификатором общего доступа, хранящее типа дат (структура из System) значение "Желаемо время доставки",
        //выполняющее доступ к получению этого значения.
        public DateTime _orderDesiredDate { get; }

        //Поля и свойства изменяемые:
        //Поле с модификатором ограниченного доступа, хранящее строковое значение "Описание заказа"
        //Свойство с модификатором общего доступа, выполняющее доступ к получению этого значения и доступ к изменению этого значения
        private string _orderDescription;
        public string OrderDescription
        {
            get => _orderDescription;
            set => _orderDescription = string.IsNullOrEmpty(value) ? "Нет описания" : value;
        }
        //Поле с модификатором ограниченного доступа, хранящее строковое значение "Приоритет заказа" 
        //Свойство с модификатором общего доступа, выполняющее доступ к получению этого значения и доступ к изменению этого значения
        private int _orderPriority;
        public int OrederPriority
        {
            get => _orderPriority;
            set => _orderPriority = value < 0 ? 0 : value;
        }
        //Поле с модификатором ограниченного доступа, хранящее строковое значение "Статус заказа"
        //Свойство с модификатором общего доступа, выполняющее доступ к получению этого значения и доступ к изменению этого значения
        private string _orderStatus;
        public string Status
        {
            get => _orderStatus;
            set => _orderStatus = value;
        }
        //Поле с модификатором ограниченного доступа, хранящее строковое значение "Оглавление заметки для заказа" и "Текст заметки для заказа"
        //Свойство с модификатором общего доступа, выполняющее доступ к получению этого значениям и доступ к изменению этого значениям
        private Dictionary<string, string> _orderAdditionalNotes;
        public Dictionary<string, string> OrderAdditionalNotes
        {
            get => _orderAdditionalNotes;
            private set => _orderAdditionalNotes = value; // Приватный set для защиты от замены словаря извне
        }

        //Конструктор с модификатором общего доступа, выполняющий инициализацию свойств _orderNumber,_orderName, _orderAddress, _orderDesiredDate, _orderDescription,
        //_orderPriority, _orderStatus, _orderAdditionalNotes через параметры.
        public Order(int orderNumber, string customerName, HomeDelivery address, DateTime desiredDate,
                        string description, int priority, string status)
        {
            _orderNumber = orderNumber;
            _orderName = customerName;
            _orderAddress = address;
            _orderDesiredDate = desiredDate;
            _orderDescription = description;
            _orderPriority = priority;
            _orderStatus = status;
            _orderAdditionalNotes = new Dictionary<string, string>();
        }

        //Метод с модификатором общего доступа без возвращаемого значения, принимающий строковый параметр и выполняющий обновление статуса заказа
        public void UpdateStatus(string newStatus) => _orderStatus = newStatus;
        //Метод с модификатором общего доступа без возвращаемого значения, принимающий два строковых параметра и выполняющий обновление статуса заказа
        public void AddNote(string key, string note) => _orderAdditionalNotes[key] = note; // Добавляем или обновляем значение по ключу

        // Новый метод для печати всех данных
        public void PrintDetails()
        {
            Console.WriteLine("Детали заказа:");
            Console.WriteLine($"Номер заказа: {_orderNumber}");
            Console.WriteLine($"Имя заказчика: {_orderName}");
            Console.WriteLine($"Адрес доставки: {_orderAddress.AddressDelivery.ToString()}"); // Используем ToString() структуры Address
            Console.WriteLine($"Желаемая дата: {_orderDesiredDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine($"Описание: {_orderDescription}");
            Console.WriteLine($"Приоритет: {_orderPriority}");
            Console.WriteLine($"Статус: {_orderStatus}");
            Console.WriteLine("Дополнительные заметки:");
            if (_orderAdditionalNotes.Count > 0)
            {
                foreach (var note in _orderAdditionalNotes)
                {
                    Console.WriteLine($"  {note.Key}: {note.Value}");
                }
            }
            else
            {
                Console.WriteLine("  Нет заметок.");
            }
        }
    }

    /// <summary>
    /// Абстрактный класс верхнего уровня с модификатором внутреннего доступа для объекта Название курьерской службы для доставки заказа
    /// </summary>
    internal abstract class CourierServiceName(string courierserviceName)
    {
        //Объявление поля с модификатором общего доступа, хранящее "Название курьерсокй службы, обслуживающей данный адрес" со значением по умолчанию.
        public string _courierserviceName = courierserviceName; // "_" помогает выделить поля класса от параметров конструктора (аналогия с this.courierserviceName)
    }

    internal abstract class CourierServiceAddressAndName(string courierserviceName, StructAddress courierserviceAddress) : CourierServiceName(courierserviceName)
    {
        //Объявление поля с модификатором общего доступа, хранящее "Обслуживаемый адрес" со значением по умолчанию.
        public StructAddress _courierserviceAddress = courierserviceAddress;
    }

    // Класс-наследник верхнего уровня с модификатором внутреннего доступа для реализации 
    internal class RealizationCourierServiceAddress : CourierServiceAddressAndName
    {
        public RealizationCourierServiceAddress(string courierserviceName, StructAddress courierserviceAddress)
            : base(courierserviceName, courierserviceAddress)
        {
        }
    }

    internal abstract class CourierServiceTypesAndName(string courierserviceName, string[] courierservicePackageTypes) : CourierServiceName(courierserviceName)
    {
        //Объявление поля с модификатором общего доступа, хранящее "Поддерживаемые типы поссылки для обслуживаемого адреса" со значением по умолчанию.
        public string[] _courierservicePackageTypes = courierservicePackageTypes;
    }

    internal class CourierServiceCollection
    {
        private StructAddress _searchKey; // поле для получения адреса
        private CourierServiceAddressAndName[] _cellCollection;

        //Конструктор с модификатором общего доступа, инициализирующий поле _sendingAddress;
        public CourierServiceCollection(StructAddress sendingAddress)
        {
            _searchKey = sendingAddress;
        }

        //Конструктор с модификатором общего доступа, инициализирующий поле cellCollection;
        public CourierServiceCollection(CourierServiceAddressAndName[] cellCollection)
        {
            _cellCollection = cellCollection;
        }

        //Метод с модификатором общего доступа, выполняющий поиск среди доступных адресов  
        public string CourierServiceNameSearch(ref StructAddress _searchKey)
        {
            string foundСourierserviceName = this[_searchKey];
            return foundСourierserviceName;
        }

        // (Стандартный) индексатор с модификатором общего доступа, выполняющий поиск элемента коллекции названиий и адресов по индексу элемента,
        // вовращающий элемен под нужным индексом, либо дающий присвоить значение найденному элементу под нужным индексом.
        public CourierServiceAddressAndName this[int index]
        {
            get
            {

                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < _cellCollection.Length)
                {
                    return _cellCollection[index]; //условие выполнено, элемент под индексом найден
                }
                else
                {
                    return null; //условие не выполнено, вовращается null
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < _cellCollection.Length)
                {
                    _cellCollection[index] = value;
                }
            }
        }

        // Индиксатор с модификатором общего доступа, выполняющий поиск адреса среди проиндиксованных элементов коллекции названиий и адресов, возвращающий название из найденного элемента.
        public string this[StructAddress address]
        {
            get
            {

                //Переберием элементы коллекции и ищем в них совпадающий адрес с искомой строкой address
                for (int i = 0; i < _cellCollection.Length; i++)
                {
                    if (_cellCollection[i]._courierserviceAddress == address)
                    {
                        return _cellCollection[i]._courierserviceName; // возвращает название фирмы обслуживающей данный адрес
                    }
                }

                return null; // элемент не найден, возвращается null
            }
        }
    }

    ///// <summary>
    ///// Класс верхнего уровня с модификатором внутреннего доступа для объекта Коллекция курьерских служба для доставки заказа
    ///// </summary>
    //internal class CourierServiceCollection<TKey, TValue, TFind>
    //    where TKey : notnull
    //{
    //    // Поле с модификатором закрытого доступа, хранящее курьерских службы в виде массива
    //    //private CourierService[] collection;
    //    private readonly Dictionary<TKey, TValue[]> collection; 

    //    // Конструктор с модификатором общего доступа с добавлением массива курьерских служб
    //    public CourierServiceCollection(Dictionary<TKey, TValue[]> collection)
    //    {
    //        this.collection = collection;
    //    }

    //    // Индексатор с модификатором общего доступа для объекта 
    //    public Dictionary<TKey, TValue[]> this[TFind index]
    //    {
    //        get
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (collection.Contains(index) == true)
    //            {
    //                return collection.Contains(index, true);
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }

    //        private set
    //        {
    //            // Проверяем, чтобы индекс был в диапазоне для массива
    //            if (index >= 0 && index < collection.Length)
    //            {
    //                collection[index] = value;
    //            }
    //        }
    //    }
    //}

    // перегрузка по поиску сразу двух элементов

    /// <summary>
    /// Статический класс верхнего уровня с модификатором общего доступа для объекта Расширение Методов Массива
    /// </summary>

    public static class ArrayExtensions
    {
        // Метод расширения для проверки наличия элемента в массиве
        public static bool? Contains<T1, T2>(this T1[] array, T2 value)
        {
            if (array is null)
                return null; // Массив null

            if (value is null)
            {
                return array.Contains(default(T1)); // Возвращается знаечние по умолчанию для данноого типа
            }

            var comparer = EqualityComparer<T1>.Default; // Класс, который предоставляет методы для сравнения объектов типа T, один из которых Equals
            foreach (var item in array)
            {
                if (item is not null && comparer.Equals(item, (T1)(object)value)) // До приведения была ошибка о возможной несовсместимости для сравнения T1 и T2
                {
                    return true; // Элемент найден
                }
            }

            return false; // Элемент не найден
        }
    }

    /// <summary>
    /// Статический класс верхнего уровня с модификатором общего доступа для объекта Расширение Методов Словаря
    /// </summary>
    public static class DictionaryExtensions
    {
        // Универсальный метод расширения для Dictionary<string, T[]>
        public static bool? Contains<TKey, TValue, TFind>(this Dictionary<TKey, TValue[]> dictionary, TFind valueToFind)
        where TKey : notnull // Ограничение: TKey не может быть nullable
        {
            foreach (var array in dictionary.Values)
            {
                var containsResult = array.Contains(valueToFind);
                if (containsResult == null)
                {
                    return null; // Массив null
                }
                if (containsResult == true)
                {
                    return true;
                }
            }
            return false;
        }

        // Перегрузка метода: возвращает ключ (TKey?)
        public static TKey? Contains<TKey, TValue>(this Dictionary<TKey, TValue[]> dictionary, TValue valueToFind, bool returnKey)
            where TKey : notnull
        {
            foreach (var kvp in dictionary)
            {
                if (kvp.Value == null)
                {
                    continue; // Пропускаем null-массивы
                }

                if (kvp.Value.Contains(valueToFind) == true)
                {
                    return kvp.Key; // Возвращаем ключ, если значение найдено
                }
            }
            return default; // Возвращаем null (или default для значимых типов)
        }
    }
}
