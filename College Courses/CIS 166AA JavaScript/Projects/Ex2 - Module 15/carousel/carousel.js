var fishing_pics;

jsLib.event.add( window, "load", function() {
    var options = {
        height: 550, //was 500
		maxAspect: 0.3,
		minSize: 0.2,
        maxSpeed: 4 //was 5
    }
    fishing_pics = new Carousel("fishing_pics", options);
});