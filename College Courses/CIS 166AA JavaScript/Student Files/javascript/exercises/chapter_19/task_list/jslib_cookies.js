if ( ! jsLib ) var jsLib = {};
if ( ! jsLib.cookies ) jsLib.cookies = {};

jsLib.cookies.parseCookies = function () {
    var raw_cookies = document.cookie.split("; ");
    var cookies = [], cookie, name, value;
    for ( var i = 0; i < raw_cookies.length; i++ ) {
        cookie = raw_cookies[i].split("=");
        name = cookie[0];
        value = decodeURIComponent(cookie[1]);
        cookies[name] = value;
    }
    return cookies;
}

jsLib.cookies.hasCookie = function(name) {
    var cookies = jsLib.cookies.parseCookies();
    return cookies[name] !== undefined;
}

jsLib.cookies.getCookie = function(name) {
    var cookies = jsLib.cookies.parseCookies();
    return cookies[name];
}

jsLib.cookies.setCookie = function (name, value, seconds) {
    if ( arguments.length < 2 ) return;
    var name_pattern = /^[^\s,;]+$/;
    if ( !name_pattern.test(name) ) {
        alert("Invalid Name");
        return;
    }
    var cookie = name + "=" + encodeURIComponent(value);
    if ( seconds !== undefined ) seconds = parseInt(seconds);
    if ( !isNaN(seconds) ) {
        cookie += "; max-age=" + seconds;
    }
    document.cookie = cookie + "; path=/";
}

jsLib.cookies.deleteCookie = function (name) {
    jsLib.cookies.setCookie( name, "", 0 );
}