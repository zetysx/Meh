package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class Contact_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("        <title>Contact Page</title>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("        <div class=\"container-fluid site-wrapper\"> <!-- this is the Sheet -->\n");
      out.write("            <div class=\"container-fluid header-wrapper \" id=\"header\"> <!-- this is the Header Wrapper -->\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <div class=\"title-wrapper\">\n");
      out.write("                        <div class=\"title-wrapper-inner\">\n");
      out.write("                            <a rel=\"nofollow\" class=\"logo \" href=\"http://us-123office.simplesite.com/\">\n");
      out.write("                            </a>\n");
      out.write("                            <div class=\"title \">\n");
      out.write("                                Grey Consulting Group\n");
      out.write("                            </div>\n");
      out.write("                            <div class=\"subtitle\">\n");
      out.write("                                Welcome to our website\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div>  <!-- these are the titles -->\n");
      out.write("                    <div class=\"navbar navbar-compact\">\n");
      out.write("                        <div class=\"navbar-inner\">\n");
      out.write("                            <div class=\"container\">\n");
      out.write("                                <!-- .btn-navbar is used as the toggle for collapsed navbar content -->\n");
      out.write("                                <a rel=\"nofollow\" class=\"btn btn-navbar\" data-toggle=\"collapse\" data-target=\".nav-collapse\" title=\"Toggle menu\">\n");
      out.write("                                    <span class=\"menu-name\">Menu</span>\n");
      out.write("                                    <span class=\"menu-bars\">\n");
      out.write("                                        <span class=\"icon-bar\"></span>\n");
      out.write("                                        <span class=\"icon-bar\"></span>\n");
      out.write("                                        <span class=\"icon-bar\"></span>\n");
      out.write("                                    </span>\n");
      out.write("                                </a>\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("                                <!-- Everything you want hidden at 940px or less, place within here -->\n");
      out.write("                                <div class=\"nav-collapse collapse\">\n");
      out.write("                                    <ul class=\"nav\" id=\"topMenu\" data-submenu=\"horizontal\">\n");
      out.write("                                        <li class=\"  \" style=\"\">\n");
      out.write("                                            <a href=\"./Home.jsp\">Home</a>\n");
      out.write("                                        </li><li class=\"  \" style=\"\">\n");
      out.write("                                            <a href=\"./Services.jsp\">Services</a>\n");
      out.write("                                        </li><li class=\" active \" style=\"\">\n");
      out.write("                                            <a href=\"./Services.jsp\">Contact</a>\n");
      out.write("                                        </li>                </ul>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
      out.write("                    <!-- this is the Menu content -->\n");
      out.write("                </div>\n");
      out.write("            </div>  <!-- this is the Header content -->\n");
      out.write("\n");
      out.write("            <div class=\"container-fluid content-wrapper\" id=\"content\"> <!-- this is the Content Wrapper -->\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <div class=\"row-fluid content-inner\">\n");
      out.write("                        <div id=\"left\" class=\"span9\"> <!-- ADD \"span12\" if no sidebar, or \"span9\" with sidebar -->\n");
      out.write("                            <div class=\"wrapper contact\">\n");
      out.write("                                <div class=\"heading\">\n");
      out.write("                                    <h1 class=\"page-title\">Contact us</h1>\n");
      out.write("                                </div>\n");
      out.write("\n");
      out.write("                                <div class=\"content\">\n");
      out.write("                                    <div class=\"section\">\n");
      out.write("                                        <div class=\"content\">\n");
      out.write("                                            <div class=\"span12 contact-text\">\n");
      out.write("                                                <h4>Grey Consulting Group</h4>\n");
      out.write("                                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit<span>, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</span></p> <p>Address:<br>City:<br>Country:</p> <p>Tel: 123456<br>Email: your-email@your-email.com</p>\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"img-simple span6 \">\n");
      out.write("                                                <div class=\"image\">\n");
      out.write("                                                    <img src=\"img/5.jpg\"></a>\n");
      out.write("                                                </div>\n");
      out.write("                                            </div>\n");
      out.write("                                        </div>\n");
      out.write("                                    </div>\n");
      out.write("\n");
      out.write("                                    <div class=\"section contact-form\"><div class=\"content\"><div class=\"alert alert-success hide\">\n");
      out.write("                                                Thank you for your message.\n");
      out.write("                                            </div>\n");
      out.write("                                            <div class=\"alert alert-error hide\">\n");
      out.write("                                                <button type=\"button\" class=\"close\">×</button>\n");
      out.write("                                            </div>\n");
      out.write("                                            <p>Write your message here. Fill out the form:</p>\n");
      out.write("                                            <form>\n");
      out.write("\n");
      out.write("                                                <fieldset>\n");
      out.write("\n");
      out.write("                                                    <div class=\"row-fluid\">\n");
      out.write("                                                        <div class=\"span6\">\n");
      out.write("                                                            <input type=\"text\" name=\"author[name]\" placeholder=\"Write your name here\" style=\"margin-bottom:11px!important\">\n");
      out.write("                                                            <span class=\"_help-block\"></span>\n");
      out.write("                                                        </div>\n");
      out.write("\n");
      out.write("                                                        <div class=\"span6\">\n");
      out.write("                                                            <input type=\"text\" name=\"author[email]\" placeholder=\"Write your email here\" style=\"margin-bottom:11px!important\">\n");
      out.write("                                                            <span class=\"_help-block\"></span>\n");
      out.write("                                                        </div>\n");
      out.write("                                                    </div>\n");
      out.write("\n");
      out.write("                                                    <div class=\"row-fluid\">\n");
      out.write("                                                        <div class=\"span12\">\n");
      out.write("                                                            <textarea id=\"contactFormMessageText\" name=\"text\" placeholder=\"Write your message here\" style=\"margin-bottom:11px!important\"></textarea>\n");
      out.write("                                                            <span class=\"_help-block\"></span>\n");
      out.write("                                                        </div>\n");
      out.write("                                                    </div>\n");
      out.write("\n");
      out.write("                                                    <div id=\"recaptcha\" class=\"row-fluid\"></div>  \n");
      out.write("\n");
      out.write("                                                    <div class=\"row-fluid\">\n");
      out.write("                                                        <div class=\"span12\">\n");
      out.write("                                                            <button class=\"btn btn-primary pull-right\" type=\"submit\" data-default=\"Send - Click here\" data-progress=\"&lt;i class=&#39;icon-spin icon-spinner&#39;&gt;&lt;/i&gt; Sending\" data-error=\"Send - Click here\" data-success=\"&lt;i class=&#39;icon-ok&#39;&gt;&lt;/i&gt; Sent\">Send - Click here\n");
      out.write("                                                            </button>\n");
      out.write("                                                        </div>\n");
      out.write("                                                    </div>\n");
      out.write("\n");
      out.write("                                                </fieldset>\n");
      out.write("\n");
      out.write("                                            </form>\n");
      out.write("                                            </div></div>\n");
      out.write("                                </div>\n");
      out.write("\n");
      out.write("\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div id=\"right\" class=\"span3\">\n");
      out.write("                            <div class=\"sidebar\">\n");
      out.write("                                <div class=\"wrapper share-box\">\n");
      out.write("                                    <style>    .wordwrapfix {\n");
      out.write("                                            word-wrap:break-word;\n");
      out.write("                                        }\n");
      out.write("                                    </style>\n");
      out.write("                                    <div class=\"heading wordwrapfix\">\n");
      out.write("                                        <h4>Share this page</h4>\n");
      out.write("                                    </div>\n");
      out.write("\n");
      out.write("                                    <div class=\"content\"><div>\n");
      out.write("                                            <ul>\n");
      out.write("                                                <li><span>Share on Facebook</span></li>\n");
      out.write("                                                <li><span>Share on Twitter</span></li>\n");
      out.write("                                                <li><span>Share on Google+</span></li>\n");
      out.write("                                            </ul>\n");
      out.write("                                        </div></div>\n");
      out.write("                                </div>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div>        \n");
      out.write("                </div>\n");
      out.write("            </div>  <!-- the controller has determined which view to be shown in the content -->\n");
      out.write("\n");
      out.write("            <div class=\"container-fluid footer-wrapper\" id=\"footer\">\n");
      out.write("                <!-- this is the Footer Wrapper -->\n");
      out.write("                <div class=\"container\">\n");
      out.write("                   \n");
      out.write("                    <div class=\"footer-page-counter\" style=\"display: block;\">\n");
      out.write("                        <span class=\"footer-page-counter-item\">0</span>\n");
      out.write("\n");
      out.write("                        <span class=\"footer-page-counter-item\">7</span>\n");
      out.write("\n");
      out.write("                        <span class=\"footer-page-counter-item\">8</span>\n");
      out.write("\n");
      out.write("                        <span class=\"footer-page-counter-item\">9</span>\n");
      out.write("\n");
      out.write("                        <span class=\"footer-page-counter-item\">5</span>\n");
      out.write("\n");
      out.write("                        <span class=\"footer-page-counter-item\">9</span>\n");
      out.write("                    </div>\n");
      out.write("\n");
      out.write("                </div>\n");
      out.write("\n");
      out.write("                </body>\n");
      out.write("                </html>\n");
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
