using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSR_SAMARA_2020
{
    public interface IMethodClass
    {
        /// <summary>
        /// Метод возвращает  Короткую запись ФИО типа «Иванов И.И.» 
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns></returns>
        string GetInitials(string Name, string surname, string patronymic);

        /// <summary>
        /// Метод конвертирования телефона в единый числовой формат
        /// </summary>
        /// <param name="number">Номер  телефона</param>
        /// <returns></returns>
        int GetMobilePhoneNumber(string number);

        /// <summary>
        /// метод  преобразования контента в  хеш 
        /// </summary>
        /// <param name="content">контент</param>
        /// <param name="has">вид хеширования</param>
        /// <returns></returns>
        string GetHash(string content , TypeHas has) ;

        /// <summary>
        /// конвертер  продажи валют банку 
        /// </summary>
        /// <param name="cash"></param>
        /// <param name="currency">валюта '$' or '€'</param>
        /// <returns></returns>
        double ConvertCurrency(double cash, char currency );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xColumn"></param>
        /// <param name="xRow"></param>
        /// <returns></returns>
        double DistanceToKindergarten(int xRow, int xColumn);

        int GetAge(DateTime DateOfBirth);


    }

    public class MethodClass : IMethodClass
    {
        public string GetInitials(string Name, string surname, string patronymic)
        {
            throw new NotImplementedException();
        }

        public int GetMobilePhoneNumber(string number)
        {
            throw new NotImplementedException();
        }

        public string GetHash(string content, TypeHas has)
        {
            throw new NotImplementedException();
        }

        public double ConvertCurrency(double cash, char currency)
        {
            throw new NotImplementedException();
        }

        public double DistanceToKindergarten(int xRow, int xColumn)
        {
            throw new NotImplementedException();
        }

        public int GetAge(DateTime dateOfBirth)
        {
          

            return 5;
        }
    }
}
