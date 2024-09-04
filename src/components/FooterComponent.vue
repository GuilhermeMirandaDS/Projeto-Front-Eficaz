<template>
    <footer class="footer">
      <div class="container">
        <div class="menu">
          <h4>Menu</h4>
          <ul>
            <li><a href="#">Home</a></li>
            <li><a href="#">About Us</a></li>
            <li><a href="#">Product</a></li>
            <li><a href="#">Pricing</a></li>
          </ul>
        </div>
        <div class="resources">
          <h4>Resources</h4>
          <ul>
            <li><a href="#">Forum</a></li>
            <li><a href="#">Support</a></li>
            <li><a href="#">Partners</a></li>
            <li><a href="#">Events</a></li>
          </ul>
        </div>
        <div class="account">
          <h4>My Account</h4>
          <ul>
            <li><a href="#">My Orders</a></li>
            <li><a href="#">FAQ</a></li>
            <li><a href="#">Sales conditions</a></li>
            <li><a href="#">Contact</a></li>
            <li><a href="#">Legal mentions</a></li>
          </ul>
        </div>
        <div class="newsletter">
          <h4>Subscribe to Newsletter</h4>
          <form @submit.prevent="subscribe">
            <input type="email" v-model="email" placeholder="Email Address" required />
            <button type="submit">→</button>
          </form>
        </div>
      </div>
      <div class="bottom-bar">
        <div class="brand">GABINI</div>
        <div class="links">
          <a href="#">Products</a>
          <a href="#">Privacy Policy</a>
          <a href="#">Customer Service</a>
        </div>
      </div>
    </footer>
  </template>
  
  <script>
  
  </script>
  
  <style scoped>
        .footer {
        background-color: #000;
        color: #fff;
        padding: 40px 20px;
        width: 100%;
        /* position: fixed; */
        bottom: 0;
        left: 0;
    }
    
    .container {
        display: flex;
        justify-content: space-between;
        flex-wrap: wrap;
    }
    
    .menu, .resources, .account, .newsletter {
        flex: 1;
        min-width: 200px;
        margin: 0 10px;
    }
    
    h4 {
        font-size: 16px;
        margin-bottom: 15px;
    }
    
    ul {
        list-style: none;
        padding: 0;
    }
    
    li {
        margin-bottom: 10px;
    }
    
    a {
        color: #fff;
        text-decoration: none;
        transition: color 0.3s;
    }
    
    a:hover {
        color: #ccc;
    }
    
    form {
        display: flex;
    }
    
    input[type="email"] {
        flex: 1;
        padding: 10px;
        border: none;
        border-radius: 4px;
        margin-right: 10px;
    }
    
    button {
        background-color: #444;
        color: #fff;
        border: none;
        padding: 10px 20px;
        border-radius: 4px;
        cursor: pointer;
    }
    
    .bottom-bar {
        margin-top: 20px;
        display: flex;
        justify-content: space-between;
        align-items: center;
        flex-wrap: wrap;
    }
    
    .brand {
        font-size: 40px;
        font-weight: bold;
    }
    
    .links {
        display: flex;
        gap: 15px;
    }
    
  </style>
  