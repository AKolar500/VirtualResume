var fishing_pics;

jsLib.event.add( window, "load", function() {
    var options = {
        height: 550,
		maxAspect: 0.35,
		minSize: 0.25,
        maxSpeed: 1
    }
    fishing_pics = new Carousel("fishing_pics", options);
});