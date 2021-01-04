using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_WorkShift
    {
        private string workShiftID;
        private string userID;
        private DateTime dateWork;
        private float beginAt;
        private float endAt;

        public string WorkShiftID { get => workShiftID; set => workShiftID = value; }
        public string UserID { get => userID; set => userID = value; }
        public DateTime DateWork { get => dateWork; set => dateWork = value; }
        public float BeginAt { get => beginAt; set => beginAt = value; }
        public float EndAt { get => endAt; set => endAt = value; }

        public DTO_WorkShift()
        {
            this.workShiftID = "";
            this.userID = "";
            this.beginAt = 0;
            this.endAt = 0;
            this.dateWork = DateTime.Now;

        }
        public DTO_WorkShift(string workShiftID, string userID, DateTime dateWork, float beginAt, float endAt)
        {
            this.WorkShiftID = workShiftID;
            this.UserID = userID;
            this.DateWork = dateWork;
            this.BeginAt = beginAt;
            this.EndAt = endAt;
        }
    }
}
