<%-- 
    Document   : Contact
    Created on : Sep 27, 2017, 9:41:53 PM
    Author     : Administrator
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" type="text/css" href="css/LUL.css"/>
        <title>Contact Page</title>
    </head>
    <body>
        <div class="container-fluid site-wrapper"> <!-- this is the Sheet -->
            <div class="container-fluid header-wrapper " id="header"> <!-- this is the Header Wrapper -->
                <div class="container">
                    <div class="title-wrapper">
                        <div class="title-wrapper-inner">
                            <a rel="nofollow" class="logo " href="http://us-123office.simplesite.com/">
                            </a>
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
                                <!-- .btn-navbar is used as the toggle for collapsed navbar content -->
                                <a rel="nofollow" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse" title="Toggle menu">
                                    <span class="menu-name">Menu</span>
                                    <span class="menu-bars">
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                    </span>
                                </a>



                                <!-- Everything you want hidden at 940px or less, place within here -->
                                <div class="nav-collapse collapse">
                                    <ul class="nav" id="topMenu" data-submenu="horizontal">
                                        <li class="  " style="">
                                            <a href="./Home.jsp">Home</a>
                                        </li><li class="  " style="">
                                            <a href="./Services.jsp">Services</a>
                                        </li><li class=" active " style="">
                                            <a href="./Services.jsp">Contact</a>
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
                            <div class="wrapper contact">
                                <div class="heading">
                                    <h1 class="page-title">Contact us</h1>
                                </div>

                                <div class="content">
                                    <div class="section">
                                        <div class="content">
                                            <div class="span12 contact-text">
                                                <h4>Grey Consulting Group</h4>
                                                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit<span>, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</span></p> <p>Address:<br>City:<br>Country:</p> <p>Tel: 123456<br>Email: your-email@your-email.com</p>
                                            </div>
                                            <div class="img-simple span6 ">
                                                <div class="image">
                                                    <img src="img/5.jpg"></a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="section contact-form"><div class="content"><div class="alert alert-success hide">
                                                Thank you for your message.
                                            </div>
                                            <div class="alert alert-error hide">
                                                <button type="button" class="close">×</button>
                                            </div>
                                            <p>Write your message here. Fill out the form:</p>
                                            <form>

                                                <fieldset>

                                                    <div class="row-fluid">
                                                        <div class="span6">
                                                            <input type="text" name="author[name]" placeholder="Write your name here" style="margin-bottom:11px!important">
                                                            <span class="_help-block"></span>
                                                        </div>

                                                        <div class="span6">
                                                            <input type="text" name="author[email]" placeholder="Write your email here" style="margin-bottom:11px!important">
                                                            <span class="_help-block"></span>
                                                        </div>
                                                    </div>

                                                    <div class="row-fluid">
                                                        <div class="span12">
                                                            <textarea id="contactFormMessageText" name="text" placeholder="Write your message here" style="margin-bottom:11px!important"></textarea>
                                                            <span class="_help-block"></span>
                                                        </div>
                                                    </div>

                                                    <div id="recaptcha" class="row-fluid"></div>  

                                                    <div class="row-fluid">
                                                        <div class="span12">
                                                            <button class="btn btn-primary pull-right" type="submit" data-default="Send - Click here" data-progress="&lt;i class=&#39;icon-spin icon-spinner&#39;&gt;&lt;/i&gt; Sending" data-error="Send - Click here" data-success="&lt;i class=&#39;icon-ok&#39;&gt;&lt;/i&gt; Sent">Send - Click here
                                                            </button>
                                                        </div>
                                                    </div>

                                                </fieldset>

                                            </form>
                                            </div></div>
                                </div>


                            </div>
                        </div>
                        <div id="right" class="span3">
                            <div class="sidebar">
                                <div class="wrapper share-box">
                                    <style>    .wordwrapfix {
                                            word-wrap:break-word;
                                        }
                                    </style>
                                    <div class="heading wordwrapfix">
                                        <h4>Share this page</h4>
                                    </div>

                                    <div class="content"><div>
                                            <ul>
                                                <li><span>Share on Facebook</span></li>
                                                <li><span>Share on Twitter</span></li>
                                                <li><span>Share on Google+</span></li>
                                            </ul>
                                        </div></div>
                                </div>
                            </div>
                        </div>
                    </div>        
                </div>
            </div>  <!-- the controller has determined which view to be shown in the content -->

            <div class="container-fluid footer-wrapper" id="footer">
                <!-- this is the Footer Wrapper -->
                <div class="container">
                   
                    <div class="footer-page-counter" style="display: block;">
                        <span class="footer-page-counter-item">0</span>

                        <span class="footer-page-counter-item">7</span>

                        <span class="footer-page-counter-item">8</span>

                        <span class="footer-page-counter-item">9</span>

                        <span class="footer-page-counter-item">5</span>

                        <span class="footer-page-counter-item">9</span>
                    </div>

                </div>

                </body>
                </html>
