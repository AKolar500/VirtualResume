var pad_left = function(text, width, pad) {
	if ( arguments.length < 2 || arguments.length > 3 ) {
        return "";
    }
    if ( arguments.length == 2 ) {
        pad = " ";
    }
	
	var result = arguments[0].toString();
    while ( result.length < arguments[1] ) {
        result = pad + result;
    }
    return result;
}

var pad_right = function(text, width, pad) {
    if ( arguments.length < 2 || arguments.length > 3 ) {
        return "";
    }
    if ( arguments.length == 2 ) {
        pad = " ";
    }
    
    var result = text.toString();
    while ( result.length < width ) {
        result = result + pad;
    }
    return result;
}

var get_item_list = function(item_list) {
    if ( item_list.length == 0 ) {
        return "";
    }
    
    var list, line_cost, item_cost, item_count = 0;
    list  = pad_right("Item Code", 10) + " ";
    list += pad_right("Item Name", 40) + " ";
    list += "Qty ";
    list += "Item Cost ";
    list += "Line Cost\n";
    list += pad_right("", 10, "-") + " ";
    list += pad_right("", 40, "-") + " ";
    list += "--- ";
    list += pad_right("", 9, "-") + " ";
    list += pad_right("", 9, "-") + "\n";
    
    for ( var i in item_list ) {
        item_cost = parseFloat(item_list[i]["item_cost"]);
        line_cost = item_list[i]["item_qty"] * item_list[i]["item_cost"];
        list += pad_right(item_list[i]["item_code"], 10) + " ";
        list += pad_right(item_list[i]["item_name"], 40) + " ";
        list += pad_left(item_list[i]["item_qty"],    3) + " ";
        list += "$" + pad_left(item_cost.toFixed(2),  8) + " ";
        list += "$" + pad_left(line_cost.toFixed(2),  8) + "\n";
    }
    return list;
}

var get_subtotal = function (item_list) {
    var subtotal = 0, line_cost;
    for ( var i in item_list ) {
        line_cost = item_list[i]["item_qty"] * item_list[i]["item_cost"];
        subtotal += parseFloat( line_cost.toFixed(2) );
    }
    return subtotal;
}

var get_sales_tax = function (item_list) {
     var subtotal = get_subtotal(item_list);
     var sales_tax = subtotal * 0.07;
     return parseFloat( sales_tax.toFixed(2) );
}

var get_total = function (item_list) {
    var total = get_subtotal(item_list) + get_sales_tax(item_list);
    return parseFloat( total.toFixed(2) );
}
