var $ = function (id) {
    return document.getElementById(id);
}
/*The problem with arrays is that once the block in which they reside is finished executing, that
array is gone from memory forever. I fixed the code to work each time the button is pressed, but
it can only handle one student and their score.*/

/*
JA: The issue is that you need to have the array variables declared outside any function blocks 
otherwise they get destroyed when the function is finished executing. Please see the solution 
and also this resource for more info variable scope: 
	https://www.inkling.com/read/javascript-definitive-guide-david-flanagan-6th/chapter-3/variable-scope
*/
var add_click = function() {
	//declare vars
	var firstname = $("firstname").value;
	var lastname = $("lastname").value;
	var score = $("score").value;
	var singlestudent = new Array( firstname, lastname, score );
	var aryStudentScores = new Array( singlestudent );
	var studentscores = "";
	
	for (var i = 1; i <= aryStudentScores.length; i++) {
		//creates the string to be displayed in the textarea
		studentscores += firstname + " " + lastname + " " + score + "\n";
		//display the string in the textarea
		$("studentscores").value = studentscores;
		//compute the average, and stick it in the average text box.
		$("average").value = score / aryStudentScores.length;
	}
}

window.onload = function () {
    $("addstudentscores").onclick = add_click;
    $("clearstudentscores").onclick = clear_click;
	$("sortlastname").onclick = sort_click;
}

