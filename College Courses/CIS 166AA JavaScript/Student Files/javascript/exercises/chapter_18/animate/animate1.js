var compassToRadians = function ( compass ) {
    var radians = ( 180 - compass - 90 ) * Math.PI / 180 % (2 * Math.PI);
    return ( radians < 0 ) ? radians + (2 * Math.PI) : radians;
}

/**********************************************
* Define the AnimationElement object
***********************************************/
var AnimationElement = function ( element ) {
    this.element = element;
}

AnimationElement.prototype.getPosition = function() {
    var style = getComputedStyle( this.element, null );
    return { x: parseInt( style.left ), y: parseInt( style.top ) };
}

AnimationElement.prototype.updatePosition = function ( distance, heading ) {
    var position = this.getPosition();

    var deltaX = distance * Math.cos( compassToRadians(heading) );
    var deltaY = distance * Math.sin( compassToRadians(heading) );

    var x = Math.round( position.x + deltaX );
    var y = Math.round( position.y - deltaY );

    this.element.style.left = x + "px";
    this.element.style.top  = y + "px";
}

/**********************************************
* Define the ElementAnimator object
***********************************************/
var ElementAnimator = function ( element, speed ) {
    this.element = element;
    this.speed = speed;
    this.heading = 90;
}

ElementAnimator.prototype.onTimer = function () {
    var now = new Date().getTime();
    var elapsedMS = now - this.lastUpdate;         // ms since last update
    this.lastUpdate = now;
    var distance = this.speed * elapsedMS / 1000;  // Convert ms to seconds
    this.element.updatePosition( distance, this.heading );
}

ElementAnimator.prototype.play = function() {
    var that = this;
    this.lastUpdate = new Date().getTime();
    this.timer = setInterval( function() { that.onTimer() }, 50 );
}

/**********************************************
* Start the animation
***********************************************/
var fishElement, animator;

jsLib.event.add( window, "load", function () {
    fishElement = new AnimationElement( document.getElementById("fish") );
    animator = new ElementAnimator( fishElement, 150 );
    animator.play();
});