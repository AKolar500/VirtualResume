var $ = function (id) {
    return document.getElementById(id);
}

var calculate_future_value = function( investment, annualRate, years ) {
    if ( investment <= 0 || annualRate <= 0 || years <= 0 ) {
	}

    var monthlyRate = annualRate / 12 / 100;
    var months = years * 12;
    var futureValue = 0;
		
    for ( i = 1; i <= months; i++ ) {
        futureValue = ( futureValue + investment ) * (1 + monthlyRate);
    }
	return futureValue.toFixed(2);
}
	
var calculate_click = function () {
    var investment = parseFloat( $("investment").value );
    var annualRate = parseFloat( $("rate").value );
    var years = parseInt( $("years").value );
	
    $("futureValue").value = 
		calculate_future_value(investment, annualRate, years);

} 

window.onload = function () {
    $("calculate").onclick = calculate_click;
    $("investment").focus();
}
