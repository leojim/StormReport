# Storm Report - Generate your reports in EXCEL and PDF using only Annotations in ASP NET MVC.

# How to install
```C#
 
```

# How to use
```C#
 [ReportTitleStyle(styles: "text-align: center; padding: 5px 0px 5px 0px;")]
 public class MockCustomerTest
 {
     private List<MockCustomerTest> List { get; set; }

     public MockCustomerTest()
     {
         List = new List<MockCustomerTest>();
     }

     [ExportableColumnHeaderName(description: "Customer Name")]
     [ExportableColumnHeaderStyle(styles: "text-align: center; color: black; font-size: 17px; background-color: yellow;")]
     [ExportableColumnContentStyle(styles: "text-align: center; color: black; font-size: 17px;")]
     [ExportableColumnGroup(description: "Customer", styles: "color: white; text-align: center; background-color: gray;")]
     public string Nome { get; set; }

     [ExportableColumnHeaderName(description: "Customer Age")]
     [ExportableColumnHeaderStyle(styles: "text-align: center; color: black; font-size: 17px; background-color: yellow;")]
     [ExportableColumnContentStyle(styles: "text-align: center; color: black; font-size: 17px; mso-number-format:'0.000'")]
     [ExportableColumnGroup(description: "Customer",styles: "color: white; text-align: center; background-color: gray;")]
     [ExportableAddtionalText(description: " Year", direction: AdditionalTextEnum.RIGHT)]
     public int Idade { get; set; }

     [ExportableColumnHeaderName(description: "Customer City")]
     [ExportableColumnHeaderStyle(styles: "text-align: center; color: black; font-size: 17px; background-color: yellow;")]
     [ExportableColumnContentStyle(styles: "text-align: center; color: black; font-size: 17px;")]
     [ExportableColumnGroup(description: "Address",styles: "color: white; text-align: center; background-color: gray;")]
     public string Cidade { get; set; }

     [ExportableColumnHeaderName(description: "Customer State")]
     [ExportableColumnHeaderStyle(styles: "text-align: center; color: black; font-size: 17px; background-color: yellow;")]
     [ExportableColumnContentStyle(styles: "text-align: center; color: black; font-size: 17px;")]
     [ExportableColumnGroup(description: "Address",styles: "color: white; text-align: center; background-color: gray;")]
     public string Estado { get; set; }

     public void Add(MockCustomerTest e)
     {
         List.Add(e);
     }

     public List<MockCustomerTest> GetList()
     {
         return List;
     }
 }
```

```C#
public ActionResult GenerateReport()
{
   var customer1 = new MockCustomerTest
   {
       Cidade = "Ibiúna",
       Estado = "SP",
       Idade = 10,
       Nome = "Mike"
   };
   var customer2 = new MockCustomerTest
   {
       Cidade = "Sorocaba",
       Estado = "SP",
       Idade = 28,
       Nome = "Mike Lima"
   };
   var customerList = new List<MockCustomerTest>();
   customerList.Add(customer1);
   customerList.Add(customer2);
   var rep = new StormExcel("Customer Description : " + DateTime.Now);
   rep.CreateExcel(customerList, this.Response);
   return View();
}

excel: https://drive.google.com/file/d/0B3fZDB3QKwrlejJ5T0thVlBZY1E/view?usp=sharing
pdf: https://drive.google.com/file/d/0B3fZDB3QKwrlTDk5NWQ0VkhmNzg/view?usp=sharing

```

### Excel column format type.
```Html
 mso-number-format:'0'	NO Decimals
 mso-number-format:'0.000'	3 Decimals
 mso-number-format:'#,##0.000'	Comma with 3 dec
 mso-number-format:'mm/dd/yy'	Date7
 mso-number-format:'mmmm\ d,\ yyyy' Date9
 mso-number-format:'m/d/yy\ h:mm\ AM/PM'	D -T AMPM
 mso-number-format:'Short Date'	01/03/1998
 mso-number-format:'Medium Date'	01-mar-98
 mso-number-format:'d-mmm-yyyy'	01-mar-1998
 mso-number-format:'Short Time'	5:16
 mso-number-format:'Medium Time'	5:16 am
 mso-number-format:'Long Time'	5:16:21:00
 mso-number-format:'Percent'	Percent - two decimals
 mso-number-format:'0%'	Percent - no decimals
 mso-number-format:'0.E+00'	Scientific Notation
 mso-number-format:'@'	Text
 mso-number-format:'#\ ???/???'	Fractions - up to 3 digits (312/943)
 mso-number-format:'\0022£\0022#,##0.00'	£12.76
 mso-number-format:'#,##0.00_ ;[Red]-#,##0.00\ ' 2 decimals, negative numbers in red and signed
```

#### Used versions

##### C# 
version: `4.0`
<hr>

### License

It is available under the MIT license.
[License](https://opensource.org/licenses/mit-license.php)
