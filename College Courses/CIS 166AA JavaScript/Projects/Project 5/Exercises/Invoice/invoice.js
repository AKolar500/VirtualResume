var invoice = [];

var $ = function(id) { return document.getElementById(id); }

var update_display = function () {
    $("item_list").value = get_item_list(invoice);
    $("subtotal").value = get_subtotal(invoice).toFixed(2);
    $("sales_tax").value = get_sales_tax(invoice).toFixed(2);
    $("total").value = get_total(invoice).toFixed(2);

    $("item_code").value = "";
    $("item_name").value = "";
    $("item_cost").value = "";
    $("item_qty").value = "1";
    
    $("item_code").focus();
}    

var item_add_click = function() {
    var item = [];
    item["item_code"] = $("item_code").value;
    item["item_name"] = $("item_name").value;
    item["item_cost"] = parseFloat($("item_cost").value);
    item["item_qty"]  = parseInt($("item_qty").value);
    
    if ( item["item_code"] == "" ) return;
    if ( item["item_name"] == "" ) return;
    if ( isNaN(item["item_cost"]) ) return;
    if ( isNaN(item["item_qty"] ) ) return;

    invoice.push(item);
    update_display.call();
}

window.onload = function () {
    $("item_add").onclick = item_add_click;
    $("item_code").focus();
	update_display();
}