public abstract class ThucPham
{
    protected string ten;
    protected float dongia;
    public abstract string inTT();
    public virtual float tinhGia()
    {
        return dongia;
    }
}