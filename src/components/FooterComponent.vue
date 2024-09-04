<template>
  <footer class="footer">
    <div class="container">
      <div class="brand">
        <img src="@/assets/LogoGabini.png" alt="Gabini Logo" class="logo">
      </div>
      <div class="sections">
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
          <p>Sign up for exclusive offers, original stories, events and more.</p>
          <form>
            <input type="email" placeholder="Email Address" required />
            <button type="submit">→</button>
          </form>
        </div>
      </div>
    </div>
    <div class="footer-background">
      <img src="@/assets/GabiniCortado.jpg" alt="Gabini Background" />
    </div>
    <div class="bottom-bar">
      <p>© 2024 Gabini Headset Store. - All Rights Reserved</p>
      <div class="links">
        <a href="#">Products</a>
        <a href="#">Privacy Policy</a>
        <a href="#">Customer Service</a>
      </div>
      <div class="social-icons">
        <a href="#"><img src="/src/assets/LogoX.png" alt="Icon X" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoFacebook.png" alt="Icon Facebook" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoYT.png" alt="Icon Youtube" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoLinkedIn.png" alt="Icon LinkedIn" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoInstagram.png" alt="Icon Instagram" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoTikTok.png" alt="Icon TikTok" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoPinterest.png" alt="Icon Pinterest" class="social-icon"></a>
        <a href="#"><img src="/src/assets/LogoSpotify.png" alt="Icon Spotify" class="social-icon"></a>
      </div>
    </div>
  </footer>
</template>

<script>

</script>

<style scoped>
.footer {
  position: relative;
  background-color: #000;
  color: #fff;
  padding: 40px 20px;
  border-radius: 20px;
  overflow: hidden;
}

.container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
}

.brand {
  display: flex;
  justify-content: flex-start;
  margin-bottom: 20px;
}

.logo {
  height: 50px;
  width: auto;
}

.sections {
  display: flex;
  justify-content: space-between;
  width: 100%;
}

.menu, .resources, .account, .newsletter {
  flex: 1;
  text-align: left;
  margin: 0 20px;
}

h4 {
  font-size: 18px;
  font-weight: bold;
  text-transform: uppercase;
  color: #fff;
  margin-bottom: 15px;
}

ul {
  list-style: none;
  padding: 0;
}

ul li a {
  font-size: 14px;
  color: #ccc;
  text-decoration: none;
  font-weight: normal;
  line-height: 1.8;
  transition: color 0.3s;
}

ul li a:hover {
  color: #fff;
}

.newsletter p {
  font-size: 14px;
  font-weight: normal;
  color: #aaa;
  margin-bottom: 10px;
}

.newsletter form {
  display: flex;
  margin-top: 10px;
}

input[type="email"] {
  padding: 12px;
  border: none;
  border-radius: 20px;
  margin-right: 10px;
  background-color: #222;
  color: #fff;
  font-size: 14px;
}

button {
  background-color: #666;
  color: #fff;
  border: none;
  padding: 12px 20px;
  border-radius: 20px;
  font-size: 18px;
  cursor: pointer;
}

.footer-background {
  position: absolute;
  bottom: 0;
  left: 50%;
  transform: translateX(-50%);
  opacity: 0.2;
  z-index: 0;
}

.footer-background img {
  width: 100%;
  height: auto;
}

.bottom-bar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  max-width: 1200px;
  margin: 0 auto;
  margin-top: 20px;
  padding-top: 20px;
  border-top: 1px solid #444;
}

.bottom-bar p {
  font-size: 12px;
  color: #aaa;
}

.links a {
  margin-left: 20px;
  color: #aaa;
  font-size: 12px;
}

.links a:hover {
  color: #fff;
}

.social-icons {
  display: flex;
  gap: 10px;
}

.social-icon {
  width: 24px;
  height: 24px;
}

@media (max-width: 768px) {
  .sections {
    flex-direction: column;
    text-align: center;
  }

  .menu, .resources, .account, .newsletter {
    margin: 20px 0;
  }

  .footer-background {
    bottom: -30px;
  }
}
</style>
