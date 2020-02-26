using System;
using InputAccuracy;

namespace vveennyy
{
    class Account
    {
        /// <summary>
        /// Поле содержащее наименование счёта
        /// </summary>
        private string _Nomination { get; set; }
        /// <summary>
        /// Поле содержащее номер счёта
        /// </summary>
        private int _AccountNumber { get; set; }
        /// <summary>
        /// Поле содержащее сумму на счёте
        /// </summary>
        private double _Amount { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Account()
        {
            this._Nomination = "No name";
            this._AccountNumber = 0000;
            this._Amount = 0.0f;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_nomination">Наименование</param>
        /// <param name="_accountNumber">Номер счёта</param>
        /// <param name="_amount">Сумма на счёте</param>
        public Account(string _nomination, int _accountNumber, double _amount)
        {
            this._Nomination = _nomination;
            this._AccountNumber = _accountNumber;
            this._Amount = _amount;
        }
        /// <summary>
        /// Изменяет наименование
        /// </summary>
        /// <param name="_nomination">Новое наименование</param>
        /// <returns>Новое наименование</returns>
        public string NominationEdit(string _nomination)
        {
            this._Nomination = _nomination;
            return _nomination;
        }
        /// <summary>
        /// Изменяет номер счёта
        /// </summary>
        /// <param name="_accountNumber">Новый номер счёта</param>
        /// <returns>Номер счёта</returns>
        public int AccountNumberEdit(int _accountNumber)
        {
            this._AccountNumber = _accountNumber;
            return _accountNumber;
        }
        /// <summary>
        /// Изменяет сумму на счёте
        /// </summary>
        /// <param name="_amount">Новая сумма на счёте</param>
        /// <returns>Новая сумма на счёте</returns>
        public double AmountEdit(double _amount)
        {
            this._Amount = _amount;
            return _amount;
        }
        /// <summary>
        /// Получение наименования
        /// </summary>
        /// <returns></returns>
        public string NominationInfo()
        {
            return this._Nomination;
        }
        /// <summary>
        /// Получения номера счёта
        /// </summary>
        /// <returns></returns>
        public int AccountNumberInfo()
        {
            return this._AccountNumber;
        }
        /// <summary>
        /// Получение суммы на счёте
        /// </summary>
        /// <returns></returns>
        public double AmountInfo()
        {
            return this._Amount;
        }
        /// <summary>
        /// Форматирования объекта класса в строку
        /// </summary>
        /// <returns>Строка</returns>
        public override string ToString()
        {
            return string.Format("наименование:{0}\nНомер счета:{1}\nСумму:{2}", this._Nomination, this._AccountNumber, this._Amount);
        }
        /// <summary>
        /// Ввод данных в объект
        /// </summary>
        public void DataInput()
        {
            Class1 input = new Class1();
            Console.WriteLine("введите наименование");
            NominationEdit(input._stringName(Console.ReadLine()));
            Console.WriteLine("введите номер счета");
            AccountNumberEdit(Convert.ToInt32(input._int(Console.ReadLine())));
            Console.WriteLine("введите сумму");
            AmountEdit(Convert.ToDouble(input._double(Console.ReadLine())));
        }
    }
}
