var $ = function (id) { return document.getElementById(id); }

var rollover1, rollover2;
window.onload = function () {
    rollover1 = new Rollover("image1", "fish.jpg");
	rollover2 = new Rollover("image2", "catchrelease.jpg");
}