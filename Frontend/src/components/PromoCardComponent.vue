<template>
    <div class="back-promo">
      <div class="info-promo">
        <div class="title">
          <h1>Save 20% or more on Headset</h1>
          <h3>Enjoy for a limited time</h3>
        </div>
        <div class="timer">
          <div class="timer-sep">
            <h2>{{ hours }}</h2>
            <p class="timer-name">HOURS</p>
          </div>
          <div class="timer-sep">
            <h2>{{ minutes }}</h2>
            <p class="timer-name">MINUTES</p>
          </div>
          <div class="timer-sep">
            <h2>{{ seconds }}</h2>
            <p class="timer-name">SECONDS</p>
          </div>
        </div>
        <div class="button-buy">
          <a class="buyBtn" href="#">
            <p class="btn-text">SHOP NOW</p>
            <img class="arrow-buy" src="../assets/arrow_svg.svg" />
          </a>
        </div>
        <h4>Ends 25/12. Restrictions apply. See details</h4>
      </div>
      <div class="headphone">
        <img class="promo-img" src="../assets/headphone-promo.png" />
      </div>
    </div>
  </template>
  
  <script>
  import { ref, onMounted } from "vue";
  
  export default {
    setup() {
      const hours = ref("00");
      const minutes = ref("00");
      const seconds = ref("00");
  
      const finalDate = new Date("December 25 2024 00:00:00");
  
      function updateCountdown() {
        const currentTime = new Date();
        const diff = finalDate - currentTime;
  
        if (diff <= 0) {
          hours.value = "00";
          minutes.value = "00";
          seconds.value = "00";
          return;
        }
  
        const h = Math.floor(diff / 1000 / 60 / 60);
        const m = Math.floor(diff / 1000 / 60) % 60;
        const s = Math.floor(diff / 1000) % 60;
  
        hours.value = h < 10 ? `0${h}` : `${h}`;
        minutes.value = m < 10 ? `0${m}` : `${m}`;
        seconds.value = s < 10 ? `0${s}` : `${s}`;
      }
  
      onMounted(() => {
        updateCountdown();
        setInterval(updateCountdown, 1000);
      });
  
      return {
        hours,
        minutes,
        seconds,
      };
    },
  };
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