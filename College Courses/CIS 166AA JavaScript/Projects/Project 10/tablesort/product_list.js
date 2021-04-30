var itemList; //new

jsLib.dom.ready( function () {
    // Exercise 17-1 Step 4: Add fourth product to table
    var tableNode = document.getElementById("product_list");
    var tbodyNode = tableNode.tBodies[0];
    
	// New row is added to the tbody Node
    var rowNode = tbodyNode.insertRow(-1);

    var textNode1 = document.createTextNode("MBT-6114");
    var cellNode1 = rowNode.insertCell(-1);
    cellNode1.appendChild( textNode1 );
    cellNode1.className = "product-code";

    var textNode2 = document.createTextNode("Fly Rod");
    var cellNode2 = rowNode.insertCell(-1);
    cellNode2.appendChild( textNode2 );
    cellNode2.className = "product-descr";

    var textNode3 = document.createTextNode("214.95");
    var cellNode3 = rowNode.insertCell(-1);
    cellNode3.appendChild( textNode3 );
    cellNode3.className = "product-price";
    
    // Exercise 17-1 Step 5: Remove first product from table
    // Table header is row 0, first product is row 1
    tbodyNode.deleteRow(1);

    itemList = new TableSort("product_list");    
});