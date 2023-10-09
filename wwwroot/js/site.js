// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const caracteresEspeciales = [
    '!', '"', '#', '$', '%', '&', "'", '(', ')', '*', '+', ',', '-', '.', '/',
    ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'
  ];
  

const validarContra = () => {

    const contra = document.getElementById("contraseña").value;
    let especial = true;
    for (let index = 0; index < caracteresEspeciales.length; index++) {
        if (contra.includes(caracteresEspeciales[i])) {
            especial = false;
            break;
        }
    }

    if ((contra.length >= 8) && (contra != contra.toLowercase()) && (especial)) {
        console.log(true);
        return true;
    } else{console.log(false); return false};
}