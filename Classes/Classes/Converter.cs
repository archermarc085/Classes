using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Converter
    {
                #region Fields
        double sum = 0;

        //CultureInfo ua = new CultureInfo("uk-UA");
       // CultureInfo eu = new CultureInfo("de-DE");
        CultureInfo us = new CultureInfo("en-US");
        double ExchangeRates_Dollar = 0;
        double ExchangeRates_Euro = 0;
        double ExchangeRates_UA = 0;
        double ExchangeRates_RU = 0;

        const double euro_dollar = 1.06;
        const double dollar_euro = 0.94;
        const double ru_dollar = 0.014 ;
        const double ru_euro = 0.012 ;

        const double euro_ru = 76.1864;
        const double dollar_ru = 69.7934;

        double currencyexchange_usd = 0;
        double currencyexchange_euro = 0;
        double currencyexchange_rub = 0;

        double currencybuy_usd = 0;
        double currencybuy_euro = 0;
        double currencybuy_rub = 0;

        public char symbol = '$';
        public char symbol2 = 'U';
        #endregion

        #region Properties
        public double Sum 
        {
            get { return sum; }
            set { sum = value; }
        }
        #endregion

        #region Constructors
        public Converter(double buy_usd, double buy_euro = 27.3450, double buy_rub = 0.3567, string buying = "UA")
        {
            currencybuy_euro = buy_euro;
            currencybuy_rub = buy_rub;
            currencybuy_usd = buy_usd;

        }

        public Converter(double usd, double euro, double rub)
            : this(25.0773)
        {
            currencyexchange_euro = euro;
            currencyexchange_rub = rub;
            currencyexchange_usd = usd;
        }
        #endregion

        #region Methods
        public void ChooseCurrency() 
        {
        switch(symbol2)
        {
            case 'S'://счет долларов в ua,ru,euro
              ExchangeRates_UA = Sum * currencyexchange_usd;
              ExchangeRates_Euro = dollar_euro * Sum;
              ExchangeRates_RU = dollar_ru * Sum;
                break;

            case 'E':
              ExchangeRates_Dollar = Sum * euro_dollar;
              ExchangeRates_UA = Sum * currencybuy_euro;
              ExchangeRates_RU = Sum * euro_ru;
                break;

            case 'R':
              ExchangeRates_Dollar = Sum * ru_dollar;
              ExchangeRates_Euro =  Sum * ru_euro;
              ExchangeRates_UA = Sum * currencyexchange_rub; 
                break;
            case 'U'://счет грн. в долларах, евро,руб
              ExchangeRates_Dollar = Sum / currencybuy_usd;
              ExchangeRates_Euro = Sum / currencybuy_euro;
              ExchangeRates_RU = Sum * currencybuy_rub;
               break;   
        }
        }

        public void ExchangeCurrency()
        {
            switch (symbol)
            {
                case '$':
                    Console.WriteLine("Перевод в доллары : {0}", ExchangeRates_Dollar.ToString("c", us));
                    break;

                case 'E':
                    Console.WriteLine("Перевод в евро: {0}", ExchangeRates_Euro);
                    break;

                case 'R':
                    Console.WriteLine("Перевод в руб : {0}", ExchangeRates_RU);
                    break;

                case 'U':
                    Console.WriteLine("Перевод в грн : {0}", ExchangeRates_UA);
                    break;
            }
        }
        #endregion
    }
}
