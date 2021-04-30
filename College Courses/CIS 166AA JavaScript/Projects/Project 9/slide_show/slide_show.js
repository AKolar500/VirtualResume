var slideShow;

var slideShowSetup = function () {
    var params = {
        listId     : "imageList",
        imageId    : "image",
        captionId  : "caption",
        previousId : "btnPrevious",
        playId     : "btnPlay",
        playPauseId: "imgPlayPause",
        nextId     : "btnNext",
        speedId    : "btnSpeed"
    }
    slideShow = new SlideShow( params );
}

jsLib.event.add( window, "load", slideShowSetup );

// An optional improvement...
//jsLib.dom.ready( slideShowSetup );