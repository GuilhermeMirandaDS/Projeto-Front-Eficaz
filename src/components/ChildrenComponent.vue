<template>
    <div class="children-background">

        <!-- Imagens do produto -->
        <div class="hp-img">
            <img id="red-hp" src="../assets/ImageredHP.png" alt="Red Headphone">
            <img id="pink-hp" src="../assets/ImagepinkHP.png" alt="Pink Headphone">
        </div>

        <!-- Área de informações do produto -->
        <div class="hp-info">
            <h1 class="title">JBL Children's Bluetooth Headphones</h1>
            <div class="reviews">
                <img class="stars" src="../assets/estrelas.png">
                <p class="qtd-reviews">18,921 (reviews)</p> 
            </div>
            <div class="colors">
                <p class="color-opt">Color Options</p>
                <button type="button" id="red-btn"><img src=""></button>
                <button type="button" id="pink-btn" class="selected"><img src=""></button>
            </div>
            <div class="price">
                <p class="money-sign">$</p>
                <h2>28</h2>
                <div class="desconto">
                    <p class="oldprice">$35,99</p>
                    <p class="prcntoff">22% off</p>
                </div>
            </div>

            <!-- Área do botão -->
            <div class="button-buy">
                <a class="buyBtn" href="#"><p class="btn-text">SEE MORE DETAILS</p><img class="arrow-buy" src="../assets/arrow_svg.svg"></a>
            </div>
        </div>
    </div>

</template>

<script>

// Função que aguarda o carregamento da página e em seguida
// aciona o funcionamento dos botões para a alteração da imagem do produto,
// verificando se o botão com a cor desejada não está selecionado

document.addEventListener('DOMContentLoaded', () => {
    const redButton = document.getElementById('red-btn');
    const pinkButton = document.getElementById('pink-btn');
    const redImage = document.getElementById('red-hp');
    const pinkImage = document.getElementById('pink-hp');

    function changeImage(showImage, hideImage) {
        hideImage.style.display = 'none';
        
        showImage.style.display = 'block';
        showImage.classList.add('slide-in');
        setTimeout(() => showImage.classList.remove('slide-in'), 500);
    }

    function selectButton(selectedBtn, otherBtn) {
        selectedBtn.classList.add('selected');
        otherBtn.classList.remove('selected');
    }

    redButton.addEventListener('click', () => {
        if (!redButton.classList.contains('selected')) {
            changeImage(redImage, pinkImage);
            selectButton(redButton, pinkButton);
        }
    });

    pinkButton.addEventListener('click', () => {
        if (!pinkButton.classList.contains('selected')) {
            changeImage(pinkImage, redImage);
            selectButton(pinkButton, redButton);
        }
    });
});



</script>

<style scoped>

/* Estilização do componente */

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
    gap: 100px;
}

.hp-img img{
    transition: transform 0.5s ease, opacity 0.5s ease;
}

.colors button {
    position: relative;
    width: 60px;
    height: 60px;
    border: none;
    background-size: cover;
    border-radius: 50%;
    cursor: pointer;
}

.colors button::after {
    content: "✔";
    position: absolute;
    top: -10px;
    right: -10px;
    width: 20px;
    height: 20px;
    border-radius: 50%;
    background-color: white;
    color: green;
    display: none;
    justify-content: center;
    align-items: center;
    font-size: 12px;
}

.colors button.selected::after {
    display: flex;
}

#red-hp {
    display: none;
    margin: 0px;
    padding: 0px;
    max-width: 100%;
    height: auto; 
}

#pink-hp {
    display: block;
    margin: 0px;
    padding: 0px;
    max-width: 100%;
    height: auto; 
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
}

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

/* Animação da troca de imagens */

.slide-in {
    display: block;
    animation: slideUpIn 0.5s forwards;
}

@keyframes slideUpIn {
    from {
        opacity: 0;
        transform: translateY(100%);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* Responsividade do componente */

@media (max-width: 768px) {
    .children-background {
        align-items: center;
        justify-content: initial;
        padding: 0px;
        gap: 10px;
        margin: 40px 0px;
        max-width: 100%;
        max-height: fit-content;
    }

    #red-hp, #pink-hp{
        max-width: 300px;
    }
    .hp-info{
        flex-wrap: wrap;
        max-width: 300px;
        margin: 0;
        
    }
    .title{
        font-size: 26px;
    }
    .reviews{
        gap: 0;
        max-width: fit-content;
    }
    .reviews img{
        width: 180px;
    }
}

@media (max-width: 480px) {
    .children-background {
        flex-direction: column;
        height: auto;
        padding: 20px;
        align-items: baseline;
    }

    #red-hp, #pink-hp{
        max-width: 50%;
    }
    
}
</style>