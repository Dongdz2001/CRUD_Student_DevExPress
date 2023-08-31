using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_STUDENT_2
{
    internal static class Program
    {

        /* 
         Mã hóa:

            +   Chuẩn bị chuỗi kết nối: Trước tiên, bạn có chuỗi kết nối cần che giấu. Ví dụ: "gconnect-host.hopto.org"

            +   Đảo ngược chuỗi: Bước đầu tiên trong quá trình mã hóa là đảo ngược chuỗi kết nối. Tức là, bạn sẽ đảo ngược thứ tự của tất cả các ký tự trong chuỗi. Ví dụ: "groto-poth.gnohc-tcocnug"

            +   Mã hóa Unicode và Base64: Tiếp theo, bạn chuyển chuỗi đã đảo ngược thành một mảng các ký tự Unicode, sau đó mã hóa mảng này bằng Base64. Mã hóa Unicode là để đảm bảo rằng mọi ký tự trong chuỗi đều được đại diện bằng các giá trị số. Mã hóa Base64 là để chuyển dãy byte sang một dạng chữ số an toàn để lưu trữ hoặc truyền tải. Ví dụ: "7bC6LgD1TjF/Y1Sw5zP+2A==".

        Giải mã:

            +   Giải mã Base64 và Unicode: Đầu tiên, bạn giải mã chuỗi Base64 để nhận được mảng các byte. Sau đó, bạn chuyển mảng byte này thành chuỗi ký tự Unicode. Ví dụ: "groto-poth.gnohc-tcocnug"

            +   Đảo ngược chuỗi: Tiếp theo, bạn đảo ngược lại chuỗi Unicode đã nhận được để đưa nó trở lại đúng thứ tự ban đầu. Ví dụ: "gconnect-host.hopto.org"
         */
        private static string ReverseDecrypt(string encryptedInput)
        {
            string decodedString = Encoding.Unicode.GetString(Convert.FromBase64String(encryptedInput));
            char[] charArray = decodedString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VBSQLHelper.SQLHelper.SERVER_NAME = ReverseDecrypt("ZwByAG8ALgBvAHQAcABvAGgALgB0AHMAbwBoAC0AdABjAGUAbgBuAG8AYwBnAA==").ToString();
            VBSQLHelper.SQLHelper.DATABASE = ReverseDecrypt("dABzAGUAdABfAHQAYwBlAG4AbgBvAGMARwA=");
            VBSQLHelper.SQLHelper.USERNAME_DB = ReverseDecrypt("dABsAGwAcQA=");
            VBSQLHelper.SQLHelper.PASSWORD_DB = ReverseDecrypt("NgA1ADQAMwAyADEAQAB0AGwAbABxAA==");
            VBSQLHelper.SQLHelper.ConnectString();
            Application.Run(new LoginForm());
        }
    }
}
