using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_WorkShift
    {
        public void insertWorkShift(DTO_WorkShift workShift)
        {
            new DAL_WorkShift().insertWorkShift(workShift);
        }

        public void updateWorkShift(String workShiftID, float time)
        {
            new DAL_WorkShift().updateWorkShiftTime(workShiftID, time);
        }

        public void insertWorkShiftDetail(string workShiftID, long money, long sales, long moneyOfEnd)
        {
            new DAL_WorkShift().insertWorkShiftDetail(workShiftID, money, sales, moneyOfEnd);
        }
    }
}
