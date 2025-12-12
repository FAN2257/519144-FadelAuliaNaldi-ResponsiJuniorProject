using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2
{
    internal class Developer
    {
        private string _nama_developer;
        private string _id_proyek;
        private bool _status_kontrak;
        private int _fitur_selesai;
        private int _jumlah_bug;


        public Developer(string nama_developer, string id_proyek, bool status_kontrak, int fitur_selesai, int jumlah_bug) {
            this._nama_developer = nama_developer;
            this._id_proyek = id_proyek;
            this._status_kontrak = status_kontrak;
            this._fitur_selesai = fitur_selesai;
            this._jumlah_bug = jumlah_bug;
        }
        public Developer(string name) { }


    }
}
