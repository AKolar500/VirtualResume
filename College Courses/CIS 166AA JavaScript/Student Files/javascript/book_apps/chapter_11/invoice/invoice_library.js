String.prototype.pad_left = function() {
    if ( arguments.length < 1 || arguments.length > 2 ) {
        return this;
    }
    var width = parseInt(arguments[0]);
    var pad = " ";
    if ( arguments.length == 2 ) pad = arguments[1];
    
    var result = this;
    while ( result.length < width ) {
        result = pad + result;
    }
    return result;
}

String.prototype.pad_right = function() {
    if ( arguments.length < 1 || arguments.length > 2 ) {
        return this;
    }
    var width = parseInt(arguments[0]);
    var pad = " ";
    if ( arguments.length == 2 ) pad = arguments[1];
    
    var result = this;
    while ( result.length < width ) {
        result = result + pad;
    }
    return result;
}

var Item_Info = function( item_name, item_cost, item_qty ) {
    this.item_name = item_name;
    this.item_cost = parseFloat(item_cost);
    this.item_qty  = parseInt(item_qty);
}

var Invoice = function() {
    this.items = [];
    this.tax_rate = 0.07;
}

Invoice.prototype.add_item = function(item_code, item_info) {
    if ( ! item_info instanceof Item_Info ) return this;
    if ( isNaN(item_info.item_cost) ) return this;
    if ( isNaN(item_info.item_qty)  ) return this;
    if ( item_info.item_name == ""  ) return this;
    if ( item_code == "" ) return this;
    
    item_code = item_code.toUpperCase();
    if ( item_code in this.items ) {
        delete this.items[item_code];
    }
    
    this.items[item_code] = item_info;
    this.sort_by_code();
    
    return this;
}

Invoice.prototype.delete_item = function(item_code) {
    item_code = item_code.toUpperCase();
    if ( item_code in this.items ) {
        delete this.items[item_code];
    }
    return this;
}

Invoice.prototype.get_item_list = function() {
    var item_list, line_cost, item_count = 0;
    item_list  = "Item Code".pad_right(10) + " ";
    item_list += "Item Name".pad_right(40) + " ";
    item_list += "Qty ";
    item_list += "Item Cost ";
    item_list += "Line Cost\n";
    item_list += "".pad_right(10,"-") + " ";
    item_list += "".pad_right(40,"-") + " ";
    item_list += "--- ";
    item_list += "".pad_right(9,"-") + " ";
    item_list += "".pad_right(9,"-") + "\n";
    for ( var code in this.items ) {
        line_cost =
            this.items[code].item_qty * this.items[code].item_cost;
        item_list += code.pad_right(10) + " ";
        item_list += this.items[code].item_name.pad_right(40) + " ";
        item_list += 
            this.items[code].item_qty.toString().pad_left(3) + " ";
        item_list +=
            "$" + this.items[code].item_cost.toFixed(2).pad_left(8) + " ";
        item_list += "$" + line_cost.toFixed(2).pad_left(8) + "\n";
        item_count++;
    }
    return (item_count == 0) ? "" : item_list;
}

Invoice.prototype.get_subtotal = function () {
    var subtotal = 0, line_cost;
    for ( var code in this.items ) {
        line_cost =
            this.items[code].item_qty * this.items[code].item_cost;
        subtotal += parseFloat( line_cost.toFixed(2) );
    }
    return subtotal;
}

Invoice.prototype.get_sales_tax = function () {
     var subtotal = this.get_subtotal();
     var sales_tax = subtotal * this.tax_rate;
     return parseFloat( sales_tax.toFixed(2) );
}

Invoice.prototype.get_total = function () {
    var total = this.get_subtotal() + this.get_sales_tax();
    return parseFloat( total.toFixed(2) );
}

Invoice.prototype.sort_by_code = function () {
    var code, codes = [], sorted_list = [];
    for ( code in this.items ) codes.push(code);
    codes.sort();
    for ( code in codes ) {
        sorted_list[ codes[code] ] = this.items[ codes[code] ];
    }
    this.items = sorted_list;
    return this;
}
    