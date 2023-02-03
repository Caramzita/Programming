using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscoundTab : UserControl
    {
        PointsDiscount pointsDiscount = new PointsDiscount();

        PercentDiscount percentDiscount = new PercentDiscount(Category.Clothes);
            
        private List<Item> items = new List<Item>();

        private double totalAmount = 0;

        public DiscoundTab()
        {
            InitializeComponent();
        }

        private void DiscoundTab_Load(object sender, EventArgs e)
        {
            InfoLabel.Text = pointsDiscount.Info;
            InfoPercent.Text = percentDiscount.Info;
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
            Discount.Text = pointsDiscount.Calculate(items).ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            pointsDiscount.Apply(items);
            InfoLabel.Text = pointsDiscount.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            pointsDiscount.Update(items);
            InfoLabel.Text = pointsDiscount.Info;
            Discount.Text = "0";
        }

        private void CalculatePercent_Click(object sender, EventArgs e)
        {
            PercentDiscount.Text = percentDiscount.Calculate(items).ToString();
        }

        private void ApplyPercent_Click(object sender, EventArgs e)
        {
            percentDiscount.Apply(items);
            InfoPercent.Text = percentDiscount.Info;
        }

        private void UpdatePercent_Click(object sender, EventArgs e)
        {
            percentDiscount.Update(items);
            InfoPercent.Text = percentDiscount.Info;
            PercentDiscount.Text = "0";
        }
    }
}
