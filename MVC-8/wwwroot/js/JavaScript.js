


function swapClasses(elem, c1, c2) {
    var classes = elem.classList;
    if (classes.contains(c1)) {
        elem.classList.remove(c1);
        elem.classList.add(c2);    
    } else {
        elem.classList.remove(c2);
        elem.classList.add(c1);    
    }
}

function replaceClass(elem, cFrom, cTo) {
    var classes = elem.classList;
    elem.classList.remove(cFrom);
    elem.classList.add(cTo);    
}


function toggleVisible(idToggle, idHide) {
    var elemHide = document.getElementById(idHide);
    replaceClass(elemHide, 'display_block', 'display_hidden');

    var elemToggle = document.getElementById(idToggle);
    swapClasses(elemToggle, 'display_block', 'display_hidden');
}
