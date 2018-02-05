package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class Service_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"css/LUL.css\"/>\n");
      out.write("        <title>JSP Page</title>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        <div class=\"container-fluid site-wrapper\"> <!-- this is the Sheet -->\n");
      out.write("            <div class=\"container-fluid header-wrapper \" id=\"header\"> <!-- this is the Header Wrapper -->\n");
      out.write("    <div class=\"container\">\n");
      out.write("<div class=\"title-wrapper\">\n");
      out.write("\t<div class=\"title-wrapper-inner\">\n");
      out.write("\t    <a rel=\"nofollow\" class=\"logo \" href=\"http://us-123office.simplesite.com/\">\n");
      out.write("\t    </a>\n");
      out.write("\t    <div class=\"title \">\n");
      out.write("\t        Grey Consulting Group\n");
      out.write("\t    </div>\n");
      out.write("\t    <div class=\"subtitle\">\n");
      out.write("\t        Welcome to our website\n");
      out.write("\t    </div>\n");
      out.write("\t</div>\n");
      out.write("</div>  <!-- these are the titles -->\n");
      out.write("<div class=\"navbar navbar-compact\">\n");
      out.write("    <div class=\"navbar-inner\">\n");
      out.write("        <div class=\"container\">\n");
      out.write("            <!-- .btn-navbar is used as the toggle for collapsed navbar content -->\n");
      out.write("            <a rel=\"nofollow\" class=\"btn btn-navbar\" data-toggle=\"collapse\" data-target=\".nav-collapse\" title=\"Toggle menu\">\n");
      out.write("                <span class=\"menu-name\">Menu</span>\n");
      out.write("                <span class=\"menu-bars\">\n");
      out.write("                    <span class=\"icon-bar\"></span>\n");
      out.write("                    <span class=\"icon-bar\"></span>\n");
      out.write("                    <span class=\"icon-bar\"></span>\n");
      out.write("                </span>\n");
      out.write("            </a>\n");
      out.write("            \n");
      out.write("\n");
      out.write("\n");
      out.write("            <!-- Everything you want hidden at 940px or less, place within here -->\n");
      out.write("            <div class=\"nav-collapse collapse\">\n");
      out.write("                <ul class=\"nav\" id=\"topMenu\" data-submenu=\"horizontal\">\n");
      out.write("<li class=\"  \" style=\"\">\n");
      out.write("    <a href=\"./Home.html\">Home</a>\n");
      out.write("</li><li class=\" active \" style=\"\">\n");
      out.write("    <a href=\"./Services.html\">Services</a>\n");
      out.write("</li><li class=\"  \" style=\"\">\n");
      out.write("    <a href=\"./Contact.html\">Contact</a>\n");
      out.write("</li>                </ul>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("    </div>\n");
      out.write("</div>\n");
      out.write("  <!-- this is the Menu content -->\n");
      out.write("    </div>\n");
      out.write("</div>  <!-- this is the Header content -->\n");
      out.write("\n");
      out.write("            <div class=\"container-fluid content-wrapper\" id=\"content\"> <!-- this is the Content Wrapper -->\n");
      out.write("    <div class=\"container\">\n");
      out.write("        <div class=\"row-fluid content-inner\">\n");
      out.write("            <div id=\"left\" class=\"span9\"> <!-- ADD \"span12\" if no sidebar, or \"span9\" with sidebar -->\n");
      out.write("                <div class=\"wrapper \">\n");
      out.write("                    <div class=\"content\">\n");
      out.write("<div class=\"section article\">\n");
      out.write("    <style>    .wordwrapfix {\n");
      out.write("        word-wrap:break-word;\n");
      out.write("    }\n");
      out.write("</style>\n");
      out.write("<div class=\"heading wordwrapfix\">\n");
      out.write("        <h3>Our Expertise</h3>\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("    <div class=\"content\">\n");
      out.write("<div class=\"img-simple span6 pull-right\">\n");
      out.write("    <div class=\"image\">\n");
      out.write("            <img src=\"img/4.jpg\"></a>\n");
      out.write("    </div>\n");
      out.write("    </div>\n");
      out.write("<p><span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip\n");
      out.write(" ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue\n");
      out.write(" duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes\n");
      out.write(" demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis\n");
      out.write(" per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.</span></p>    </div>\n");
      out.write("</div>\n");
      out.write("<div class=\"section article\">\n");
      out.write("    <style>    .wordwrapfix {\n");
      out.write("        word-wrap:break-word;\n");
      out.write("    }\n");
      out.write("</style>\n");
      out.write("<div class=\"heading wordwrapfix\">\n");
      out.write("        <h3>Consulting</h3>\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("    <div class=\"content\">\n");
      out.write("<p><span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip\n");
      out.write(" ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue\n");
      out.write(" duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes\n");
      out.write(" demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis\n");
      out.write(" per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.</span></p>    </div>\n");
      out.write("</div>\n");
      out.write("    </div>\n");
      out.write("\n");
      out.write("                \n");
      out.write("                </div>\n");
      out.write("            </div>\n");
      out.write("            <div id=\"right\" class=\"span3\">\n");
      out.write("                <div class=\"sidebar\">\n");
      out.write("            <div class=\"wrapper share-box\">\n");
      out.write("                <style>    .wordwrapfix {\n");
      out.write("        word-wrap:break-word;\n");
      out.write("    }\n");
      out.write("</style>\n");
      out.write("<div class=\"heading wordwrapfix\">\n");
      out.write("        <h4>Share this page</h4>\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("                <div class=\"content\"><div>\n");
      out.write("                    <ul>\n");
      out.write("    <li><a rel=\"nofollow\" id=\"share-facebook\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-facebook-sign\"></i><span>Share on Facebook</span></a></li>\n");
      out.write("    <li><a rel=\"nofollow\" id=\"share-twitter\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-twitter-sign\"></i><span>Share on Twitter</span></a></li>\n");
      out.write("    <li><a rel=\"nofollow\" id=\"share-google-plus\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-google-plus-sign\"></i><span>Share on Google+</span></a></li>\n");
      out.write("</ul>\n");
      out.write("                </div></div>\n");
      out.write("            </div>\n");
      out.write("</div>\n");
      out.write("            </div>\n");
      out.write("        </div>        \n");
      out.write("    </div>\n");
      out.write("</div>  <!-- the controller has determined which view to be shown in the content -->\n");
      out.write("\n");
      out.write("            <div class=\"container-fluid footer-wrapper\" id=\"footer\">\n");
      out.write("    <!-- this is the Footer Wrapper -->\n");
      out.write("    <div class=\"container\">\n");
      out.write("        <div class=\"footer-info\">\n");
      out.write("                            <div class=\"footer-powered-by\">\n");
      out.write("                    <a rel=\"nofollow\" href=\"http://www.simplesite.com/pages/receive.aspx?partnerkey=123i%3afooterbanner&amp;referercustomerid=10677696&amp;refererpageid=410914420\">Created with SimpleSite</a>\n");
      out.write("                </div>\n");
      out.write("        </div>\n");
      out.write("            <div class=\"footer-page-counter\" style=\"display: block;\">\n");
      out.write("\t<span class=\"footer-page-counter-item\">0</span>\n");
      out.write("\n");
      out.write("\t<span class=\"footer-page-counter-item\">7</span>\n");
      out.write("\n");
      out.write("\t<span class=\"footer-page-counter-item\">8</span>\n");
      out.write("\n");
      out.write("\t<span class=\"footer-page-counter-item\">9</span>\n");
      out.write("\n");
      out.write("\t<span class=\"footer-page-counter-item\">5</span>\n");
      out.write("\n");
      out.write("\t<span class=\"footer-page-counter-item\">9</span>\n");
      out.write("</div>\n");
      out.write("        <div id=\"css_simplesite_com_fallback\" class=\"hide\"></div>\n");
      out.write("    </div>\n");
      out.write("</div>\n");
      out.write("    </body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
