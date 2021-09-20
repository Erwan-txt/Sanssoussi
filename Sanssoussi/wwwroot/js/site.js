// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function AddComments() {
    if ($("#NewComment:visible").length < 1) {
        $("#NewComment").show();
        $("#NewCommentsBtn").val("Ajouter");
    }
    else {
        $.ajax({
                url: ResolveUrl("~/home/comments"),
                type: "POST",
                data: { comment: $("#NewComment").val() },
                success: function (status) {
                    if (status != "success") {
                        alert(status);
                    }

                    $("#NewComment").hide();
                    $("#NewCommentsBtn").val("Nouveau commentaire");
                },
                error: function (info) {
                    alert(info);
                }
            }
        );
    }
}

function search() {
    window.location = ResolveUrl("~/home/Search?searchData=" + $("#searchBox").val());
}
