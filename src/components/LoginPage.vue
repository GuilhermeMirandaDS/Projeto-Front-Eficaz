<script setup>
import { RouterLink, RouterView } from 'vue-router';
</script>

<template>
    <div id="app">
      <div class="login-container">
        <div class="image-section">
          <img src="/src/assets/Login_img.png" alt="Lateral Image" class="lateral-image"/>
        </div>
  
     
        <div class="form-section">
          <RouterLink to="/">
            <img src="/src/assets/back_arrow.png" alt="Back Arrow" class="back-arrow" />
          </RouterLink>
          <div class="logo-section">
            <img src="/src/assets/Login_logo.png" alt="Logo" class="logo" />
          </div>
  
          <form @submit.prevent="submitForm">
            <div class="form-group">
              <input type="text" placeholder="Username" v-model="username" />
            </div>
            <div class="form-group">
              <input type="password" placeholder="Password" v-model="password" />
            </div>
            <button type="submit" class="btn btn-primary btn-block">
              Join us
              <img src="/src/assets/arrow.png" alt="Seta" class="arrow-icon" />
            </button>
          </form>
  
          <div class="social-login">
            <button class="google-btn">
              <img src="/src/assets/Google_icon.png" alt="Google Logo" class="social-logo" />
              Sign in with Google
            </button>
            <button class="apple-btn">
              <img src="/src/assets/Apple_icon.png" alt="Apple Logo" class="social-logo" />
              Sign in with Apple
            </button>
          </div>
          
          <div class="signup-link">
            <p>Not a member? <a href="#">Sign up.</a></p>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  import { defineComponent } from 'vue';
  import axios from 'axios';
  import api from '@/services/api';

  export default defineComponent({
    name:'UserLogin',
    data() {
      return {
        username: '',
        password: ''
      };
    },
    methods: {
      async submitForm() {
        try {
          const response = await axios.post('https://localhost:7288/api/User/login', {
            username: this.username,
            password: this.password
          });

          const token = response.data.token;
          
          window.localStorage.setItem("AUTH_TOKEN", token);
          this.$router.push({ name: 'home' });
        } catch (error) {
          console.error("Erro na requisição de login:", error);
        }
      }
    }
  });
  </script>
  
  <style scoped>
  * {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }
  
  
  #app {
    font-family: 'Inter', sans-serif;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #f9f9f9;
    height: 100vh;
  }
  
  
  .login-container {
    display: flex;
    background-color: white;
    width: 100%;
    height: 100%; 
    max-width: 100%;
    border-radius: 0;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1);
    overflow: hidden;
  }
  
  
  .image-section {
    width: 50%;
    height: 100%; 
  }
  
  .back-arrow {
  position: absolute;
  right: 39%; 
  top: 5%;  
  
 
 
  }
  
  .lateral-image {
    width: 100%;
    height: 100%;
    object-fit: cover; 
  }
  
  .form-section {
    width: 50%;
    padding: 40px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100%;
  }
  
  
  .logo-section {
    margin-bottom: 20px;
  }
  
  .logo {
    width: 375px;
    height: 112.22px;
  }
  
  .form-section p {
    font-size: 1rem;
    margin-bottom: 10px;
  }
  
  .form-section h1 {
    font-size: 2rem;
    margin-bottom: 20px;
    font-weight: bold;
  }
  
  .form-group {
    width: 100%;
    margin-bottom: 15px;
  }
  
  .form-group input {
    width: 375px; 
    height: 50px; 
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 4px;
    font-size: 1rem;
    margin-bottom: 24px; 
  }
  
  .btn-primary {
    width: 375px; 
    height: 50px; 
    background-color: black;
    color: white;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    margin-top: 24px; 
    font-size: 1rem;
    transition: background-color 0.6s ease, transform 0.4s ease;
  }

  .btn-primary:hover {
  background-color: #333; 
  transform: scale(1.05); 
  }
  
  .social-login {
    margin-top: 20px;
    display: flex;
    justify-content: center; 
    width: 100%;
    gap: 8px; 
  }
  
  .social-login button {
    width: 185px; 
    height: 50px; 
    padding: 10px;
    border-radius: 4px;
    cursor: pointer;
    font-size: 14px;
    display: flex;
    justify-content: center;
    align-items: center; 
    transition: background-color 0.6s ease, transform 0.4s ease;
  }
  
  
  .google-btn {
    background-color: #6987CD;
    border: 1px solid #ccc;
    color: black;
    color: white;
  }

  .google-btn:hover {
  background-color: #5077b7; 
  transform: scale(1.05); 
  }
  
  
  .apple-btn {
    background-color: black;
    color: white;
    border: none;
  }

  .apple-btn:hover {
  background-color: #333; 
  transform: scale(1.05); 
  }
  
  
  .social-logo {
    width: 20px; 
    height: 20px; 
    margin-right: 8px; 
  }
  
  .signup-link {
    margin-top: 20px;
    text-align: center;
  }
  
  .signup-link a {
    color: black;
    text-decoration: none;
    font-weight: bold;
  }
  </style>
  