$(document).ready(function () {
    $('.open-submenu').off().on('click', function () {
        let subMenu = $(this).attr('submenu-name');
        let menu = $('ul.submenu[name=' + subMenu + ']');
        if (menu.length > 0) {
            menu.toggle(500);
        }
    });
})