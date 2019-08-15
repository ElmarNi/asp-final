// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function ($) {
    let takenCars = parseInt($("#takenAds").val());
    let totalCount = parseInt($("#carCount").val());
    $("#load_more").click(function () {
        $.ajax({
            url: "Home/LoadCars?skip=" + takenCars,
            type: "GET",
            success: function (res) {
                $("#cars").append(res);
                takenCars += 3;
                if (parseInt(takenCars) >= parseInt(totalCount)) {
                    $("#load_more").remove();
                }
            }
        });
    });
})
$(function ($) {
    var height = 0;
    $(window).load(function () {
        setBlogsHeight()
    });
    $(window).resize(function () {
        setBlogsHeight()
    })
    function setBlogsHeight() {
        for (var i = 0; i < $(".slick-slide-item").length; i++) {
            if ($(".slick-slide-item")[i].clientHeight > height) {
                height = $(".slick-slide-item")[i].clientHeight
            }
        }
        $(".slick-slide-item").height(height);
        $(".slick-slide-item .blog-1").css("height", "93%")
    }
    
}) 
$(function ($) {

    $("#countries").change(function () {
        let countryId = $(this).val();
        if (countryId) {
            $.ajax({
                url: "/ajax/LoadCitiesByCountryId?countryId=" + countryId,
                type: "POST",
                success: function (res) {
                    $("#CityId").html(res)
                    $("#CityId").prepend("<option value=''>Select City</option>")
                    $("#CityId").val("")
                }
            });
        }
    })
    $("#brands").change(function () {
        let brandId = $(this).val();

        if (brandId) {
            $.ajax({
                url: "/ajax/LoadMakesByBrandId?brandId=" + brandId,
                type: "POST",
                success: function (res) {
                    $("#MakeId").html(res)
                    $("#MakeId").prepend("<option value=''>Select Make</option>")
                    $("#MakeId").val("")
                }
            });
        }
    })
})
$(function ($) {
    $(".detailImage").each(function () {
        $(this).click(function () {
            let carDetailImageId = parseInt(this.attributes.valueOf()[0].value);
            console.log(carDetailImageId)
            $.ajax({
                url: "/ajax/DeleteImage?carDetailImageId=" + carDetailImageId,
                type: "POST",
            });
            $(this).remove();
        })
    })
    //$("#detailImage").click(function () {
    //    let carDetailImageId = parseInt(this.attributes.valueOf()[0].value);
    //    console.log(carDetailImageId)
    //    $.ajax({
    //        url: "/ajax/DeleteImage?carDetailImageId=" + carDetailImageId,
    //        type: "POST",
    //        success: function (res) {
    //            console.log(res)
    //        }
    //    });
    //})
})
//$(function ($) {
//    $(window).ready(function () {
//        CarBoxesHeight()
//    })
//    $(window).resize(function () {
//        CarBoxesHeight();
//    })
//    function CarBoxesHeight() {
//        let maxHeight = 0;
//        $(".car-box img").each(function () {
//            if ($(this).height() > maxHeight) {
//                maxHeight = $(this).height()
//            }
//        })
//        $(".car-box img").each(function () {
//            $(this).height(maxHeight);
//        })
//    }
//})
