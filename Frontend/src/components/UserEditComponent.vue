<template>

    <form @submit.prevent="updateUserData" id="app">
        <form @submit.prevent="updateUserData" class="top-page">
            <img :src="`https://localhost:7288/${userData.imageUrl}`" class="user-img" v-if="userData.imageUrl"/>
            <p v-else> sem imagem </p>
            <div class="user-info1">
                <img src=".../" alt="">
                <h1>{{ userData.firstName }}</h1>
                <h3>{{ userData.username }}</h3>
            </div>
            <button class="input-img" @click="openModalImg" >Change Picture</button>
            <div id="modalImage" class="modal">
                <div class="modalContent">
                    <input class="inputPicture" type="file" accept="image/jpeg">
                    <button type="submit" id="subBtn" @click="closeModalImg(); updateUserImg();" >Submit</button>
                </div>
            </div>
        </form>  
        <div class="personal-info">
            <h1>Personal</h1>
            <div class="name-phone">
                <div class="name-area">
                    <div class="object1">
                        <label>Name</label>
                        <input class="label-input" type="text" v-model="userData.firstName" placeholder="Gabriela">
                    </div>
                    <div class="object1">
                        <label>Last Name</label>
                        <input class="label-input" type="text" v-model="userData.lastName" placeholder="Leal">
                    </div>
                </div>
                <div class="phone-area">
                    <div class="object1">
                        <label>Mobile Phone</label>
                        <input class="label-input" type="number" v-model="userData.celular" placeholder="(14) 99654-8247" maxlength="11">
                    </div>
                    <div class="object1">
                        <label>Landline</label>
                        <input class="label-input" type="number" v-model="userData.telefoneFixo" placeholder="(14) 3003-4598" maxlength="11">
                    </div>
                </div>
            </div>
            <div class="object2">
                <label>Date of Birth</label>
                <input type="date" class="calendar" v-model="userData.dob" placeholder="22/04/2005">
            </div>
            <div class="add-adress">
                <label>Address</label>
                <button id="add-btn" @click="openModalAdress">Add a new Adress</button>
                <div id="modalAdress" class="modal">
                    <div class="modalContent">
                        <label>New Address</label>
                            <input class="label-input" type="number" v-model="userAdressData.zipCode" placeholder="CEP">
                            <input class="label-input" type="text" v-model="userAdressData.city" placeholder="City">
                            <input class="label-input" type="text" v-model="userAdressData.neighborhood" placeholder="Neighborhood">
                            <div class="last2-modal">
                                <input class="label-input" type="text" v-model="userAdressData.street" placeholder="Road">
                                <input class="label-input" type="number" v-model="userAdressData.number" placeholder="Number">
                            </div>
                        <button type="submit"class="saveBtn" @click="closeModalAdress">Save</button>
                        <button type="button" class="cancelBtn" @click="closeModalAdress">Cancel</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="login">
            <h1>Login</h1>
            <div class="object3">
                <label>E-mail</label>
                <input class="label-input" type="email" v-model="userData.email" placeholder="gabrielaleal@gmail.com">
            </div>
            <div class="object3">
                <label>Username</label>
                <input class="label-input" type="text" v-model="userData.username" placeholder="gabrielaleal@gmail.com">
            </div>
            <div class="object3">
                <label>Password</label>
                <input class="label-input" type="text" placeholder="*********" disabled="">
            </div>
        </div>
        <div class="card-info">
            <h1>Cards</h1>
            <button id="addCardBtn" class="addCardBtn" @click="openModalCard">Add a new Card</button>
            <div id="modalCard" class="modal">
                <div class="modalContent">
                    <label>New Card</label>
                    <div class="last2-modal">
                        <input type="datetime" v-model="userCardData.expiryDate" placeholder="MM/YY">
                        <input type="number" v-model="userCardData.cvc" placeholder="CVC">
                    </div>
                    <input type="number" class="card-input" v-model="userCardData.cardNumber" placeholder="0000 0000 0000 0000">
                    <button type="submit"class="savecardBtn" @click="closeModalCard(); updateCardData();">Save</button>
                    <button type="button" class="cancelcardBtn" @click="closeModalCard">Cancel</button>
                </div>
            </div>
        </div>
        <button type="submit" class="save-btn" @click="updateUserData">Save</button>
        <RouterLink to="/user" class="back-btn">Return to Profile</RouterLink>
    </form>
</template>

<script lang="ts">

import axios from 'axios';
import router from '@/router/index.js';
import { onMounted, ref, defineComponent } from 'vue';
import api from "@/services/api";


export default defineComponent ({
    name: "userProfileEdit",
    setup() {
        const userData = ref({
            id: "",
            firstName: "",
            lastName: "",
            dob: "",
            telefoneFixo: "",
            celular: "",
            email:"",
            imageUrl: "",
            password: "",
            username: "",
        });

        const userCardData = ref({
            cardNumber: "",
            expiryDate: "",
            cvc: "",
            userId: null
        });

        const userAdressData = ref({
            street: "",
            number: "",
            neighborhood: "",
            city: "",
            zipCode: "",
            userId: null
        });

        const getUserData = async () => {
            try {

                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token) {
                    router.push("/login");                
                    throw new Error('Token não encontrado!');
                }

                const response = await axios.get('https://localhost:7288/api/User/profile', {
                    headers: {
                        Authorization: `Bearer ${token}`
                    }
                });
                userData.value = response.data;


            } catch (error) {
                console.error('Erro ao buscar os dados do usuário:', error);
            }
        };

        const updateUserData = async () => {
            try {
                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token) {
                    throw new Error('Token não encontrado!');
                }

                const response = await axios.put('https://localhost:7288/api/User/profile', userData.value, {
                    headers: {
                        Authorization: `Bearer ${token}`,
                        'Content-Type': 'application/json'
                    }
                });

            } catch (error) {
                console.error('Erro ao atualizar os dados do usuário:', error);
                alert('erro ao atualizar dados!');
            }

            
        };

        const updateCardData = async () => {
            try{
                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token) {
                    throw new Error('Token não encontrado!');
                }

                const expiryDate = new Date(userCardData.value.expiryDate);

                userCardData.value.expiryDate = expiryDate.toISOString();

                userCardData.value.userId = userData.value.id;

                const response = await axios.post('https://localhost:7288/api/CreditCard', userCardData.value, {
                    headers: {
                        Authorization: `Bearer ${token}`,
                        'Content-Type': 'application/json'
                    },
                });

                if (!userCardData.value.cardNumber || !userCardData.value.expiryDate || !userCardData.value.cvc) {
                    alert('Por favor, preencha todos os campos do cartão.');
                    return;
                }

                console.log("cartão adicionado com sucesso");
            } catch (error) {
                console.log('Dados do cartão:', userCardData.value);
                console.error('Erro ao inserir cartão do usuário:', error);
                alert('Erro ao inserir cartão do usuário');
            }
        };

        const updateUserImg = async () => {
            try{
                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token){
                    throw new Error("token do usuário não encontrado.");
                }

                const userId = userData.value.id;
                const fileInput = document.querySelector<HTMLInputElement>('.inputPicture');

                if (!fileInput || !fileInput.files || fileInput.files.length === 0) {
                    alert("Por favor, selecione uma imagem.");
                    return;
                }

                const formData = new FormData();
                formData.append("image", fileInput.files[0]);

                const updateImage = await axios.post(`/api/User/${userId}/UploadImage`, formData, {
                    headers: {
                        Authorization: `Bearer ${token}`,
                        'Content-Type': 'application/json'
                    }
                })

                console.log("imagem alterada com sucesso!", updateImage)
            } catch (error) {
                console.error('Erro ao atualizar imagem do usuário:', error);
                alert('erro ao atualizar imagem');
            }
        };

        onMounted(getUserData);

        return {
            userData,
            userCardData,
            userAdressData,
            updateUserImg,
            updateUserData,
            updateCardData
        };
    },
        

        methods: {
            openModalImg() {
                document.getElementById("modalImage")!.style.display = "block";
            },

            closeModalImg() {
                document.getElementById("modalImage")!.style.display = "none";
            },



            openModalAdress() {
                document.getElementById("modalAdress")!.style.display = "block";
            },
            closeModalAdress() {
                document.getElementById("modalAdress")!.style.display = "none";
            },


            openModalCard() {
                document.getElementById("modalCard")!.style.display = "block";
            },
            closeModalCard() {
                document.getElementById("modalCard")!.style.display = "none";
            },
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
    margin-top: 8%;
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
    height: 3vw;
    margin-top: 2%;
    border:none;
    background-color: rgba(105, 135, 205, 1);
    color: white;
    padding: 0% 0.5%;
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
    text-decoration: none;
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