#pragma checksum "T:\RND05_1911\.NET\Practices\JqueryDataTable\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be8ca60a4b8202195161852b4bb26ec95d11988"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "T:\RND05_1911\.NET\Practices\JqueryDataTable\Views\_ViewImports.cshtml"
using JqueryDataTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\RND05_1911\.NET\Practices\JqueryDataTable\Views\_ViewImports.cshtml"
using JqueryDataTable.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be8ca60a4b8202195161852b4bb26ec95d11988", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8080e08973021ad4f284ee0b9bb271a5c0203c33", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JqueryDataTable.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "T:\RND05_1911\.NET\Practices\JqueryDataTable\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Student</h1>
<div class=""content-wrapper"">
    <table class=""table table-striped table-bordered"" id=""student_dataTable"" style=""width:100%"">
    </table>

</div> 

  
    <script>
    $.ajax({
        url: 'Student/GetStudent',
        type: 'GET',
        dataType: 'json',
        
     
        success: function (response) {
            //console.log(JSON.stringify(response));
            var Mycolumns = new Array();
            var TableHeader = ""<thead class='bg-gradient-lightblue'><tr>"";
            var footer = ""<tfoot><tr>""
            for (var key in response[0]) {
                var myObj = new Object();
                myObj.data = key;
                Mycolumns.push(myObj);
                TableHeader += ""<th>"" + key + ""</th>""
                footer += ""<th></th>""
            }

            TableHeader += ""</thead></tr>"";
            footer += ""</tfoot></tr>"";


            $(""#student_dataTable"").append(TableHeader);
            $(""#student_dataTable"").append");
            WriteLiteral(@"(footer);
            var numberRenderer = $('#student_dataTable').dataTable.render.number(',', '.', 2,).display;
            $('#student_dataTable').DataTable({

                columns: Mycolumns,
                data: response,

                ""autoWidth"": true,
                ""responsive"": true,
                ""aaSorting"": [],
                aLengthMenu: [
                    [25, 50, 100, 200, -1],
                    [25, 50, 100, 200, ""All""]
                ],

                iDisplayLength: 50,
");
            WriteLiteral(@"

                rowGroup: {
                    startRender: null,
                    endRender: function (rows, group, level) {
                        var api = rows;
                        var container = $('<tr/>');
                        container.append('<td colspan= ""3""> ' + group + '</td>');
                        var j;
                        var intVal = function (i) {
                            return typeof i === 'string' ?
                                i.replace(/[\%£,]/g, '') * 1 :
                                typeof i === 'number' ?
                                    i : 0;
                        };
                        for (j = 3; j < api.columns().header().length; j++) {
                            var RowGroupSum = rows
                                .data()
                                .pluck('marks1')
                                .reduce(function (a, b) {
                                    return intVal(a) + intVal(b);
                        ");
            WriteLiteral(@"        }, 0);

                            container.append('<td>' + RowGroupSum + '</td>');
                        }

                        return $(container)

                    },
                    dataSrc: 'department'
                },



                //dom: 'Blfrtip',
                dom: 'lBfrtip',

                ""footerCallback"": function (row, data, start, end, display, rows, group) {

         
                    var api = this.api(), data;
                    var intVal = function (i) {
                        return typeof i === 'string' ?
                            i.replace(/[\$,]/g, '') * 1 :
                            typeof i === 'number' ?
                                i : 0;
                    };

                    api.columns().every(function () {
                        var column = this;
                        var Counter = 0;

                        sum = column
                            .data({ search: 'applied' })
            ");
            WriteLiteral(@"                .reduce(function (a, b) {
                                Counter++;
                                return intVal(a) + intVal(b);
                            }, 0).toFixed(2);

                        pagesum = api.column(column, { page: 'current' })
                            .data({ search: 'applied' })
                            .reduce(function (a, b) {
                                return intVal(a) + intVal(b);
                            }, 0).toFixed(2);
                        Average = sum / Counter;


                        $(api.column(0).footer()).html('<b>PageTotal:<hr>Total:<hr>Average:</b>');
                        if (!isNaN(sum) && !isNaN(pagesum)) {
                            $(column.footer()).html(
                                '<b>' + numberRenderer(pagesum) + '<hr>' + numberRenderer(sum) + '<hr>' + numberRenderer(Average) + '</b>'
                            );
                        }
                        else {
                         ");
            WriteLiteral("   $(column.footer()).html(\'<b></b>\');\r\n                        }\r\n                    });\r\n\r\n                },\r\n\r\n            });\r\n\r\n        },\r\n    });\r\n    </script>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JqueryDataTable.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591