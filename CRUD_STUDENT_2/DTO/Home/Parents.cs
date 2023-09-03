using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace CRUD_STUDENT_DEMO
{
    [Dapper.Contrib.Extensions.Table("tbl_parents")]
    internal class Parents
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public bool gender { get; set; }
    }
}
