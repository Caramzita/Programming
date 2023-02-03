using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PointsDiscount : IDiscount
    {
        private int _points;

        private double _dicsount;

        private double _totalAmount = 0;

        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество баллов должно быть положительным");
                }

                _points = value;
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalAmount = 0;

            for(int i = 0; i < items.Count; i++)
            {
                totalAmount += items[i].Cost;
            }

            _totalAmount = totalAmount;

            _dicsount = totalAmount * 0.3;

            if (_points < (int)(_dicsount))
            {
                return _points;
            }
            else
            {
                return Math.Round(_dicsount);
            }
        }

        public double Apply(List<Item> items)
        {
            _points -= (int)Calculate(items);
            return _points;
        }

        public void Update(List<Item> items)
        {
            _points += (int)Math.Round(_totalAmount * 0.1);
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {_points} баллов";
            }
        }
        
        public PointsDiscount()
        {

        }
    }
}
