public class ThucPhamTuoiSong : ThucPham
{
    private sbyte dotuoi;

    public ThucPhamTuoiSong(string ten, float dongia, sbyte dotuoi)
    {
        this.ten = ten;
        this.dongia = dongia;
        this.dotuoi = dotuoi;
    }
    public override string inTT()
    {
        return $"TP Tươi sống ({ten}, {dongia}, {dotuoi})";
    }
    public override float tinhGia()
    {
        return dotuoi >= 3 ? 0.9f * base.tinhGia() : (dotuoi == 2 ? 0.75f * base.tinhGia() : 0.5f * base.tinhGia());
    }
}