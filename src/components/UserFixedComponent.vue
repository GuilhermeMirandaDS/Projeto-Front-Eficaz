<template>

    <div id="app">
        <div class="top-page">
            <img src="../assets/pfp.png" alt="user-pic" class="user-img">
            <div class="user-info1">
                <h1>Gabriela Leal</h1>
                <h3>Gabizinha</h3>
            </div>
            <RouterLink to="/edit" class="edit-btn">Edit Profile</RouterLink>
        </div>  
        <div class="personal-info">
            <h1>Personal</h1>
            <div class="name-phone">
                <div class="name-area">
                    <div class="object1">
                        <label>Name</label>
                        <input class="label-input" type="text" placeholder="Gabriela" disabled="">
                    </div>
                    <div class="object1">
                        <label>Last Name</label>
                        <input class="label-input" type="text" placeholder="Leal" disabled="">
                    </div>
                </div>
                <div class="phone-area">
                    <div class="object1">
                        <label>Mobile Phone</label>
                        <input class="label-input" type="number" placeholder="(14) 99654-8247" disabled="">
                    </div>
                    <div class="object1">
                        <label>Landline</label>
                        <input class="label-input" type="number" placeholder="(14) 3003-4598" disabled="">
                    </div>
                </div>
            </div>
            <div class="object2">
                <label>Date of Birth</label>
                <input type="text" class="calendar" placeholder="22/04/2005" disabled="">
            </div>
            <div class="object2">
                <label>Address</label>
                <p class="adress">Av. Higino Muzi Filho, 1001 · (14) 2105-4000</p>
                <p class="adress">Av. Higino Muzi Filho, 1001 · (14) 2105-4000</p>
            </div>
        </div>
        <div class="login">
            <h1>Login</h1>
            <div class="object3">
                <label>E-mail</label>
                <input class="label-input" type="email" placeholder="gabrielaleal@gmail.com" disabled="">
            </div>
            <div class="object3">
                <label>Password</label>
                <input class="label-input" type="password" placeholder="*********" disabled="">
            </div>
        </div>
        <div class="card-info">
            <h1>Cards</h1>
            <div class="credit-card">
                <p>1234 5678 8765 4321</p><p> - </p>
                <p>01/30</p><p> - </p>
                <P>123</P>
            </div>
        </div>
    </div>
</template>

<script>
import { RouterLink } from 'vue-router';


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
.edit-btn{
    font-family: 'Inter', sans-serif;
    text-align: center;
    text-decoration: none;
    height: 3vw;
    margin-top: 2%;
    border:none;
    background-color: rgba(105, 135, 205, 1);
    color: white;
    padding: 0% 0.5%;
    font-weight: 700;
    border-radius: 4px;
    display: flex;
    align-items: center;
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
.adress{
    font-family: 'Inter', sans-serif;
    font-size: 2vh;
    font-weight: 500;
    background-color: rgba(105, 135, 205, 0.2);
    padding: 2%;
    border-radius: 4px;
    margin-bottom: 1%;
}
.last2{
    max-width: 100%;
    display: flex;
    justify-content: space-between;
}
.last2 input{
    width: 44%;
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
.credit-card{
    font-family: 'Inter', sans-serif;
    font-size: 2vh;
    font-weight: 500;
    background-color: rgba(105, 135, 205, 0.2);
    padding: 2% 4%;
    border-radius: 4px;
    margin-bottom: 1%;
    display: flex;
    justify-content: space-between;
}



.save-btn{
    font-family: 'Inter', sans-serif;
    border: none;
    border-radius: 4px;
    padding: 13px 24px;
    width: 36%;
    margin-top: 2%;
    margin-bottom: 10%;
    background-color: rgba(105, 135, 205, 1) ;
    color: white;
}
.save-btn:hover{
    cursor: pointer;
    background-color: rgb(80, 103, 156) ;
    transition: 500ms;
}



input[type=number]::-webkit-inner-spin-button { 
    -webkit-appearance: none;
    
}
input[type=number] { 
   -moz-appearance: textfield;
   appearance: textfield;

}

</style>