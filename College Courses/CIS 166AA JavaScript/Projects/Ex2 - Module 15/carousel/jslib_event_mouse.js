if ( ! jsLib ) {
    throw new Error("jsLib Mouse Events: jsLib not loaded");
} else if ( ! jsLib.event ) {
    throw new Error("jsLib Mouse Events: jsLib event not loaded");
}

jsLib.event.mouse = {};

jsLib.event.mouse.fixMouse = function (oEvt, evt) {
    // User Interface properties
    evt.screenX = oEvt.screenX;
    evt.screenY = oEvt.screenY;
    evt.clientX = oEvt.clientX;
    evt.clientY = oEvt.clientY;
    
    // Mouse properties
    if ( typeof oEvt.cancelBubble == "boolean" ) {
        if ( oEvt.button & 1 ) {
            evt.button = 0;
        } else if ( oEvt.button & 2 ) {
            evt.button = 2;
        } else if ( oEvt.button & 4 ) {
            evt.button = 1;
        } else {
            evt.button = 0;
        }
    } else {
        evt.button = oEvt.button;
    }
    
}