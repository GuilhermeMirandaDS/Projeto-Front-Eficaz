<template>
    <div class="children-background">
        <div class="hp-img">
            <img id="red-hp" src="../assets/ImageredHP.png" alt="Red Headphone">
            <img id="pink-hp" src="../assets/ImagepinkHP.png" alt="Pink Headphone">
        </div>
        <div class="hp-info">
            <h1 class="title">JBL Children's Bluetooth Headphones</h1>
            <div class="reviews">
                <img class="stars" src="../assets/estrelas.png">
                <p class="qtd-reviews">18,921 (reviews)</p> 
            </div>
            <div class="colors">
                <p class="color-opt">Color Options</p>
                <button type="button" id="red-btn"><img src=""></button>
                <button type="button" id="pink-btn"><img src=""></button>
            </div>
            <div class="price">
                <p class="money-sign">$</p>
                <h2>28</h2>
                <div class="desconto">
                    <p class="oldprice">$35,99</p>
                    <p class="prcntoff">22% off</p>
                </div>
            </div>
            <div class="button-buy">
                <a class="buyBtn" href="#"><p class="btn-text">SEE MORE DETAILS</p><img class="arrow-buy" src="../assets/arrow_svg.svg"></a>
            </div>
        </div>
    </div>

</template>

<script>
 document.addEventListener('DOMContentLoaded', () => {
    const redButton = document.getElementById('red-btn');
    const pinkButton = document.getElementById('pink-btn');
    
    const redImage = document.getElementById('red-hp');
    const pinkImage = document.getElementById('pink-hp');

    redButton.addEventListener('click', function() {
        redImage.style.display = 'block';  
        pinkImage.style.display = 'none';  
    });

    pinkButton.addEventListener('click', function() {
        redImage.style.display = 'none';   
        pinkImage.style.display = 'block'; 
    });
 });

</script>

<style scoped>
.children-background {
    background-color: #f3f5f9;
    width: 1400px;
    height: 928px;
    border-radius: 30px;
    margin: 0;
    padding: 0;
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    gap: 80px;
}

#red-hp {
    display: none;
}

#pink-hp {
    display: block; 
}

.hp-info{
    display: flex;
    flex-direction: column;
    align-items: baseline;
    justify-content: center;
    gap: 32px;
}
.title{
    font-family: 'Inter', sans-serif;
    width: 450px;
    color: black;
    font-size: 48px;
    font-style: normal;
    font-weight: 600;
    margin: 0;
}

.reviews{
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 24px;
    height: 42px;
    width: 359px;
}

.qtd-reviews{
    font-family: 'Inter', sans-serif;
    font-size: 16px;
    color: #17f;
    text-align: center;
    font-weight: 600;
}

.colors{
    display: flex;
    align-items: center;
    gap: 24px;
}

.color-opt{
    font-family: 'Inter', sans-serif;
    font-size: 20px;
    color: black;
    text-align: center;
    font-weight: 400;
}

#red-btn{
    background-image: url(../assets/red-button.svg);
    border: none;
    background-position: center;
    background-size: cover;
    width: 60px;
    height: 60px;
    border-radius: 50%;
    padding: 0px;
}
#red-btn:hover, #pink-btn:hover {
    cursor: pointer;
    filter: brightness(90%);
    transition: 0.5ms ease-in-out;
}
/* #red-btn:enabled{
    background-image: url(../assets/Check.svg);
    background-position: center;
    background-size: contain;
    filter: opacity(30%);
} */

#pink-btn{
    background-image: url(../assets/pink-button.svg);
    border: none;
    background-position: center;
    background-size: cover;
    width: 60px;
    height: 60px;
    border-radius: 50%;
    padding: 0px;
}

.price{
    display: flex;
    align-items: flex-start;
    gap: 10px;
}

.money-sign{
    color: #000;
    font-size: 24px;
    font-style: normal;
    font-weight: 600;
    margin: 0;
}
h2{
    font-family: 'Inter', sans-serif;
    font-size: 90px;
    font-style: normal;
    font-weight: 700;
    margin: 0;
}
.desconto{
    display: flex;
    flex-direction: column;
    align-items: flex-start;
    gap: 7px;
    max-width: 93px;
    max-height: 65px;
    padding: 0px;
    margin: 0;
}
.oldprice{
    color: #000;
    font-family: 'Inter', sans-serif;
    font-size: 24px;
    font-style: normal;
    font-weight: 600;
    text-decoration-line:line-through;
    margin: 0;
}
.prcntoff{
    color: #000;
    font-family: 'Inter', sans-serif;
    font-size: 20px;
    font-style: normal;
    font-weight: 600;
    justify-content: center;
    margin: 0;
    border-radius: 40px;
    padding: 6px 14px;
    text-wrap: nowrap;
    border: 1px solid rgba(205, 67, 255, 1);
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
    border: solid 1px rgba(0, 0, 0, 0.34);
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
.arrow-buy{
    background-color: black;
    border-radius: 50%;
    padding:10px;
}
</style>