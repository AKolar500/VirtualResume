// Detect required jsLib objects
if ( !jsLib ) {
    throw new Error("Carousel: Requires jsLib_css, jsLib_event, " + 
        "jsLib_event_mouse, and jsLib_event_keyboard");
} else if ( !jsLib.css ) {
    throw new Error("Carousel: Requires jsLib_css");
} else if ( !jsLib.event ) {
    throw new Error("Carousel: Requires jsLib_event, " +
        "jsLib_event_mouse, and jsLib_event_keyboard");
} else if ( !jsLib.event.mouse ) {
    throw new Error("Carousel: Requires jsLib_event_mouse");
} else if ( !jsLib.event.keyboard ) {
    throw new Error("Carousel: Requires jsLib_event_keyboard");
}

Math.sign = function (value) {
    if (value > 0) return 1;
    if (value < 0) return -1;
    return 0;
}

/**********************************************
* Define the ImageElement object
***********************************************/
var ImageElement = function ( divNode, imageNode ) {
    this.div = divNode;
    this.image = imageNode;
    this.originalWidth = this.image.width;
    this.originalHeight = this.image.height;
    this.image.style.position = "absolute";
}

ImageElement.prototype.getOriginalSize = function () {
    return { width: this.originalWidth, height: this.originalHeight };
}

ImageElement.prototype.updateImage = function ( 
        maxSize, angle, aspect, minSize) {

    // 1. Calculate bounds for images
    var maxWidth = this.div.clientWidth / 2;
    var maxHeight = this.div.clientHeight * (1 - Math.abs(aspect));
    var centerX = jsLib.css.getOffsetLeft(this.div) + this.div.clientWidth/2;
    var centerY = jsLib.css.getOffsetTop(this.div) + this.div.clientHeight/2;
    var maxX = this.div.clientWidth / 2 - maxWidth / 2;
    var maxY = this.div.clientHeight / 2 - maxHeight / 2;
    var maxZ = 100;

    // 2. Calculate 3D position
    var angleRadians = angle * Math.PI / 180;
    var deltaX = Math.cos(angleRadians) * maxX;
    var deltaY = Math.sin(angleRadians) * maxY * Math.sign(aspect) * -1;
    var deltaZ = Math.sin(angleRadians) * maxZ * -1 + maxZ;

    // 3. Calculate image size
    var scale = (deltaZ / (maxZ * 2) ) * (1 - minSize) + minSize;
    var imageWidth = maxSize.width * scale;
    var imageHeight = maxSize.height * scale;

    // 4. Calculate image edge offset
    var x = centerX + deltaX - this.image.width / 2;
    var y = centerY + deltaY - this.image.height / 2;

    // 5. Apply size and position values
    this.image.style.left = Math.round(x) + "px";
    this.image.style.top  = Math.round(y) + "px";
    this.image.style.zIndex = Math.round(deltaZ);
    this.image.width = Math.round(imageWidth);
    this.image.height = Math.round(imageHeight);
}

/**********************************************
* Define the Carousel object
***********************************************/
var Carousel = function(id, options) {
    // 1. If necessary, create options object
    if (!options) options = {};

    // 2. Set default for height or get from options param
    if (isNaN(options.height)) {
        this.height = 400;
    } else {
        this.height = parseInt(options.height);
        this.height = Math.max(this.height, 50);
    }

    // 3. Set default for maxAspect or get from options param
    if (isNaN(options.maxAspect)) {
        this.maxAspect = 0.5;
    } else {
        this.maxAspect = parseFloat(options.maxAspect);
        this.maxAspect = Math.max(this.maxAspect, 0);
        this.maxAspect = Math.min(this.maxAspect, .75);
    }

    // 4. Set default for minSize or get from options param
    if (isNaN(options.minSize)) {
        this.minSize = 0.15;
    } else {
        this.minSize = parseFloat(options.minSize);
        this.minSize = Math.max(this.minSize, 0.05);
        this.minSize = Math.min(this.minSize, 0.95);
    }

    // 5. Set default for maxSpeed or get from options param
    if (isNaN(options.maxSpeed)) {
        this.maxSpeed = 10;
    } else {
        this.maxSpeed = parseFloat(options.maxSpeed);
        this.maxSpeed = Math.max(this.maxSpeed, 1);
        this.maxSpeed = Math.min(this.maxSpeed, 45);
    }

    // 6. Set internal properties and variables
    this.aspect = Math.min( this.maxAspect, 0.40 );
    this.speed = this.maxSpeed;
    this.paused = false;
    this.angle = 0;
    var that = this;

    // 7. Get div element from id param
    this.div = document.getElementById(id);

    // Validate div element
    if ( !this.div ) {
        throw new Error("Carousel: ID is not an element.");
    }
    if ( this.div.nodeType !== 1 || this.div.nodeName !== "DIV" ) {
        throw new Error("Carousel: ID is not a DIV tag.");
    }

    // 8. Get image nodes
    var imgNodes = this.div.getElementsByTagName("img");
    
    // Validate image nodes
    if ( imgNodes.length == 0 ) {
        throw new Error("Carousel: DIV tag needs at least one image.");
    }

    // 9. Store image nodes in images property
    this.images = [];
    var imageNode, imageElement;
    for ( var i = 0; i < imgNodes.length; i++ ) {
        imageNode = imgNodes[i];
        imageElement = new ImageElement(this.div, imgNodes[i]);
        this.images.push( imageElement );
    }

    // 10. Set height of div element
    this.div.style.height = this.height + "px";

    // 11. Attach event handlers
    jsLib.event.add(this.div, "mousemove", function(evt) {
        that.mousemoveHandler(evt);
    });
    var htmlElement = document.getElementsByTagName("html")[0];
    jsLib.event.add(htmlElement, "keydown", function(evt) {
        that.keydownHandler(evt);
    });

    // 12. Start animation
    this.onTimer();
    setInterval( function() { that.onTimer(); }, 50 );
}

Carousel.prototype.mousemoveHandler = function (evt) {
    // 1. Set null zone width to stop carousel
    var nullWidth = 1 / (this.maxSpeed * 2 + 1);
    var nullMin = 0.5 - ( nullWidth / 2 );
    var nullMax = 0.5 + ( nullWidth / 2 );

    // 2. Determine mouse position in percent
    var baseX = jsLib.css.getOffsetLeft(this.div);
    var mousePct = (evt.clientX - baseX) / 
        this.div.clientWidth;

    // 3. Set speed based on mouse position
    if ( mousePct > nullMin && mousePct < nullMax ) {
        this.speed = 0;
    } else if ( mousePct <= nullMin ) {
        this.speed = Math.floor(
            -this.maxSpeed * ((nullMin - mousePct) / nullMin)
        );
    } else {
        this.speed = Math.ceil(
            this.maxSpeed * ((mousePct - nullMax) / nullMin)
        );
    }
}

Carousel.prototype.keydownHandler = function (evt) {
    switch( evt.keyIdentifier ) {
        case "Up":      // CTRL-Up
            if ( evt.getModifierState("Ctrl") ) {
                this.aspect += 0.05;
                this.aspect = Math.min(this.aspect, this.maxAspect);
            }
            break;
        case "Down":    // CTRL-Down
            if ( evt.getModifierState("Ctrl") ) {
                this.aspect -= 0.05;
                this.aspect = Math.max(this.aspect, -this.maxAspect);
            }
            break;
        case "Right":   // CTRL-Right
            if ( evt.getModifierState("Ctrl") ) {
                this.speed = this.maxSpeed * 0.7;
                this.paused = false;
            }
            break;
        case "Left":    // CTRL-Left
            if ( evt.getModifierState("Ctrl") ) {
                this.speed = -this.maxSpeed * 0.7;
                this.paused = false;
            }
            break;
        case "U+001B":  // Escape key
            this.paused = !this.paused;
            break;
    }
}

Carousel.prototype.onTimer = function () {
    // 1. Update angle if not paused
    if ( ! this.paused ) {
        this.angle = (this.angle + this.speed) % 360;
        this.angle = (this.angle < 0 ) ? this.angle + 360 : this.angle;
    }

    // 2. Find tallest and widest image 
    var largestWidth = -Infinity;
    var largestHeight = -Infinity;
    var i, imageSize;
    for (i in this.images ) {
        imageSize = this.images[i].getOriginalSize();
        largestWidth = Math.max( largestWidth, imageSize.width );
        largestHeight = Math.max( largestHeight,imageSize.height );
    }

    // 3. Calculate scale for images to fit in largest size
    var maxWidth = this.div.clientWidth / 2;
    var maxHeight = this.div.clientHeight * (1 - Math.abs(this.aspect));
    var scaleX = maxWidth / largestWidth;
    var scaleY = maxHeight / largestHeight;
    var scale = Math.min(scaleX, scaleY);

    // 4. Position and size images
    var angle, angleOffset;
    for (i in this.images) {
        // Calculate image size
        imageSize = this.images[i].getOriginalSize();
        imageSize.width *= scale;
        imageSize.height *= scale;

        // Calculate image angle
        angleOffset = 360 * ( i / this.images.length );
        angle = (this.angle + angleOffset) % 360; 
        
        // Call updateImage method
        this.images[i].updateImage( imageSize, angle,
                                    this.aspect, this.minSize );
    }
}