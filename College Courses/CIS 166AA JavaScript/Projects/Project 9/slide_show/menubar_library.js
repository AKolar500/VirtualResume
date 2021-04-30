var $ = function (id) { return document.getElementById(id); }

// Make sure all required libraries are loaded
if ( ! jsLib ) {
    throw new Error("MenuBar: jsLib CSS and Event libraries required.");
} else if ( ! jsLib.css ) {
    throw new Error("MenuBar: jsLib CSS library required.");
} else if ( ! jsLib.event ) {
    throw new Error("MenuBar: jsLib Event library required.");
}

var MenuBar = function ( menuId ) {
    var that = this;

    // Store a reference to the menu bar as a property
    this.menuBar = $(menuId);

    // Validate the menu bar
    if ( arguments.length != 1 ) {
        throw new Error("MenuBar: Wrong number of arguments.");
    }
    if ( this.menuBar && this.menuBar.nodeType != 1 ) {
        throw new Error("MenuBar: Menu id is not a DOM element.");
    }
    if ( this.menuBar.tagName != "DIV" ) {
        throw new Error("MenuBar: menu id is not a div element.");
    }
    
    // Store a reference to the menu bar links as a property
    this.links = this.menuBar.getElementsByTagName("a");

    // Validate the menu bar links
    if (this.links.length == 0) {
        throw new Error("MenuBar: no links in menu.");
    }
    
    // Add a right border to the last menu bar link
    var lastList = this.links[this.links.length - 1];
    var linkStyle = getComputedStyle(lastList, null);
    lastList.style.borderRightWidth = linkStyle.borderLeftWidth;
    lastList.style.borderRightColor = linkStyle.borderLeftColor;
    lastList.style.borderRightStyle = linkStyle.borderLeftStyle;
    
    // Loop through each menu bar link
    var dropMenu, linkIndex, link;
    var listItems, itemIndex, item;
    for ( linkIndex = 0; linkIndex < this.links.length; linkIndex++) {
        link = this.links[linkIndex];

        // Add an event handler to each menu bar link
        jsLib.event.add ( link, "mouseover", this.highlight(link) );
        jsLib.event.add ( link, "mouseout", this.normal(link) );
        
        // If a drop-down menu exists for the menu bar link...
        if ( link.getAttribute("menu") ) {

            // Store the menu in the array of drop-down menus
            dropMenuName = link.getAttribute("menu");
            dropMenu = $( dropMenuName );

            if ( dropMenu && dropMenu.tagName == "DIV" ) {
                listItems = dropMenu.getElementsByTagName("li");
                
                // Remove the extra bottom border from the last menu item
                last = listItems.length - 1;
                listItems[last].style.borderBottom = "none";
                
                // Add the event handlers to the items
                for (itemIndex=0; itemIndex < listItems.length; itemIndex++) {
                    item = listItems[itemIndex];
                    jsLib.event.add( item, "mouseover", this.highlight(item));
                    jsLib.event.add( item, "mouseout", this.normal(item));
                }

                // Hide the drop-down menus and specify absolute positioning
                dropMenu.style.visibility = "hidden";
                dropMenu.style.position = "absolute";
                
                // Attach the event handlers that display the drop-down menu
                jsLib.event.add( link, "mouseover", 
                    this.displayMenu( dropMenu, link )
                );
                jsLib.event.add( dropMenu, "mouseover", 
                    this.displayMenu( dropMenu, link )
                );
                jsLib.event.add( link, "mouseout", 
                    this.hideMenuWithDelay()
                );
                jsLib.event.add( dropMenu, "mouseout", 
                    this.hideMenuWithDelay()
                );
            }
        // If no drop-down menu exists for the menu bar link...
        } else {
            jsLib.event.add( link, "mouseover", this.hideMenu() );
        }
    }
}

MenuBar.prototype.highlight = function ( element ) {
    return function () {
        element.className = "highlight";
    }
}

MenuBar.prototype.normal = function ( element ) {
    return function () {
        element.className = "";
    }
}

MenuBar.prototype.displayMenu = function ( menu, link ) {
    var that = this;
    return function () {
        // If a timer exists, clear it and delete the hideTimer property
        if ( that.hideTimer ) {
            clearTimeout ( that.hideTimer );
            delete that.hideTimer;
        }
        // If a menu is visible, hide it
        if ( that.visibleMenu ) {
            that.visibleMenu.style.visibility = "hidden";
            delete that.visibleMenu;
        }

        // Calculate the position for the drop-down menu
        var offsetTop, offsetLeft;
        offsetTop  = jsLib.css.getOffsetTop(link);
        offsetTop += link.offsetHeight;
        offsetLeft = jsLib.css.getOffsetLeft(link);
        if ( link.offsetParent.tagName != "BODY" ) {
            offsetTop += 1;
            offsetLeft += 2;
        }

        // Set the Style object properties for the drop-down menu
        menu.style.top = offsetTop + "px";
        menu.style.left = offsetLeft + "px";        
        
        // Store a reference to the drop-down menu and display it
        that.visibleMenu = menu;
        menu.style.visibility = "visible";
    }
}

MenuBar.prototype.hideMenuWithDelay = function () {
    var that = this;
    return function () {
        // Hide the menu after 750 milliseconds
        that.hideTimer = setTimeout( that.hideMenu(), 750 );
    }
}

MenuBar.prototype.hideMenu = function () {
    var that = this;
    return function() {
        // If a timer exists, clear it and delete the hideTimer property
        if ( that.hideTimer ) {
            clearTimeout ( that.hideTimer );
            delete that.hideTimer;
        }
        // If a menu is visible, hide it
        if ( that.visibleMenu ) {
            that.visibleMenu.style.visibility = "hidden";
            delete that.visibleMenu;
        }
    }
}