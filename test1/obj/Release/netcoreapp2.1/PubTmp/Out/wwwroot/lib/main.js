$(document).ready(function () {

    // product technic details button
    $('#productInfoButton').click(function () {
        $('#productTechnicInfo').removeClass('d-md-flex');
        $('#productTechnicInfo').addClass('d-none');
        $('#productINFO').removeClass('d-none');
        $('#productINFO').addClass('d-md-flex');
        $(this).css("background-color", "rgba(0,125,190,.2)");
        $('#productTechnicInfoButton').css("background-color", "transparent");
    });
    $('#productTechnicInfoButton').click(function () {
        $('#productINFO').removeClass('d-md-flex');
        $('#productINFO').addClass('d-none');
        $('#productTechnicInfo').removeClass('d-none');
        $('#productTechnicInfo').addClass('d-md-flex');
        $(this).css("background-color", "rgba(0,125,190,.2)");
        $('#productInfoButton').css("background-color", "transparent");
    });

    // dropdown menu hover
    $('.dropdown').hover(function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(0).fadeIn(700);
    }, function () {
        $(this).find('.dropdown-menu').stop(true, true).delay(0).fadeOut(700);
    });

    //scroll
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll >= 100) {
            $("#topButton").addClass('show');
        }
        else {
            $("#topButton").removeClass('show');
        }
        if ($(window).width() > 1000) {
            if (scroll >= 100) {

                $('nav').addClass('scrolled');
                $('#menuclc').removeClass('d-flex');
                $('#menuclc').addClass('d-none');
            } else {
                $('nav').removeClass('scrolled');
                $('#menuclc').removeClass('d-none');
                $('#menuclc').addClass('d-flex');
            }
        }

    });
  
    $("#topButton").on('click', function (e) {
        $("html, body").animate({ scrollTop: 0 }, 1000);
    });

    $('#aboutSlider').carousel({
        interval: 4000
    });

    $('select').on('change', function () {
        var item = $(this).find(":selected");
        var optionText = item.text();
        item.val(optionText);
    });

    // reCaptcha
    function scaleCaptcha(elementWidth) {
        
        var reCaptchaWidth = 304;
        var containerWidth = $('.recaptcha').width();

        if (reCaptchaWidth > containerWidth) {
            var captchaScale = containerWidth / reCaptchaWidth;
            $('.g-recaptcha').css({
                'transform': 'scale(' + captchaScale + ')'
            });
        }
    }

    $(function () {
        scaleCaptcha();
        window.resize(throttle(100, scaleCaptcha));

    });

});

