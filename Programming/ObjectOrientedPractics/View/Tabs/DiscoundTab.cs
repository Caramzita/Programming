using ObjectOrientedPractics.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscoundTab : UserControl
    {
        /// <summary>
        /// Хранит накопительную скидку.
        /// </summary>
        private readonly PointsDiscount _pointsDiscount = new PointsDiscount();

        /// <summary>
        /// Хранит процентную скидку.
        /// </summary>
        private readonly PercentDiscount _percentDiscount = new PercentDiscount(Category.None);
            
        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private readonly ObservableCollection<Item> items = new ObservableCollection<Item>();

        /// <summary>
        /// Хранит итоговую стоимость.
        /// </summary>
        private double totalAmount = 0;

        /// <summary>
        /// Создает экзмепляр класса <see cref="DiscoundTab"/>.
        /// </summary>
        public DiscoundTab()
        {
            InitializeComponent();
        }

        private void DiscoundTab_Load(object sender, EventArgs e)
        {
            InfoLabel.Text = _pointsDiscount.Info;
            InfoPercent.Text = _percentDiscount.Info;
            Discount.Text = "0";

            for (int i = 0; i < 10; i++)
            {
                items.Add(ItemFactory.Randomize());
                totalAmount += items[i].Cost;
            }

            Amount.Text = totalAmount.ToString();
            AmountPercent.Text = totalAmount.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Discount.Text = _pointsDiscount.Calculate(items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _pointsDiscount.Apply(items);
            InfoLabel.Text = _pointsDiscount.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _pointsDiscount.Update(items);
            InfoLabel.Text = _pointsDiscount.Info;
            Discount.Text = "0";
        }

        private void CalculatePercent_Click(object sender, EventArgs e)
        {
            PercentDiscount.Text = _percentDiscount.Calculate(items).ToString();
        }

        private void ApplyPercent_Click(object sender, EventArgs e)
        {
            _percentDiscount.Apply(items);
            InfoPercent.Text = _percentDiscount.Info;
        }

        private void UpdatePercent_Click(object sender, EventArgs e)
        {
            _percentDiscount.Update(items);
            InfoPercent.Text = _percentDiscount.Info;
            PercentDiscount.Text = "0";
        }
    }
}
