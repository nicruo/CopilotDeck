// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function copyToClipboard(elementId) {
    const element = document.querySelector("#"+elementId);
    navigator.clipboard.writeText(element.textContent).then(function () {
        alert("Copied to clipboard!");
    })
    .catch(function (error) {
        alert(error);
    });
}