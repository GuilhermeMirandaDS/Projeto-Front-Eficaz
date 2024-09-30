<template>
    <div class="back-promo">
        <div class="info-promo">

            <!-- Título -->
            <div class="title">
                <h1>Save 20% or more on Headset</h1>
                <h3>Enjoy for a limited time</h3>
            </div>

            <!-- Temporizador -->
            <div class="timer">
                <div class="timer-sep">
                    <h2 id="hours">00</h2>
                    <p class="timer-name">HOURS</p>
                </div>

                <div class="timer-sep">
                    <h2 id="minutes">00</h2>
                    <p class="timer-name">MINUTES</p>
                </div>

                <div class="timer-sep">
                    <h2 id="seconds">00</h2>
                    <p class="timer-name">SECONDS</p>
                </div>

            </div>

            <!-- Área do Botão -->
            <div class="button-buy">
                <a class="buyBtn" href="#"><p class="btn-text">SHOP NOW</p><img class="arrow-buy" src="../assets/arrow_svg.svg"></a>
            </div>
            <h4>Ends 18/08. Restrictions apply. See details</h4>
        </div>

        <!-- Imagem do Produto -->
        <div class="headphone">
            <img class="promo-img" src="../assets/headphone-promo.png">
        </div>
    </div>
</template>

<script>

    // Função que espera o conteúdo da página ser carregado e em seguida executa a contagem do temporizador
    document.addEventListener('DOMContentLoaded', () => {
        const hours = document.getElementById('hours');
        const minutes = document.getElementById('minutes');
        const seconds = document.getElementById('seconds');

        const finalDate = new Date('October 20 2024 00:00:00');

        function updateCountdown() {
            const currentTime = new Date();
            const diff = finalDate - currentTime;

            const h = Math.floor(diff / 1000 / 60 / 60);
            const m = Math.floor(diff / 1000 / 60) % 60;
            const s = Math.floor(diff / 1000) % 60;

            updateNumber(hours, h);
            updateNumber(minutes, m);
            updateNumber(seconds, s);
        }

        // Função que executa a animação de alteração no temporizador
        function updateNumber(element, newValue) {
            const currentValue = parseInt(element.innerHTML, 10);
            const formattedValue = newValue < 10 ? '0' + newValue : newValue; 

            if (currentValue !== newValue) {
                element.innerHTML = formattedValue;
                element.classList.add('slide-in');
                
                setTimeout(() => {
                    element.classList.remove('slide-in');
                }, 500);
            }
    }
        // Comando para a função ser executada a cada 1 segundo
        setInterval(updateCountdown, 1000);
    });
</script>


<style scoped>

/* Estilização do Componente */

.back-promo{
    display: flex;
    flex-direction: row;
    background-image: url(../assets/background-promo.png);
    background-position: center;
    background-size: cover;
    margin: 10px;

    padding: 30px 60px;
    border-radius: 30px;
    height: 645px;
}

.info-promo{
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    margin-right: 20px ;
}

.title{
    display: flex;
    flex-direction: column;
}

h1{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 80px;
    font-style: normal;
    font-weight: 600;
    margin: 0;
}

.timer{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-between;
    width: 600px;
    margin-bottom: 20px;
}

.timer-sep{
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 160px;
}


h2{
    color: #FFF;
    font-family: "Inter", sans-serif;
    font-style: normal;
    font-size: 127px;
    font-weight: 500;
    margin: 0;
    display: inline-block;
    text-align: center;
    width: 230px;
}

.timer-name {
    color: #FFF;
    text-align: center;
    font-family: "Inter", sans-serif;
    font-size: 19px;
    font-style: normal;
    font-weight: 400;
    text-transform: uppercase;
}

h3{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 24px;
    font-style: normal;
    font-weight: 600;
    margin-top: 20px;
}

h4{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 16px;
    font-style: normal;
    font-weight: 400;
    line-height: 24px;
    margin: 0;
}

.arrow-buy{
    background-color: black;
    border-radius: 50%;
    padding:10px;
}

.buyBtn{
    background-color: white;
    color: black;
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-items: space-between;
    padding: 8px 8px 8px 24px;
    gap: 30px;
    border-radius: 40px;
    border: none;
    text-decoration: none;
    max-width: fit-content;
}
.buyBtn:hover{
    cursor: pointer;
}

.btn-text{
    font-family: "Inter", sans-serif;
    font-size: 14px;
    font-style: normal;
    font-weight: 600;
    line-height: 24px; 
    letter-spacing: -0.14px;
    text-transform: uppercase;
}

.headphone{
   display: flex;
   align-items: center; 
}

.promo-img{
    width: 35vw;
    
}

/* Animação da troca de Valores do temporizador */

.slide-in {
    animation: slideUpIn 0.5s forwards;
}

@keyframes slideUpIn {
    from {
        opacity: 0;
        transform: translateY(50%);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* Responsividade do componente */

@media (max-width: 1024px) {
    .back-promo {
        flex-direction: column;
        height: auto;
        padding: 20px;
    }

    .info-promo {
        margin-right: 0;
        text-align: center;
    }

    h1 {
        font-size: 60px;
    }

    .button-buy{
        display: flex;
        justify-content: center;
    }

    .headphone{
        display: flex;
        justify-content: center;
        order: 1;
    }

    .timer {
        width: 100%;
    }

    h2 {
        font-size: 90px;
        width: auto;
    }
    
    .promo-img {
        width: 360px;
        margin-top: 20px;
    }
}

@media (max-width: 768px) {
    .back-promo {
        padding: 15px;
        margin: 0;
        padding: 10px;
        max-width: 768px;
        justify-content: initial;
    }

    h1 {
        font-size: 50px;
    }

    .timer {
        flex-direction: column;
        align-items: center;
        width: 100%;
    }

    h2 {
        font-size: 70px;
    }

    h3 {
        font-size: 18px;
    }

    .promo-img {
        width: 300px;
    }

    .buyBtn {
        padding: 10px 15px;
        gap: 15px;
    }

    .btn-text {
        font-size: 12px;
    }
}

@media (max-width: 480px) {
    .back-promo {
        padding: 10px;
    }

    h1 {
        font-size: 40px;
    }

    .timer {
        width: 100%;
    }

    h2 {
        font-size: 50px;
    }

    h3 {
        font-size: 16px;
    }

    .promo-img {
        width: 250px;
    }

    .buyBtn {
        padding: 8px 10px;
        gap: 10px;
    }

    .btn-text {
        font-size: 10px;
    }
}
</style>