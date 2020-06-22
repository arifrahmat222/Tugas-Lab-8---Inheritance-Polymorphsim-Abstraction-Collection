using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugaslab8.ClassInduk
{
    public abstract class Karyawan
    {
        public int NIK { get; set; }
        public string NAMA { get; set; }
        public abstract double GAJI();
    }
}
