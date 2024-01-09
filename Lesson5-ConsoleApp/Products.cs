using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_ConsoleApp
{
    internal class Products
    {
        private int _code;
        private string _name;
        private string _description;
        private double _buyPrice;
        private double _sellerPrice;
        private string _category;

        public Products()
        {
            _code = 0;
            _description = string.Empty;
            _name = string.Empty;
            _buyPrice = 0;
            _sellerPrice = 0;
            _category = string.Empty;

        }

        public Products(int code, string description, string name, double buyPrice, double sellerPrice, string category)
        {
            this._code = code;
            this._description = description;
            this._name = name;
            this._buyPrice = buyPrice;
            this._sellerPrice = sellerPrice;
            this._category = category;

        }

    }
}
