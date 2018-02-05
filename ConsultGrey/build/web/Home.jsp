<%-- 
    Document   : Home
    Created on : Sep 27, 2017, 9:22:52 PM
    Author     : Administrator
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="/struts-tags" prefix="s" %>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" type="text/css" href="css/LUL.css"/>
        <title>Home Page</title>
    </head>
    <body>
        <div class="container-fluid site-wrapper"> <!-- this is the Sheet -->
            <div class="container-fluid header-wrapper " id="header"> <!-- this is the Header Wrapper -->
                <div class="container">
                    <div class="title-wrapper">
                        <div class="title-wrapper-inner">    
                            <div class="title ">
                                
                                Grey Consulting Group
                            </div>
                            <div class="subtitle">
                                Welcome to our website
                            </div>
                        </div>
                    </div>  <!-- these are the titles -->
                    <div class="navbar navbar-compact">
                        <div class="navbar-inner">
                            <div class="container">
                                <div class="nav-collapse collapse">
                                    <ul class="nav"  >
                                        <li class=" active " style="">
                                            <a href="home">Home</a>
                                        </li><li class="  " style="">
                                            <a href="./Services.jsp">Services</a>
                                        </li><li class="  " style="">
                                            <a href="./Contact.jsp">Contact</a>
                                        </li>                </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- this is the Menu content -->
                </div>
            </div>  <!-- this is the Header content -->

            <div class="container-fluid content-wrapper" id="content"> <!-- this is the Content Wrapper -->
                <div class="container">
                    <div class="row-fluid content-inner">
                        <div id="left" class="span9"> <!-- ADD "span12" if no sidebar, or "span9" with sidebar -->
                            <div class="wrapper ">
                                <div class="content">
                                    <div class="section article">
                                        
                                        <div class="heading wordwrapfix">
                                            <h3><s:property value="%{welcome.title}"/> </h3>
                                        </div>
                                        <div class="content">
                                            <div class="img-simple  ">
                                                <div class="image">
                                                    <img src="<s:property value="%{welcome.imgPath}"/>">
                                                </div>
                                            </div>
                                                    <p><s:property value="%{welcome.description}"/></p>    
                                        </div>
                                    </div>
                                    <div class="section">
                                        <div class="content">
                                            <s:iterator var="dto" value="entries">
                                            <ul class="thumbnails column-article-section">
                                                <li class="span6">
                                                    <div class="img-simple span12 ">
                                                        <div class="image">
                                                            <img src="<s:property value="%{#dto.imgPath}"/>"></a>
                                                        </div>
                                                    </div>

                                                    <h4>
                                                        <a href="service"><s:property value="%{#dto.title}"/></a>
                                                    </h4>

                                                    <p><s:property value="%{#dto.description}"/></p>
                                                </li>
                                                <li class="span6">
                                                    <div class="img-simple span12 ">
                                                        <div class="image">
                                                            <img src="<s:property value="%{#dto.imgPath}"/>"></a>
                                                        </div>
                                                    </div>

                                                    <h4>
                                                        <a href="contact"><s:property value="%{#dto.title}"/></a>
                                                    </h4>

                                                    <p><s:property value="%{#dto.description}"/></p>
                                                </li>
                                            </ul>
                                            </s:iterator>
                                        </div>
                                    </div>
                                </div>


                            </div>
                        </div>
                        <div id="right" class="span3">
                            <div class="sidebar">
                                <div class="wrapper share-box">

                                    <div class="heading wordwrapfix">
                                        <h4>Share this page</h4>
                                    </div>

                                    <div class="content"><div>
                                            <ul>
                                                <li><a id="share-facebook" ><i class="icon-facebook-sign"></i><span>Share on Facebook</span></a></li>
                                                <li><a id="share-twitter" ><i class="icon-twitter-sign"></i><span>Share on Twitter</span></a></li>
                                                <li><a id="share-google-plus" ><i class="icon-google-plus-sign"></i><span>Share on Google+</span></a></li>
                                            </ul>
                                        </div></div>
                                </div>
                            </div>
                        </div>
                    </div>        
                </div>
            </div>
            <div class="container-fluid footer-wrapper" id="footer">
                <div class="container">
                    <div class="footer-page-counter" style="display: block;">
                        <span class="footer-page-counter-item">0</span>

                        <span class="footer-page-counter-item">7</span>

                        <span class="footer-page-counter-item">8</span>

                        <span class="footer-page-counter-item">8</span>

                        <span class="footer-page-counter-item">5</span>

                        <span class="footer-page-counter-item">4</span>
                    </div>
                    <div id="css_simplesite_com_fallback" class="hide"></div>
                </div>
            </div>
        </div>
    </body>
</html>
