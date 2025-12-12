using Npgsql;
using System;
using System.Data;

namespace Responsi2
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=5Juli2005;Database=responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connString);



        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvData.DataSource = null;
            sql = "select * from st_select()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();

            try
            {
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from st_insert(:_nama_dev, :_id_proyek, :_status_kontrak, :_fitur_selesai, :_jumlah_bug)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_nama_dev", tb_namaDeveloper.Text);
                cmd.Parameters.AddWithValue("_id_proyek", cb_proyek.Text);
                cmd.Parameters.AddWithValue("_status_kontrak", cb_statusKontrak.Text);
                cmd.Parameters.AddWithValue("_fitur_selesai", int.Parse(tb_fiturSelesai.Text));
                cmd.Parameters.AddWithValue("_jumlah_bug", int.Parse(tb_jumlahBug.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil Disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_load.PerformClick();
                    tb_namaDeveloper.Clear();
                    cb_proyek.SelectedIndex = -1;
                    cb_statusKontrak.SelectedIndex = -1;
                    tb_fiturSelesai.Clear();
                    tb_jumlahBug.Clear();
                }
                else
                {
                    MessageBox.Show("Data Gagal Disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb_fiturSelesai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_namaDeveloper_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_proyek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_statusKontrak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_statusKontrak.SelectedItem != null)
            {
                string selectedStatus = cb_statusKontrak.SelectedItem.ToString();
                if (selectedStatus == "Kontrak")
                {
                    tb_fiturSelesai.Enabled = true;
                    tb_jumlahBug.Enabled = true;
                }
                else
                {

                }
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan diubah");
                return;
            }

            try
            {
                conn.Open();
                sql = "select * from st_update(:_id_dev, :_nama_dev, :_id_proyek, :_status_kontrak, :_fitur_selesai, :_jumlah_bug)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_dev", int.Parse(r.Cells["id_developer"].Value.ToString()));
                cmd.Parameters.AddWithValue("_nama_dev", tb_namaDeveloper.Text);
                cmd.Parameters.AddWithValue("_id_proyek", cb_proyek.Text);
                cmd.Parameters.AddWithValue("_status_kontrak", cb_statusKontrak.Text);
                cmd.Parameters.AddWithValue("_fitur_selesai", int.Parse(tb_fiturSelesai.Text));
                cmd.Parameters.AddWithValue("_jumlah_bug", int.Parse(tb_jumlahBug.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil Diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_load.PerformClick();
                    tb_namaDeveloper.Clear();
                    cb_proyek.SelectedIndex = -1;
                    cb_statusKontrak.SelectedIndex = -1;
                    tb_fiturSelesai.Clear();
                    tb_jumlahBug.Clear();
                    r = null;
                }
                else
                {
                    MessageBox.Show("Data Gagal Diubah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tb_namaDeveloper.Text = r.Cells["_nama_dev"].Value.ToString();
                cb_proyek.Text = r.Cells["_id_proyek"].Value.ToString();
                cb_statusKontrak.Text = r.Cells["_status_kontrak"].Value.ToString();
                tb_fiturSelesai.Text = r.Cells["_fitur_selesai"].Value.ToString();
                tb_jumlahBug.Text = r.Cells["_jumlah_bug"].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus");
                return;
            }

            try
            {
                conn.Open();
                sql = "select * from st_delete(:_id_dev)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_dev", int.Parse(r.Cells["_id_dev"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil Dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btn_load.PerformClick();
                    tb_namaDeveloper.Clear();
                    cb_proyek.SelectedIndex = -1;
                    cb_statusKontrak.SelectedIndex = -1;
                    tb_fiturSelesai.Clear();
                    tb_jumlahBug.Clear();
                    r = null;
                }
                else
                {
                    MessageBox.Show("Data Gagal Dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
