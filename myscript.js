// ===== Модальное окно =====

// Получаем элементы модального окна и кнопки закрытия
var modal = document.getElementById('myModal');
var close = document.getElementById('myClose');

// Закрытие модального окна при клике на кнопку "Закрыть"
close.onclick = function() {
    modal.style.display = "none";
};


// ===== Изменение фото на главной странице при наведении =====

document.addEventListener("DOMContentLoaded", function() {
    const foto = document.getElementById("moe_foto");

    if (foto) {
        foto.addEventListener("mouseover", function() {
            this.src = "./images/ya.png"; // Указываем путь к новому изображению
        });

        foto.addEventListener("mouseout", function() {
            this.src = "./images/ya2.png"; // Возвращаем исходное изображение
        });
    } else {
        console.error("Элемент с id='moe_foto' не найден.");
    }
});



// ===== Слайдеры =====

// Объект для хранения текущих индексов слайдов каждого слайдера
let slideIndex = {
    slider1: 0,
    slider2: 0,
    slider3: 0
};

// Функция переключения слайдов
function plusSlides(sliderId, n) {
    // Обновляем индекс текущего слайда
    slideIndex[sliderId] += n;
    // Отображаем обновленный слайд
    showSlides(sliderId);
}

// Функция отображения слайдов
function showSlides(sliderId) {
    // Получаем все слайды внутри указанного слайдера
    const slides = document.querySelectorAll(`#${sliderId} .slide`);

    // Проверяем, если слайды существуют
    if (slides.length === 0) {
        console.error(`Слайды для слайдера ${sliderId} не найдены.`);
        return;
    }

    // Циклическая прокрутка: если индекс выходит за границы массива, сбрасываем его
    if (slideIndex[sliderId] >= slides.length) {
        slideIndex[sliderId] = 0;
    }
    if (slideIndex[sliderId] < 0) {
        slideIndex[sliderId] = slides.length - 1;
    }

    // Рассчитываем сдвиг слайдов по горизонтали
    const offset = -slideIndex[sliderId] * 100;

    // Применяем сдвиг к контейнеру слайдов
    const slidesContainer = document.querySelector(`#${sliderId} .slides`);
    if (slidesContainer) {
        slidesContainer.style.transform = `translateX(${offset}%)`;
        slidesContainer.style.transition = "transform 0.5s ease"; // Плавный переход
    } else {
        console.error(`Контейнер слайдов для ${sliderId} не найден.`);
    }
}

// Инициализация всех слайдеров при загрузке страницы
document.addEventListener("DOMContentLoaded", function() {
    showSlides('slider1');
    showSlides('slider2');
    showSlides('slider3');
});


