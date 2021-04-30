if ( ! jsLib ) {
    throw new Error("HeadLines: jsLib Event library required.");
} else if ( ! jsLib.event ) {
    throw new Error("MenuBar: jsLib Event library required.");
}

var headlines;

var headlinesStart = function () {
    headlines = new Headlines( "headlines", "toggle", 4);
}

jsLib.dom.ready( headlinesStart );