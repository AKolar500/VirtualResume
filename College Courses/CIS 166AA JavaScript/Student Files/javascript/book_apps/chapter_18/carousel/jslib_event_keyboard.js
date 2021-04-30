if ( ! jsLib ) {
    throw new Error("jsLib Keyboard Events: jsLib not loaded");
} else if ( ! jsLib.event ) {
    throw new Error("jsLib Keyboard Events: jsLib event not loaded");
}

jsLib.event.keyboard = {};

jsLib.event.keyboard.fixKeys = function (oEvt, evt) {
    evt.shiftKey = oEvt.shiftKey;
    evt.ctrlKey = oEvt.ctrlKey;
    evt.altKey = oEvt.altKey;
    evt.metaKey = oEvt.metaKey || oEvt.ctrlKey;

    if ( oEvt.keyIdentifier ) {
        // DOM Level 3 support in original event
        evt.keyIdentifier = oEvt.keyIdentifier;
        evt.keyLocation = oEvt.keyLocation;
        evt.getModiferState = oEvt.getModifierState;
        // Fix two Safari issues
        if ( evt.keyIdentifier == "U+0090" ) {
            evt.keyIdentifier = "NumLock";
        } else if ( evt.keyIdentifier == "U+005D" ) {
            evt.keyIdentifier = "Apps";
        }
    } else { 
        // Non-standard keyboard event
        var code = ( oEvt.keyCode || oEvt.charCode || 0 );
        if ( evt.type == "keydown" || evt.type == "keyup" ) {
            if ( jsLib.event.keyboard.updownKeyId[code] ) {
                evt.keyIdentifier = jsLib.event.keyboard.updownKeyId[code];
            } else {
                evt.keyIdentifier = "Unidentified";
            }
            evt.keyLocation = 0;                
        } else if ( evt.type == "keypress" ) {
            if ( ! this.lastKeyWasControl && this.pressData[code]) {
                evt.data = this.pressData[code];
            } else {
                evt.data = "";
            }
        }
        
        evt.getModifierState = function ( modifier ) {
            switch ( modifier ) {
                case "Shift":
                    return this.shiftKey;
                case "Ctrl":
                    return this.ctrlKey;
                case "Alt":
                    return this.altKey;
                case "Meta":
                    return this.metaKey;
                default:
                    return false;
            }
        }
    }
}
    
jsLib.event.keyboard.keyIdToChar = function ( id ) {
    if ( /^U\+[0-9A-F]{4}$/.test(id) ) {
        return String.fromCharCode(parseInt("0x"+id.substr(2,4)));
    } else {
        return "";
    }
}
    
jsLib.event.keyboard.codeToUnicode = function(code) {
    var unicode = code.toString(16).toUpperCase();
    if ( unicode.length == 1 ) { unicode = "0" + unicode; }
    return "U+00" + unicode;
}

jsLib.event.keyboard.lastKeyWasControl = false;
    
jsLib.event.keyboard.keydownTracker = function (evt) {
    if ( jsLib.event.keyboard.keyIdToChar( evt.keyIdentifier ) == "" ) {
        jsLib.event.keyboard.lastKeyWasControl = true;
    } else if (evt.keyIdentifier == "U+0008") {
        jsLib.event.keyboard.lastKeyWasControl = true;
    } else if (evt.keyIdentifier == "U+007F") {
        jsLib.event.keyboard.lastKeyWasControl = true;
    } else {
        jsLib.event.keyboard.lastKeyWasControl = false;
    }
}
    
jsLib.event.keyboard.updownKeyId = [];
jsLib.event.keyboard.pressData = [];

jsLib.event.keyboard.init = function () {
    // Add keydownTracker to every element in the page
    var tags = document.getElementsByTagName("*");
    for ( var i = 0; i < tags.length; i++) {
        jsLib.event.add(tags[i], "keydown", this.keydownTracker);
    }
    
    var code;
    ///////// keyCode conversions
    // Letters
    for ( code = 65; code <= 90; code++ ) {
        this.updownKeyId[code] = this.codeToUnicode(code);
    }
    // Numbers
    for ( code = 48; code <= 57; code++ ) {
        this.updownKeyId[code] = this.codeToUnicode(code);
    }
    // Symbols
    this.updownKeyId[32] = this.codeToUnicode(" ".charCodeAt(0));
    this.updownKeyId[59] = this.codeToUnicode(";".charCodeAt(0));
    this.updownKeyId[61] = this.codeToUnicode("=".charCodeAt(0));
    this.updownKeyId[107] = this.codeToUnicode("=".charCodeAt(0));
    this.updownKeyId[109] = this.codeToUnicode("-".charCodeAt(0));
    this.updownKeyId[186] = this.codeToUnicode(";".charCodeAt(0));
    this.updownKeyId[187] = this.codeToUnicode("=".charCodeAt(0));
    this.updownKeyId[188] = this.codeToUnicode(",".charCodeAt(0));
    this.updownKeyId[189] = this.codeToUnicode("-".charCodeAt(0));
    this.updownKeyId[190] = this.codeToUnicode(".".charCodeAt(0));
    this.updownKeyId[191] = this.codeToUnicode("/".charCodeAt(0));
    this.updownKeyId[192] = this.codeToUnicode("`".charCodeAt(0));
    this.updownKeyId[219] = this.codeToUnicode("[".charCodeAt(0));
    this.updownKeyId[220] = this.codeToUnicode("\\".charCodeAt(0));
    this.updownKeyId[221] = this.codeToUnicode("]".charCodeAt(0));
    this.updownKeyId[222] = this.codeToUnicode("'".charCodeAt(0));
    // Control Keys
    this.updownKeyId[8] = this.codeToUnicode(8); // Backspace
    this.updownKeyId[9] = this.codeToUnicode(9); // Tab
    this.updownKeyId[13] = "Enter";
    this.updownKeyId[16] = "Shift";
    this.updownKeyId[17] = "Control";
    this.updownKeyId[18] = "Alt";
    this.updownKeyId[19] = "Break";
    this.updownKeyId[20] = "CapsLock";
    this.updownKeyId[27] = this.codeToUnicode(27); // Escape
    this.updownKeyId[33] = "PageUp";
    this.updownKeyId[34] = "PageDown";
    this.updownKeyId[35] = "End";
    this.updownKeyId[36] = "Home";
    this.updownKeyId[37] = "Left";
    this.updownKeyId[38] = "Up";
    this.updownKeyId[39] = "Right";
    this.updownKeyId[40] = "Down";
    this.updownKeyId[44] = "PrintScreen";
    this.updownKeyId[45] = "Insert";
    this.updownKeyId[46] = this.codeToUnicode(127); // Delete
    this.updownKeyId[91] = "Win";  // Left Windows Logo Key
    this.updownKeyId[92] = "Win";  // Right Windows Logo Key
    this.updownKeyId[93] = "Apps"; // The Application Key
    this.updownKeyId[112] = "F1";
    this.updownKeyId[113] = "F2";
    this.updownKeyId[114] = "F3";
    this.updownKeyId[115] = "F4";
    this.updownKeyId[116] = "F5";
    this.updownKeyId[117] = "F6";
    this.updownKeyId[118] = "F7";
    this.updownKeyId[119] = "F8";
    this.updownKeyId[120] = "F9";
    this.updownKeyId[121] = "F10";
    this.updownKeyId[122] = "F11";
    this.updownKeyId[123] = "F12";
    this.updownKeyId[145] = "Scroll"; // Scroll Lock
    this.updownKeyId[219] = "Win";    // Left Windows Logo Key
    this.updownKeyId[220] = "Win";    // Right Windows Logo Key
    // Numeric Keypad
    this.updownKeyId[144] = "NumLock";
    this.updownKeyId[42] = this.codeToUnicode("*".charCodeAt(0));
    this.updownKeyId[43] = this.codeToUnicode("+".charCodeAt(0));
    this.updownKeyId[47] = this.codeToUnicode("\/".charCodeAt(0));
    this.updownKeyId[106] = this.codeToUnicode("*".charCodeAt(0));
    this.updownKeyId[107] = this.codeToUnicode("+".charCodeAt(0));
    this.updownKeyId[109] = this.codeToUnicode("-".charCodeAt(0));
    this.updownKeyId[110] = this.codeToUnicode(".".charCodeAt(0));
    this.updownKeyId[111] = this.codeToUnicode("\/".charCodeAt(0));
    for ( code = 96; code <= 105; code++ ) {
        this.updownKeyId[code] = this.codeToUnicode(code - 48);
    }
    this.updownKeyId[12] = "Clear"; // NumPad5 with NumLock Off
    
    // pressData conversions
    for ( code = 32; code <= 126; code++ ) {
        this.pressData[code] = String.fromCharCode(code);
    }
}

jsLib.event.keyboard.init();