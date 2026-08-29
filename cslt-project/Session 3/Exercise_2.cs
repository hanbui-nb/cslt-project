using System;
using System.Collections.Generic;
using System.Text;

namespace cslt_project.Session_3
{
    internal class Exercise_2
    {
        static void Bai_1()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh)    : "); bool check1 = decimal.TryParse(Console.ReadLine(), out decimal chisocu);
            Console.Write("Nhập chỉ số điện mới (kWh)   : "); bool check2 = decimal.TryParse(Console.ReadLine(), out decimal chisomoi);
            while (!check1 || !check2 || chisocu < 0 || chisomoi < 0 || chisomoi < chisocu) {
                if (!check1 || !check2) {
                    Console.WriteLine("Sai định dạng, chỉ nhập số. Vui lòng nhập lại!");
                }
                else if (chisocu < 0 || chisomoi < 0 || chisomoi < chisocu) {
                    Console.WriteLine("Kiểm tra lại chỉ số điện (kWh). Vui lòng nhập lại!");
                }
                Console.Write("Nhập chỉ số điện cũ (kWh)    : "); check1 = decimal.TryParse(Console.ReadLine(), out chisocu);
                Console.Write("Nhập chỉ số điện mới (kWh)   : "); check2 = decimal.TryParse(Console.ReadLine(), out chisomoi);
            }
            decimal deltadien = chisomoi - chisocu, bacdien, chuathue;
            bacdien = Math.Min(deltadien, 50);
            chuathue = bacdien * 1806;
            bacdien = Math.Max(0, Math.Min(deltadien, 100) - 50);
            chuathue = bacdien * 1866 + chuathue;
            bacdien = Math.Max(0, Math.Min(deltadien, 200) - 100);
            chuathue = bacdien * 2167 + chuathue;
            bacdien = Math.Max(0, Math.Min(deltadien, 300) - 200);
            chuathue = bacdien * 2729 + chuathue;
            bacdien = Math.Max(0, deltadien - 300);
            chuathue = bacdien * 3050 + chuathue;
            Console.WriteLine($"Số điện tiêu thụ            : {deltadien} kWh");
            Console.WriteLine($"Tiền điện chưa thuế         : {chuathue:C0}");
            Console.WriteLine($"Thuế VAT (8%)               : {chuathue * 0.08m:C0}");
            Console.WriteLine($"Tổng thanh toán             : {chuathue * 1.08m:C0}");
        }
        static void Bai_2()
        {
            Console.Write("Chiều cao (m)    : "); bool check1 = double.TryParse(Console.ReadLine(), out double height);
            Console.Write("Cân nặng (kg)    : "); bool check2 = double.TryParse(Console.ReadLine(), out double weigh);
            while (!check1 || !check2 || height <= 0 || weigh <= 0)
            {
                if (!check1 || !check2)
                {
                    Console.WriteLine("Sai định dạng, chỉ nhập số. Vui lòng nhập lại!");
                }
                else if (height <= 0 || weigh <= 0)
                {
                    Console.WriteLine("Kiểm tra lại thông tin. Vui lòng nhập lại!");
                }
            }
                Console.Write("Chiều cao (m)    : "); check1 = double.TryParse(Console.ReadLine(), out height);
                Console.Write("Cân nặng (kg)    : "); check2 = double.TryParse(Console.ReadLine(), out weigh);
            double bmi = Math.Round(weigh / Math.Pow(height, 2),2);
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi}");
            switch (bmi) {
                case double x when x < 18.5:
                    Console.WriteLine("Phân loại sức khỏe: Gầy (Thiếu cân");
                    break;
                case double x when 23.0 <= x && x < 25.0:
                    Console.WriteLine("Phân loại sức khỏe: Thừa cân (Tiền béo phì)");
                    break;
                default:
                    Console.WriteLine("Phân loại sức khỏe: Béo phì");
                    break;
            }
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {Math.Round(18.5 * Math.Pow(height, 2), 2)} kg đến {Math.Round(22.9 * Math.Pow(height, 2), 2)} kg.");
        }
        enum CurrencyType
        {
            USD = 1, 
            EUR, 
            JPY, 
            GBP
        }
        static void Bai_3()
        {
            const decimal usd = 25400m, eur = 27200m, jpy = 165m, gbp = 32100m;
            Console.Write("Nhập số tiền VNĐ: "); bool check1 = decimal.TryParse(Console.ReadLine(), out decimal vnd);
            while (!check1 || vnd < 0)
            {
                if (!check1)
                {
                    Console.WriteLine("Sai định dạng, chỉ nhập số. Vui lòng nhập lại!");
                }
                else if (vnd < 0)
                {
                    Console.WriteLine("Kiểm tra lại số tiền VNĐ. Vui lòng nhập lại!");
                }
                Console.Write("Nhập số tiền VNĐ: "); check1 = decimal.TryParse(Console.ReadLine(), out vnd);
            }
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): "); bool check2 = int.TryParse(Console.ReadLine(), out int choice);
            while (!check2 || choice < 1 || choice > 4)
            {
                if (!check2)
                {
                    Console.WriteLine("Sai định dạng, chỉ nhập số. Vui lòng nhập lại!");
                }
                else if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Kiểm tra lại mã ngoại tệ, danh sách có thể quy đổi: 1-USD, 2-EUR, 3-JPY, 4-GBP. Vui lòng nhập lại!");
                }
                Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): "); check2 = int.TryParse(Console.ReadLine(), out choice);
            }
            Console.WriteLine($"Phí dịch vụ (0.5%)      : {vnd * 0.5m / 100}");
            Console.WriteLine($"Số tiền VNĐ tính đổi    : {vnd * 99.5m / 100}");
            switch (choice) {
                case (int)CurrencyType.USD:
                    Console.WriteLine($"Số tiền USD nhận được: Math.Round({vnd / usd}, 2) {(CurrencyType)choice}");
                    break;
                case (int)CurrencyType.EUR:
                    Console.WriteLine($"Số tiền EUR nhận được: Math.Round({vnd / eur}, 2) {(CurrencyType)choice}");
                    break;
                case (int)CurrencyType.JPY:
                    Console.WriteLine($"Số tiền JPY nhận được: Math.Round({vnd / jpy}, 2) {(CurrencyType)choice}");
                    break;
                default:
                    Console.WriteLine($"Số tiền GBP nhận được: Math.Round({vnd / gbp}, 2) {(CurrencyType)choice}");
                    break;
            }
        }
        static void Bai_4() 
        {
            string format = "dd/MM/yyyy";
            DateTime dob;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                bool check = DateTime.TryParseExact(Console.ReadLine(), format, null, System.Globalization.DateTimeStyles.None, out dob);
                if (check)
                {
                    break;
                }    
            }
            TimeSpan delta = DateTime.Now.Date - dob;
            DateTime birthday = new DateTime(DateTime.Today.Year, dob.Month, dob.Day);
            DateTime nextbirthday = birthday.AddYears(1);
            int age = DateTime.Today.Year - dob.Year;
            int daysleft = (int) (birthday - DateTime.Now.Date).TotalDays;
            if (birthday > DateTime.Now.Date)
            {
                Console.WriteLine($"Tuổi hiện tại: {age - 1} tuổi");
                Console.WriteLine($"Bạn đã sống tổng cộng: {(int)(delta).TotalDays} ngày");
                Console.WriteLine($"Sinh nhật tiếp theo còn: {daysleft} ngày");
            }
            else if (birthday <= DateTime.Now.Date)
            {
                Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
                Console.WriteLine($"Bạn đã sống tổng cộng: {(int)(delta).TotalDays} ngày");
                Console.WriteLine($"Sinh nhật tiếp theo còn: {(int) (nextbirthday - DateTime.Now.Date).TotalDays} ngày");
            }
        }
        enum XepLoai
        {
            Kiem,
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        }
        static void Bai_5()
        {
            int tcCSharp = 4;
            int tcToan = 3;
            int tcTiengAnh = 2;

            Console.WriteLine("=== NHẬP ĐIỂM CÁC MÔN HỌC (THANG 10) ===");
            Console.Write($"Lập trình C# ({tcCSharp} TC): ");
            double diemCSharp = double.Parse(Console.ReadLine());

            Console.Write($"Toán rời rạc ({tcToan} TC): ");
            double diemToan = double.Parse(Console.ReadLine());

            Console.Write($"Tiếng Anh ({tcTiengAnh} TC): ");
            double diemTiengAnh = double.Parse(Console.ReadLine());

            // 2. TÍNH ĐIỂM TRUNG BÌNH TRỌNG SỐ (GPA THANG 10)
            int tongTinChi = tcCSharp + tcToan + tcTiengAnh;
            double scoreAvg = (diemCSharp * tcCSharp + diemToan * tcToan + diemTiengAnh * tcTiengAnh) / tongTinChi;

            // 3. LOGIC QUY ĐỔI ĐIỂM CHỮ, THANG 4 VÀ ENUM XẾP LOẠI
            char diemChu;
            double gpaThang4;
            XepLoai xepLoaiHocLuc;

            if (scoreAvg >= 8.5)
            {
                diemChu = 'A';
                gpaThang4 = 4.0;
                xepLoaiHocLuc = XepLoai.Gioi;
            }
            else if (scoreAvg >= 7.0)
            {
                diemChu = 'B';
                gpaThang4 = 3.0;
                xepLoaiHocLuc = XepLoai.Kha;
            }
            else if (scoreAvg >= 5.5)
            {
                diemChu = 'C';
                gpaThang4 = 2.0;
                xepLoaiHocLuc = XepLoai.TrungBinh;
            }
            else if (scoreAvg >= 4.0)
            {
                diemChu = 'D';
                gpaThang4 = 1.0;
                xepLoaiHocLuc = XepLoai.Yeu;
            }
            else
            {
                diemChu = 'F';
                gpaThang4 = 0.0;
                xepLoaiHocLuc = XepLoai.Kiem;
            }

            // 4. XUẤT BẢNG ĐIỂM CHI TIẾT VÀ KẾT QUẢ
            Console.WriteLine("\n================ BẢNG ĐIỂM CHUẨN ================");

            // Căn lề cột: Môn học (-18), Số TC (8), Điểm (10)
            string headerFormat = "{0,-18} | {1,8} | {2,10}";
            Console.WriteLine(headerFormat, "Tên Môn Học", "Số TC", "Điểm Số");
            Console.WriteLine(new string('-', 45));

            Console.WriteLine(headerFormat, "Lập trình C#", tcCSharp, diemCSharp.ToString("F1"));
            Console.WriteLine(headerFormat, "Toán rời rạc", tcToan, diemToan.ToString("F1"));
            Console.WriteLine(headerFormat, "Tiếng Anh", tcTiengAnh, diemTiengAnh.ToString("F1"));

            Console.WriteLine(new string('-', 45));

            // In kết quả tổng hợp làm tròn 2 chữ số thập phân (`:F2`)
            Console.WriteLine($"\n--- KẾT QUẢ TỔNG HỢP ---");
            Console.WriteLine($"Điểm TB Thang 10 : {scoreAvg:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi : {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4 : {gpaThang4:F1}");
            Console.WriteLine($"Xếp Loại Học Lực : {DichXepLoai(xepLoaiHocLuc)}");
            static string DichXepLoai(XepLoai xl)
            {
                return xl switch
                {
                    XepLoai.Gioi => "Giỏi / Xuất sắc",
                    XepLoai.Kha => "Khá",
                    XepLoai.TrungBinh => "Trung bình",
                    XepLoai.Yeu => "Yếu",
                    _ => "Kém (Trượt)"
                };
            }
        }
        public static void Main3(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
        }
    }
}
