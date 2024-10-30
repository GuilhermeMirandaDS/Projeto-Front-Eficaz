<template>
    <div class="page-container">
      <div class="image-container">
        <img src="/src/assets/Register_img.png" alt="Imagem ilustrativa" />
      </div>
  
      <div class="form-container">
        <div class="form-box">
          <RouterLink to="/">
            <img src="/src/assets/back_arrow.png" alt="Back Arrow" class="back-arrow" />
          </RouterLink>
          <div class="logo-container">
            <img src="/src/assets/Register_logo.png" alt="Gabini Logo" class="logo" />
          </div>
  
          <h5>Personal info</h5>
          <form @submit.prevent="submitForm">
            <div class="form-group">
              <div class="row">
                <input type="text" v-model="firstName" placeholder="First name" required class="half-width" />
                <input type="text" v-model="lastName" placeholder="Last name" required class="half-width" />
              </div>
  
              <input type="date" v-model="dob"/>
  
              <div class="row">
                <input type="text" v-model="telefoneFixo" placeholder="Telefone fixo" class="half-width" inputmode="numeric" pattern="\d{8}*" />
                <input type="text" v-model="celular" placeholder="Celular" class="half-width" inputmode="numeric" pattern="\d{11}*" />
              </div>
  
              <select v-model="gender" required>
                <option disabled value="">Select your gender</option>
                <option value="male">Male</option>
                <option value="female">Female</option>
                <option value="other">Other</option>
              </select>
  
              <h5>Login info</h5>
  
              <input type="text" v-model="cpf" placeholder="CPF" required pattern="\d{11}" title="Insira 11 dígitos numéricos">
            </div>
  
            <div class="form-group">
              <input type="text" v-model="username" placeholder="Username" required />
  
              <div class="row">
                <input type="password" v-model="password" placeholder="Password" required class="half-width" />
                <input type="password" v-model="confirmPassword" placeholder="Confirm password" required class="half-width" />
              </div>
  
              <input type="text" v-model="securityQuestion" placeholder="Pergunta de segurança" required />
            </div>
  
            <div class="terms-checkbox">
              <input type="checkbox" v-model="termsAgreed" required id="terms-checkbox" />
              <label for="terms-checkbox">
                Concordo com as <a href="#">Condições de Uso</a> da Gabini.
              </label>
            </div>
  
            <button type="submit" class="btn btn-primary btn-block">
              SIGN UP
              <img src="/src/assets/arrow.png" alt="Seta" class="arrow-icon" />
            </button>
          </form>
        </div>
      </div>
    </div>
  </template>
  
  
  <script>
  export default {
    data() {
      return {
        firstName: "",
        lastName: "",
        dob: "",
        telefoneFixo: "",
        celular: "",
        gender: "",
        cpf: "",
        username: "",
        password: "",
        confirmPassword: "",
        securityQuestion: "",
        termsAgreed: false,
      };
    },
    methods: {
      submitForm() {
        if (this.password !== this.confirmPassword) {
          alert("Passwords do not match!");
          return;
        }
  
        if (!this.termsAgreed) {
          alert("You must agree to the terms of use.");
          return;
        }
  
        alert("Formulário enviado com sucesso!");
        
        this.$router.push({ name: 'login' });
      },
    },
  };
  </script>
  
  <style scoped>
  
  
  .page-container {
    display: flex;
    height: 100vh;
    width: 100vw;
    margin: 0; 
    padding: 0; 
  }
  
  
  .image-container {
    flex: 1;
    background-color: #f9f9f9;
  }
  
  .image-container img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }
  
  .form-container {
    flex: 1;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 20px;
    background-color: white;
    overflow: hidden;
  }
  
  .form-box {
    font-family: Arial, sans-serif;
    background: white;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    max-width: 500px;
    width: 100%;
  }
  
  
  .logo-container {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-bottom: 20px;
  }
  
  .back-arrow {
    max-width: 30px;
    padding-bottom: 5%;
  }
  
  .logo {
    max-width: 150px;
  }
  
  h5 {
    margin-bottom: 8px;
    font-size: 14px;
    font-weight: bold;
  }
  
  .form-group input,
  .form-group select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 5px;
    box-sizing: border-box;
    margin-bottom: 10px;
  }
  
  .row {
    display: flex;
    justify-content: space-between;
    gap: 10px;
  }
  
  .half-width {
    width: calc(50% - 5px);
  }
  
  button {
    width: 100%;
    padding: 10px;
    border: none;
    border-radius: 5px;
    background-color: #000000;
    color: white;
    cursor: pointer;
  }
  
  button:hover {
    background-color: #0056b3;
  }
  
  .terms-checkbox {
    display: flex;
    align-items: center;
    margin-bottom: 15px;
    width: auto;
  }
  
  .terms-checkbox input[type="checkbox"] {
    margin-right: 15px;
  }
  
  .terms-checkbox label {
    text-align: left;
    white-space: nowrap;
    flex-grow: 1;
  }
  
  .terms-checkbox label a {
    text-decoration: underline;
    color: rgb(58, 160, 255);
  }
  
  
  @media (max-width: 768px) {
    .form-box {
      max-width: 100%; 
      padding: 15px;
    }
  
    .logo {
      max-width: 100px; 
    }
  
    .back-arrow {
      max-width: 20px; 
    }
  }
  </style>
  