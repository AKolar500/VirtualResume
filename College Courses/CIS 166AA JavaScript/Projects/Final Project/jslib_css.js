if ( ! jsLib ) { var jsLib = new Object(); }
if ( ! jsLib.css ) { jsLib.css = new Object(); }

// Fix getComputedStyle method for IE model
if ( !("getComputedStyle" in window) ) {
    window.getComputedStyle = function (e) {
        return e.currentStyle;
    }
}

// Define the getOffsetTop method
jsLib.css.getOffsetTop = function ( element ) {
    var offset = 0;
    while ( element !== null ) {
        offset += element.offsetTop;
        element = element.offsetParent;
    }
    return offset;
}

// Define the getOffsetLeft method
jsLib.css.getOffsetLeft = function ( element ) {
    var offset = 0;
    while ( element !== null ) {
        offset += element.offsetLeft;
        element = element.offsetParent;
    }
    return offset;
}