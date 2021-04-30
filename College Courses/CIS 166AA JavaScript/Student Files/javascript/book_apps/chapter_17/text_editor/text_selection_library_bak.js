var TextSelection = function (id) {
    this.node = document.getElementById(id);
    if ( this.node && this.node.nodeType != 1 ) {
        throw new Error ("TextSelection: id does not specify an element.");
    }
}

TextSelection.prototype.getSelectedText = function () {
    if ( window.getSelection ) {                    // DOM model
        var selection = window.getSelection();
        if ( selection.rangeCount > 0 ) {
            var range = selection.getRangeAt(0);
            return range.toString();
        } else if ( this.node.selectionStart !== undefined ) {
            var start = this.node.selectionStart;
            var end = this.node.selectionEnd;
            return this.node.value.substring(start,end);
        }
        return "";
    } else if ( document.selection ) {              // IE model
        var range = document.selection.createRange();
        return range.text;
    }
    return "";
}

TextSelection.prototype.getStartIndex = function () {
    if ( this.node.selectionStart !== undefined ) { // DOM model
            return this.node.selectionStart;
    } else if ( document.selection ) {              // IE model
        var isTextBox = (this.node.tagName == "INPUT" &&
                         this.node.type == "text");
        var isTextArea = ( this.node.tagName == "TEXTAREA" );
        if ( isTextBox || isTextArea ) {
            var range = document.selection.createRange();
            return this.getIEEndpoints(range, "start");
        } else {
            return 0;
        }
    }
    return 0;
}

TextSelection.prototype.getEndIndex = function () {
    if ( this.node.selectionEnd !== undefined ) {
            return this.node.selectionEnd;
    } else if ( document.selection ) {
        var isTextBox = (this.node.tagName == "INPUT" &&
                         this.node.type == "text");
        var isTextArea = ( this.node.tagName == "TEXTAREA" );
        if ( isTextBox || isTextArea ) {
            var range = document.selection.createRange();
            return this.getIEEndpoints(range, "end");
        } else {
            return 0;
        }
    }
    return 0;
}

TextSelection.prototype.getIEEndpoints = function (range, which) {
    var node = range.parentElement();
    var backup = node.value;
    var rangeText = range.text;
    var bookmark = range.getBookmark();
    var counter = 1000, flag;
    do {
        flag = "%_%" + Math.random() + "%_%";
        counter--;
    } while ( backup.indexOf(flag) != -1 && counter > 0);
    if ( counter < 0 ) return 0;
    if ( which == "start" ) {
        range.text = flag + range.text;
    } else {
        range.text = range.text + flag;
    }
    var point = node.value.indexOf(flag);
    node.value = backup;
    range.moveToBookmark(bookmark);
    range.select();
    return point;
}