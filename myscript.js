var modal= document.getElementById('myModal');
var close= document.getElementById('myClose');
close.onclick= function() {
  modal.style.display = "none";
}

//переключение фото при наведении Главная страница
document.getElementById("moe_foto").addEventListener("mouseover", function() {
    this.src = "./images/ya.png";  // Меняем изображение при наведении
});

document.getElementById("moe_foto").addEventListener("mouseout", function() {
    this.src = "./images/ya2.png";  // Возвращаем исходное изображение
});


//обработка события наведения мыши на фото
// Ждем, когда весь контент страницы загрузится
document.addEventListener("DOMContentLoaded", function() {
    // Находим элемент по ID
    const foto = document.getElementById("moe_foto");

    // Проверяем, найден ли элемент
    if (foto) {
        console.log("Элемент найден");

        // Добавляем обработчик события для mouseover
        foto.addEventListener("mouseover", function() {
            console.log("Наведение на изображение");
            this.src = "./images/ya.png";  // Изменяем изображение при наведении
        });

        // Добавляем обработчик события для mouseout
        foto.addEventListener("mouseout", function() {
            console.log("Убрал курсор с изображения");
            this.src = "./images/ya2.png";  // Возвращаем исходное изображение
        });
    } else {
        console.log("Элемент не найден");
    }
});



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

