<template>

    <nav class="navbar">
        <div class="container">
            <div class="logo">
                <img src="/src/assets/Logo_nav.png" alt="Logo" />
            </div>
            <div :class="['nav-links', { active: isMenuActive }]">
                <RouterLink to="/" >HOME</RouterLink>
                <a href="#">SALE</a>
                <a href="#">BUNDLE & SAVE</a>
                <div class="dropdown">
                    <a href="#" class="dropdown-toggle">SHOP BY CATEGORY ▼</a>
                    <div class="dropdown-content">
                        <a href="#">ITEM 01</a>
                        <a href="#">ITEM 02</a>
                        <a href="#">ITEM 03</a>
                        <a href="#">ITEM 04</a>
                    </div>
                </div>
                <a href="#">SUPPORT</a>
            </div>
            <div id="menu-toggle" class="menu-toggle" @click="toggleMenu">
                <span></span>
                <span></span>
                <span></span>
            </div>
        </div>
        <div class="nav-auth">
            <RouterLink v-if="isAuthenticated" to="/user" class="userlink">
                <img :src="`https://localhost:7288/${userData.imageUrl}`" class="userIMG" v-if="userData.imageUrl"/>
                <img v-else src="../assets/user-image-no.jpg" class="userIMG"/>
            </RouterLink>
            <RouterLink v-if="!isAuthenticated" to="/login" class="sign-in" style="font-weight: 900;">SIGN IN</RouterLink>
            <RouterLink v-if="!isAuthenticated" to="/register" class="signup">SIGN UP FOR FREE</RouterLink>
        </div>
    </nav>
</template>

<script setup lang="ts">
import { onMounted } from 'vue';
import { ref } from 'vue';
import axios from 'axios';

const isAuthenticated = ref(false);
const userData = ref<{ imageUrl: string } | null>(null);

const isMenuActive = ref(false);
const toggleMenu = () => {
    isMenuActive.value = !isMenuActive.value;
};

const getUserData = async () => {
    try {
        const token = sessionStorage.getItem('AUTH_TOKEN');
        if (!token) {   
            isAuthenticated.value = false;            
            throw new Error('Token não encontrado!');
        }

        const response = await axios.get('https://localhost:7288/api/User/profile', {
            headers: {
                Authorization: `Bearer ${token}`
            }
        });
        userData.value = response.data;
        isAuthenticated.value = true;
    } catch (error) {
        console.error('Erro ao buscar os dados do usuário:', error);
        isAuthenticated.value = false;
    }
};

onMounted(() => {
    getUserData();
});
</script>


<style scoped>

.userlink{
    padding: 10px;
}

.navbar {
    width: 100%;
    background-color: white;
    display: flex;
    justify-content: center;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); 
    position: fixed;
    z-index: 2;
    top: 0;
    left: 0;
}

.container {
    width: 100%;
    max-width: 1440px;
    height: 94px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding-left: 2%;
    margin: 0%;
}

.navbar-logo {
    width: 195px;
    height: 25px;
    flex-shrink: 0;
    margin-left: 7000000px; 
}


.logo img {
    width: 135px;
    height: 26px;
    flex-shrink: 0;
}

.nav-links {
    display: flex;
    gap: 40px; 
    align-items: center;
    transition: all 0.3s ease-in-out;
    margin-left: auto; 
    margin-right: 40px; 
}

.nav-links a {
    color: var(--Black-black-500, #000); 
    text-align: center;
    font-family: Inter, sans-serif;
    font-size: 14px;
    font-style: normal;
    font-weight: 400;
    line-height: 24px;
    letter-spacing: -0.14px;
    text-transform: uppercase;
    text-decoration: none;
    padding: 10px 0;
    display: flex;
    align-items: center;
    transition: color 0.3s ease, transform 0.3s ease; 
}

.nav-links a:hover {
    color: #007bff; 
    transform: scale(1.05); 
}

.dropdown {
    position: relative;
    display: inline-block;
}

.dropdown-content {
    display: none;
    position: absolute;
    background-color: white;
    min-width: 160px;
    box-shadow: 0 8px 16px rgba(0, 0, 0, 0.15); 
    z-index: 1;
}

.dropdown-content a {
    color: #333;
    padding: 12px 16px;
    text-decoration: none;
    display: block;
    white-space: nowrap;
}

.dropdown-content a:hover {
    background-color: #f1f1f1;
}

.dropdown:hover .dropdown-content {
    display: block;
}

.nav-auth {
    display: flex;
    gap: 20px; 
    margin-left: auto; 
}

.nav-auth a {
    color: var(--Black-black-500, #000);
    text-align: center;
    font-family: Inter, sans-serif;
    font-size: 14px;
    font-style: normal;
    font-weight: 400;
    line-height: 24px;
    letter-spacing: -0.14px;
    text-transform: uppercase;
    text-decoration: none;
    padding: 10px 0;
    display: flex;
    align-items: center;
    transition: color 0.3s ease, transform 0.3s ease; 
}

.nav-links a:hover,
.nav-auth a:hover {
    color: #007bff;
    transform: scale(1.05); 
}


.signup:hover {
    color: #007bff; 
    transform: scale(1.05); 
}

.userIMG{
    width: 50px;
    border-radius: 50%;
    padding:0px 20px;
}


.menu-toggle {
    display: none;
    flex-direction: column;
    cursor: pointer;
    width: 30px;
}

.menu-toggle span {
    background-color: #333;
    height: 3px;
    margin: 5px 0;
    transition: all 0.3s ease;
}


@media (max-width: 768px) {
    .container {
        flex-direction: column;
        align-items: flex-start;
        padding: 0 20px;
    }

    .nav-links {
        flex-direction: column;
        gap: 10px;
        width: 100%;
        background-color: white;
        padding: 10px;
        display: none;
        align-items: center; 
    }

    .nav-links.active {
        display: flex; 
    }

    .nav-links a,
    .dropdown-toggle {
        padding: 10px 0;
        text-align: center; 
        width: 100%; 
    }

    .nav-auth {
        display: none; 
    }

    .menu-toggle {
        display: flex;
    }

    .logo {
        width: 100%;
        text-align: center;
        padding: 20px 0;
    }
}

.menu-toggle.active span:nth-child(1) {
    transform: translateY(8px) rotate(45deg);
}

.menu-toggle.active span:nth-child(2) {
    opacity: 0;
}

.menu-toggle.active span:nth-child(3) {
    transform: translateY(-8px) rotate(-45deg);
}
</style>