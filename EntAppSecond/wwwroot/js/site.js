// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

jQuery.validator.addMethod("studentId",
    function (value, element, param) {

        return (value == @"(s|S)\d{7}"));
    });

jQuery.validator.unobtrusive.adapters.addBool("studentId");

jQuery.validator.addMethod("FirstName",
    function (value, element, param) {

        return (value == "[\w’-]{2,}");
    });

jQuery.validator.unobtrusive.adapters.addBool("FirstName");

jQuery.validator.addMethod("secondName",
    function (value, element, param) {

        return (value == "[\\w’-]{2,}");
    });

jQuery.validator.unobtrusive.adapters.addBool("secondName");

jQuery.validator.addMethod("modules",
    function (value, element, param) {

        return (value >= 1);
    });

jQuery.validator.unobtrusive.adapters.addBool("modules");

jQuery.validator.addMethod("height",
    function (value, element, param) {

        return (value >= 50 &&  value <= 250);
    });

jQuery.validator.unobtrusive.adapters.addBool("height");