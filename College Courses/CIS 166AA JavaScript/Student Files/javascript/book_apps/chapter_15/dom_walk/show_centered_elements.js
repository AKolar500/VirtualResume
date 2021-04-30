var showCenteredElementsCount = function () {
    var centeredElements = jsLib.dom.getElementsByClassName("center");
    alert("Centered elements: " + centeredElements.length);
}

jsLib.dom.ready( showCenteredElementsCount );