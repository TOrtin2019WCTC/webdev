$(function () {
  
    // array of animations
    var animations = ["rubberBand", "shake", "swing", "tada", "wobble", "jello", "heartBeat"];

    // formula to get random element from array 
    var randomAnimation = Math.floor(Math.random() * 8);

   

    // format date for date picker
    $('#birthday').pickadate({ format: 'mmmm, d' });


    // makes all checkboxes unchecked by default
    $('.form-check-input').each(function () {
        $(this).prop('checked', false);
    });


   // functionality to check/uncheck all balloon options
    $('#check-uncheck-all-balloons').click(function () {
           $('.form-check-input').prop('checked', $(this).prop('checked'));
          
    });

  

      // changes color of "happy birthday" when mouse hovers over label
     $('.form-check-label').mouseenter(function () {

        $('#happyBirthday').css('color', this.id);

    });

    // changes color of "happy birthday" back to default after mouse leaves label
     $('.form-check-label').mouseleave(function () {
        $('#happyBirthday').css('color', '');
     });
    

    // closes toast with escape key 
    $(document).on('keyup', function (e) {
        if (e.key === "Escape") {
            $("#toast").toast('hide');
        }
    });

    // handles functionality when submit button is clicked
    $('#submit').on('click', function (e) {
        e.preventDefault();

        var checkedBoxes= document.querySelectorAll('.form-check-input:checked').length
        if (checkedBoxes === 0) {

            $('#toast').toast({ autohide: false }).toast('show');
        } else {
            $('.form-check-input:checked').each(function () {
                if ($(this).prop('checked', true)) {
                    $('#' + this.id + 'Img').css('visibility', 'visible').addClass('animated zoomInUp');
                }
            });
            }
             
    });

    
    // resets the form and removes balloons from screen
    $('#reset').on('click', function (e) {
        $('.form-check-input:checked').each(function () {
            $('#' + this.id + "Img").css('visibility', 'hidden');
            $(this).prop('checked', false);
        })
    });

   

 // adds random animation to "happy birthday" after page is loaded
   $(document).ready(function () {
        $('#happyBirthday').removeClass().addClass('animated ' + animations[randomAnimation]);
      
   });
   

});
