var $ = function (id) { return document.getElementById(id); }

var StyleSwitch = function ( selectId ) {
    var that = this;
    
    // Store a reference to the select node as a property
    this.select = $(selectId);

    // If there is only one style sheet, hide the select node and exit
    this.sheetTitles = this.getStyleSheetTitles();
    if ( this.sheetTitles.length == 1 ) {
        this.select.style.visibility = "hidden";
        return;
    }
    
    // Display the select node with all available style sheets
    this.select.style.visibility = "visible";
    this.buildStyleSelect();

    // Create and attach the event handler for the select node
    this.selectChange = function () { that.update(); }
    jsLib.event.add( this.select, "change", this.selectChange );
}

StyleSwitch.prototype.getStyleSheetTitles = function () {
    // Get all link nodes
    var allLinks = document.getElementsByTagName("link");
    
    // Loop through all link nodes 
    var sheetTitles = [];
    var link, foundTitle;
    for ( var i = 0; i < allLinks.length; i++ ) {
        link = allLinks[i];
        
        // Make sure the link is for a preferred or alternate style sheet
        if ( /stylesheet/.test(link.rel) && link.title !== "" ) {
            // Disable the alternate style sheets
            link.disabled = /alternate/.test(link.rel);
            
            // Check if the title already exists in the array
            foundTitle = false;
            for ( var j = 0; j < sheetTitles.length; j++ ) {
                if ( sheetTitles[j] == link.title ) {
                    foundTitle = true;
                }
            }

            // If the title doesn't exist, add it to the array
            if ( !foundTitle) {
                sheetTitles.push(link.title);
            }
        }
    }    
    return sheetTitles;
}

StyleSwitch.prototype.buildStyleSelect = function () {
    // Create the appropriate option nodes and add them to the select node
    var textNode, option;
    for ( var i = 0; i < this.sheetTitles.length; i++ ) {
        textNode = document.createTextNode( this.sheetTitles[i] );
        option = document.createElement( "option" );
        option.value = this.sheetTitles[i];
        option.appendChild(textNode);
        this.select.appendChild(option);
    }
}

StyleSwitch.prototype.update = function () {
    // Get the selected style sheet
    var optionIndex = this.select.selectedIndex;
    var sheetTitle = this.select.options[optionIndex].value;

    // Loop through all link nodes and enable the appropriate style sheets
    var allLinks = document.getElementsByTagName("link");
    var link;
    for ( var i = 0; i < allLinks.length; i++ ) {
        link = allLinks[i];
        if ( /stylesheet/.test(link.rel) && link.title !== "" ) {
            if ( link.title != sheetTitle ){
                link.disabled = true;
            } else {
                link.disabled = false;
            }
        }
    }
    this.select.blur();
    
    // Force IE to redraw the entire page
    document.documentElement.style.display = "none";
    document.documentElement.style.display = "";
}