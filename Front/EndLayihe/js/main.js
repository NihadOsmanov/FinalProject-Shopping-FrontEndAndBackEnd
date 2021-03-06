$(document).ready(function () {
  // $(".owl-slider").owlCarousel({
  //   loop: true,
  //   items: 1,
  //   nav: false,
  //   dots: false,
  //   autoplay: true,
  // });
  $(".owl-space").owlCarousel({
    stagePadding: 50,
    loop: true,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      490: {
        items: 2,
      },
      600: {
        items: 3,
      },
      850: {
        items: 4,
      },
      1000: {
        items: 5,
      },
    },
  });
  $(".owl-category").owlCarousel({
    loop: true,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      600: {
        items: 2,
      },
      1000: {
        items: 3,
      },
      1200: {
        items: 4,
      },
    },
  });
  $(".owl-trending").owlCarousel({
    loop: false,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 2,
      },
      800: {
        items: 3,
      },
      1100: {
        items: 4,
      },
    },
  });
  $(".owl-recent").owlCarousel({
    loop: true,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      600: {
        items: 2,
      },
      1200: {
        items: 3,
      },
    },
  });
  $(".owl-testimonial").owlCarousel({
    loop: true,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      600: {
        items: 1,
      },
      1200: {
        items: 2,
      },
    },
  });
  $(".owl-team").owlCarousel({
    loop: true,
    margin: 10,
    nav: false,
    dots: false,
    responsive: {
      0: {
        items: 1,
      },
      473: {
        items: 2,
      },
      991: {
        items: 3,
      },
      1200: {
        items: 4,
      },
    },
  });
});

// $(".color-variant li").on("click", function () {
//   $(this).parent().parent().prev().prev().children()[0].children()[0].src = $(this).next().val();
$("#tab-3").on("click", function () {
  document.getElementById("ng-slider-3").style.display = "flex";
  document.getElementById("ng-slider-4").style.display = "none";
  document.getElementById("ng-slider-5").style.display = "none";
  document.getElementById("tab-3").style.color = "#ec6356";
  document.getElementById("tab-4").style.color = "#222";
  document.getElementById("tab-5").style.color = "#222";
});
$("#tab-4").on("click", function () {
  document.getElementById("ng-slider-3").style.display = "none";
  document.getElementById("ng-slider-4").style.display = "flex";
  document.getElementById("ng-slider-5").style.display = "none";
  document.getElementById("tab-4").style.color = "#ec6356";
  document.getElementById("tab-5").style.color = "#222";
  document.getElementById("tab-3").style.color = "#222";
});
$("#tab-5").on("click", function () {
  document.getElementById("ng-slider-3").style.display = "none";
  document.getElementById("ng-slider-5").style.display = "flex";
  document.getElementById("ng-slider-4").style.display = "none";
  document.getElementById("tab-4").style.color = "#222";
  document.getElementById("tab-3").style.color = "#222";
  document.getElementById("tab-5").style.color = "#ec6356";
});
$("#ngb-tab-3").on("click", function () {
  document.getElementById("ngb-tab-3-panel").style.display = "block";
  document.getElementById("ngb-tab-4-panel").style.display = "none";
  document.getElementById("ngb-tab-5-panel").style.display = "none";
  document.getElementById("ngb-tab-3").style.color = "#ec6356";
  document.getElementById("ngb-tab-3").style.borderBottom = "2px solid #ec6356";
  document.getElementById("ngb-tab-4").style.color = "#222";
  document.getElementById("ngb-tab-4").style.borderBottom = "2px solid #dee2e6";
  document.getElementById("ngb-tab-5").style.color = "#222";
  document.getElementById("ngb-tab-5").style.borderBottom = "2px solid #dee2e6";
});
$("#ngb-tab-4").on("click", function () {
  document.getElementById("ngb-tab-3-panel").style.display = "none";
  document.getElementById("ngb-tab-4-panel").style.display = "block";
  document.getElementById("ngb-tab-5-panel").style.display = "none";
  document.getElementById("ngb-tab-4").style.color = "#ec6356";
  document.getElementById("ngb-tab-4").style.borderBottom = "2px solid #ec6356";
  document.getElementById("ngb-tab-3").style.color = "#222";
  document.getElementById("ngb-tab-3").style.borderBottom = "2px solid #dee2e6";
  document.getElementById("ngb-tab-5").style.color = "#222";
  document.getElementById("ngb-tab-5").style.borderBottom = "2px solid #dee2e6";
});
$("#ngb-tab-5").on("click", function () {
  document.getElementById("ngb-tab-3-panel").style.display = "none";
  document.getElementById("ngb-tab-5-panel").style.display = "block";
  document.getElementById("ngb-tab-4-panel").style.display = "none";
  document.getElementById("ngb-tab-4").style.color = "#222";
  document.getElementById("ngb-tab-4").style.borderBottom = "2px solid #dee2e6";
  document.getElementById("ngb-tab-3").style.color = "#222";
  document.getElementById("ngb-tab-3").style.borderBottom = "2px solid #dee2e6";
  document.getElementById("ngb-tab-5").style.color = "#ec6356";
  document.getElementById("ngb-tab-5").style.borderBottom = "2px solid #ec6356";
});

const toTop = document.querySelector(".to-top");

window.addEventListener("scroll", () => {
  if (window.pageYOffset > 400) {
    toTop.classList.add("d-block");
  } else {
    toTop.classList.remove("d-block");
  }
});

const lightMode = document.querySelector(".light");
lightMode.addEventListener("click", function () {
  if (document.querySelector(".dark")) {
    lightMode.innerHTML = "Dark";
  } else {
    lightMode.innerHTML = "Light";
  }
  document.body.classList.toggle("dark");
});

$(window).on("load", function () {
  var range = $("#range").attr("value");
  $("#demo").html(range);
  $(".slide").css("width", "50%");
  $(document).on("input change", "#range", function () {
    $("#demo").html($(this).val() + "$");
    var slideWidth = ($(this).val() * 100) / 1000;

    $(".slide").css("width", slideWidth + "%");
  });
});

$(".filter-back").on("click", function () {
  document.getElementById("col-filter").style.display = "none";
  $(".filter-btn").on("click", function () {
    document.getElementById("col-filter").style.display = "block";
  });
});

// titan.addEventListener("click", function () {
//   isChecked = !isChecked;
//   let a = document.querySelector("#cl3").childNodes;
//   let productCart = document.createElement("div");
//   productCart.className = "col-grid-box col-lg-3";
//   // console.log(tempProductBox.innerHTML);
//   if (isChecked) {
//     a.forEach((product) => {
//       if (product.id === "watchTitan") {
//         productBox.innerHTML = "";
//         productBox.appendChild(product);
//       }
//     });
//   } else {
//     productBox.innerHTML += tempProductBox.innerHTML;
//   }
//   // console.log(titanBox.getAttribute("checked"));
// });

(function () {
  "use strict";
  var jQueryPlugin = (window.jQueryPlugin = function (ident, func) {
    return function (arg) {
      if (this.length > 1) {
        this.each(function () {
          var $this = $(this);

          if (!$this.data(ident)) {
            $this.data(ident, func($this, arg));
          }
        });

        return this;
      } else if (this.length === 1) {
        if (!this.data(ident)) {
          this.data(ident, func(this, arg));
        }

        return this.data(ident);
      }
    };
  });
})();

(function () {
  "use strict";
  function Guantity($root) {
    const element = $root;
    const quantity = $root.first("data-quantity");
    const quantity_target = $root.find("[data-quantity-target]");
    const quantity_minus = $root.find("[data-quantity-minus]");
    const quantity_plus = $root.find("[data-quantity-plus]");
    var quantity_ = quantity_target.val();
    $(quantity_minus).click(function () {
      quantity_target.val(--quantity_);
    });
    $(quantity_plus).click(function () {
      console.log();
      quantity_target.val(++quantity_);
    });
  }
  $.fn.Guantity = jQueryPlugin("Guantity", Guantity);
  $("[data-quantity]").Guantity();
})();

$(document).ready(function () {
  $(".container ul.toggle").click(function () {
    $(this).toggleClass("active");
    $(".container .sidebar").toggleClass("active");
  });
});
$(".faq-heading").click(function () {
  $(this)
    .parent("li")
    .toggleClass("the-active")
    .find(".faq-text")
    .slideToggle();
});

let imgs = document.querySelectorAll(".product-img");
let main = document.querySelector("#main");

imgs.forEach((img) => {
  img.addEventListener("click", function () {
    main.src = this.src;
  });
});

$(".fa-search").click(function () {
  document.getElementById("search-overlay").style.display = "block";
  $(".closebtn").click(function () {
    document.getElementById("search-overlay").style.display = "none";
  });
});

$(document).on("click", "#tabs li a", function (e) {
  e.preventDefault();
  let category = $(this).attr("data-id");
  let products = $(".card");

  products.each(function () {
    if (category == $(this).attr("data-id")) {
      $(this).parent().fadeIn();
    } else {
      $(this).parent().hide();
    }
  });
});
