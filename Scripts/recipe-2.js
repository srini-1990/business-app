var images = [];
$(function(){
    $(document).on("mouseover", ".photos li", function(){
        var _image = $(this).find('img');
        _image.finish();
        images[$(this).index()] = {
            width: _image.width(),
            height: _image.height()
        };
        _image.animate({
            width: '290px',
            height: '250px',
            top: 0,
            left: 0,
            opacity: 1.0
        });
    }).on("mouseout", ".photos li", function(){
        var _image = $(this).find('img');
        _image.finish();
        _image.animate({
            width: images[$(this).index()].width + "px",
            height: images[$(this).index()].height + "px",
            top: '-50%',
            left: '-50%',
            opacity: 0.5
        });
    });
});