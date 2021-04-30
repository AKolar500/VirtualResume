if ( ! jsLib ) {
    throw new Error("jsLib Mouse Events: jsLib not loaded");
} else if ( ! jsLib.event ) {
    throw new Error("jsLib Mouse Events: jsLib event not loaded");
}

jsLib.event.mouse = {};

jsLib.event.mouse.fixMouse = function (oEvt, evt) {
    // Copy the User Interface properties
    evt.screenX = oEvt.screenX;
    evt.screenY = oEvt.screenY;
    evt.clientX = oEvt.clientX;
    evt.clientY = oEvt.clientY;
    
    // Fix the button property
    if ( "preventDefault" in oEvt ) {
        evt.button = oEvt.button;
    } else {
        if ( oEvt.button & 1 ) {          // The left button
            evt.button = 0;
        } else if ( oEvt.button & 2 ) {   // The right button
            evt.button = 2;
        } else if ( oEvt.button & 4 ) {   // The middle button
            evt.button = 1;
        } else {
            evt.button = 0;
        }
    }

    // Fix the relatedTarget property
    if ( "relatedTarget" in oEvt ) {
        evt.relatedTarget = oEvt.relatedTarget;    
    } else {
        if ( evt.type == "mouseout" ) {
            evt.relatedTarget = oEvt.toElement;
        } else if ( evt.type == "mouseover" ) {
            evt.relatedTarget = oEvt.fromElement;
        }
    }    
}