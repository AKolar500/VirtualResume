var fishing_pics;

jsLib.event.add( window, "load", function() {
    var options = {
        height: 500,
        maxSpeed: 5
    }
    fishing_pics = new Carousel("fishing_pics", options);
});