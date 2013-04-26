$(function() {
    $(".Car").on('click', function(event, ui) {
        var $this = $(this);
        var carId = $this.find(".CarId").val();
        document.location ="/Auto/Details/" + carId;
    });

});