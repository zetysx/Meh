package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class Services_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      out.write("        <meta property=\"appid\" content=\"1880640628839943\" />\n");
      out.write("<meta property=\"og:site_name\" content=\"Grey Consulting Group\" />\n");
      out.write("<meta property=\"article:publisher\" content=\"https://www.facebook.com/simplesite\" />\n");
      out.write("<meta property=\"og:locale\" content=\"en-US\" />\n");
      out.write("<meta property=\"og:url\" content=\"http://us-123office.simplesite.com/410914420\" />\n");
      out.write("<meta property=\"og:title\" content=\"Our Expertise\" />\n");
      out.write("<meta property=\"og:description\" content=\"\n");
      out.write("Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip\n");
      out.write(" ex ea commodo consequat. Duis autem vel eum iriur...\" />\n");
      out.write("<meta property=\"og:image\" content=\"https://cdn.simplesite.com/i/c0/85/286823008966182336/i286823014247712785._szw1280h1280_.jpg\" />\n");
      out.write("<meta property=\"og:updated_time\" content=\"2017-09-27T14:49:07.0567720+00:00\" />\n");
      out.write("<meta property=\"og:type\" content=\"website\" />\n");
      out.write("<meta name=\"robots\" content=\"nofollow\" />\n");
      out.write("<meta charset=\"utf-8\" />\n");
      out.write("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n");
      out.write("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" /><script type=\"text/javascript\">window.NREUM||(NREUM={});NREUM.info = {\"beacon\":\"bam.nr-data.net\",\"errorBeacon\":\"bam.nr-data.net\",\"licenseKey\":\"17c3efee35\",\"applicationID\":\"29916044\",\"transactionName\":\"YgZQN0RZWkRYW0RbWltMczBmF0RWXl1DHUVUBFcLV1ZQW1xKHlNGRRs=\",\"queueTime\":0,\"applicationTime\":65,\"agent\":\"\",\"atts\":\"\"}</script><script type=\"text/javascript\">(window.NREUM||(NREUM={})).loader_config={xpid:\"VQUPWFVWDhACXVhTAQEDUg==\"};window.NREUM||(NREUM={}),__nr_require=function(t,n,e){function r(e){if(!n[e]){var o=n[e]={exports:{}};t[e][0].call(o.exports,function(n){var o=t[e][1][n];return r(o||n)},o,o.exports)}return n[e].exports}if(\"function\"==typeof __nr_require)return __nr_require;for(var o=0;o<e.length;o++)r(e[o]);return r}({1:[function(t,n,e){function r(t){try{s.console&&console.log(t)}catch(n){}}var o,i=t(\"ee\"),a=t(15),s={};try{o=localStorage.getItem(\"__nr_flags\").split(\",\"),console&&\"function\"==typeof console.log&&(s.console=!0,o.indexOf(\"dev\")!==-1&&(s.dev=!0),o.indexOf(\"nr_dev\")!==-1&&(s.nrDev=!0))}catch(c){}s.nrDev&&i.on(\"internal-error\",function(t){r(t.stack)}),s.dev&&i.on(\"fn-err\",function(t,n,e){r(e.stack)}),s.dev&&(r(\"NR AGENT IN DEVELOPMENT MODE\"),r(\"flags: \"+a(s,function(t,n){return t}).join(\", \")))},{}],2:[function(t,n,e){function r(t,n,e,r,o){try{d?d-=1:i(\"err\",[o||new UncaughtException(t,n,e)])}catch(s){try{i(\"ierr\",[s,c.now(),!0])}catch(u){}}return\"function\"==typeof f&&f.apply(this,a(arguments))}function UncaughtException(t,n,e){this.message=t||\"Uncaught error with no additional information\",this.sourceURL=n,this.line=e}function o(t){i(\"err\",[t,c.now()])}var i=t(\"handle\"),a=t(16),s=t(\"ee\"),c=t(\"loader\"),f=window.onerror,u=!1,d=0;c.features.err=!0,t(1),window.onerror=r;try{throw new Error}catch(l){\"stack\"in l&&(t(8),t(7),\"addEventListener\"in window&&t(5),c.xhrWrappable&&t(9),u=!0)}s.on(\"fn-start\",function(t,n,e){u&&(d+=1)}),s.on(\"fn-err\",function(t,n,e){u&&(this.thrown=!0,o(e))}),s.on(\"fn-end\",function(){u&&!this.thrown&&d>0&&(d-=1)}),s.on(\"internal-error\",function(t){i(\"ierr\",[t,c.now(),!0])})},{}],3:[function(t,n,e){t(\"loader\").features.ins=!0},{}],4:[function(t,n,e){function r(t){}if(window.performance&&window.performance.timing&&window.performance.getEntriesByType){var o=t(\"ee\"),i=t(\"handle\"),a=t(8),s=t(7),c=\"learResourceTimings\",f=\"addEventListener\",u=\"resourcetimingbufferfull\",d=\"bstResource\",l=\"resource\",p=\"-start\",h=\"-end\",m=\"fn\"+p,w=\"fn\"+h,v=\"bstTimer\",y=\"pushState\",g=t(\"loader\");g.features.stn=!0,t(6);var b=NREUM.o.EV;o.on(m,function(t,n){var e=t[0];e instanceof b&&(this.bstStart=g.now())}),o.on(w,function(t,n){var e=t[0];e instanceof b&&i(\"bst\",[e,n,this.bstStart,g.now()])}),a.on(m,function(t,n,e){this.bstStart=g.now(),this.bstType=e}),a.on(w,function(t,n){i(v,[n,this.bstStart,g.now(),this.bstType])}),s.on(m,function(){this.bstStart=g.now()}),s.on(w,function(t,n){i(v,[n,this.bstStart,g.now(),\"requestAnimationFrame\"])}),o.on(y+p,function(t){this.time=g.now(),this.startPath=location.pathname+location.hash}),o.on(y+h,function(t){i(\"bstHist\",[location.pathname+location.hash,this.startPath,this.time])}),f in window.performance&&(window.performance[\"c\"+c]?window.performance[f](u,function(t){i(d,[window.performance.getEntriesByType(l)]),window.performance[\"c\"+c]()},!1):window.performance[f](\"webkit\"+u,function(t){i(d,[window.performance.getEntriesByType(l)]),window.performance[\"webkitC\"+c]()},!1)),document[f](\"scroll\",r,{passive:!0}),document[f](\"keypress\",r,!1),document[f](\"click\",r,!1)}},{}],5:[function(t,n,e){function r(t){for(var n=t;n&&!n.hasOwnProperty(u);)n=Object.getPrototypeOf(n);n&&o(n)}function o(t){s.inPlace(t,[u,d],\"-\",i)}function i(t,n){return t[1]}var a=t(\"ee\").get(\"events\"),s=t(18)(a,!0),c=t(\"gos\"),f=XMLHttpRequest,u=\"addEventListener\",d=\"removeEventListener\";n.exports=a,\"getPrototypeOf\"in Object?(r(document),r(window),r(f.prototype)):f.prototype.hasOwnProperty(u)&&(o(window),o(f.prototype)),a.on(u+\"-start\",function(t,n){var e=t[1],r=c(e,\"nr@wrapped\",function(){function t(){if(\"function\"==typeof e.handleEvent)return e.handleEvent.apply(e,arguments)}var n={object:t,\"function\":e}[typeof e];return n?s(n,\"fn-\",null,n.name||\"anonymous\"):e});this.wrapped=t[1]=r}),a.on(d+\"-start\",function(t){t[1]=this.wrapped||t[1]})},{}],6:[function(t,n,e){var r=t(\"ee\").get(\"history\"),o=t(18)(r);n.exports=r,o.inPlace(window.history,[\"pushState\",\"replaceState\"],\"-\")},{}],7:[function(t,n,e){var r=t(\"ee\").get(\"raf\"),o=t(18)(r),i=\"equestAnimationFrame\";n.exports=r,o.inPlace(window,[\"r\"+i,\"mozR\"+i,\"webkitR\"+i,\"msR\"+i],\"raf-\"),r.on(\"raf-start\",function(t){t[0]=o(t[0],\"fn-\")})},{}],8:[function(t,n,e){function r(t,n,e){t[0]=a(t[0],\"fn-\",null,e)}function o(t,n,e){this.method=e,this.timerDuration=isNaN(t[1])?0:+t[1],t[0]=a(t[0],\"fn-\",this,e)}var i=t(\"ee\").get(\"timer\"),a=t(18)(i),s=\"setTimeout\",c=\"setInterval\",f=\"clearTimeout\",u=\"-start\",d=\"-\";n.exports=i,a.inPlace(window,[s,\"setImmediate\"],s+d),a.inPlace(window,[c],c+d),a.inPlace(window,[f,\"clearImmediate\"],f+d),i.on(c+u,r),i.on(s+u,o)},{}],9:[function(t,n,e){function r(t,n){d.inPlace(n,[\"onreadystatechange\"],\"fn-\",s)}function o(){var t=this,n=u.context(t);t.readyState>3&&!n.resolved&&(n.resolved=!0,u.emit(\"xhr-resolved\",[],t)),d.inPlace(t,y,\"fn-\",s)}function i(t){g.push(t),h&&(x?x.then(a):w?w(a):(E=-E,O.data=E))}function a(){for(var t=0;t<g.length;t++)r([],g[t]);g.length&&(g=[])}function s(t,n){return n}function c(t,n){for(var e in t)n[e]=t[e];return n}t(5);var f=t(\"ee\"),u=f.get(\"xhr\"),d=t(18)(u),l=NREUM.o,p=l.XHR,h=l.MO,m=l.PR,w=l.SI,v=\"readystatechange\",y=[\"onload\",\"onerror\",\"onabort\",\"onloadstart\",\"onloadend\",\"onprogress\",\"ontimeout\"],g=[];n.exports=u;var b=window.XMLHttpRequest=function(t){var n=new p(t);try{u.emit(\"new-xhr\",[n],n),n.addEventListener(v,o,!1)}catch(e){try{u.emit(\"internal-error\",[e])}catch(r){}}return n};if(c(p,b),b.prototype=p.prototype,d.inPlace(b.prototype,[\"open\",\"send\"],\"-xhr-\",s),u.on(\"send-xhr-start\",function(t,n){r(t,n),i(n)}),u.on(\"open-xhr-start\",r),h){var x=m&&m.resolve();if(!w&&!m){var E=1,O=document.createTextNode(E);new h(a).observe(O,{characterData:!0})}}else f.on(\"fn-end\",function(t){t[0]&&t[0].type===v||a()})},{}],10:[function(t,n,e){function r(t){var n=this.params,e=this.metrics;if(!this.ended){this.ended=!0;for(var r=0;r<d;r++)t.removeEventListener(u[r],this.listener,!1);if(!n.aborted){if(e.duration=a.now()-this.startTime,4===t.readyState){n.status=t.status;var i=o(t,this.lastSize);if(i&&(e.rxSize=i),this.sameOrigin){var c=t.getResponseHeader(\"X-NewRelic-App-Data\");c&&(n.cat=c.split(\", \").pop())}}else n.status=0;e.cbTime=this.cbTime,f.emit(\"xhr-done\",[t],t),s(\"xhr\",[n,e,this.startTime])}}}function o(t,n){var e=t.responseType;if(\"json\"===e&&null!==n)return n;var r=\"arraybuffer\"===e||\"blob\"===e||\"json\"===e?t.response:t.responseText;return h(r)}function i(t,n){var e=c(n),r=t.params;r.host=e.hostname+\":\"+e.port,r.pathname=e.pathname,t.sameOrigin=e.sameOrigin}var a=t(\"loader\");if(a.xhrWrappable){var s=t(\"handle\"),c=t(11),f=t(\"ee\"),u=[\"load\",\"error\",\"abort\",\"timeout\"],d=u.length,l=t(\"id\"),p=t(14),h=t(13),m=window.XMLHttpRequest;a.features.xhr=!0,t(9),f.on(\"new-xhr\",function(t){var n=this;n.totalCbs=0,n.called=0,n.cbTime=0,n.end=r,n.ended=!1,n.xhrGuids={},n.lastSize=null,p&&(p>34||p<10)||window.opera||t.addEventListener(\"progress\",function(t){n.lastSize=t.loaded},!1)}),f.on(\"open-xhr-start\",function(t){this.params={method:t[0]},i(this,t[1]),this.metrics={}}),f.on(\"open-xhr-end\",function(t,n){\"loader_config\"in NREUM&&\"xpid\"in NREUM.loader_config&&this.sameOrigin&&n.setRequestHeader(\"X-NewRelic-ID\",NREUM.loader_config.xpid)}),f.on(\"send-xhr-start\",function(t,n){var e=this.metrics,r=t[0],o=this;if(e&&r){var i=h(r);i&&(e.txSize=i)}this.startTime=a.now(),this.listener=function(t){try{\"abort\"===t.type&&(o.params.aborted=!0),(\"load\"!==t.type||o.called===o.totalCbs&&(o.onloadCalled||\"function\"!=typeof n.onload))&&o.end(n)}catch(e){try{f.emit(\"internal-error\",[e])}catch(r){}}};for(var s=0;s<d;s++)n.addEventListener(u[s],this.listener,!1)}),f.on(\"xhr-cb-time\",function(t,n,e){this.cbTime+=t,n?this.onloadCalled=!0:this.called+=1,this.called!==this.totalCbs||!this.onloadCalled&&\"function\"==typeof e.onload||this.end(e)}),f.on(\"xhr-load-added\",function(t,n){var e=\"\"+l(t)+!!n;this.xhrGuids&&!this.xhrGuids[e]&&(this.xhrGuids[e]=!0,this.totalCbs+=1)}),f.on(\"xhr-load-removed\",function(t,n){var e=\"\"+l(t)+!!n;this.xhrGuids&&this.xhrGuids[e]&&(delete this.xhrGuids[e],this.totalCbs-=1)}),f.on(\"addEventListener-end\",function(t,n){n instanceof m&&\"load\"===t[0]&&f.emit(\"xhr-load-added\",[t[1],t[2]],n)}),f.on(\"removeEventListener-end\",function(t,n){n instanceof m&&\"load\"===t[0]&&f.emit(\"xhr-load-removed\",[t[1],t[2]],n)}),f.on(\"fn-start\",function(t,n,e){n instanceof m&&(\"onload\"===e&&(this.onload=!0),(\"load\"===(t[0]&&t[0].type)||this.onload)&&(this.xhrCbStart=a.now()))}),f.on(\"fn-end\",function(t,n){this.xhrCbStart&&f.emit(\"xhr-cb-time\",[a.now()-this.xhrCbStart,this.onload,n],n)})}},{}],11:[function(t,n,e){n.exports=function(t){var n=document.createElement(\"a\"),e=window.location,r={};n.href=t,r.port=n.port;var o=n.href.split(\"://\");!r.port&&o[1]&&(r.port=o[1].split(\"/\")[0].split(\"@\").pop().split(\":\")[1]),r.port&&\"0\"!==r.port||(r.port=\"https\"===o[0]?\"443\":\"80\"),r.hostname=n.hostname||e.hostname,r.pathname=n.pathname,r.protocol=o[0],\"/\"!==r.pathname.charAt(0)&&(r.pathname=\"/\"+r.pathname);var i=!n.protocol||\":\"===n.protocol||n.protocol===e.protocol,a=n.hostname===document.domain&&n.port===e.port;return r.sameOrigin=i&&(!n.hostname||a),r}},{}],12:[function(t,n,e){function r(){}function o(t,n,e){return function(){return i(t,[f.now()].concat(s(arguments)),n?null:this,e),n?void 0:this}}var i=t(\"handle\"),a=t(15),s=t(16),c=t(\"ee\").get(\"tracer\"),f=t(\"loader\"),u=NREUM;\"undefined\"==typeof window.newrelic&&(newrelic=u);var d=[\"setPageViewName\",\"setCustomAttribute\",\"setErrorHandler\",\"finished\",\"addToTrace\",\"inlineHit\",\"addRelease\"],l=\"api-\",p=l+\"ixn-\";a(d,function(t,n){u[n]=o(l+n,!0,\"api\")}),u.addPageAction=o(l+\"addPageAction\",!0),u.setCurrentRouteName=o(l+\"routeName\",!0),n.exports=newrelic,u.interaction=function(){return(new r).get()};var h=r.prototype={createTracer:function(t,n){var e={},r=this,o=\"function\"==typeof n;return i(p+\"tracer\",[f.now(),t,e],r),function(){if(c.emit((o?\"\":\"no-\")+\"fn-start\",[f.now(),r,o],e),o)try{return n.apply(this,arguments)}finally{c.emit(\"fn-end\",[f.now()],e)}}}};a(\"setName,setAttribute,save,ignore,onEnd,getContext,end,get\".split(\",\"),function(t,n){h[n]=o(p+n)}),newrelic.noticeError=function(t){\"string\"==typeof t&&(t=new Error(t)),i(\"err\",[t,f.now()])}},{}],13:[function(t,n,e){n.exports=function(t){if(\"string\"==typeof t&&t.length)return t.length;if(\"object\"==typeof t){if(\"undefined\"!=typeof ArrayBuffer&&t instanceof ArrayBuffer&&t.byteLength)return t.byteLength;if(\"undefined\"!=typeof Blob&&t instanceof Blob&&t.size)return t.size;if(!(\"undefined\"!=typeof FormData&&t instanceof FormData))try{return JSON.stringify(t).length}catch(n){return}}}},{}],14:[function(t,n,e){var r=0,o=navigator.userAgent.match(/Firefox[\\/\\s](\\d+\\.\\d+)/);o&&(r=+o[1]),n.exports=r},{}],15:[function(t,n,e){function r(t,n){var e=[],r=\"\",i=0;for(r in t)o.call(t,r)&&(e[i]=n(r,t[r]),i+=1);return e}var o=Object.prototype.hasOwnProperty;n.exports=r},{}],16:[function(t,n,e){function r(t,n,e){n||(n=0),\"undefined\"==typeof e&&(e=t?t.length:0);for(var r=-1,o=e-n||0,i=Array(o<0?0:o);++r<o;)i[r]=t[n+r];return i}n.exports=r},{}],17:[function(t,n,e){n.exports={exists:\"undefined\"!=typeof window.performance&&window.performance.timing&&\"undefined\"!=typeof window.performance.timing.navigationStart}},{}],18:[function(t,n,e){function r(t){return!(t&&t instanceof Function&&t.apply&&!t[a])}var o=t(\"ee\"),i=t(16),a=\"nr@original\",s=Object.prototype.hasOwnProperty,c=!1;n.exports=function(t,n){function e(t,n,e,o){function nrWrapper(){var r,a,s,c;try{a=this,r=i(arguments),s=\"function\"==typeof e?e(r,a):e||{}}catch(f){l([f,\"\",[r,a,o],s])}u(n+\"start\",[r,a,o],s);try{return c=t.apply(a,r)}catch(d){throw u(n+\"err\",[r,a,d],s),d}finally{u(n+\"end\",[r,a,c],s)}}return r(t)?t:(n||(n=\"\"),nrWrapper[a]=t,d(t,nrWrapper),nrWrapper)}function f(t,n,o,i){o||(o=\"\");var a,s,c,f=\"-\"===o.charAt(0);for(c=0;c<n.length;c++)s=n[c],a=t[s],r(a)||(t[s]=e(a,f?s+o:o,i,s))}function u(e,r,o){if(!c||n){var i=c;c=!0;try{t.emit(e,r,o,n)}catch(a){l([a,e,r,o])}c=i}}function d(t,n){if(Object.defineProperty&&Object.keys)try{var e=Object.keys(t);return e.forEach(function(e){Object.defineProperty(n,e,{get:function(){return t[e]},set:function(n){return t[e]=n,n}})}),n}catch(r){l([r])}for(var o in t)s.call(t,o)&&(n[o]=t[o]);return n}function l(n){try{t.emit(\"internal-error\",n)}catch(e){}}return t||(t=o),e.inPlace=f,e.flag=a,e}},{}],ee:[function(t,n,e){function r(){}function o(t){function n(t){return t&&t instanceof r?t:t?c(t,s,i):i()}function e(e,r,o,i){if(!l.aborted||i){t&&t(e,r,o);for(var a=n(o),s=h(e),c=s.length,f=0;f<c;f++)s[f].apply(a,r);var d=u[y[e]];return d&&d.push([g,e,r,a]),a}}function p(t,n){v[t]=h(t).concat(n)}function h(t){return v[t]||[]}function m(t){return d[t]=d[t]||o(e)}function w(t,n){f(t,function(t,e){n=n||\"feature\",y[e]=n,n in u||(u[n]=[])})}var v={},y={},g={on:p,emit:e,get:m,listeners:h,context:n,buffer:w,abort:a,aborted:!1};return g}function i(){return new r}function a(){(u.api||u.feature)&&(l.aborted=!0,u=l.backlog={})}var s=\"nr@context\",c=t(\"gos\"),f=t(15),u={},d={},l=n.exports=o();l.backlog=u},{}],gos:[function(t,n,e){function r(t,n,e){if(o.call(t,n))return t[n];var r=e();if(Object.defineProperty&&Object.keys)try{return Object.defineProperty(t,n,{value:r,writable:!0,enumerable:!1}),r}catch(i){}return t[n]=r,r}var o=Object.prototype.hasOwnProperty;n.exports=r},{}],handle:[function(t,n,e){function r(t,n,e,r){o.buffer([t],r),o.emit(t,n,e)}var o=t(\"ee\").get(\"handle\");n.exports=r,r.ee=o},{}],id:[function(t,n,e){function r(t){var n=typeof t;return!t||\"object\"!==n&&\"function\"!==n?-1:t===window?0:a(t,i,function(){return o++})}var o=1,i=\"nr@id\",a=t(\"gos\");n.exports=r},{}],loader:[function(t,n,e){function r(){if(!x++){var t=b.info=NREUM.info,n=l.getElementsByTagName(\"script\")[0];if(setTimeout(u.abort,3e4),!(t&&t.licenseKey&&t.applicationID&&n))return u.abort();f(y,function(n,e){t[n]||(t[n]=e)}),c(\"mark\",[\"onload\",a()+b.offset],null,\"api\");var e=l.createElement(\"script\");e.src=\"https://\"+t.agent,n.parentNode.insertBefore(e,n)}}function o(){\"complete\"===l.readyState&&i()}function i(){c(\"mark\",[\"domContent\",a()+b.offset],null,\"api\")}function a(){return E.exists&&performance.now?Math.round(performance.now()):(s=Math.max((new Date).getTime(),s))-b.offset}var s=(new Date).getTime(),c=t(\"handle\"),f=t(15),u=t(\"ee\"),d=window,l=d.document,p=\"addEventListener\",h=\"attachEvent\",m=d.XMLHttpRequest,w=m&&m.prototype;NREUM.o={ST:setTimeout,SI:d.setImmediate,CT:clearTimeout,XHR:m,REQ:d.Request,EV:d.Event,PR:d.Promise,MO:d.MutationObserver};var v=\"\"+location,y={beacon:\"bam.nr-data.net\",errorBeacon:\"bam.nr-data.net\",agent:\"js-agent.newrelic.com/nr-1044.min.js\"},g=m&&w&&w[p]&&!/CriOS/.test(navigator.userAgent),b=n.exports={offset:s,now:a,origin:v,features:{},xhrWrappable:g};t(12),l[p]?(l[p](\"DOMContentLoaded\",i,!1),d[p](\"load\",r,!1)):(l[h](\"onreadystatechange\",o),d[h](\"onload\",r)),c(\"mark\",[\"firstbyte\",s],null,\"api\");var x=0,E=t(17)},{}]},{},[\"loader\",2,10,4,3]);</script>\n");
      out.write("<meta name=\"description\" content=\"Grey Consulting Group - http://us-123office.simplesite.com/\" />\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"//css.simplesite.com/5d/54/3822685.design.v25490.css?h=90c6b5eff5edc30fea2d2cdac3a3188b50dc1449311a6f9a81aff9156780f92d\" />\n");
      out.write("<link rel=\"canonical\" href=\"http://us-123office.simplesite.com/410914420\" />\n");
      out.write("                <link rel=\"icon\" href=\"data:;base64,iVBORw0KGgo=\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"/c/css/experiments/ionicons.css\" />\n");
      out.write("        <script type=\"text/javascript\" src=\"/userPages/pages/FrontendAppLocalePage.aspx?CultureKey=en-US\"></script>\n");
      out.write("                <script type=\"text/javascript\" src=\"//css.simplesite.com/c/js/frontendApp.min.js?_v=6cdd910340f52697c52f7b816e5815ab\"></script>\n");
      out.write("        <script type=\"text/javascript\">if(typeof window.jQuery==\"undefined\"){(function(){var a=document.createElement(\"script\");a.type=\"text/javascript\";a.src=\"/c/js/version3/frontendApp/init/frontendApp.min.js?_v=6cdd910340f52697c52f7b816e5815ab\";document.getElementsByTagName('head')[0].appendChild(a);})();}</script>\n");
      out.write("\n");
      out.write("                <script type=\"text/javascript\">var css_simplesite_com_fallback_element = document.getElementById('css_simplesite_com_fallback');\n");
      out.write("if(typeof css_simplesite_com_fallback_element !== 'undefined' && css_simplesite_com_fallback_element !== null){\n");
      out.write("var isVisible = css_simplesite_com_fallback_element.offsetParent !== null\n");
      out.write("if(isVisible){\n");
      out.write("var head = document.head, link = document.createElement('link');\n");
      out.write("\n");
      out.write("link.type = 'text/css';\n");
      out.write("link.rel = 'stylesheet';\n");
      out.write("link.href = '{/d/designs/3822685.design.v25490.css}';\n");
      out.write("\n");
      out.write("head.appendChild(link);\n");
      out.write("}\n");
      out.write("}</script>\n");
      out.write("        <title>JSP Page</title>\n");
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
      out.write("                                        </li><li class=\" active \" style=\"\">\n");
      out.write("                                            <a href=\"./Services.jsp\">Services</a>\n");
      out.write("                                        </li><li class=\"  \" style=\"\">\n");
      out.write("                                            <a href=\"./Contact.jsp\">Contact</a>\n");
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
      out.write("                            <div class=\"wrapper \">\n");
      out.write("                                <div class=\"content\">\n");
      out.write("                                    <div class=\"section article\">\n");
      out.write("                                        <style>    .wordwrapfix {\n");
      out.write("                                                word-wrap:break-word;\n");
      out.write("                                            }\n");
      out.write("                                        </style>\n");
      out.write("                                        <div class=\"heading wordwrapfix\">\n");
      out.write("                                            <h3>Our Expertise</h3>\n");
      out.write("                                        </div>\n");
      out.write("\n");
      out.write("                                        <div class=\"content\">\n");
      out.write("                                            <div class=\"img-simple span6 pull-right\">\n");
      out.write("                                                <div class=\"image\">\n");
      out.write("                                                    <img src=\"img/4.jpg\"></a>\n");
      out.write("                                                </div>\n");
      out.write("                                            </div>\n");
      out.write("                                            <p><span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip\n");
      out.write("                                                    ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue\n");
      out.write("                                                    duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes\n");
      out.write("                                                    demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis\n");
      out.write("                                                    per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.</span></p>    </div>\n");
      out.write("                                    </div>\n");
      out.write("                                    <div class=\"section article\">\n");
      out.write("                                        <style>    .wordwrapfix {\n");
      out.write("                                                word-wrap:break-word;\n");
      out.write("                                            }\n");
      out.write("                                        </style>\n");
      out.write("                                        <div class=\"heading wordwrapfix\">\n");
      out.write("                                            <h3>Consulting</h3>\n");
      out.write("                                        </div>\n");
      out.write("\n");
      out.write("                                        <div class=\"content\">\n");
      out.write("                                            <p><span>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip\n");
      out.write("                                                    ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue\n");
      out.write("                                                    duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes\n");
      out.write("                                                    demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis\n");
      out.write("                                                    per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.</span></p>    </div>\n");
      out.write("                                    </div>\n");
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
      out.write("                                                <li><a rel=\"nofollow\" id=\"share-facebook\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-facebook-sign\"></i><span>Share on Facebook</span></a></li>\n");
      out.write("                                                <li><a rel=\"nofollow\" id=\"share-twitter\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-twitter-sign\"></i><span>Share on Twitter</span></a></li>\n");
      out.write("                                                <li><a rel=\"nofollow\" id=\"share-google-plus\" href=\"http://us-123office.simplesite.com/410914420#\"><i class=\"icon-google-plus-sign\"></i><span>Share on Google+</span></a></li>\n");
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
      out.write("                    <div class=\"footer-info\">\n");
      out.write("                        <div class=\"footer-powered-by\">\n");
      out.write("                            <a rel=\"nofollow\" href=\"http://www.simplesite.com/pages/receive.aspx?partnerkey=123i%3afooterbanner&amp;referercustomerid=10677696&amp;refererpageid=410914420\">Created with SimpleSite</a>\n");
      out.write("                        </div>\n");
      out.write("                    </div>\n");
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
      out.write("                    <div id=\"css_simplesite_com_fallback\" class=\"hide\"></div>\n");
      out.write("                </div>\n");
      out.write("            </div>\n");
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
