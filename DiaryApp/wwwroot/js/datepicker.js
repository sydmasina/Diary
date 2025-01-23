$(document).ready(function () {
    // Initialize the date picker
    $('#popup-datepicker').datepicker({
        format: 'mm/dd/yyyy',
        autoclose: true,
        todayHighlight: true
    });

    // Open datepicker when calendar icon is clicked
    $('.input-group-text').on('click', function () {
        $('#popup-datepicker').datepicker('show');
    });
});