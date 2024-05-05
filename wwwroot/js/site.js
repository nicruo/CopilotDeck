// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//navigate back if the previous page is available and same domain
function back() {
    if (document.referrer.indexOf(window.location.origin) !== -1) {
        history.back();
    }
    else {
        window.location = "https://localhost:32772/"
    }
}