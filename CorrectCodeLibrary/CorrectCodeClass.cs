using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        /// <summary>
        /// Метод принимает в качестве параметра строку. 
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>
        /// Метод возвращает true, если входная строка соответствует следующим условиям:
        /// строка имеет правильную длину;
        /// десятый символ строки (контрольное значение) содержит правильную цифру.
        /// При нарушении данных условий, метод возвращает false.
        /// </returns>
        public static bool IsCorrectCode(string candidate)
        {
            if (String.IsNullOrEmpty(candidate)) //Проверка на пустоту
            {
                return false;
            }
            char[] chars = candidate.ToCharArray();
            
            if (chars.Length == 10) //Проверка что строка равна 10 символам 
            {
                
                double sum = 0; //Переменная суммы
                double controlsum = Char.GetNumericValue(chars[9]); //Получение контрольной суммы
                for (int i = 0; i < chars.Length;i++)
                {
                    if (!Char.IsDigit(chars[i])) //Проверка того,что в строке только цифры
                    {
                        return false;
                    }
                }
                for (int i = 0; i < chars.Length-1; i++) 
                { 
                    sum = sum + Char.GetNumericValue(chars[i]); //получение суммы строки
                }
                if ((sum % 10) == 0 || (sum % 3) == 0)//проверка на то, что число делится на 10 или на 3
                {

                    if ((sum % 10) == 0)//число делится 10
                    {
                        if (controlsum == 0) //сравнение числа и контрольной суммы
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if ((sum % 3) == 0)//число делится 3
                    {
                        if (controlsum == 1)//сравнение числа и контрольной суммы
                        {
                            return true;
                        }
                        else
                        {                   
                            return false;
                        }
                    } 
                }
                else
                {
                    sum = 9;
                    if (sum == controlsum)//сравнение числа и контрольной суммы
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return false;





            
        }
    }
}
