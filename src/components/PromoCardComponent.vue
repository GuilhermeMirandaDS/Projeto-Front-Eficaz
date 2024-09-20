<template>

    <div class="promo-area">
        <div class="back-promo">
            <div class="info-promo">
                <div class="title">
                    <h1>Save 20% or more on Headset</h1>
                    <h3>Enjoy for a limited time</h3>
                </div>
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
                <div class="button-buy">
                    <a class="buyBtn" href="#"><p class="btn-text">SHOP NOW</p><img class="arrow-buy" src="../assets/arrow_svg.svg"></a>
                </div>
                <h4>Ends 18/08. Restrictions apply. See details</h4>
            </div>
            <div class="headphone">
                <img class="promo-img" src="../assets/headphone-promo.png">
            </div>
        </div>
    </div>

</template>

<script>
    document.addEventListener('DOMContentLoaded', () => {
        const hours = document.getElementById('hours');
        const minutes = document.getElementById('minutes');
        const seconds = document.getElementById('seconds');

        const finalDate = new Date('September 23 2024 00:00:00');

        function updateCountdown() {
            const currentTime = new Date();
            const diff = finalDate - currentTime;

            const h = Math.floor(diff / 1000 / 60 / 60);
            const m = Math.floor(diff / 1000 / 60) % 60;
            const s = Math.floor(diff / 1000) % 60;

            hours.innerHTML = h < 10 ? '0' + h : h;
            minutes.innerHTML = m < 10 ? '0' + m : m;
            seconds.innerHTML = s < 10 ? '0' + s : s;
        }

        setInterval(updateCountdown, 1000);
    });
</script>

<style scoped>

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
    max-width: 600px;
    margin-bottom: 20px;
}

.timer-sep{
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    max-height: 160px;
}

h2{
    color: #FFF;
    font-family: "Inter", sans-serif;
    font-style: normal;
    font-size: 127px;
    font-weight: 500;
    margin: 0;
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

promo-img{
    width: 440px;
}

</style>