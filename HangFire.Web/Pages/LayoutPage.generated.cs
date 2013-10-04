﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\LayoutPage.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\LayoutPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"ru\">\r\n<head>\r\n    <title>");


            
            #line 10 "..\..\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - HangFire</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" cont" +
"ent=\"width=device-width, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 13 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/css/styles.css"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
<body>
    <!-- Wrap all page content here -->
    <div id=""wrap"">

        <!-- Fixed navbar -->
        <div class=""navbar navbar-default navbar-static-top"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""");


            
            #line 28 "..\..\Pages\LayoutPage.cshtml"
                                             Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral(@""">HangFire Monitor</a>
                </div>
                <div class=""collapse navbar-collapse"">
                    <ul class=""nav navbar-nav navbar-right"">
                        <li>
                            <a href=""/"">
                                <span class=""glyphicon glyphicon-log-out""></span>
                                Back to site
                            </a>
                        </li>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

        <!-- Begin page content -->

        <div class=""container"">
            <div class=""col-md-3"">
                <div id=""stats"" class=""list-group"" data-refresh-url=""");


            
            #line 48 "..\..\Pages\LayoutPage.cshtml"
                                                                Write(Request.LinkTo("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <a class=\"list-group-item ");


            
            #line 49 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                       href=\"");


            
            #line 50 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span class=\"glyphicon glyphicon-dashboard\"></span>\r\n" +
"                        Dashboard\r\n                    </a>\r\n\r\n                 " +
"   <a class=\"list-group-item ");


            
            #line 55 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.Equals("/servers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                       href=\"");


            
            #line 56 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/servers"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span class=\"label label-default pull-right\">");


            
            #line 57 "..\..\Pages\LayoutPage.cshtml"
                                                                Write(JobStorage.Servers().Count());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span class=\"glyphicon glyphicon-hdd\"></span>\r\n " +
"                       Active Servers\r\n                    </a>\r\n\r\n             " +
"       <a class=\"list-group-item ");


            
            #line 62 "..\..\Pages\LayoutPage.cshtml"
                                          Write(Request.PathInfo.StartsWith("/queues") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 63 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/queues"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-enqueued\" class=\"label label-default " +
"pull-right\">\r\n                            <span title=\"Enqueued jobs count\">\r\n  " +
"                              ");


            
            #line 66 "..\..\Pages\LayoutPage.cshtml"
                           Write(String.Format("{0:n0}", JobStorage.EnqueuedCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n                            / \r\n          " +
"                  <span title=\"Queues count\">\r\n                                ");


            
            #line 70 "..\..\Pages\LayoutPage.cshtml"
                           Write(JobStorage.QueuesCount());

            
            #line default
            #line hidden
WriteLiteral(@"
                            </span>
                        </span>
                        <span class=""glyphicon glyphicon-inbox""></span>
                        Jobs & Queues
                    </a>
                    <a class=""list-group-item stats-indent ");


            
            #line 76 "..\..\Pages\LayoutPage.cshtml"
                                                       Write(Request.PathInfo.Equals("/schedule") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 77 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/schedule"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-scheduled\" class=\"label label-info pu" +
"ll-right\">\r\n                            ");


            
            #line 79 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", JobStorage.ScheduledCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Scheduled\r\n           " +
"         </a>\r\n                    <a class=\"list-group-item stats-indent ");


            
            #line 83 "..\..\Pages\LayoutPage.cshtml"
                                                       Write(Request.PathInfo.Equals("/processing") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 84 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/processing"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-workers\" class=\"label label-warning p" +
"ull-right\">\r\n                            ");


            
            #line 86 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", JobStorage.ProcessingCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Processing\r\n          " +
"          </a>\r\n                    <a class=\"list-group-item stats-indent ");


            
            #line 90 "..\..\Pages\LayoutPage.cshtml"
                                                       Write(Request.PathInfo.Equals("/succeeded") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 91 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/succeeded"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-succeeded\" class=\"label label-success" +
" pull-right\">\r\n                            ");


            
            #line 93 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", JobStorage.SucceededCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Succeeded\r\n           " +
"         </a>\r\n                    <a class=\"list-group-item stats-indent ");


            
            #line 97 "..\..\Pages\LayoutPage.cshtml"
                                                       Write(Request.PathInfo.Equals("/failed") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 98 "..\..\Pages\LayoutPage.cshtml"
                        Write(Request.LinkTo("/failed"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span id=\"stats-failed\" class=\"label label-danger pul" +
"l-right\">\r\n                            ");


            
            #line 100 "..\..\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0:n0}", JobStorage.FailedCount()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n                        Failed\r\n              " +
"      </a>\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div cla" +
"ss=\"col-md-9\">\r\n");


            
            #line 109 "..\..\Pages\LayoutPage.cshtml"
                 if (Breadcrumbs != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <ol class=\"breadcrumb\">\r\n                        <li><a href=" +
"\"");


            
            #line 112 "..\..\Pages\LayoutPage.cshtml"
                                Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\"><span class=\"glyphicon glyphicon-home\"></span></a></li>\r\n");


            
            #line 113 "..\..\Pages\LayoutPage.cshtml"
                         foreach (var breadcrumb in Breadcrumbs)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li><a href=\"");


            
            #line 115 "..\..\Pages\LayoutPage.cshtml"
                                    Write(breadcrumb.Value);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 115 "..\..\Pages\LayoutPage.cshtml"
                                                       Write(breadcrumb.Key);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 116 "..\..\Pages\LayoutPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li class=\"active\">");


            
            #line 117 "..\..\Pages\LayoutPage.cshtml"
                                      Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    </ol>\r\n");


            
            #line 119 "..\..\Pages\LayoutPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <h1 class=\"page-header\">\r\n                    ");


            
            #line 122 "..\..\Pages\LayoutPage.cshtml"
               Write(Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 123 "..\..\Pages\LayoutPage.cshtml"
                     if (!String.IsNullOrEmpty(Subtitle))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <small>");


            
            #line 125 "..\..\Pages\LayoutPage.cshtml"
                          Write(Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n");


            
            #line 126 "..\..\Pages\LayoutPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h1>\r\n                ");


            
            #line 128 "..\..\Pages\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
            </div>
        </div>
    </div>

    <div id=""footer"">
        <div class=""container"">
            <ul class=""list-inline credit"">
                <li>
                    <a href=""http://github.io/odinserj/hangfire"" target=""_blank"">HangFire 
                        ");


            
            #line 138 "..\..\Pages\LayoutPage.cshtml"
                   Write(FileVersionInfo.GetVersionInfo(GetType().Assembly.Location).ProductVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </li>\r\n                <li>\r\n        " +
"            ");


            
            #line 142 "..\..\Pages\LayoutPage.cshtml"
               Write(String.Format("redis://{0}:{1}/{2}", RedisFactory.Host, RedisFactory.Port, RedisFactory.Db));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>Time: ");


            
            #line 144 "..\..\Pages\LayoutPage.cshtml"
                     Write(DateTime.UtcNow);

            
            #line default
            #line hidden
WriteLiteral(" UTC\r\n                </li>\r\n                <li>Generated in [");


            
            #line 146 "..\..\Pages\LayoutPage.cshtml"
                              Write((DateTime.UtcNow - (DateTime)Context.Items["GenerationStartedAt"]).Milliseconds);

            
            #line default
            #line hidden
WriteLiteral(" ms]\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n   " +
" <script src=\"");


            
            #line 152 "..\..\Pages\LayoutPage.cshtml"
            Write(Request.LinkTo("/js/scripts.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n</body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
