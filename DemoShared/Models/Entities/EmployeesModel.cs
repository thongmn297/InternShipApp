using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShared.Models.Entities
{
    [Table("m_employees")]
    public class EmployeesModel
    {
        [Key]
        [Column("EMP_NO")]
        [MaxLength(8)]
        public required string emp_no { get; set; }

        [Column("USR_NAME")]
        [MaxLength(20)]
        public string? emp_name { get; set; }

        [Column("USR_NAME_KATA")]
        [MaxLength(40)]
        public string? emp_name_kana { get; set; }

        // 1 : Female, 0 : Male
        [Column("SEX")]
        [MaxLength(1)]
        public string? sex { get; set; }

        [Column("DATE_OF_BIRTH")]
        public DateTime? birthday { get; set; }

        [Column("HIRE_DATE")]
        public DateTime? hire_date { get; set; }

        [Column("CPN_ID")]
        [MaxLength(8)]
        public string? company_id { get; set; }

        [Column("POST_CD")]
        [MaxLength(5)]
        public string? post_cd { get; set; }

        // 1 : Yes, 0 : No
        [Column("RETIED")]
        [MaxLength(1)]
        public string? is_retired { get; set; }

        [Column("CRE_BY")]
        public string? created_by { get; set; }

        [Column("UPD_BY")]
        public string? updated_by { get; set; }

        [Column("CRE_DT")]
        public DateTime? created_at { get; set; }

        [Column("UPD_DT")]
        public DateTime? updated_at { get; set; }
    }
}
