var slideNow = 1;
var slideCount = $('.context').children().length;
var slideInterval = 5;
var navBtnId = 0;
var currWidth = 0;
var translateWidth = 0;

$(document).ready(function () {
    

    
    $(document).on('click', '#slide-nav', function () {
         event.preventDefault();
        navBtnId = $(this).index();

        if (navBtnId + 1 != slideNow) {
           
            translateWidth = -$('.context').width() * (navBtnId);
            $('.context').css({
                'transform': 'translate(' + translateWidth + 'px, 0)',
                '-webkit-transform': 'translate(' + translateWidth + 'px, 0)',
                '-ms-transform': 'translate(' + translateWidth + 'px, 0)',
                'overflow': 'hidden'
            });
            if (navBtnId == 1) {
                $('.context').css({ 'overflow': 'visible' });
            }

            
            slideNow = navBtnId + 1;
        }

    });
  /*  $('#slide-nav').click(function () {
       
            $("#but_image" + slideNow).attr("src", "");
            slideNow = navBtnId + 1; console.log(slideNow);
            $('#but' + '_image' + slideNow).attr("src", "Rectangle 2 (1).png");

        }

    });*/
});