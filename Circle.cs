using System;
namespace TINHCHATLOP
{
    public class Circle
    {
        private double bankinh;
        public double BanKinhR
        {
            get => bankinh;
            set => bankinh = value;
        }
        private string mausac;
        public string MauSac
        {
            get => mausac;
            set => mausac = value;
        }
        protected double dientich;
        public Circle(double bankinhR, string Mausac)
        {
            bankinh = bankinhR;
            mausac = Mausac;
            dientich = Math.Pow(bankinh,2)*Math.PI;
        }
        public override string ToString()
        {
            return $"Hinh tron voi ban kinh {bankinh}, co mau sac la {mausac}, dien tich bang {dientich}";
        }
    }
}