if ( ! jsLib ) {
    var jsLib = new Object();
}

if ( ! jsLib.css ) {
    jsLib.css = new Object();
}

if ( !("getComputedStyle" in window) ) {
    window.getComputedStyle = function (e) {
        return e.currentStyle;
    }
}

jsLib.css.getOffset = function ( e, type ) {
    var offset = 0;
    while ( e !== null ) {
        offset += (type == "left") ? e.offsetLeft : e.offsetTop;
        e = e.offsetParent;
    }
    return offset;
}
