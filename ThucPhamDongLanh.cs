public class ThucPhamDongLanh : ThucPham
{
    private sbyte nhietdobq;

    public ThucPhamDongLanh(string ten, float dongia, sbyte nhietdobq)
    {
        this.ten = ten;
        this.dongia = dongia;
        this.nhietdobq = nhietdobq;
    }

    public override string inTT()
    {
        return $"TP Đông lạnh ({ten}, {dongia}, {nhietdobq})";
    }
    public override float tinhGia()
    {
        return base.tinhGia() * 0.85f;
    }
}