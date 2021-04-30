var $log = function () {
    if (typeof console == "object" && console.log ) {
        console.log.apply(console, arguments);
    }
}

var $ = function (id) {
    return document.getElementById(id);
}

var calculate_click = function () {
    var investment = parseFloat( $("investment").value );
    var annualRate = parseFloat( $("rate").value );
    var years = parseInt( $("years").value );
    $log("investment", investment);
	$log("annualRate", annualRate);
    $log("years", years);
	
    $("futureValue").value = "";
    
    var monthlyRate = annualRate / 12 / 100;
    var months = years * 12;
    var futureValue = 0;
	$log("monthlyRate", monthlyRate);
	$log("months", months);
	
    for ( i = 1; i <= months; i++ ) {
        futureValue = ( futureValue + investment ) *
            (1 + monthlyRate);
		$log("month " + i + " futureValue", futureValue);
    }
    
	$("futureValue").value = futureValue.toFixed(2);
    
}

window.onload = function () {
    $("calculate").onclick = calculate_click;
    $("investment").focus();
}