﻿using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;

namespace StormReport.Test
{
    [ExcelFileName("ExcelReport", useDateTimeToAdditionalName: true)]
    public class ClassTest
    {
        private List<ClassTest> List { get; set; }

        public ClassTest()
        {
            List = new List<ClassTest>();
        }

        [ExportableColumnName("Nome do Cliente")]
        [ExportableColumnStyle("text-align: center;", "color: red;", "font-size: 17px;")]
        public string Nome { get; set; }

        [ExportableColumnName("Idade do Cliente")]
        public int Idade { get; set; }

        [ExportableColumnName("Cidade do Cliente")]
        public string Cidade { get; set; }

        [ExportableColumnName("Estado do Cliente")]
        public string Estado { get; set; }

        public void Add(ClassTest e)
        {
            List.Add(e);
        }

        public List<ClassTest> GetList()
        {
            return List;
        }
    }

    public class ClassTestWithoutName
    {
        private List<ClassTest> List { get; set; }

        public ClassTestWithoutName()
        {
            List = new List<ClassTest>();
        }

        [ExportableColumnName("Nome do Cliente")]
        public string Nome { get; set; }

        [ExportableColumnName("Idade do Cliente")]
        public int Idade { get; set; }

        [ExportableColumnName("Cidade do Cliente")]
        public string Cidade { get; set; }

        [ExportableColumnName("Estado do Cliente")]
        public string Estado { get; set; }

        public void Add(ClassTest e)
        {
            List.Add(e);
        }

        public List<ClassTest> GetList()
        {
            return List;
        }
    }
}
