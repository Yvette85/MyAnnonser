$(document).ready(function () {
    $("#UniqueId").on("focusout", OnFocusOut);
    $("input[type='submit']").on("click", OnClick);
});

function OnFocusOut() {

    $.ajax(
        {
            url: "/Customers/CustomerUniqueId",
            type: "post",
            data:
                {
                    DataId: this.id,
                    text: this.value
                },
            conttext: this,
            success: function (data) {
                if (data !== null && data.length > 0) {

                    $("#warningText").removeClass("hidden");
                    $("#UniqueId").addClass("has-error");

                }
                else {

                    $("#warningText").addClass("hidden");
                    $("#UniqueId").removeClass("has-error");
                }
            },
            error: function (data) {

                $("#warningText").removeClass("hidden");
                $("#UniqueId").addClass("has-error");
            }

        }
    );
}

function OnClick(e) {
    if ($("#UniqueId").hasClass("has-error")) {
        e.preventDefault();


    }

}