var modal= document.getElementById('myModal');
var close= document.getElementById('myClose');
close.onclick= function() {
  modal.style.display = "none";
}

// Объект для хранения индексов слайдов для каждого слайдера
let slideIndex = {
    slider1: 0,
    slider2: 0,
    slider3: 0 
};

// Функция для переключения слайдов (принимает идентификатор слайдера и направление)
function plusSlides(sliderId, n) {
    slideIndex[sliderId] += n;
    showSlides(sliderId);
}

// Функция для отображения слайдов (принимает идентификатор слайдера)
function showSlides(sliderId) {
    const slides = document.querySelectorAll(`#${sliderId} .slide`);
    
    // Циклическая прокрутка слайдов
    if (slideIndex[sliderId] >= slides.length) {
        slideIndex[sliderId] = 0;
    }
    if (slideIndex[sliderId] < 0) {
        slideIndex[sliderId] = slides.length - 1;
    }

    // Рассчитываем сдвиг слайдов по горизонтали
    const offset = -slideIndex[sliderId] * 100;
    document.querySelector(`#${sliderId} .slides`).style.transform = `translateX(${offset}%)`;
}

// Изначально отображаем первый слайд для всех трех слайдеров
showSlides('slider1');
showSlides('slider2');
showSlides('slider3'); 
