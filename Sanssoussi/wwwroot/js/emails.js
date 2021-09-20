function getEmails() {
    var options =
    {
        url: ResolveUrl("~/home/emails"),
        type: "POST",
        data: { __RequestVerificationToken: $("#__RequestVerificationToken").val() },
        success: function (status) {
            var emails = "";
            $.each(status, function (index, item) { emails += item + "<br/>"; });
            $("#emailData").html(emails);
        },
        error: function (info) {
            alert(info);
        }
    };

    $.ajax(options);
}