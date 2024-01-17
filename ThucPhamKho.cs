public class ThucPhamKho : ThucPham
{
    private string ptlamkho;

    public ThucPhamKho(string ten, float dongia, string ptlamkho)
    {
        this.ten = ten;
        this.dongia = dongia;
        this.ptlamkho = ptlamkho;
    }

    public override string inTT()
    {
        return $"TP Khô ({ten}, {dongia}, {ptlamkho})";
    }
    public override float tinhGia()
    {
        return ptlamkho.Equals("sấy nhiệt") ? 0.9f * base.tinhGia() : 0.95f * base.tinhGia();
    }
}