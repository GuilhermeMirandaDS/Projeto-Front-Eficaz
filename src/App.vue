<template>
<body>
    <nav class="navbar">
        <div class="container">
            <div class="logo">
                <img src="" alt="Logo">
            </div>
            <div class="nav-links">
                <a href="#">HOME</a>
                <a href="#">SALE</a>
                <a href="#">BUNDLE & SAVE</a>
                <div class="dropdown">
                    <a href="#">SHOP BY CATEGORY &#9662;</a>
                    <div class="dropdown-content">
                        <a href="#">ITEM 01</a>
                        <a href="#">ITEM 02</a>
                        <a href="#">ITEM 03</a>
                        <a href="#">ITEM 04</a>
                        <a href="#">ITEM 05</a>
                        <a href="#">ITEM 06</a>
                    </div>
                </div>
                <a href="#">SUPPORT</a>
            </div>
            <div class="nav-auth">
                <a href="#">SIGN IN</a>
                <a href="#" class="signup">SIGN UP FOR FREE</a>
            </div>
        </div>
    </nav>
    <FooterComponent />
</body>

</template>

<script>
import FooterComponent from './FooterComponent.vue';

export default {
  components: {
    FooterComponent
  }
};
</script>

<style scoped>
body {
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #f5f5f5;
}

.navbar {
    width: 100%;
    background-color: white;
    display: flex;
    justify-content: center;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); 
    position: relative;
}

.container {
    width: 100%;
    max-width: 1440px;
    height: 94px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0 20px;
}

.logo img {
    height: 50px;
}

.nav-links {
    display: flex;
    gap: 30px;
    align-items: center;
}

.nav-links a {
    color: #333;
    text-decoration: none;
    font-size: 14px;
    padding: 10px 0;
    position: relative;
    display: flex;
    align-items: center;
}

.nav-links a:hover {
    color: black;
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
    align-items: center;
}

.nav-auth a {
    color: #333;
    text-decoration: none;
    font-size: 14px;
    padding: 10px 0;
}

.signup {
    color: #007bff;
    font-weight: bold;
}

.signup:hover {
    text-decoration: underline;
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
        flex-direction: row;
        justify-content: space-between;
        align-items: center;
        padding: 0 20px;
    }

    .nav-links {
        flex-direction: column;
        gap: 10px;
        width: 100%;
        background-color: white;
        position: absolute;
        top: 94px;
        left: 0;
        padding: 10px;
        display: none;
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); 
    }

    .nav-links.active {
        display: flex;
    }

    .nav-links a {
        padding: 10px 0;
        width: 100%;
        text-align: left;
    }

    .nav-auth {
        flex-direction: column;
        gap: 10px;
        width: 100%;
    }

    .nav-auth a {
        text-align: left;
    }

    .menu-toggle {
        display: flex;
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
