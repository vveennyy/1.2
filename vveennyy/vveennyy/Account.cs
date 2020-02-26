using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
