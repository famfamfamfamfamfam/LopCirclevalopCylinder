using System.Security.Cryptography;

namespace TINHCHATLOP
{
    public class Cylinder : Circle
    {
        private double chieucao;
        public double ChieuCao
        {
            get => chieucao;
            set => chieucao = value;
        }
        private double TheTich()
        {
            return dientich * chieucao;
        }
        public Cylinder(double bankinhR, string Mausac, double Chieucao): base(bankinhR,Mausac)
        {
            chieucao = Chieucao;
        }
        public override string ToString()
        {
            return $"Hinh tru co:\nBan kinh day bang {BanKinhR}\nDien tich day bang {dientich}\nChieu cao bang {chieucao}\nThe tich bang {TheTich()}\nMau sac la {MauSac}";
        }
    }
}
