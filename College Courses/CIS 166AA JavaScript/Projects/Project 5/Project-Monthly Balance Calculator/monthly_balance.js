/*Alex Kolar
*6/13/2013
*CIS166AA Section 15309
*Program 5
*/

var invoice = [];

var $ = function(id) { return document.getElementById(id); }

var update_display = function () {
    $("transactions").value = get_transactions(invoice);
    //$("subtotal").value = get_subtotal(invoice).toFixed(2);
    $("amount").value = get_subtotal(invoice).toFixed(2);
    //$("total").value = get_total(invoice).toFixed(2);
	
    $("date").value = "";
    $("types").value = "withdrawal";
    $("amount").value = "";
    
    $("date").focus();
}    

var item_add_click = function() {
    var item = [];
    item["date"] = $("date").value;
    //item[""] = $("item_name").value;
	item["type"] = $("types").value;
    item["amount"] = parseFloat($("amount").value);
    
    if ( item["date"] == "" ) return;
    //if ( item["item_name"] == "" ) return;
	if (item["type"] == "" ) return;
    if ( isNaN(item["amount"]) ) return;

    invoice.push(item);
    update_display.call();
}

//right-aligned padding. copied from invoice_library
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

//left-aligned padding. copied from invoice_library
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
var get_transactions(invoice) = function {//(transactions) {
    if ( invoice.length == 0 ) { //invoice used to be transactions
        return "";
    }
    
    var list = "";//, line_cost, item_cost, item_count = 0;
    list  = pad_right("Date", 10) + " ";
    list += pad_right("Amount", 40) + " ";
    list += "Running Balance\n";
    list += pad_right("", 10, "-") + " ";
    list += pad_right("", 40, "-") + " ";
    list += pad_right("", 15, "-") + "\n";
    
    for ( var i in item[] ) { //item used to be transactions
        list += pad_right(item[i]["date"], 10) + " "; //item used to be transactions
        list += pad_right(item[i]["amount"], 40) + " ";
		list += pad_left(item[i]["subtotal"], 15) + "\n";
        //list += pad_left(transactions[i]["item_qty"],    3) + " ";
        //list += "$" + pad_left(item_cost.toFixed(2),  8) + " ";
        //list += "$" + pad_left(line_cost.toFixed(2),  8) + "\n";
    }
    return list;
}

//make the withdrawal or the deposit
var get_subtotal(invoice) = function { //(transactions) {
    var subtotal = 2000;//, line_cost;
	var amount = item["amount"];
    /*for ( var i in transactions ) {
        line_cost = transactions[i]["item_qty"] * transactions[i]["item_cost"];
        subtotal += parseFloat( line_cost.toFixed(2) );
    }*/
	
	if ( item["type"] = "withdrawal" ) {
		subtotal -= amount;
	}
	if ( item["type"] = "deposit" ) {
		subtotal += amount;
	}
    return subtotal;
}

/*var get_amount = function (transactions) {
     var subtotal = get_subtotal(transactions);
     var amount = subtotal;
     return parseFloat( amount.toFixed(2) );
}

var get_total = function (transactions) {
    var total = get_subtotal(transactions) + get_amount(transactions);
    return parseFloat( total.toFixed(2) );
}*/

window.onload = function () {
    $("item_add").onclick = item_add_click;
    $("date").focus();
	update_display();
}