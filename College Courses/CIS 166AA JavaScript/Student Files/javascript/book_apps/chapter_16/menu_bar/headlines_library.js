var $ = function (id) { return document.getElementById(id); }

var Headlines = function ( ulId, imgId, show ) {
    var that = this;
    if ( arguments.length < 2 || arguments.length > 3) {
        throw new Error("Headlines: wrong number of arguments.");
    }
    this.ulNode = $(ulId);
    if ( this.ulNode && this.ulNode.nodeType != 1 ) {
        throw new Error("Headlines: UL id is not a DOM element.");
    }
    if ( this.ulNode.tagName != "UL" ) {
        throw new Error("Headlines: UL id is not a UL element.");
    }
    this.imgNode = $(imgId);
    if ( this.imgNode && this.imgNode.nodeType != 1 ) {
        throw new Error("Headlines: IMG id is not a DOM element.");
    }
    if ( this.imgNode.tagName != "IMG" ) {
        throw new Error("Headlines: IMG id is not a IMG element.");
    }
    show = (arguments.length == 2) ? 3 : parseInt(show);
    if ( isNaN(show) || show < 1 ) {
        throw new Error("Headlines: show is not a valid number.");
    }
    
    this.show = show;
    this.items = [];
    this.running = false;

    var node;
    while ( this.ulNode.hasChildNodes() ) {
        node = this.ulNode.removeChild( this.ulNode.firstChild );
        if ( node.nodeType == 1 && node.tagName == "LI") {
            this.items.push(node);
        }
    }
    
    this.next = 0;
    while ( this.next < this.show && this.next < this.items.length) {
        this.ulNode.appendChild( this.items[this.next] );
        this.next++;
    }
    this.next--;
    
    this.imgClick = function () { that.toggle(); };
    this.ulOver   = function () { that.pause(); };
    this.ulOut    = function () { that.play(); };

    jsLib.event.add( this.imgNode, "click", this.imgClick );
    jsLib.event.add( this.ulNode, "mouseover", this.ulOver );
    jsLib.event.add( this.ulNode, "mouseout", this.ulOut );

    this.play();
}

Headlines.prototype.showNext = function () {
    this.next++;
    this.next %= this.items.length;
    this.ulNode.removeChild( this.ulNode.firstChild );
    this.ulNode.appendChild( this.items[this.next] );
}

Headlines.prototype.pause = function () {
    clearInterval( this.timer );
    this.imgNode.src = "play.gif";
    this.running = false;
}

Headlines.prototype.play = function () {
    var that = this;
    this.timer = setInterval( function() { that.showNext(); }, 3000 );
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