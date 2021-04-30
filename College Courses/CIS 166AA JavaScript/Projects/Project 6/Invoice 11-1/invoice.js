var invoice = new Invoice();

var $ = function(id) { return document.getElementById(id); }

var update_invoice = function () {
    $("item_list").value = invoice.get_item_list();
    $("subtotal").value = invoice.get_subtotal().toFixed(2);
    $("sales_tax").value = invoice.get_sales_tax().toFixed(2);
    $("total").value = invoice.get_total().toFixed(2);

    $("item_code").value = "";
    $("item_name").value = "";
    $("item_cost").value = "";
    $("item_qty").value = "1";
	$("item_notes").value = "";
    $("item_delete_code").value = "";

    $("item_code").focus();
}    

var item_add_click = function() {
    var item_code = $("item_code").value;
    var item_name = $("item_name").value;
    var item_cost = $("item_cost").value;
    var item_qty  = $("item_qty").value;
	var item_notes = $("item_notes").value;
    var item_info = new Item_Info(item_name, item_cost, item_qty, item_notes);
    
    invoice.add_item(item_code, item_info);
    update_invoice();
}

var item_delete_click = function() {
    var item_code = $("item_delete_code").value;
    invoice.delete_item(item_code);
    update_invoice();
}

window.onload = function () {
    $("item_add").onclick = item_add_click;
    $("item_delete").onclick = item_delete_click;
	update_invoice();
    $("item_code").focus();
}

