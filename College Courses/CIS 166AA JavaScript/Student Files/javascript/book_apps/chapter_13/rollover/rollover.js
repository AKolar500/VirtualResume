var $ = function (id) { return document.getElementById(id); }

var rollover;
window.onload = function () {
    rollover = new Rollover("image", "fish.jpg");
}