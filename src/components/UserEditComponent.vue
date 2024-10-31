<template>

    <div id="app">
        <div class="top-page">
            <img src="../assets/pfp.png" alt="user-pic" class="user-img">
            <div class="user-info1">
                <h1>Gabriela Leal</h1>
                <h3>Gabizinha</h3>
            </div>
            <button id="changeImg" class="input-img">Change Picture</button>
            <div id="modalImage" class="modal">
                <div class="modalContent">
                    <input class="inputPicture" type="file" accept="image/jpeg">
                    <button type="submit" id="subBtn">Submit</button>
                </div>
            </div>
        </div>  
        <div class="personal-info">
            <h1>Personal</h1>
            <div class="name-phone">
                <div class="name-area">
                    <div class="object1">
                        <label>Name</label>
                        <input class="label-input" type="text" placeholder="Gabriela">
                    </div>
                    <div class="object1">
                        <label>Last Name</label>
                        <input class="label-input" type="text" placeholder="Leal">
                    </div>
                </div>
                <div class="phone-area">
                    <div class="object1">
                        <label>Mobile Phone</label>
                        <input class="label-input" type="number" placeholder="(14) 99654-8247" maxlength="11">
                    </div>
                    <div class="object1">
                        <label>Landline</label>
                        <input class="label-input" type="number" placeholder="(14) 3003-4598" maxlength="11">
                    </div>
                </div>
            </div>
            <div class="object2">
                <label>Date of Birth</label>
                <input type="date" class="calendar" placeholder="22/04/2005">
            </div>
            <div class="add-adress">
                <label>Address</label>
                <p class="adress">Av. Higino Muzi Filho, 1001 · (14) 2105-4000</p>
                <p class="adress">Av. Higino Muzi Filho, 1001 · (14) 2105-4000</p>
                <button id="add-btn">Add a new Adress</button>
                <div id="modalAdress" class="modal">
                    <div class="modalContent">
                        <label>New Address</label>
                        <input class="label-input" type="number" placeholder="CEP">
                        <input class="label-input" type="text" placeholder="City">
                        <input class="label-input" type="text" placeholder="Neighborhood">
                        <div class="last2-modal">
                            <input class="label-input" type="text" placeholder="Road">
                            <input class="label-input" type="number" placeholder="Number">
                        </div>
                        <button type="submit"class="saveBtn">Save</button>
                        <button type="button" class="cancelBtn">Cancel</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="login">
            <h1>Login</h1>
            <div class="object3">
                <label>E-mail</label>
                <input class="label-input" type="email" placeholder="gabrielaleal@gmail.com">
            </div>
            <div class="object3">
                <label>Password</label>
                <input class="label-input" type="password" placeholder="*********">
            </div>
        </div>
        <div class="card-info">
            <h1>Cards</h1>
            <div class="credit-card">
                <p>1234 5678 8765 4321</p><p> - </p>
                <p>01/30</p><p> - </p>
                <P>123</P>
            </div>
            <button id="addCardBtn" class="addCardBtn">Add a new Card</button>
            <div id="modalCard" class="modal">
                <div class="modalContent">
                    <label>Card</label>
                    <input type="number" class="card-input" placeholder="0000 0000 0000 0000">
                    <div class="last2-modal">
                        <input type="text" placeholder="MM/YY">
                        <input type="number" placeholder="CVC">
                    </div>
                    <button type="submit"class="savecardBtn">Save</button>
                    <button type="button" class="cancelcardBtn">Cancel</button>
                </div>
            </div>
        </div>
        <button type="submit" class="save-btn">Save</button>
        <RouterLink to="/user" class="back-btn">Return to Profile</RouterLink>
    </div>
</template>

<script>

import { RouterLink } from 'vue-router';

document.addEventListener('DOMContentLoaded', () => {


// MODAL ADRESS

    var modal = document.getElementById("modalAdress");
    var btn = document.getElementById("add-btn");
    var save = document.getElementsByClassName("saveBtn")[0];
    var cancel = document.getElementsByClassName("cancelBtn")[0];

    btn.onclick = function() {
        modal.style.display = "block";
    }

    save.onclick = function() {
        modal.style.display = "none";
    }

    cancel.onclick = function() {
        modal.style.display = "none";
    }

// MODAL PROFILE PICTURE

    var modalImg = document.getElementById("modalImage");
    var btnImg = document.getElementById("changeImg");
    var subBtn = document.getElementById("subBtn");

    btnImg.onclick = function() {
        modalImg.style.display = "block";
    }

    subBtn.onclick = function() {
        modalImg.style.display = "none";
    }

    window.onclick = function(event2) {
    if (event2.target == modalImg) {
        modalImg.style.display = "none";
    }
    }

// MODAL CREDIT CARD

    var modal3 = document.getElementById("modalCard");
    var addCard = document.getElementById("addCardBtn");
    var saveCard = document.getElementsByClassName("savecardBtn")[0];
    var cancelCard = document.getElementsByClassName("cancelcardBtn")[0];

    addCard.onclick = function() {
        modal3.style.display = "block";
    }

    saveCard.onclick = function() {
        modal3.style.display = "none";
    }

    cancelCard.onclick = function() {
        modal3.style.display = "none";
    }
});
</script>

<style scoped>
#app{
    display: flex;
    flex-direction: column;
    align-items: center;
}

.top-page{
    display: flex;
    align-items:first top;
    gap: 2%;
    margin-top: 4%;
    max-height: fit-content;
    width: 100%;
    justify-content: center;
}
.user-img{
    width: 160px;
    border-radius: 50%;
}
.top-page h1{
    font-family: 'Inter', sans-serif;
    font-size: 32px;
    font-weight: 700;
}
.top-page h3{
    font-family: 'Inter', sans-serif;
    font-size: 20px;
    font-weight: 500;
    color: grey;
}
.top-page button{
    font-family: 'Inter', sans-serif;
    height: 4vw;
    margin-top: 2%;
    border:none;
    background-color: rgba(105, 135, 205, 1);
    color: white;
    padding: 0% 1%;
    font-weight: 700;
    border-radius: 4px;
    cursor: pointer;
}
.inputPicture{
    font-family: 'Inter', sans-serif;
    font-size: 16px;
    font-weight: 400;
    color: rgb(81, 81, 81);
    background-color: rgb(255, 255, 255);
}
#subBtn{
    height: 2vw;
}



.personal-info{
    display: flex;
    flex-direction: column;
    gap: 20%;
    max-height: fit-content;
    width: 36%;
}
.personal-info h1{
    font-family: 'Inter', sans-serif;
    font-size: 24px;
    font-weight: 600;
}
.name-phone{
    display: flex;
    justify-content: space-between;
    max-width: 88%;
}
.name-area, .phone-area{
    max-width: fit-content;
}
.object1{
    display: flex;
    flex-direction: column;
    margin-top: 10%;
    margin-bottom: 10%;
}
label{
    font-family: 'Inter', sans-serif;
    font-weight: 500;
    font-size: 14px;
}
.object1 input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    width: 118%;
    outline: none;
}
.object2{
    display: flex;
    flex-direction: column;

}
.object2 input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    margin-bottom: 2%;
    outline: none;
}

.add-adress{
    display: flex;
    flex-direction: column;
}
.adress{
    font-family: 'Inter', sans-serif;
    font-size: 2vh;
    font-weight: 500;
    background-color: rgba(105, 135, 205, 0.2);
    padding: 2%;
    border-radius: 4px;
    margin-bottom: 1%;
}
#add-btn{
    font-family: 'Inter', sans-serif;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 100%;
    margin-top: 2%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
    cursor: pointer;
}

.last2{
    max-width: 100%;
    display: flex;
    justify-content: space-between;
}
.last2 input{
    width: 44%;
}


.modal{
    display: none;
    position: fixed;
    z-index: 1;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    overflow: hidden;
    background-color: rgb(0,0,0);
    background-color: rgba(0,0,0,0.4);
}
.modalContent{
    background-color: #fefefe;
    margin: 15% auto;
    padding: 2%;
    width: 50%;
    border-radius: 24px;
    display: flex;
    flex-direction: column;
    align-items: center;
}
.modalContent input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    margin-bottom: 2%;
    outline: none;
    width: 96%;
}
.last2-modal{
    width: 100%;
    display: flex;
    justify-content: space-between;
    align-items: center;
}
.last2-modal input{
    width: 45%;
}

.saveBtn, .cancelBtn{
    font-family: 'Inter', sans-serif;
    text-align: center;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 100%;
    margin-top: 2%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
    cursor: pointer;
}
.cancelBtn{
    background-color: rgb(167, 167, 167);
    width: 20%;
}



.login {
    display: flex;
    flex-direction: column;
    gap: 20%;
    max-height: fit-content;
    width: 36%;
}
.login h1{
    font-family: 'Inter', sans-serif;
    font-size: 24px;
    font-weight: 600;
}
.object3{
    display: flex;
    flex-direction: column;
}
.object3 input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    margin-bottom: 2%;
    outline: none;
}






.card-info {
    display: flex;
    flex-direction: column;
    gap: 20%;
    max-height: fit-content;
    width: 36%;
}
.card-info h1{
    font-family: 'Inter', sans-serif;
    font-size: 24px;
    font-weight: 600;
}
.card-info input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    margin-bottom: 2%;
    outline: none;
}
.credit-card{
    font-family: 'Inter', sans-serif;
    font-size: 2vh;
    font-weight: 500;
    background-color: rgba(105, 135, 205, 0.2);
    padding: 2% 4%;
    border-radius: 4px;
    margin-bottom: 2%;
    display: flex;
    justify-content: space-between;
}
.addCardBtn{
    font-family: 'Inter', sans-serif;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 100%;
    margin-top: 2%;
    margin-bottom: 2%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
    cursor: pointer;
}
.savecardBtn, .cancelcardBtn{
    font-family: 'Inter', sans-serif;
    text-align: center;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 100%;
    margin-top: 2%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
    cursor: pointer;
}
.cancelcardBtn{
    background-color: rgb(167, 167, 167);
    width: 20%;
}



.save-btn{
    font-family: 'Inter', sans-serif;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 36%;
    margin-top: 2%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
}
.save-btn:hover{
    cursor: pointer;
    background-color: rgb(80, 103, 156) ;
    transition: 500ms;
}
.back-btn{
    font-family: 'Inter', sans-serif;
    text-align: center;
    font-size: 14px;
    border: none;
    border-radius: 4px;
    padding: 8px;
    width: 6%;
    margin-top: 1%;
    margin-bottom: 5%;
    background-color: rgb(165, 165, 165) ;
    color: white;
    cursor: pointer;
}


input[type=number]::-webkit-inner-spin-button { 
    -webkit-appearance: none;
    
}
input[type=number] { 
   -moz-appearance: textfield;
   appearance: textfield;

}

</style>