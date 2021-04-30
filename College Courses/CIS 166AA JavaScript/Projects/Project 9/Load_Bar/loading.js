var $ = function (id) {
    return document.getElementById(id);
}

//declare global vars
var loaded = false;
var loaded_cond = 0;

//this will determine the text of the button
var decide_text = function () {
	var text_zero = "Go to 100%";
	var text_hundred = "Go to 0%";
	
	if ( loaded == true ) {
		$("goText").value = text_hundred;
		loaded_cond = 2;
	} else {
		$("goText").value = text_zero;
		loaded_cond = 1;
	}
}
//activate all necessary events for the load button and animation.
var start_load = function () {
	
	//show the load. This should both go back and forth, or at least erase the background when told to go to zero.
	load_display();
	
	//after all is done, change the text of the load button
	if ( loaded_cond == 1 ) {
		loaded = true;
	} else if ( loaded_cond == 2 ) {
		loaded = false;
	} else {
		loaded = false;
	}
	decide_text();
}

var load_display = function () {
	
}

window.onload = function () {
	decide_text();
    $("btnGo").onclick = start_load;
}