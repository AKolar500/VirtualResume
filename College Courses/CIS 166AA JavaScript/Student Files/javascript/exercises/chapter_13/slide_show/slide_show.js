var slideShow;

window.onload = function () {
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