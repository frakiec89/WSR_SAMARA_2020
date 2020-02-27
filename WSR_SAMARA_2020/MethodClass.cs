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
        /// Растояние  до  детского  сада  
        /// </summary>
        /// <param name="xColumn"> координата дома </param>
        /// <param name="xRow"> координата дома </param>
        /// <returns></returns>
        double DistanceToKindergarten(int xRow, int xColumn);

        /// <summary>
        /// Возвращает колл-во  полных лет  
        /// </summary>
        /// <param name="DateOfBirth">дата рождения</param>
        /// <returns></returns>
        int GetAge(DateTime DateOfBirth);

        /// <summary>
        /// возмедение числа в степень
        /// </summary>
        /// <param name="x">число</param>
        /// <param name="stepen">степень</param>
        /// <returns></returns>
        int GetPow(int x ,  int stepen);

        /// <summary>
        /// Ход  конем
        /// </summary>
        /// <param name="chessCellStart">стартовая позиция </param>
        /// <param name="ChessCellEnd">планируемый  ход </param>
        /// <returns></returns>
        bool HorseRide(ChessCell chessCellStart, ChessCell ChessCellEnd);
 
    }

    public class MethodClass : IMethodClass
    {
      
    }










    public struct ChessBoard
    {
        public List<ChessCell> chessCells { get; set; }
    }

    public struct ChessCell
    {
        public char C { get; set; }
        public int I { get; set; }
        public char Color { get; set; }
        public Figure figure { get; set; }
    }

    public struct Figure
    {
        public char Name { get; set; }
        public char Color { get; set; }
    }
}
