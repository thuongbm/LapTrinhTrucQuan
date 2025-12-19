using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Đề_03
{
    internal class ProcessDatabase
    {
        SqlConnection sqlConnect = null;

        // CHÚ Ý DÒNG NÀY:
        // Sửa chuỗi kết nối để trỏ đến file DuLieu.mdf của bạn.
        // |DataDirectory| sẽ tự động tìm file .mdf trong thư mục project
        string strConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LapTrinhTrucQuan\Kiemtra\Đề_03\DuLieu.mdf;Integrated Security=True";

        //Hàm mở kết nối CSDL
        private void KetNoiCSDL()


        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }//Hàm đóng kết nối CSDL
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }

        //Hàm thực thi câu lệnh dạng Select trả về một DataTable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, sqlConnect);
            sqldataAdapte.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }

        //Hàm thực lệnh insert hoặc update hoặc delete
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
    }
}
