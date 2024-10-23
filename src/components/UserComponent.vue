<template>

    <body>
        <div class="top-page">
            <img src="../assets/pfp.png" alt="user-pic" class="user-img">
            <div class="user-info1">
                <h1>Gabriela Leal</h1>
                <h3>Gabizinha</h3>
                <input type="text" placeholder="Add a description...">
            </div>
            <button class="input-img">Change Picture</button>
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
                        <input class="label-input" type="number" placeholder="(14) 99654-8247">
                    </div>
                    <div class="object1">
                        <label>Landline</label>
                        <input class="label-input" type="number" placeholder="(14) 3003-4598">
                    </div>
                </div>
            </div>
            <div class="object2">
                <label>Date of Birth</label>
                <input type="date" class="calendar" placeholder="22/04/2005">
            </div>
            <div class="object2">
                <label>Address</label>
                <input class="label-input" type="number" placeholder="CEP">
                <input class="label-input" type="text" placeholder="City">
                <input class="label-input" type="text" placeholder="Neighborhood">
                <div class="last2">
                    <input class="label-input" type="text" placeholder="Road">
                    <input class="label-input" type="number" placeholder="Number">
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
            <h1>Card</h1>
            <input type="number" class="card-input" placeholder="0000 0000 0000 0000">
            <div class="last2">
                <input type="text" placeholder="MM/YY">
                <input type="number" placeholder="CVC">
            </div>
        </div>
        <button type="submit" class="save-btn">Save</button>
    </body>
</template>

<style scoped>
body{
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
.top-page input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    width: 165%;
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
.card-info input{
    font-family: 'Inter', sans-serif;
    border: solid 1px rgba(128, 128, 128, 0.445);
    border-radius: 4px;
    padding: 10px 13px;
    margin-bottom: 2%;
    outline: none;
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