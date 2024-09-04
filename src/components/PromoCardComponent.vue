    <!-- Secção de promoção da página -->
<template>

    <div class="promo-area">
        <div class="card-promo">
            <div class="info-promo">
                <h1>Save 20% or more on Headset</h1>
                <h3>Enjoy for a limited time</h3>
                <div class="timer">

                </div>
                <a href="#"><button class="buyBtn"></button></a>
                <h3>Ends 18/08. Restrictions apply. See details</h3>
            </div>
            <img class="promo-img" src="../assets/headphone-promo.png">
        </div>
    </div>

</template>

<style scoped>

.card-promo{
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    background-color: blue;
    margin: 10px;
    padding: 60px;
    border-radius: 30px;
}

.info-promo{
    display: flex;
    flex-direction: column;
    justify-content:left;
}

</style>