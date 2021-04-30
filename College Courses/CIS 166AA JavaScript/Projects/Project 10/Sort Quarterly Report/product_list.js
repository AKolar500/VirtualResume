var itemList; //new

jsLib.dom.ready( function () {
    // Exercise 17-1 Step 4: Add fourth product to table
    var tableNode = document.getElementById("product_list");
    var tbodyNode = tableNode.tBodies[0];
    
	// New row is added to the tbody Node
    var rowNode = tbodyNode.insertRow(-1);

    var textNode1 = document.createTextNode("Totals");
    var cellNode1 = rowNode.insertCell(-1);
    cellNode1.appendChild( textNode1 );
    cellNode1.className = "left-col";

    var textNode2 = document.createTextNode("$5,355.00");
    var cellNode2 = rowNode.insertCell(-1);
    cellNode2.appendChild( textNode2 );
    cellNode2.className = "q1";

    var textNode3 = document.createTextNode("$9,585.00");
    var cellNode3 = rowNode.insertCell(-1);
    cellNode3.appendChild( textNode3 );
    cellNode3.className = "q2";

    var textNode4 = document.createTextNode("$9,398.00");
    var cellNode4 = rowNode.insertCell(-1);
    cellNode4.appendChild( textNode4 );
    cellNode4.className = "q3";

    var textNode5 = document.createTextNode("$6,196.00");
    var cellNode5 = rowNode.insertCell(-1);
    cellNode5.appendChild( textNode5 );
    cellNode5.className = "q4";
    
    // Exercise 17-1 Step 5: Remove first product from table
    // Table header is row 0, first product is row 1
    //tbodyNode.deleteRow(1);

    itemList = new TableSort("product_list");    
});