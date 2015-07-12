using DDDInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentists.Models.Patient
{
    public class Patient : IAggregateRoot
    {
        public string Name { get; set; }
        /// <summary>
        /// 患者身份证号
        /// </summary>
        public string CreditID { get; set; }
        /// <summary>
        /// 患者编号
        /// </summary>
        public string PatientNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string CellPhoneNumber { get; set; }
        public string HousePhoneNumber { get; set; }
        /// <summary>
        /// 症状描述
        /// </summary>
        public string Symptom { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// 医师表，表结构会更改， 最好是一个引用。
        /// </summary>
        public Guid DoctorID { get; set; }
        /// <summary>
        /// 疾病信息表，表结构会更改，最好是一个引用。
        /// </summary>
        public Guid Disease { get; set; }
        private Guid id;
        public Guid ID
        {
            get
            {
                if (id == default(Guid)) id = Guid.NewGuid();
               return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
