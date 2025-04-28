// static/js/scripts.js
document.addEventListener('DOMContentLoaded', function() {
    // ======================
    // Efectos de Scroll
    // ======================
    const navbar = document.querySelector('.navbar');
    
    window.addEventListener('scroll', function() {
        if (window.scrollY > 50) {
            navbar.style.boxShadow = '0 4px 12px rgba(0, 0, 0, 0.1)';
            navbar.style.padding = '10px 0';
        } else {
            navbar.style.boxShadow = '0 2px 10px rgba(0, 0, 0, 0.1)';
            navbar.style.padding = '15px 0';
        }
    });

    // ======================
    // Interacción con Cursos
    // ======================
    const courseCards = document.querySelectorAll('.course-card');
    
    courseCards.forEach(card => {
        // Efecto hover mejorado
        card.addEventListener('mouseenter', function() {
            const img = this.querySelector('.course-image');
            if (img) {
                img.style.transform = 'scale(1.05)';
            }
        });
        
        card.addEventListener('mouseleave', function() {
            const img = this.querySelector('.course-image');
            if (img) {
                img.style.transform = 'scale(1)';
            }
        });
        
        // Botón de inscripción
        const enrollBtn = card.querySelector('.btn-enroll');
        if (enrollBtn) {
            enrollBtn.addEventListener('click', function(e) {
                e.preventDefault();
                e.stopPropagation();
                
                const courseTitle = card.querySelector('h3').textContent;
                showModal(`¿Deseas inscribirte en <strong>${courseTitle}</strong>?`);
            });
        }
        
        // Click en toda la tarjeta
        card.addEventListener('click', function() {
            const courseTitle = this.querySelector('h3').textContent;
            console.log(`Curso seleccionado: ${courseTitle}`);
            // Aquí podrías redirigir a una página de detalle
            // window.location.href = `/curso/${courseId}`;
        });
    });

    // ======================
    // Modal de Inscripción
    // ======================
    function showModal(content) {
        // Crear modal si no existe
        let modal = document.getElementById('enrollment-modal');
        
        if (!modal) {
            modal = document.createElement('div');
            modal.id = 'enrollment-modal';
            modal.className = 'modal';
            modal.innerHTML = `
                <div class="modal-content">
                    <span class="close-modal">&times;</span>
                    <div class="modal-body" id="modal-body"></div>
                    <div class="modal-footer">
                        <button class="btn-secondary" id="cancel-btn">Cancelar</button>
                        <button class="btn-primary" id="confirm-btn">Confirmar</button>
                    </div>
                </div>
            `;
            document.body.appendChild(modal);
            
            // Eventos del modal
            document.querySelector('.close-modal').addEventListener('click', closeModal);
            document.getElementById('cancel-btn').addEventListener('click', closeModal);
            document.getElementById('confirm-btn').addEventListener('click', function() {
                alert('¡Inscripción exitosa!');
                closeModal();
            });
        }
        
        // Mostrar modal con contenido
        document.getElementById('modal-body').innerHTML = content;
        modal.style.display = 'flex';
        document.body.style.overflow = 'hidden';
    }
    
    function closeModal() {
        const modal = document.getElementById('enrollment-modal');
        if (modal) {
            modal.style.display = 'none';
            document.body.style.overflow = 'auto';
        }
    }

    // ======================
    // Animaciones al Scroll
    // ======================
    const animateOnScroll = function() {
        const elements = document.querySelectorAll('.course-card, .section-header');
        
        elements.forEach(element => {
            const elementPosition = element.getBoundingClientRect().top;
            const screenPosition = window.innerHeight / 1.2;
            
            if (elementPosition < screenPosition) {
                element.style.opacity = '1';
                element.style.transform = 'translateY(0)';
            }
        });
    };
    
    // Configuración inicial para animaciones
    const animatedElements = document.querySelectorAll('.course-card, .section-header');
    animatedElements.forEach(el => {
        el.style.opacity = '0';
        el.style.transform = 'translateY(20px)';
        el.style.transition = 'opacity 0.5s ease, transform 0.5s ease';
    });
    
    window.addEventListener('scroll', animateOnScroll);
    animateOnScroll(); // Ejecutar al cargar

    // ======================
    // Menú Mobile (Responsive)
    // ======================
    const mobileMenuBtn = document.createElement('div');
    mobileMenuBtn.className = 'mobile-menu-btn';
    mobileMenuBtn.innerHTML = '<i class="fas fa-bars"></i>';
    document.querySelector('.navbar .container').appendChild(mobileMenuBtn);
    
    mobileMenuBtn.addEventListener('click', function() {
        const navLinks = document.querySelector('.nav-links');
        navLinks.style.display = navLinks.style.display === 'flex' ? 'none' : 'flex';
    });

    // Ajustar menú al cambiar tamaño de pantalla
    window.addEventListener('resize', function() {
        const navLinks = document.querySelector('.nav-links');
        if (window.innerWidth > 768) {
            navLinks.style.display = 'flex';
        } else {
            navLinks.style.display = 'none';
        }
    });
});