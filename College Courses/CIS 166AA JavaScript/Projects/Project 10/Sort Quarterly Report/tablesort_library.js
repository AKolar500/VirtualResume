var TableSort = function ( tableId ) {
    var that = this;

    // Store a reference to the table node as a property
    this.table = document.getElementById(tableId);
    
    // Validate the table node
    if ( this.table && this.table.nodeType != 1 ) {
        throw new Error("TableSort: Table id is not a DOM element.");
    }
    if ( this.table.tagName != "TABLE" ) {
        throw new Error("TableSort: Table id is not a table element.");
    }

    // Set three global properties
    this.sortColumn = "";
    this.sortUp = true;
    this.imageNodes = [];

    // Get the header nodes
    var headers = this.table.getElementsByTagName("th");

    // Loop through the header nodes
    var header, columnName, imageNode, imageClick;
    for ( var i = 0; i < headers.length; i++) {
        header = headers[i];
        
        // Create a node for the image
        imageNode = document.createElement("img");
        
        // Add the "sort arrow" images to the header column
        // And set the first column as the default sort column
        columnName = header.className;
        if ( i == 0 ) {
            this.sortColumn = columnName;
            imageNode.src = "arrows_up.png";
        } else {
            imageNode.src = "arrows_off.png";
        }

        // Get the event handler for the image
        imageClick = this.imageClickHandler(columnName);
        
        // Add the event handler to the image
        jsLib.event.add(imageNode, "click", imageClick);
        
        // Add the image node to column header and to array of image nodes
        header.appendChild(imageNode);
        this.imageNodes[columnName] = imageNode;
    }
    
    // Sort the table
    this.sort();
}

TableSort.prototype.imageClickHandler = function (columnName) {
    var that = this;
    
    // return an event handler
    return function () {
        // If current sort column, toggle the sort direction
        if ( that.sortColumn == columnName ) {
            that.sortUp = ! that.sortUp;
        // Otherwise...
        } else {
            // Set the image for the old sort column
            that.imageNodes[that.sortColumn].src = "arrows_off.png";
            
            // Switch the current sort column and sort ascending
            that.sortColumn = columnName;
            that.sortUp = true;
        }
        
        // Set the appropriate arrows for the current sort column
        if ( that.sortUp ) {
            that.imageNodes[that.sortColumn].src = "arrows_up.png";
        } else {
            that.imageNodes[that.sortColumn].src = "arrows_down.png";
        }

        that.sort();
    }
}

TableSort.prototype.sort = function () {	
    var that = this;
    if ( this.sortColumn == "" ) return;

    // Get the rows from the table
    var rowNodes = this.table.getElementsByTagName("tr");
    if (rowNodes.length <= 1 ) return;

    // Store a reference to each row in the rows array
    var rows = [];
    for ( var i = 0; i < rowNodes.length; i++) {
        rows.push( rowNodes[i] );
    }

    // Get a reference to the tbody node
    var tbodyNode = rows[0].parentNode;
    
    // Remove the header row from the array (but not the DOM)
    rows.shift();
    
    // Exercise 17-1 Step 3: Remove table rows with deleteRow
    // Remove all rows except the header row from the DOM
    /*
	var row;
    for ( i = 1; i < rows.length; i++ ) {
        row = rows[i];
        row.parentNode.removeChild(row);
    }
	*/
    while ( tbodyNode.rows > 1 ) {
            tbodyNode.deleteRow(1);
    }

    // Define two functions that check for data types
    var isDate = function ( value ) {
        var d = new Date(value);
        return ! isNaN(d);
    }
    var isMoney = function ( value ) {
        var m = value.replace( /[$,]/g, "" );
        return ! isNaN(m);
    }

    // Define the sort direction
    var direction = ( that.sortUp ) ? 1 : -1;
    
    // Define the function that compares the rows
    var sortRows = function (rowA, rowB) {
        var i, textA, textB, valueA, valueB;
        var cell;

        // Get the cell value for row A
        var cellsA = rowA.getElementsByTagName("td");
        for ( i = 0; i < cellsA.length; i++ ) {
            cell = cellsA[i];
            if ( cell.className == that.sortColumn ) {
                valueA = cell.firstChild.nodeValue;
                break;
            }
        }

        // Get the cell value for row B
        var cellsB = rowB.getElementsByTagName("td");
        for ( i = 0; i < cellsB.length; i++ ) {
            cell = cellsB[i];
            if ( cell.className == that.sortColumn ) {
                valueB = cell.firstChild.nodeValue;
                break;
            }
        }

        // Convert the values to the appropriate data type
        if ( ! isNaN(valueA) && ! isNaN(valueB) ) {
            valueA = parseFloat(valueA);
            valueB = parseFloat(valueB);
        } else if ( isDate(valueA) && isDate(valueB) ) {
            valueA = new Date(valueA);
            valueB = new Date(valueB);
        } else if ( isMoney(valueA) && isMoney(valueB) ) {
            valueA = parseFloat(valueA.replace( /[$,]/g, "" ));
            valueB = parseFloat(valueB.replace( /[$,]/g, "" ));
        }

        // Compare the two values and return the appropriate comparison value
        if ( valueA < valueB ) {
            return -1 * direction;
        } else if ( valueB < valueA ) {
            return 1 * direction;
        } else {
            return 0;
        }
    }
    
    // Use the sortRows function to sort the rows array
    rows.sort( sortRows );

    // Append the sorted rows to the table body node
    for ( i = 0; i < rows.length; i++) {
        tbodyNode.appendChild( rows[i] );
    }
}