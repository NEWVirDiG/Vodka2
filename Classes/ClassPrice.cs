using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePracWork13.Classes
{
    internal class ClassPrice
    {
        // Предметная область: Библиотека.Минимальный список характеристик: 
        //	номер читательского билета, 
        //	ФИО читателя,
        //	адрес,
        //	телефон, 
        //	название книги,
        //	дата выдачи книги читателю,
        //	дата сдачи книги читателем.

        //поля класса
        string names;
        string shop;
        string price;
        string amount;
    

        //свойства для доступа к полям
       public string Names
        { get { return names; } set { names = value; } }
        public string Shop
        { get { return shop; } set { shop = value; } }
        public string Price
        { get { return price; }  set { price = value; } }
        public string Amount
        { get { return amount; } set { amount = value; } }
   

        //конструкторы
        public ClassPrice() 
        {
            names = string.Empty;
            shop = string.Empty;
            price = string.Empty;
            amount = string.Empty;
            
        }
        public ClassPrice(string nm, string sp, 
            string prc, string Am)
        {
            names = nm;
            shop = sp;
            price = prc;
            amount = Am;
          
            
        }
    }
}
