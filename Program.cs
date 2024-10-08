internal class Program
{
    private static void Main(string[] args)
    {
        string[] hocsinh = {"Viet", "Chien", "Vu", "Nam", "Nguyen", "Nga", "Linh", "Tran Anh"};
        Console.Write($"Nhap ten hoc sinh: ");
        string tenHocSinh = Console.ReadLine();
        bool duyetmang = false;
        for(int i = 0; i < hocsinh.Length; i++){
            if(hocsinh[i].Equals(tenHocSinh)){
                Console.WriteLine($"Hoc sinh '{tenHocSinh}' co trong mang.");
                duyetmang = true;
                break;
            }
        }
        if(!duyetmang){
            Console.WriteLine($"Hoc sinh '{tenHocSinh}' khong co trong mang.");
        }
    }
}