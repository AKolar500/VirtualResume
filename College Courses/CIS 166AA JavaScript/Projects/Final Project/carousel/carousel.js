var fishing_pics;

jsLib.event.add( window, "load", function() {
    var options = {
        height: 550,
        maxAspect: 0.3,
        minSize: 0.4,
        maxSpeed: 4
    }

    fishing_pics = new Carousel("fishing_pics", options);
});