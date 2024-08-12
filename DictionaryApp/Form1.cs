using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asus\source\repos\DictionaryApp\bin\Debug\TuDienLacViet.accdb";
        OleDbConnection sqlCon = null;

        //Ham ket noi
        public void OpenConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new OleDbConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        //Ham ngat ket noi
        public void CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Text = "VM0";
            OpenConnection();
            HienThiDanhSachTuDien();
        }

        private void HienThiDanhSachTuDien()
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from tbTuDienLacViet";
            sqlCmd.Connection = sqlCon;

            OleDbDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string english = reader.GetString(1);
                string shortVN = reader.GetString(2);
                string longVN = reader.GetString(3);

                ListViewItem lvi = new ListViewItem(id);
                lvi.SubItems.Add(english);
                lvi.SubItems.Add(shortVN);
                lvi.SubItems.Add(longVN);

                lsvDanhSach.Items.Add(lvi);
            }

            reader.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            OpenConnection();

            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into tbTuDienLacViet values(@id, @english, @shortVN, @longVN)";

            OleDbParameter parID = new OleDbParameter("@id", OleDbType.BSTR);
            parID.Value = txtID.Text.Trim();
            sqlCmd.Parameters.Add(parID);

            OleDbParameter parEnglish = new OleDbParameter("@english", OleDbType.BSTR);
            parEnglish.Value = txtEnglish.Text.Trim();
            sqlCmd.Parameters.Add(parEnglish);

            OleDbParameter parShortVN = new OleDbParameter("@shortVN", OleDbType.BSTR);
            parShortVN.Value = txtShortVN.Text.Trim();
            sqlCmd.Parameters.Add(parShortVN);

            OleDbParameter parLongVN = new OleDbParameter("@longVN", OleDbType.BSTR);
            parLongVN.Value = txtVN.Text.Trim();
            sqlCmd.Parameters.Add(parLongVN);

            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Thành công!");

                // Cập nhật dữ liệu mới vào ListView
                ListViewItem lvi = new ListViewItem(txtID.Text.Trim());
                lvi.SubItems.Add(txtEnglish.Text.Trim());
                lvi.SubItems.Add(txtShortVN.Text.Trim());
                lvi.SubItems.Add(txtVN.Text.Trim());
                lsvDanhSach.Items.Add(lvi);

                HienThiDanhSachTuDien();
                txtEnglish.Text = "";
                txtShortVN.Text = "";
                txtVN.Text = "";
                txtID.Text = "VM0";
                txtID.Focus();
            }
            else
            {
                MessageBox.Show("Thất Bại!");
            }
            CloseConnection();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   OpenConnection();

            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                txtID.Text = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
                txtEnglish.Text = lsvDanhSach.SelectedItems[0].SubItems[1].Text;
                txtShortVN.Text = lsvDanhSach.SelectedItems[0].SubItems[2].Text;
                txtVN.Text = lsvDanhSach.SelectedItems[0].SubItems[3].Text;
            }
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                try
                {
                    OpenConnection();

                    OleDbCommand sqlCmd = new OleDbCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "UPDATE tbTuDienLacViet SET English=@english, ShortVN=@shortVn, VN=@longVN WHERE ID=@id";


                    sqlCmd.Parameters.AddWithValue("@english", txtEnglish.Text);
                    sqlCmd.Parameters.AddWithValue("@shortVn", txtShortVN.Text);
                    sqlCmd.Parameters.AddWithValue("@longVN", txtVN.Text);
                    sqlCmd.Parameters.AddWithValue("@id", txtID.Text);

                    sqlCmd.Connection = sqlCon;
                    int kq = sqlCmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công!");

                        // Cập nhật dữ liệu mới trong ListView
                        lsvDanhSach.SelectedItems[0].SubItems[0].Text = txtID.Text;
                        lsvDanhSach.SelectedItems[0].SubItems[1].Text = txtEnglish.Text;
                        lsvDanhSach.SelectedItems[0].SubItems[2].Text = txtShortVN.Text;
                        lsvDanhSach.SelectedItems[0].SubItems[3].Text = txtVN.Text;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất một dòng dữ liệu để sửa!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            OpenConnection();

            if (lsvDanhSach.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa các mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    OleDbCommand sqlCmd = new OleDbCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "DELETE FROM tbTuDienLacViet WHERE id = @id";

                    sqlCmd.Connection = sqlCon;

                    try
                    {
                        foreach (ListViewItem item in lsvDanhSach.SelectedItems)
                        {
                            string id = item.SubItems[0].Text;

                            sqlCmd.Parameters.Clear();
                            OleDbParameter parID = new OleDbParameter("@id", OleDbType.BSTR);
                            parID.Value = id;
                            sqlCmd.Parameters.Add(parID);

                            int kq = sqlCmd.ExecuteNonQuery();
                            if (kq > 0)
                            {
                                // Xóa mục đã chọn khỏi ListView
                                lsvDanhSach.Items.Remove(item);
                            }
                        }

                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!");
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            OpenConnection();

            string inputWord = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(inputWord))
            {
                string query;
                string result = "Không tìm thấy từ trong từ điển.";

                bool isEnglish = IsEnglishWord(inputWord);

                try
                {
                    if (isEnglish)
                    {
                        query = "SELECT shortVN FROM tbTuDienLacViet WHERE english = @Word";
                    }
                    else
                    {
                        query = "SELECT english FROM tbTuDienLacViet WHERE shortVN = @Word OR longVN = @Word";
                    }

                    using (OleDbCommand command = new OleDbCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@Word", inputWord);
                        var meaning = command.ExecuteScalar();

                        if (meaning != null)
                        {
                            result = meaning.ToString();
                            // Kiểm tra xem từ ngữ nhập vào là tiếng Anh hay tiếng Việt
                            // Nếu là tiếng Anh, hiển thị kết quả tiếng Việt; ngược lại, hiển thị kết quả tiếng Anh
                            if (isEnglish)
                            {
                                result = meaning.ToString();
                            }
                            else
                            {
                                // Thực hiện tìm kiếm ngược lại trong cơ sở dữ liệu để lấy kết quả tiếng Anh
                                query = "SELECT english FROM tbTuDienLacViet WHERE shortVN = @Word OR longVN = @Word";
                                using (OleDbCommand reverseCommand = new OleDbCommand(query, sqlCon))
                                {
                                    reverseCommand.Parameters.AddWithValue("@Word", inputWord);
                                    var englishResult = reverseCommand.ExecuteScalar();
                                    if (englishResult != null)
                                    {
                                        result = englishResult.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tra từ điển: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtOutput.Text = result;
            }
        }

        private bool IsEnglishWord(string word)
        {
            foreach (char c in word)
            {
                if (char.IsLetter(c) && c < 128)
                {
                    return true;
                }
            }
            return false;
        }

    }
}