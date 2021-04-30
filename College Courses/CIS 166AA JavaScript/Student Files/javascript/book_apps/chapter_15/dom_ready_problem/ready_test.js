var $ = function (id) { return document.getElementById(id); }

// The event handler for the Test button
var testClick = function () {
    alert("This button is ready!");
}

window.onload = function () {
    $("btnTest").onclick = testClick;            // Attach event handler
    $("status").firstChild.nodeValue = "READY";  // Update status
}
