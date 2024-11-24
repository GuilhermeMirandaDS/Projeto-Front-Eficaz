<template>

    <div v-if="userData" id="app">
        <div class="top-page">
            <img :src="`https://localhost:7288/${userData.imageUrl}`" class="user-img" v-if="userData.imageUrl"/>
            <p v-else> sem imagem </p>
            <div class="user-info1">
                <h1>{{ userData.firstName }}</h1>
                <h3>{{ userData.username }}</h3>

            </div>
            <RouterLink to="/edit" class="edit-btn">Edit Profile</RouterLink>
        </div>
        <div class="personal-info">
            <h1>Personal</h1>
            <div class="name-phone">
                <div class="name-area">
                    <div class="object1">
                        <label>Name</label>
                        <input class="label-input" type="text" :placeholder="userData ? userData.firstName : 'name'" disabled="">

                    </div>
                    <div class="object1">
                        <label>Last Name</label>
                        <input class="label-input" type="text" :placeholder="userData ? userData.lastName : 'last name'" disabled="">
                    </div>
                </div>
                <div class="phone-area">
                    <div class="object1">
                        <label>Mobile Phone</label>
                        <input class="label-input" type="number" :placeholder="userData ? userData.celular : '(00) 00000-0000'" disabled="">
                    </div>
                    <div class="object1">
                        <label>Landline</label>
                        <input class="label-input" type="number" :placeholder="userData ? userData.telefoneFixo : '(00) 0000-0000'" disabled="">
                    </div>
                </div>
            </div>
            <div class="object2">
                <label>Date of Birth</label>
                <input type="text" class="calendar" :placeholder="userData ? userData.dob : 'dd/MM/yyyy'" disabled="">
            </div>
            <div class="object2">
                <label>Address</label>
                <div v-if="userAdressData && userAdressData.length > 0">
                    <div v-for="(adress, index) in userAdressData" :key="index">
                        <p class="adress">
                            {{ adress.street }}, {{ adress.number }} - {{ adress.neighborhood }} - {{ adress.city }}
                        </p>
                    </div>
                </div>
                <p v-else>Carregando informações...</p>
            </div>
        </div>
        <div class="login">
            <h1>Login</h1>
            <div class="object3">
                <label>E-mail</label>
                <input class="label-input" type="email" :placeholder="userData ? userData.email : 'Email'" disabled="">
            </div>
            <div class="object3">
                <label>Password</label>
                <input class="label-input" type="password" placeholder="******" disabled="">

            </div>
        </div>
        <div class="card-info">
            <h1>Cards</h1>
            <div class="credit-card" v-if="userCardData && userCardData.length > 0">
                <div v-for="(card, index) in userCardData" :key="index" class="card">
                    <p class="adress">{{ card.cardNumber }} - {{ card.expiryDate }} - {{ card.cvc }}</p>
                </div>
            </div>
            <p v-else>Carregando informações...</p>
        </div>
    </div>
    <div class="else" v-else><p>Carregando dados do Usuário...</p></div>

</template>

<script>
import axios from 'axios';
import router from '@/router/index.js';
import { onMounted, ref, defineComponent } from 'vue';
import api from "@/services/api";

export default defineComponent({
    name: "userProfile",
    setup() {
        const userData = ref(null);
        const userCardData = ref(null);
        const userAdressData = ref(null);


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
                
                if (userData.value?.id) {
                    await getCardData();
                    await getAdressData();
                };

            } catch (error) {
                console.error('Erro ao buscar os dados do usuário:', error);
            }
        };

        const formatExpiryDate = (dateString) => {
            const date = new Date(dateString);
            const month = date.toLocaleString("default", { month: "2-digit" });
            const year = date.getFullYear();
            return `${month}/${year}`;
        };

        const getCardData = async() => {
            try{
                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token) {
                    throw new Error('Token não encontrado!');
                }

                console.log("User ID:", userData.value?.id);

                const response = await axios.get(`https://localhost:7288/api/CreditCard/${userData.value.id}`,  {
                    headers: {
                        Authorization: `Bearer ${token}`
                    }
                });

                console.log("Card Data Response:", response.data);

                userCardData.value = Array.isArray(response.data)
                    ? response.data.map(card => ({
                        ...card,
                        expiryDate: formatExpiryDate(card.expiryDate)
                    }))
                    : {
                        ...response.data,
                        expiryDate: formatExpiryDate(response.data.expiryDate)
                    };
                
            } catch (error){
                console.error('Erro ao buscar os dados do cartão do usuário:', error);
            }
        };

        const getAdressData = async() => {
            try{
                const token = sessionStorage.getItem('AUTH_TOKEN');
                if (!token) {
                    throw new Error('Token não encontrado!');
                }

                console.log("User ID:", userData.value?.id);

                const userId = userData.value.id;

                const response = await axios.get(`https://localhost:7288/api/Address/${userData.value.id}`, {
                    headers: {
                        Authorization: `Bearer ${token}`
                    }
                });

                console.log("Card Data Response:", response.data);

                userAdressData.value = Array.isArray(response.data) ? response.data : [response.data];
                
            } catch (error){
                console.error('Erro ao buscar os dados do endereço do usuário:', error);
            }
        };

        onMounted(() => {
            getUserData();
        });

        return { userData, userCardData, userAdressData };
    }
});
</script>

<style scoped>
.else{
    text-align: center;
    margin-top: 25%;
}
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
    margin-bottom: 2%;
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
    border-radius: 4px;
    margin-bottom: 8%;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
}
.credit-card input{
    border: none;
    color: black;
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