using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Biodata
            String nama, kls, npm, sks;
            //proses input biodata
            Console.WriteLine("                      TRANSKRIP NILAI AKADEMIK SEMESTER 1                         ");
            Console.WriteLine("==================================================================================");
            Console.Write(" Inputkan Nama Anda          : ");
            nama = Console.ReadLine();
            Console.Write(" Inputkan Kelas Anda         : ");
            kls = Console.ReadLine();
            Console.Write(" Inputkan Npm Anda           : ");
            npm = Console.ReadLine();
            Console.Write(" Inputkan Jumlah SKS Anda    : ");
            sks = Console.ReadLine();
            Console.WriteLine("\n");

            /* 
             * Dekalrasi Variabel Untuk Mata Kuliah Pendidikan Pancasila
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran dan Nilai Akhir 
            */
            Int32 pputs, ppuas, ppt, ppk, ppa;
            //input
            Console.WriteLine(" Berikut Terlampir Mata Kuliah : ");
            Console.WriteLine("\n\t PENDIDIKAN PANCASILA");
            Console.Write("      Inputkan Nilai UTS          : ");
            pputs = Convert.ToInt32(Console.ReadLine());
            Console.Write("      Inputkan Nilai UAS          : ");
            ppuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("      Inputkan Nilai Tugas        : ");
            ppt = Convert.ToInt32(Console.ReadLine());
            Console.Write("      Inputkan NIlai Kehadiran    : ");
            ppk = Convert.ToInt32(Console.ReadLine());
            ppa = (pputs + ppuas + ppt + ppk) / 4;  // Rumus Nilai Akhir
            Console.WriteLine(" Nilai Akhir Mata Kuliah Pendidikan Pancasila adalah : " + ppa + "\n");
            
            /* 
             * Deklarasi Variabel Untuk Mata Kuliah Pendidikan Agama
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran Nilai Akhir 
            */
            Int32 pauts, pauas, pat, pak, paa;
            //Input
            Console.WriteLine("\n\t PENDIDIKAN AGAMA");
            Console.Write("     Inputkan Nilai UTS           : ");
            pauts = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS           : ");
            pauas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas         : ");
            pat = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran     : ");
            pak = Convert.ToInt32(Console.ReadLine());
            paa = (pauts + pauas + pat + pak) / 4;  //Rumus Nilai Akhir
            Console.WriteLine(" Nilai Akhir Mata Kuliah Pendidikan Pancasila adalah : " + paa + "\n");

            /*
             * Dekalarasi Variabel Untuk Nilai Mata Kuliah Analisa Proses Bisnis
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 apbuts, apbuas, apbt, apbk, apba;
            //input
            Console.WriteLine("\n\t ANALISA PROSES BISNIS");
            Console.Write("     Inputkan Nilai UTS          : ");
            apbuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            apbuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            apbt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            apbk = Convert.ToInt32(Console.ReadLine());
            apba = (apbuts + apbuas + apbt + apbk) / 4;
            Console.WriteLine(" Nilai Akhir Mata Kuliah Analisa Proses Bisnis adalah : " + apba + "\n");

            /*
             * Deklarasi Variabel Untuk Nilai Mata Kuliah Dasar-dasar Pemrograman 1
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran, & Nilai Akhir 
            */
            Int32 ddputs, ddpuas, ddpt, ddpk, ddpa;
            // input
            Console.WriteLine("\n\t DASAR-DASAR PEMROGRAMAN 1");
            Console.Write("     Inputkan Nilai UTS          : ");
            ddputs = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            ddpuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan NIlai Tugas        : ");
            ddpt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            ddpk = Convert.ToInt32(Console.ReadLine());
            ddpa = (ddputs + ddpuas + ddpt + ddpk) / 4;
            Console.WriteLine(" Nilai Akhir Mata Kuliah Dasar-dasar Pemrograman 1 adalah : " + ddpa + "\n");

            /*
             * Deklarasi Variabel Untuk Nilai Mata Kuliah Praktikum Dasar-dasar Pemrograman 1
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 pddputs, pddpuas, pddpt, pddpk, pddpa;
            // Input
            Console.WriteLine("\n\t PRAKTIKUM DASAR-DASAR PEMROGRAMAN 1");
            Console.Write("     Inputkan Nilai UTS          : ");
            pddputs = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            pddpuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            pddpt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            pddpk = Convert.ToInt32(Console.ReadLine());
            pddpa = (pddputs + pddpuas + pddpt + pddpk) / 4;
            Console.WriteLine(" Jadi Nilai Akhir Mata Kuliah Praktikium Dasar-dasar Pemrograman 1 adalah : " + pddpa + "\n");

            /*
             * Deklarasi Variabel Untuk Nilai Mata Kuliah Matematika Diskrit
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 mduts, mduas, mdt, mdk, mda;
            // Input
            Console.WriteLine("\n\t MATEMATIKA DISKRIT");
            Console.Write("     Inputkan Nilai UTS          : ");
            mduts = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            mduas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            mdt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            mdk = Convert.ToInt32(Console.ReadLine());
            mda = (mduts + mduas + mdt + mdk) / 4;
            Console.WriteLine(" Jadi Nilai Akhir Mata Kuliah Matematika Diskrit adalah : " + mda + "\n");

            /*
             * Deklarasi Varibel Untuk Nilai Bahasa Indonesia
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 biuts, biuas, bit, bik, bia;
            // Input
            Console.WriteLine("\n\t BAHASA iNDONESIA");
            Console.Write("     Inputkan Nilai UTS          : ");
            biuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            biuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            bit = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            bik = Convert.ToInt32(Console.ReadLine());
            bia = (biuts + biuas + bit + bik) / 4;
            Console.WriteLine(" Jadi Nilai Akhir Mata Kuliah Bahasa Indonesia adalah : " + bia + "\n");

            /*
             * Deklarasi Variabel Untuk Nilai Pengantar Teknologi Sistem Informasi
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 ptuts, ptuas, ptt, ptk, pta;
            // Input
            Console.WriteLine("\n\t PENGANTAR TEKNOLOGI SISTEM INFORMASI");
            Console.Write("     Inputkan Nilai UTS          : ");
            ptuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            ptuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            ptt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            ptk = Convert.ToInt32(Console.ReadLine());
            pta = (ptuts + ptuas + ptt + ptk) / 4;
            Console.WriteLine(" Jadi Nilai Akhir Mata Kuliah Pengantar Teknologi Sistem Informasi : " + pta + "\n\n");

            /*
             * Dekalarsi Variabel Untuk Nilai TOEFL Preparation
             * Terdiri dari Nilai UTS, UAS, Tugas, Kehadiran & Nilai Akhir
            */
            Int32 tputs, tpuas, tpt, tpk, tpa;
            // Input
            Console.WriteLine("\n\t TOEFL PREPARATION");
            Console.Write("     Inputkan Nilai UTS          : ");
            tputs = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai UAS          : ");
            tpuas = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Tugas        : ");
            tpt = Convert.ToInt32(Console.ReadLine());
            Console.Write("     Inputkan Nilai Kehadiran    : ");
            tpk = Convert.ToInt32(Console.ReadLine());
            tpa = (tputs + tpuas + tpt + tpk) / 4;
            Console.WriteLine(" Jadi Nilai Akhir Mata Kuliah TOEFL Preparation adalah : " + tpa + "\n\n");
            

            // Rekapitulasi Nilai Akhir
            Console.WriteLine("==================================================================================");
            Console.WriteLine("|            REKAPITULASI NILAI AKHIR DARI SEMUA MATA KULIAH SEMESTER 1          |");
            Console.WriteLine("==================================================================================");
            Console.WriteLine("Nilai Akhir Mata Kuliah Pendidikan Pancasila adalah                  : " + ppa);
            Console.WriteLine("Nilai Akhir Mata Kuliah Pendidikan Agama adalah                      : " + paa);
            Console.WriteLine("Nilai Akhir Mata Kuliah Analisa Proses Bisnis adalah                 : " + apba);
            Console.WriteLine("Nilai Akhir Mata Kuliah Dasar-dasar Pemrograman 1 adalah             : " + ddpa);
            Console.WriteLine("Nilai Akhir Mata Kuliah Praktikum Dasar-dasar Pemrograman 1 adalah   : " + pddpa);
            Console.WriteLine("Nilai Akhir Mata Kuliah Matematika Diskrit adalah                    : " + mda);
            Console.WriteLine("Nilai Akhir Mata Kuliah Bahasa Indonesia adalah                      : " + bia);
            Console.WriteLine("Nilai Akhir Mata Kuliah Pengantar Teknologi Sistem Informasi adalah  : " + pta);
            Console.WriteLine("Nilai Akhir Mata Kuliah TOEFL Preparation adalah                     : " + tpa);
            Console.WriteLine("==================================================================================\n");

            Console.ReadKey();
        }
    }
}
