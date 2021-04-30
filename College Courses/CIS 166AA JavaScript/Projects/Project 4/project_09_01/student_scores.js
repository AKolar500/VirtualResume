var $ = function (id) { return document.getElementById(id); }

var scores;
var scoresString;

var addScore = function () {
    // get the data from the form
    var scoreNumber = parseInt( $("score").value );
    var scoreString = $("last_name").value + ", " + 
                      $("first_name").value + ": " + 
                      $("score").value;

    // store the data in an array
    scores.push(scoreNumber);
    scoresString.push(scoreString);
    
    displayScores();
}

var displayScores = function () {   
    // calculate the average score
    var totalScore = 0;
    for (var i in scores) {
        totalScore += scores[i];
    }
    var numberOfScores = scores.length;
    var averageScore = totalScore / numberOfScores;    

    // display the scores on the web page
    $("scores").value = scoresString.join("\n");
    $("average_score").value = averageScore.toFixed(1);
}

var clearScores = function () {   
    // delete the data from the arrays
    scores = [];
    scoresString = [];

    // delete the data from the arrays (alternative)
    /*
    while (scores.length > 0) {
        scores.pop();
    }
    while (scoresString.length > 0) {
        scoresString.pop();
    }
    */
    
    // remove the score data from the web page
    $("average_score").value = "";
    $("scores").value = "";
}

var sortScores = function () {   
    // sort the scores
    scoresString.sort();
    
    // display the scores
    displayScores();    
}

window.onload = function () {
    $("add_button").onclick = addScore;
    $("clear_button").onclick = clearScores;    
    $("sort_button").onclick = sortScores;    
    
    clearScores();
}