    <!-- Secção de promoção da página -->
<template>

    <div class="promo-area">
        <div class="back-promo">
            <div class="info-promo">
                <h1>Save 20% or more on Headset</h1>
                <h3>Enjoy for a limited time</h3>
                <div class="timer">

                </div>
                <a href="#"><button class="buyBtn"><p class="btn-text">SHOP NOW</p><img class="arrow-buy" src="../assets/arrow_svg.svg"></button></a>
                <h4>Ends 18/08. Restrictions apply. See details</h4>
            </div>
            <img class="promo-img" src="../assets/headphone-promo.png">
        </div>
    </div>

</template>

<style scoped>

.back-promo{
    display: flex;
    flex-direction: row;
    background-color: rgb(4, 129, 129);
    justify-content: space-between;
    margin: 10px;
    padding: 60px;
    border-radius: 30px;
}

.info-promo{
    display: flex;
    flex-direction: column;
    justify-content:left;
}

h1{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 80px;
    font-style: normal;
    font-weight: 600;
    line-height: 80px;
    letter-spacing: -3.2px;
}

h3{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 24px;
    font-style: normal;
    font-weight: 600;
    line-height: 30px;
    letter-spacing: -0.48px;
}

h4{
    font-family: "Inter", sans-serif;
    color: white;
    font-size: 16px;
    font-style: normal;
    font-weight: 400;
    line-height: 24px;
    letter-spacing: -0.16px;
}

.arrow-buy{
    background-color: black;
    border-radius: 50%;
    padding:10px;
}

.buyBtn{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-items: space-between;
    padding: 8px 8px 8px 24px;
    gap: 30px;
    border-radius: 40px;
    border: none;
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
a{
    text-decoration: none;
}


</style>