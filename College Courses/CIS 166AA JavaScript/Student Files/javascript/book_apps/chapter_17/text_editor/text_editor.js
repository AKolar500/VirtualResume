var $ = function (id) { return document.getElementById(id); }

var showSelectionClick = function () {
    var ts = new TextSelection("editor");

    var selectedText = ts.getSelectedText();    
    var startIndex = ts.getStartIndex();
    var endIndex = ts.getEndIndex();

    alert("Selected text:  " + selectedText + "\n" +
          "Start index:    " + startIndex + "\n" +
          "End index:      " + endIndex + "\n");
}

jsLib.dom.ready( function () {
    jsLib.event.add( $("showSelection"), "click", showSelectionClick );
});