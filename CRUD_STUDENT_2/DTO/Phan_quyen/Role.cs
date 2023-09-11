using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_STUDENT_2.DTO.Phan_quyen
{
    [Dapper.Contrib.Extensions.Table("tbl_Role")]

    internal class Role
    {
        [Key]
        public string id { get; set; }
        public string role { get; set; }
    }
}
