﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web;
using Moq;
using System.IO;

namespace StormReport.Test
{
    [TestClass]
    public class ReportByTest
    {
        private Report report;
        public ReportByTest()
        {
            report = new Report();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ResponseIsNull()
        {
            List<ClassTest> list = GetList();
            report.CreateExcelBase(list);
        }

        [TestMethod]
        public void teste()
        {
            var response = Mock.Of<HttpResponseBase>();

            var textWriter = Mock.Of<TextWriter>();
            response.Output = textWriter;

            List<ClassTest> list = GetList();
            report.CreateExcelBase(list, response);
        }

        private static List<ClassTest> GetList()
        {
            var class1 = new ClassTest { Cidade = "Ibiúna", Estado = "SP", Idade = 10, Nome = "Mike" };
            var class2 = new ClassTest { Cidade = "Sorocaba", Estado = "SP", Idade = 28, Nome = "Mike Lima" };
            var list = new List<ClassTest>();
            list.Add(class1);
            list.Add(class2);
            return list;
        }
    }
}
