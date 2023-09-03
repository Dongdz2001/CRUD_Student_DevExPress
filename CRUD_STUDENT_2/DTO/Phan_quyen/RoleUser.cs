using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_STUDENT_2.DTO.Phan_quyen
{
    [Dapper.Contrib.Extensions.Table("tbl_Role_Users")]
    internal class RoleUser
    {
        [Key]
        public int id { get; set; }
        public string idUser { get; set; }
        public string idRole { get; set; }
    }
}
