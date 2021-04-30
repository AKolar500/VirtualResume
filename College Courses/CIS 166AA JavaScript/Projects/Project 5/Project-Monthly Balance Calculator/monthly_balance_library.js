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

//create the string for the textarea
var get_transactions = function(transactions) {
    if ( transactions.length == 0 ) {
        return "";
    }
    
    var list = 0;//, line_cost, item_cost, item_count = 0;
    list  = pad_right("Date", 10) + " ";
    list += pad_right("Amount", 40) + " ";
    list += "Running Balance\n";
    list += pad_right("", 10, "-") + " ";
    list += pad_right("", 40, "-") + " ";
    list += pad_right("", 15, "-") + "\n";
    
    for ( var i in transactions ) {
        list += pad_right(transactions[i]["date"], 10) + " ";
        list += pad_right(transactions[i]["amount"], 40) + " ";
		list += pad_left(transactions[i]["subtotal"], 15) + "\n";
        //list += pad_left(transactions[i]["item_qty"],    3) + " ";
        //list += "$" + pad_left(item_cost.toFixed(2),  8) + " ";
        //list += "$" + pad_left(line_cost.toFixed(2),  8) + "\n";
    }
    return list;
}

var get_subtotal = function (transactions) {
    var subtotal = 2000;//, line_cost;
	var amount = $("amount").value;
    /*for ( var i in transactions ) {
        line_cost = transactions[i]["item_qty"] * transactions[i]["item_cost"];
        subtotal += parseFloat( line_cost.toFixed(2) );
    }*/
	
	if ( &("types").value = "withdrawal" ) {
		subtotal -= amount;
	}
	if ( &("types").value = "deposit" ) {
		subtotal += amount;
	}
    return subtotal;
}

var get_amount = function (transactions) {
     var subtotal = get_subtotal(transactions);
     var amount = subtotal;
     return parseFloat( amount.toFixed(2) );
}

var get_total = function (transactions) {
    var total = get_subtotal(transactions) + get_amount(transactions);
    return parseFloat( total.toFixed(2) );
}
