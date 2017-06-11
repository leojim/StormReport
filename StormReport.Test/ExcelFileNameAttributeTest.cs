﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace StormReport.Test
{
    [TestClass]
    public class ExcelFileNameAttributeTest
    {
        private Report report;
        private HttpResponseBase response;

        public ExcelFileNameAttributeTest()
        {
            report = new Report();
            response = Mock.Of<HttpResponseBase>();

            var textWriter = Mock.Of<TextWriter>();
            response.Output = textWriter;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GenerateExcelWithoutAnnotationName()
        {
            List<ClassTestWithoutName> list = GetWithoutExcelNameList();
            report.CreateExcelBase(list, response);
        }


        private static List<ClassTestWithoutName> GetWithoutExcelNameList()
        {
            var class1 = new ClassTestWithoutName { Cidade = "Ibiúna", Estado = "SP", Idade = 10, Nome = "Mike" };
            var class2 = new ClassTestWithoutName { Cidade = "Sorocaba", Estado = "SP", Idade = 28, Nome = "Mike Lima" };
            var list = new List<ClassTestWithoutName>();
            list.Add(class1);
            list.Add(class2);
            return list;
        }
    }
}