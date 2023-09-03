﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_STUDENT_DEMO
{
    [Dapper.Contrib.Extensions.Table("tbl_student")]
    public class Student
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
