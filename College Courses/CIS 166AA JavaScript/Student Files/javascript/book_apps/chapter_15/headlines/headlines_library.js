var $ = function (id) { return document.getElementById(id); }

var Headlines = function ( ulId, imgId, headlineCount ) {
    var headlines = this;

    // Validate the number of arguments for the method
    if ( arguments.length < 2 || arguments.length > 3) {
        throw new Error("Headlines: wrong number of arguments.");
    }

    // Store references to the element nodes as properties
    this.ulNode = $(ulId);
    this.imgNode = $(imgId);

    // Validate the nodes
    if ( this.ulNode && this.ulNode.nodeType != 1 ) {
        throw new Error("Headlines: UL id is not a DOM element.");
    }
    if ( this.ulNode.tagName != "UL" ) {
        throw new Error("Headlines: UL id is not a UL element.");
    }
    if ( this.imgNode && this.imgNode.nodeType != 1 ) {
        throw new Error("Headlines: IMG id is not a DOM element.");
    }
    if ( this.imgNode.tagName != "IMG" ) {
        throw new Error("Headlines: IMG id is not a IMG element.");
    }

    // Convert the headlineCount argument to an integer value and validate it
    if (arguments.length == 2) {
        headlineCount = 3;
    } else {
        headlineCount = parseInt(headlineCount);
    }
    if ( isNaN(headlineCount) || headlineCount < 1 ) {
        throw new Error("Headlines: Headline count is not a valid number.");
    }

    // Define the application parameters
    this.headlineCount = headlineCount;
    this.items = [];
    this.running = false;

    // Remove the LI nodes from the UL node and store them in the items array
    var node;
    while ( this.ulNode.hasChildNodes() ) {
        node = this.ulNode.removeChild( this.ulNode.firstChild );
        if ( node.nodeType == 1 && node.tagName == "LI") {
            this.items.push(node);
        }
    }

    // Append the appropriate number of LI nodes to the UL node
    this.next = 0;
    while ( this.next < this.headlineCount && this.next < this.items.length) {
        this.ulNode.appendChild( this.items[this.next] );
        this.next++;
    }
    this.next--;

    // Define the event handlers
    this.imgClick = function () { headlines.toggle(); };
    this.ulOver   = function () { headlines.pause(); };
    this.ulOut    = function () { headlines.play(); };

    // Attach the event handlers to events
    jsLib.event.add( this.imgNode, "click", this.imgClick );
    jsLib.event.add( this.ulNode, "mouseover", this.ulOver );
    jsLib.event.add( this.ulNode, "mouseout", this.ulOut );

    // Call the play method
    this.play();
}

Headlines.prototype.showNext = function () {
    this.next++;
    this.next = this.next % this.items.length;
    this.ulNode.removeChild( this.ulNode.firstChild );
    this.ulNode.appendChild( this.items[this.next] );
}

Headlines.prototype.pause = function () {
    clearInterval( this.timer );
    this.imgNode.src = "play.gif";
    this.running = false;
}

Headlines.prototype.play = function () {
    var headlines = this;
    this.timer = setInterval( function() { headlines.showNext(); }, 3000 );
    this.imgNode.src = "pause.gif";
    this.running = true;
}

Headlines.prototype.toggle = function () {
    if ( this.running ) {
        this.pause();
    } else {
        this.play();
    }
}