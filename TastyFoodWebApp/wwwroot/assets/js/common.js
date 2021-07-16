/*==================== SHOW MENU ====================*/
const showMenu = (toggleId, navId) => {
    const toggle = document.getElementById(toggleId),
        nav = document.getElementById(navId)
    const header = document.getElementById('header')

    // Validate that variables exist
    if (toggle && nav) {
        toggle.addEventListener('click', () => {
            // We add the show-menu class to the div tag with the nav__menu class
            nav.classList.toggle('show-menu')
            header.classList.add('scroll-header')
        })
    }

}
showMenu('nav-toggle', 'nav-menu')
/*==================== REMOVE MENU MOBILE ====================*/
// const navLink = document.querySelectorAll('.nav__link')
// navLink.forEach(n => n.addEventListener('click', linkAction))
// function linkAction() {
//     const header = document.getElementById('header')
//     const navMenu = document.getElementById('nav-menu')
// }

/*==================== SHOW SUB MENU ====================*/

// let showMenuMobile = () => {
//     let list_item = document.querySelectorAll('.nav__list li');
//     list_item.forEach((item) => {
//         item.addEventListener('click', () => {
//             let sub_menu = item.querySelector('.nav__sub')
//             console.log(sub_menu);
//             if (sub_menu && sub_menu.style.display ==='block') {
//                 sub_menu.style.display ='none'
//             }else{
//                 sub_menu.style.display ='block'
//             }
//         })
//     })
// }

// showMenuMobile()

/*==================== SCROLL SECTIONS ACTIVE LINK ====================*/
// const sections = document.querySelectorAll('section[id]')

// function scrollActive() {
//     const scrollY = window.pageYOffset

//     sections.forEach(current => {
//         const sectionHeight = current.offsetHeight
//         const sectionTop = current.offsetTop - 50;
//         sectionId = current.getAttribute('id')

//         if (scrollY > sectionTop && scrollY <= sectionTop + sectionHeight) {
//             document.querySelector('.nav__menu a[href*=' + sectionId + ']').classList.add('active-link')
//         } else {
//             document.querySelector('.nav__menu a[href*=' + sectionId + ']').classList.remove('active-link')
//         }
//     })
// }
// window.addEventListener('scroll', scrollActive)

/*==================== CHANGE BACKGROUND HEADER ====================*/
function scrollHeader() {
    const nav = document.getElementById('header')
    if (this.scrollY >= 100) nav.classList.add('scroll-header')
    else nav.classList.remove('scroll-header')
}

// scrollHeader()

// window.addEventListener('scroll', scrollActive)
/*==================== SHOW SCROLL TOP ====================*/
function scrollTop() {
    const scrollTop = document.getElementById('scroll-top');
    // When the scroll is higher than 560 viewport height, add the show-scroll class to the a tag with the scroll-top class
    if (this.scrollY >= 560) scrollTop.classList.add('show-scroll'); else scrollTop.classList.remove('show-scroll')
}
window.addEventListener('scroll', scrollTop)

/*==================== DARK LIGHT THEME ====================*/
const themeButton = document.getElementById('theme-button')
const darkTheme = 'dark-theme'
const iconTheme = 'bx-sun'
// Previously selected topic (if user selected)
const selectedTheme = localStorage.getItem('selected-theme')
const selectedIcon = localStorage.getItem('selected-icon')
// // We obtain the current theme that the interface has by validating the dark-theme class
const getCurrentTheme = () => document.body.classList.contains(darkTheme) ? 'dark' : 'light'
const getCurrentIcon = () => themeButton.classList.contains(iconTheme) ? 'bx-moon' : 'bx-sun'

// // We validate if the user previously choose a theme
if (selectedTheme && selectedIcon) {
    document.body.classList[selectedTheme === 'dark' ? 'add' : 'remove'](darkTheme)
    themeButton.classList[selectedIcon === 'bx-moon' ? 'add' : 'remove'](iconTheme)
}

// // Activate when the button click
themeButton.addEventListener('click', () => {
    // Add or remove the dark / icon theme
    document.body.classList.toggle(darkTheme)
    themeButton.classList.toggle(iconTheme)
    // We save the theme and the current icon that the user chose
    localStorage.setItem('selected-theme', getCurrentTheme())
    localStorage.setItem('selected-icon', getCurrentIcon())
})

/*==================== SCROLL REVEAL ANIMATION ====================*/



const scrolls = ScrollReveal({
    origin: 'top',
    distance: '30px',
    duration: 2000,
    reset: true
})

scrolls.reveal(`
            .home__data,.home__img,
            .about__data,  .about__img,
            .services__content, 
            .menu__content,
            .app__data, .app__img,
            .contact__data, .contact__button,
            .footer__content
            .offer-weekend,
            .fresh-food__right,
            .fresh-food__left
            `, {
    interval: 200
})


// ================= ADD TO CART ==================
addToCart = (e) => {
    // Get the modal
    var ebModal = document.getElementById('addToCart');
    // When the user clicks the button, open the modal 
    ebModal.style.display = "block";
    document.body.classList.add('body-behavior')
    let text_name = document.querySelector('.text-modal')
    // text_name.innerHTML = 
    // Get the <span> element that closes the modal
    var ebSpan = document.getElementsByClassName("close-modal")[0];
    // When the user clicks on <span> (x), close the modal
    ebSpan.addEventListener('click', () => {
        ebModal.style.display = "none";
        document.body.classList.remove('body-behavior')

    })

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == ebModal) {
            ebModal.style.display = "none";
            document.body.classList.remove('body-behavior')

        }
    }
}

addToWishList = () => {
    // Get the modal
    var ebModal = document.getElementById('addToWishList');
    // When the user clicks the button, open the modal 
    ebModal.style.display = "block";
    document.body.classList.add('body-behavior')
    let text_name = document.querySelector('.text-modal')
    // text_name.innerHTML = 
    // Get the <span> element that closes the modal
    var ebSpan = document.getElementsByClassName("close-modal")[0];
    // When the user clicks on <span> (x), close the modal
    ebSpan.addEventListener('click', () => {
        ebModal.style.display = "none";
        document.body.classList.remove('body-behavior')

    })

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == ebModal) {
            ebModal.style.display = "none";
            document.body.classList.remove('body-behavior')

        }
    }
}


//======== add and minus value ==========
onMinus = () => {
    let value = document.getElementById('quantity')
    if (value.value > 1)
        value.value = parseInt(value.value) - 1;
}

onAdd = () => {
    let value = document.getElementById('quantity')
    value.value = parseInt(value.value) + 1;
}