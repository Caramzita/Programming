using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PercentDiscount : IDiscount
    {
        private Category _discountCategory;

        private double _currentDiscount = 0.01;

        private double _spentMoney = 0;

        public string Info
        {
            get
            {
                return $"Процентная «{_discountCategory}» - {_currentDiscount * 100}%";
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalDiscount = 0;

            foreach (var item in items)
            {
                if (item.Category == _discountCategory)
                {
                    totalDiscount += item.Cost * _currentDiscount;
                    _spentMoney += item.Cost * (1 - _currentDiscount);             
                }
            }

            return totalDiscount;
        }

        public double Apply(List<Item> items)
        {
            _currentDiscount = 0.01;
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            if((_spentMoney / 1000) > 10)
            {
                _currentDiscount = 0.1;
            }
            else
            {
                _currentDiscount = ((int)_spentMoney / 1000) * 0.01;
            }

            if(_currentDiscount == 0)
            {
                _currentDiscount = 0.01;
            }
        }

        public PercentDiscount(Category discountCategory) 
        { 
            _discountCategory= discountCategory;
        }    
    }
}
