if ( ! jsLib ) {
    var jsLib = {};
}

if ( ! jsLib.event ) {
    jsLib.event = {};
}

jsLib.event.handlerId = 1;

jsLib.event.add = function (element, type, handler) {
    // Create a unique ID for each event handler
    if (!handler.handlerId) {
        handler.handlerId = jsLib.event.handlerId++;
    }
    
    // Create two property names for event handlers
    var oldHandlerName = "jsLib_old_" + type + "_" + handler.handlerId;
    var newHandlerName = "jsLib_new_" + type + "_" + handler.handlerId;

    //////// Fix the Event object and attach the event handler
    // DOM Standard
    if ( element.addEventListener ) {   
        element[oldHandlerName] = handler;
        element[newHandlerName] = function(evt) {
            element[oldHandlerName](jsLib.event.fixEvent(evt));
        }
        element.addEventListener( type, element[newHandlerName], false);
        return true;    
    // IE
    } else if ( element.attachEvent ) { 
        element[oldHandlerName] = handler;
        element[newHandlerName] = function() {
            element[oldHandlerName](jsLib.event.fixEvent(window.event));
        }
        element.attachEvent("on"+type, element[newHandlerName]);
        return true;
    }
    return false;
}
    
jsLib.event.remove = function (element, type, handler) {
    var oldHandlerName = "jsLib_old_" + type + "_" + handler.handlerId;
    var newHandlerName = "jsLib_new_" + type + "_" + handler.handlerId;

    //////// Remove the event handler
    // DOM Standard
    if ( element.removeEventListener ) {
        element.removeEventListener(type, element[newHandlerName], false);
        element[newHandlerName] = null;
        element[oldHandlerName] = null;
        return true;
    // IE
    } else if ( element.detachEvent ) {
        element.detachEvent( "on"+type, element[newHandlerName] );
        element[newHandlerName] = null;
        element[oldHandlerName] = null;
        return true;
    }
    return false;
}

jsLib.event.fixEvent = function (oEvt) {
    // if the Event object has already been fixed, exit this method
    if ( oEvt.fixed === true ) return oEvt;

    // Create the new Event object
    var evt = {};
    evt.fixed = true;

    // Set the  properties that don't need to be fixed
    evt.oEvt = oEvt;
    evt.type = oEvt.type;

    // Fix the target property
    if ( "target" in oEvt ) {
        evt.target =  oEvt.target;
    } else if ( "srcElement" in oEvt ) {
        evt.target =  oEvt.srcElement;
    } else {
        evt.target = document;
    }
    if ( evt.target == null ) evt.target = document;
    if ( evt.target.nodeType == 3 ) {       // Fix Safari "span" problem
        evt.target = evt.target.parentNode;
    }

    // Fix the timeStamp property
    if ( "timeStamp" in oEvt ) {
        evt.timeStamp = oEvt.timeStamp;
    } else {
        evt.timeStamp = new Date().valueOf();
    }

    // Set and fix the control key properties
    evt.shiftKey = oEvt.shiftKey;
    evt.ctrlKey = oEvt.ctrlKey;
    evt.altKey = oEvt.altKey;
    evt.metaKey = ( "metaKey" in oEvt ) ? oEvt.metaKey : oEvt.ctrlKey;

    // Fix the preventDefault method
    evt.preventDefault = function () {
        if ( "preventDefault" in oEvt ) {    // DOM Standard
            oEvt.preventDefault();     
        } else if ( "returnValue" in oEvt) { // IE
            oEvt.returnValue = false;  
        }
    }
    
    // Fix the stopPropagation method
    evt.stopPropagation = function () {
        if ( "stopPropagation" in oEvt ) {     // DOM Standard
            oEvt.stopPropagation();    
        } else if ( "cancelBubble" in oEvt ) { // IE
            oEvt.cancelBubble = true;  
        }
    }
    
    // Fix the mouse event properties
    if ( jsLib.event.mouse && jsLib.event.mouse.fixMouse ) {
        jsLib.event.mouse.fixMouse( oEvt, evt );
    }
    
    // Fix the keyboard event properties
    if ( jsLib.event.keyboard && jsLib.event.keyboard.fixKeys ) {
        jsLib.event.keyboard.fixKeys( oEvt, evt );
    }
    
    return evt;
}