var $ = function (id) { return document.getElementById(id); }

// The event handler for the Test button
var testClick = function () {
    alert("This button is ready!");
}

// A function to run when the DOM is ready
var domReady = function () {
    $("btnTest").onclick = testClick;            // Attach event handler
    $("status").firstChild.nodeValue = "READY";  // Update status
}

jsLib.dom.ready( domReady );  // The call to the library