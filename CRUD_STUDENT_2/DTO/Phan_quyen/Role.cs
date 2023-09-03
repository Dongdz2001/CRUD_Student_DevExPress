using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_STUDENT_2.DTO.Phan_quyen
{
    [Dapper.Contrib.Extensions.Table("tbl_roleUser")]

    internal class Role
    {
        [Key]
        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}
