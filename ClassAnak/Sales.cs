using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugaslab8.ClassAnak
{
    public class Sales : ClassInduk.Karyawan
    {
        public double jumlahpenjualan { get; set; }
        public double komisi { get; set; }
        public override double GAJI()
        {
            return komisi * jumlahpenjualan;
        }
    }
}
