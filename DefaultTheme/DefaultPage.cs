﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace DefaultTheme
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.IO;
    using LiterateCS.Theme;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\DefaultPage.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DefaultPage : DefaultPageBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            this.Write("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            this.Write("<head>\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" conten" +
                    "t=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-sca" +
                    "le=1\">\r\n\r\n    <title>");
            
            #line 10 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Head.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Filename + " - " + Params["projectname"]));
            
            #line default
            #line hidden
            this.Write("</title>\r\n\r\n\t<link rel=\"icon\" type=\"image/x-icon\" href=\"");
            
            #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Head.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("images/favicon.ico\">\r\n    ");
            this.Write("<link rel=\"stylesheet\" href=\"");
            
            #line 5 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("bootstrap/css/");
            
            #line 5 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["bootstrapstyle", "default"]));
            
            #line default
            #line hidden
            this.Write("/bootstrap.min.css\" />\r\n<link rel=\"stylesheet\" href=\"");
            
            #line 6 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("font-awesome/css/font-awesome.min.css\">\r\n<link rel=\"stylesheet\" href=\"");
            
            #line 7 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("sidebar/sidebar.min.css\" />\r\n<link rel=\"stylesheet\" href=\"");
            
            #line 8 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("css/");
            
            #line 8 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["markdownstyle", "book"]));
            
            #line default
            #line hidden
            this.Write(".min.css\" />\r\n<link rel=\"stylesheet\" href=\"");
            
            #line 9 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("syntax-highlight/");
            
            #line 9 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["syntaxhighlight", "monokai"]));
            
            #line default
            #line hidden
            this.Write(".min.css\" />\r\n<link rel=\"stylesheet\" href=\"");
            
            #line 10 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("mermaid/");
            
            #line 10 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include\styles.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["diagramstyle", "mermaid"]));
            
            #line default
            #line hidden
            this.Write(".css\" />\r\n");
            this.Write("\r\n</head>");
            this.Write("\r\n\r\n<body style=\"padding-top: 80px;\">\r\n    ");
            this.Write(@"
    <nav class=""navbar navbar-inverse navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-controls=""navbar"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
");
            
            #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

var lg = "logo";
if (Params[lg] != lg)
{

            
            #line default
            #line hidden
            this.Write("                <a class=\"navbar-brand\" href=\"#sidebar-toggle\" id=\"sidebar-toggle" +
                    "\"><span><img src=\"");
            
            #line 20 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            
            #line 20 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params[lg]));
            
            #line default
            #line hidden
            this.Write("\" height=\"24\" />  ");
            
            #line 20 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["projectname"]));
            
            #line default
            #line hidden
            this.Write("</span></a>\r\n");
            
            #line 21 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}
else
{

            
            #line default
            #line hidden
            this.Write("                <a class=\"navbar-brand\" href=\"#sidebar-toggle\" id=\"sidebar-toggle" +
                    "\"><i id=\"sidebar-toggle-icon\" class=\"fa fa-book\" aria-hidden=\"true\"></i> ");
            
            #line 26 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["projectname"]));
            
            #line default
            #line hidden
            this.Write("</a>\r\n");
            
            #line 27 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}

            
            #line default
            #line hidden
            this.Write("            </div>\r\n            <div id=\"navbar\" class=\"navbar-collapse collapse\"" +
                    ">\r\n                <ul class=\"nav navbar-nav\">\r\n                    <li><a href=" +
                    "\"");
            
            #line 33 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("index.html\"><i class=\"fa fa-home\" aria-hidden=\"true\"></i> Home</a></li>\r\n");
            
            #line 34 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

var gh = "github";
if (Params[gh] != gh)
{

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<li><a href=\"");
            
            #line 39 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params[gh]));
            
            #line default
            #line hidden
            this.Write("\"><i class=\"fa fa-github\" aria-hidden=\"true\"></i> GitHub Repository</a></li>\r\n");
            
            #line 40 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}
var dl = "download";
if (Params[dl] != dl)
{

            
            #line default
            #line hidden
            this.Write("                    <li><a href=\"");
            
            #line 46 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params[dl]));
            
            #line default
            #line hidden
            this.Write("\"><i class=\"fa fa-download\" aria-hidden=\"true\"></i> Download</a></li>\r\n");
            
            #line 47 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}
var ng = "nuget";
if (Params[ng] != ng)
{

            
            #line default
            #line hidden
            this.Write("                    <li><a href=\"");
            
            #line 53 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params[ng]));
            
            #line default
            #line hidden
            this.Write("\"><i class=\"fa fa-cloud-download\" aria-hidden=\"true\"></i> NuGet</a></li>\r\n");
            
            #line 54 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}
var lc = "license";
if (Params[lc] != lc)
{

            
            #line default
            #line hidden
            this.Write("                    <li><a href=\"");
            
            #line 60 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            
            #line 60 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params[lc]));
            
            #line default
            #line hidden
            this.Write("\">License</a></li>\r\n");
            
            #line 61 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/navbar.tt"

}

            
            #line default
            #line hidden
            this.Write("                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>");
            this.Write("\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div id=\"" +
                    "sidebar\" class=\"col-md-3 hidden-sm hidden-xs\" style=\"transition: all 0.5s ease;\"" +
                    ">\r\n                ");
            this.Write(@"
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4>On This Page</h4>
            </div>
            <div id=""header-menu"" class=""panel-body main-menu"">
                <ul></ul>
            </div>
        </div>  
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h4>Table of Contents</h4>
            </div>
            <div class=""panel-body main-menu"">
                ");
            
            #line 19 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/SideBar.tt"
 OutputToc (Params.Toc.Contents); 
            
            #line default
            #line hidden
            this.Write("            </div>\r\n        </div>\r\n");
            this.Write("\r\n            </div>\r\n\t\t\t<div id=\"contentarea\" class=\"col-md-9\">\r\n\t\t\t\t");
            
            #line 23 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\DefaultPage.tt"
 OutputPager (); 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<div id=\"static-content\" class=\"markdown\">\r\n\t\t\t\t\t");
            
            #line 25 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\DefaultPage.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Contents));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</div>\r\n\t\t\t\t");
            
            #line 27 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\DefaultPage.tt"
 OutputPager (); 
            
            #line default
            #line hidden
            this.Write("\t\t\t</div>\r\n        </div>\r\n    </div>\r\n    ");
            this.Write("\r\n    <footer class=\"panel-footer text-center\">\r\n        <div align=\"center\">");
            
            #line 7 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Footer.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params["footer"]));
            
            #line default
            #line hidden
            this.Write("</div>\r\n\t\t<div align=\"right\">\r\n\t\t\t<small>\r\n\t\t\t\tDocumentation created with <a href" +
                    "=\"https://johtela.github.io/LiterateCS/\">LiterateCS</a>.\r\n\t\t\t</small>\r\n\t\t</div>\r" +
                    "\n    </footer>\r\n");
            this.Write("\r\n\r\n    ");
            this.Write("\r\n    <script src=\"");
            
            #line 6 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("bootstrap/js/jquery.min.js\"></script>\r\n    <script src=\"");
            
            #line 7 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("bootstrap/js/bootstrap.min.js\"></script>\r\n    <script src=\"");
            
            #line 8 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("sidebar/sidebar.js\"></script>\r\n    <script src=\"");
            
            #line 9 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("syntax-highlight/syntax.js\"></script>\r\n");
            
            #line 10 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
 
if (Params["usemath", null] != null) 
{ 

            
            #line default
            #line hidden
            this.Write("    <script type=\"text/x-mathjax-config\">\r\n        MathJax.Hub.Config({\r\n        " +
                    "extensions: [\"jsMath2jax.js\"]\r\n        });\r\n    </script>\r\n    <script src=\'http" +
                    "s://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.0/MathJax.js?config=TeX-AMS_HTML\'" +
                    "></script>\r\n");
            
            #line 20 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
 
} 
if (Params["usediagrams", null] != null) 
{ 

            
            #line default
            #line hidden
            this.Write("\t<script src=\"");
            
            #line 25 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Params.Root));
            
            #line default
            #line hidden
            this.Write("mermaid/mermaid.min.js\"></script>\r\n\t<script>mermaid.initialize({startOnLoad:true}" +
                    ");</script>\r\n");
            
            #line 27 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Scripts.tt"
 
} 

            
            #line default
            #line hidden
            this.Write(@"
	<!-- Sidebar Toggle Script -->
    <script>
    $(""#sidebar-toggle"").click(function(e) {
        e.preventDefault();
		var sidebarVisible = ""col-sm-4 col-xs-5"";
		var sidebarHidden = ""hidden-sm hidden-xs"";
		var contentWithSidebar = ""col-sm-8 col-xs-7"";
		if ($(""#sidebar"").hasClass(""col-sm-4"")) {
			$(""#contentarea"").removeClass (contentWithSidebar);
			$(""#sidebar"").removeClass (sidebarVisible)
				.addClass (sidebarHidden);
			$(""#sidebar-toggle-icon"").removeClass (""fa-angle-double-left"")
				.addClass (""fa-book"");
		}
		else {
			$(""#contentarea"").addClass (contentWithSidebar);
			$(""#sidebar"").removeClass (sidebarHidden)
				.addClass (sidebarVisible);
			$(""#sidebar-toggle-icon"").removeClass (""fa-book"")
				.addClass (""fa-angle-double-left"");
		}
    });
    </script>
</body>
</html>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 5 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
  public void OutputToc (List<Section> sections)
{ 
        
        #line default
        #line hidden
        
        #line 6 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("<ul>\r\n");

        
        #line default
        #line hidden
        
        #line 8 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
 foreach (var section in sections) 
	{ 
		if (section.File != null)
		{ 
        
        #line default
        #line hidden
        
        #line 11 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\t<li><a href=\"");

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Params.SectionPath (section)));

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\"");

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(SectionStyle (section)));

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(">");

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(section.Page));

        
        #line default
        #line hidden
        
        #line 12 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("</a></li>\r\n");

        
        #line default
        #line hidden
        
        #line 13 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
		}
		else
		{ 
        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\t<li>");

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(section.Page));

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("</li>\r\n");

        
        #line default
        #line hidden
        
        #line 17 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
		} 
        
        #line default
        #line hidden
        
        #line 17 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\t<ul>\r\n");

        
        #line default
        #line hidden
        
        #line 19 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"

		if (Params["ShowDescriptionsInToc"] == "true")
		{

        
        #line default
        #line hidden
        
        #line 22 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\t\t<li>");

        
        #line default
        #line hidden
        
        #line 23 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(section.Desc ?? ""));

        
        #line default
        #line hidden
        
        #line 23 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("</li>\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"

		}
		if (section.Subs != null)
			OutputToc (section.Subs);

        
        #line default
        #line hidden
        
        #line 28 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("\t</ul>\r\n");

        
        #line default
        #line hidden
        
        #line 30 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
	} 
        
        #line default
        #line hidden
        
        #line 30 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
this.Write("</ul>\r\n");

        
        #line default
        #line hidden
        
        #line 32 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Toc.tt"
 } 

private string SectionStyle (Section section)
{
	return section == Params.CurrentSection ? " class=\"selected\"" : "";
}


        
        #line default
        #line hidden
        
        #line 6 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
 public void OutputPager ()
{
	var current = Params.CurrentSection;
	if (current == null)
		return;
	var prev = Params.Toc.PreviousSection (current);
	var next = Params.Toc.NextSection (current);

        
        #line default
        #line hidden
        
        #line 13 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("<ul class=\"pager\">\r\n\t<li class=\"previous");

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Disabled (prev)));

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("\"><a href=\"");

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Link (prev)));

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("\">Previous");

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Title (prev)));

        
        #line default
        #line hidden
        
        #line 15 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("</a></li>\r\n\t<li class=\"next");

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Disabled (next)));

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("\"><a href=\"");

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Link (next)));

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("\">Next");

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(Title (next)));

        
        #line default
        #line hidden
        
        #line 16 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
this.Write("</a></li>\r\n</ul>\r\n");

        
        #line default
        #line hidden
        
        #line 18 "C:\Users\johteto\Source\Repos\LiterateCS\DefaultTheme\include/Pager.tt"
 } 

private string Disabled (Section entry) =>
	entry == null ? " disabled" : "";

private string Link (Section entry) =>
	entry != null ? Params.SectionPath (entry) : "#";

private string Title (Section entry) =>
	entry != null ? ": " + entry.Page : "";

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class DefaultPageBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
