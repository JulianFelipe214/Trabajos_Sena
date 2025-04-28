// static/js/auth.js
document.addEventListener('DOMContentLoaded', function() {
    // Mostrar/ocultar contraseña
    const togglePassword = document.querySelector('.toggle-password');
    if (togglePassword) {
        togglePassword.addEventListener('click', function() {
            const passwordInput = this.previousElementSibling;
            const icon = this.querySelector('i');
            
            if (passwordInput.type === 'password') {
                passwordInput.type = 'text';
                icon.classList.remove('fa-eye');
                icon.classList.add('fa-eye-slash');
            } else {
                passwordInput.type = 'password';
                icon.classList.remove('fa-eye-slash');
                icon.classList.add('fa-eye');
            }
        });
    }

    // Validación de formulario de registro
    const registroForm = document.querySelector('.auth-form');
    if (registroForm && registroForm.id === 'registro') {
        registroForm.addEventListener('submit', function(e) {
            const password1 = document.getElementById('password1');
            const password2 = document.getElementById('password2');
            
            if (password1.value !== password2.value) {
                e.preventDefault();
                alert('Las contraseñas no coinciden');
                password2.focus();
            }
        });
    }

    // Efecto de hover en botones
    const authButtons = document.querySelectorAll('.auth-button');
    authButtons.forEach(button => {
        button.addEventListener('mouseenter', function() {
            this.style.transform = 'translateY(-2px)';
        });
        
        button.addEventListener('mouseleave', function() {
            this.style.transform = 'translateY(0)';
        });
    });
});