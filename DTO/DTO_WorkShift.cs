using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_WorkShift
    {
        private static int numOf500K = 0;
        private static int numOf200K = 0;
        private static int numOf100K = 0;
        private static int numOf50K = 0;
        private static int numOf20K = 0;
        private static int numOf10K = 0;
        private static int numOf5K = 0;
        private static int numOf2K = 0;
        private static int numOf1K = 0;
        private static int numOf500 = 0;
        private static bool status = false;
        private static long money = 0;

     


        public static int NumOf500K { get => numOf500K; set => numOf500K = value; }
        public static int NumOf200K { get => numOf200K; set => numOf200K = value; }
        public static int NumOf100K { get => numOf100K; set => numOf100K = value; }
        public static int NumOf50K { get => numOf50K; set => numOf50K = value; }
        public static int NumOf20K { get => numOf20K; set => numOf20K = value; }
        public static int NumOf10K { get => numOf10K; set => numOf10K = value; }
        public static int NumOf5K { get => numOf5K; set => numOf5K = value; }
        public static int NumOf2K { get => numOf2K; set => numOf2K = value; }
        public static int NumOf1K { get => numOf1K; set => numOf1K = value; }
        public static int NumOf500 { get => numOf500; set => numOf500 = value; }
        public static bool Status1 { get => status; set => status = value; }
        public static long Money { get => money; set => money = value; }
    }
}
