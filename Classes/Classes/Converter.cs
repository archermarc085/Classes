using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    enum Currency { Usd, Euro, Ru, Ua }
    class Converter
    {
        #region Fields
        double sum = 0;
        Currency currency = Currency.Usd;
        Currency currency1 = Currency.Ua;
        CultureInfo us = new CultureInfo("en-US");
        double exchangeRatesDollar = 0;
        double exchangeRatesEuro = 0;
        double exchangeRatesUa = 0;
        double exchangeRatesRu = 0;

        const double euroIntoDollar = 1.06;
        const double dollarIntoEuro = 0.94;
        const double ruIntoDollar = 0.014;
        const double ruIntoEuro = 0.012;

        const double euroIntoRu = 76.1864;
        const double dollarIntoRu = 69.7934;

        double currencyExchangeDollar = 0;
        double currencyExchangeEuro = 0;
        double currencyExchangeRu = 0;

        double currencyBuyDollar = 0;
        double currencyBuyEuro = 0;
        double currencyBuyRu = 0;

        #endregion

        #region Properties
        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        #endregion

        #region Constructors
        public Converter(double buyUsd, double buyEuro = 27.3450, double buyRu = 0.3567, string buying = "Ua")
        {
            currencyBuyEuro = buyEuro;
            currencyBuyRu = buyRu;
            currencyBuyDollar = buyUsd;

        }

        public Converter(double usd, double euro, double ru)
            : this(25.0773)
        {
            currencyExchangeEuro = euro;
            currencyExchangeRu = ru;
            currencyExchangeDollar = usd;
        }
        #endregion

        #region Methods
        public void ChooseCurrency()
        {
            switch (currency1)
            {
                case Currency.Usd://счет долларов в ua,ru,euro
                    exchangeRatesUa = Sum * currencyExchangeDollar;
                    exchangeRatesEuro = dollarIntoEuro * Sum;
                    exchangeRatesRu = dollarIntoRu * Sum;
                    break;

                case Currency.Euro:
                    exchangeRatesDollar = Sum * euroIntoDollar;
                    exchangeRatesUa = Sum * currencyBuyEuro;
                    exchangeRatesRu = Sum * euroIntoRu;
                    break;

                case Currency.Ru:
                    exchangeRatesDollar = Sum * ruIntoDollar;
                    exchangeRatesEuro = Sum * ruIntoEuro;
                    exchangeRatesUa = Sum * currencyExchangeRu;
                    break;
                case Currency.Ua://счет грн. в долларах, евро,руб
                    exchangeRatesDollar = Sum / currencyBuyDollar;
                    exchangeRatesEuro = Sum / currencyBuyEuro;
                    exchangeRatesRu = Sum * currencyBuyRu;
                    break;
            }
        }

        public void ExchangeCurrency()
        {
            switch (currency)
            {
                case Currency.Usd:
                    Console.WriteLine("Перевод в доллары : {0}", exchangeRatesDollar.ToString("c", us));
                    break;

                case Currency.Euro:
                    Console.WriteLine("Перевод в евро: {0}", exchangeRatesEuro);
                    break;

                case Currency.Ru:
                    Console.WriteLine("Перевод в руб : {0}", exchangeRatesRu);
                    break;

                case Currency.Ua:
                    Console.WriteLine("Перевод в грн : {0}", exchangeRatesUa);
                    break;
            }
        }
        #endregion
     }
}
