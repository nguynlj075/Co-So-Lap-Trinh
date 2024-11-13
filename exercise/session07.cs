

internal class Exercise07
{
    static void NhapMangTuDong(int[,] a, int rows, int columns)
    {
        Random random = new Random();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = random.Next(1,100);
            }    
        }    
    }
    static void Xuatmang(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void InDong(int[,] a, int rowIndex)
    {
        if (rowIndex >= 0 && rowIndex < a.GetLength(0))
        {
            Console.WriteLine($"Dòng {rowIndex + 1}:");
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[rowIndex, j] + "\t");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("chi so dong khong hop le");
        }
    }
    static void InCot(int[,] a, int colIndex)
    {
        if (colIndex >= 0 && colIndex < a.GetLength(1))
        {
            Console.WriteLine($"Cột {colIndex + 1}:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine(a[i, colIndex]);
            }
        }
        else
        {
            Console.WriteLine("chi so cot khong hop le");
        }
    }
    private static void Main(string[] args)
    {
        Console.Write("Nhap so dong:"); int rows = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot:"); int columns = int.Parse(Console.ReadLine());
        int[,] a = new int[rows, columns];
        NhapMangTuDong(a, rows, columns) ;
        Xuatmang(a);
        // Yêu cầu người dùng chọn dòng hoặc cột cần in
        Console.WriteLine("Ban muon in dong(1) hay cot(2)?");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // In dòng
            Console.Write("Nhap so dong can in: ");
            int rowIndex = int.Parse(Console.ReadLine()) - 1; 
            InDong(a, rowIndex);
        }
        else if (choice == 2)
        {
            // In cột
            Console.Write("Nhap so cot can in: ");
            int colIndex = int.Parse(Console.ReadLine()) - 1; 
            InCot(a, colIndex);
        }
        else
        {
            Console.WriteLine("lua chon khong hop le");
        }

    }

}
