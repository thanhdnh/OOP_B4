public class Program
{   /*
    Thực phẩm tươi sống: têntp, đơn_giá, độ_tươi
    thực phẩm đông lạnh: têntp, đơn_giá, nhiệt_độ_bq, 
    thực phẩm khô: têntp, đơn_giá, pt_làm_khô
    */
    public static void Main(string[] args)
    {
        List<ThucPham> list = new List<ThucPham>();
        list.Add(new ThucPhamDongLanh("Đùi gà đông lạnh", 22000, -5));
        list.Add(new ThucPhamTuoiSong("Cá chép", 25000, 4));
        list.Add(new ThucPhamKho("Xoài sấy dẻo", 26000, "sấy lạnh"));

        foreach (ThucPham v in list)
            Console.WriteLine(v.inTT());
        Console.WriteLine("====");
        foreach (ThucPham v in list)
            Console.WriteLine(v.tinhGia()+" VNĐ");
    }
}