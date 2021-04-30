var $ = function (id) { return document.getElementById(id); }

var previewUpdate = function () {
    $("preview").innerHTML = $("editor").value;
}

var editorType = function () {
    previewUpdate();
}

var boldClick = function (evt) {
    (new TextSelection("editor")).addText("<b>", "</b>");
    previewUpdate();
}

var linkClick = function (evt) {
    (new TextSelection("editor")).addText('<a href="http://">', "</a>");
    previewUpdate();
}

jsLib.dom.ready( function () {
    jsLib.event.add( $("editor"), "keyup", editorType );
    jsLib.event.add( $("boldText"), "click", boldClick );
    jsLib.event.add( $("linkText"), "click", linkClick );
});