'use strict';

const switcher = document.querySelector('.btn');

switcher.addEventListener('click', function() {
    /* Minha solução de mudança de tema
    if (document.body.className == 'dark-theme') {
        document.body.className = 'light-theme';
        document.body.style.transition = '1s';
    }
    else {
        document.body.className = 'dark-theme';
        document.body.style.transition = '1s';
    }
    */

    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');

    //Minha solução de transição
    document.body.style.transition = '.8s';
    
    const className = document.body.className;

    if(className == "light-theme") {
        this.textContent = "Dark";
    } else {
        this.textContent = "Light";
    }

    console.log('current class name: ' + className);
})