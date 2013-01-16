$(document).ready(function () {

  var request;

  $("#logOut").click(function () {
    request = $.ajax({
      url: 'data/secure/logout',
      success: function (data) {
        $('#output').html("");
      }
    });

    request.error(function (httpObj, textStatus) {
      alert("Error! - " + httpObj.status + "\nPlease login first.");
    });

  });

  $("#logIn").click(function () {
    $.ajax({
      url: 'data/Login/' + $('#myName').val(),
      success: function (data) {
      }
    });
  });


  $("#whoAmI").click(function () {
    request = $.ajax({
      url: 'data/secure/getcustomer',
      success: function (data) {
        $.each(data, function (i, item) {
          $('#output').html(item);
        });
      }
    });

    request.error(function (httpObj, textStatus) {
      alert("Error! - " + httpObj.status + "\nPlease login first.");
    });

  });

});