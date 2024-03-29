﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using epplusexcel.Models;

namespace epplusexcel.BLL
{
    //数据类
    public class StaticDataOfStudent
    {
        public static List<Student> ListStudent => new List<Student>
        {
            new Student {ID = 1, Name = "曹操", Sex = "男", Email = "caocao@163.com", Age = 24},
            new Student {ID = 2, Name = "李易峰", Sex = "女", Email = "lilingjie@sina.com.cn", Age = 24},
            new Student {ID = 3, Name = "张三丰", Sex = "男", Email = "zhangsanfeng@qq.com", Age = 224},
            new Student {ID = 4, Name = "孙权", Sex = "男", Email = "sunquan@163.com", Age = 1224},
        };
    }
}