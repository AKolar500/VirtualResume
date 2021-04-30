var TextSelection = function (id) {
    this.node = document.getElementById(id);

    // Validate the node
    if ( this.node && this.node.nodeType != 1 ) {
        throw new Error (
            "TextSelection: id does not specify an element.");
    }
    var isTextBox = (this.node.tagName == "INPUT" &&
                     this.node.type == "text");
    var isTextArea = ( this.node.tagName == "TEXTAREA" );
    if ( ! ( isTextBox || isTextArea ) ) {
        throw new Error (
            "TextSelection: Element is not a text box or text area.");
    }
}

TextSelection.prototype.getSelectedText = function () {
    if ( this.node.selectionStart !== undefined ) {  // DOM
        var start = this.node.selectionStart;
        var end = this.node.selectionEnd;
        return this.node.value.substring(start, end);
    } else if ( document.selection ) {               // IE
        var range = document.selection.createRange();
        if ( this.node == range.parentElement() ) {
            return range.text;
        }
        return "";
    }
    return "";
}

TextSelection.prototype.getStartIndex = function () {
    if ( this.node.selectionStart !== undefined ) { // DOM
        return this.node.selectionStart;
    } else if ( document.selection ) {              // IE
        return this.getIEIndex("start");
    }
    return 0;
}

TextSelection.prototype.getEndIndex = function () {
    if ( this.node.selectionEnd !== undefined ) {  // DOM
        return this.node.selectionEnd;
    } else if ( document.selection ) {             // IE
        return this.getIEIndex("end");
    }
    return 0;
}

TextSelection.prototype.getIEIndex = function (which) {
    this.node.focus();
    var range = document.selection.createRange();

    if ( this.node !== range.parentElement() ) return 0;

    var index = 0;
    while ( range.parentElement() == this.node ) {
        if (which == "start") {
            range.moveStart("character", -1);
        } else {
            range.moveEnd("character", -1);
        }
        index++;
    }
    return index - 1;
}

TextSelection.prototype.addText = function ( before, after ) {
    this.node.focus();
    if ( before == undefined ) before = "";
    if ( after == undefined ) after = "";
    if ( this.node.selectionStart !== undefined ) {
        var start = this.node.selectionStart;
        var end = this.node.selectionEnd;
        var first = this.node.value.slice(0,start);
        var middle = this.node.value.slice(start,end);
        var last = this.node.value.slice(end);
        var scroll = this.node.scrollTop;
        this.node.value = first + before + middle + after + last;
        var cursor = first.length + before.length;
        if ( middle != "" ) {
            cursor += middle.length + after.length;
        }
        this.node.setSelectionRange(cursor, cursor);
        this.node.scrollTop = scroll;
    } else if ( document.selection ) {
        var range = document.selection.createRange();
        if ( this.node != range.parentElement() ) return;
        if ( range.text == "" ) {
            range.text = before + after;
            range.moveStart("character", -after.length);
            range.moveEnd("character", -after.length);
        } else {
            range.text = before + range.text + after;
        }
        range.select();
    }
}