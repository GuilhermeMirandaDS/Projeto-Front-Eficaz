<template>
    <div class="products-container">
      <h2>OS MAIS VENDIDOS</h2>
  
      <transition
        name="slide"
        @before-enter="beforeEnter"
        @enter="enter"
        @leave="leave"
      >
        <div class="cards-wrapper" :key="currentIndex">
          <div 
            class="product-card" 
            v-for="(product, index) in paginatedProducts" 
            :key="product.name"
          >
            <img :src="product.img" alt="Product Image" class="product-image" />
  
            <button class="favorite-btn" @click="toggleFavorite(product)">
              <img :src="product.isFavorited ? '/src/assets/Favorite_icon_1.png' : '/src/assets/Favorite_icon.png'" alt="Favorito" />
            </button>
  
            <div class="card-header">
              <h3>{{ product.prodName }}</h3>
              <p class="price">
                <span class="currency">R$</span>
                <span class="amount">{{ product.price.toFixed(2).replace('.', ',') }}</span>
              </p>
            </div>
  
            <!-- <div class="tags">
              <span class="tag">JBL</span>
              <span class="tag">Fone</span>
            </div> -->
  
            <p class="description">{{ product.description }}</p>
  
            <div class="card-footer">
              <button class="add-to-cart">
                <img src="/src/assets/Add_cart.png" alt="Add to Cart" />
              </button>
              <button class="buy-now">Comprar agora</button>
            </div>
          </div>
        </div>
      </transition>
  
      <div class="carousel-controls">
        <button class="control-btn light" @click="prevProducts">←</button>
        <button class="control-btn dark" @click="nextProducts">→</button>
      </div>
    </div>
  </template>
  
  <script>
  import axios from 'axios';
  
  export default {
    data() {
      return {
        currentIndex: 0,
        productsPerPage: 3,
        direction: 'right',
        products: []
      };
    },
    computed: {
      paginatedProducts() {
        return this.products.slice(this.currentIndex, this.currentIndex + this.productsPerPage);
      }
    },
    mounted() {
      this.fetchProducts();
    },
    methods: {
      async fetchProducts() {
        try {
          const token = sessionStorage.getItem('AUTH_TOKEN');
            if (!token) {                
                throw new Error('Token não encontrado!');
            }
          const response = await axios.get('https://localhost:7288/api/Product', {
              headers: {
                  Authorization: `Bearer ${token}`
              }
          });
          this.products = response.data;
        } catch (error) {
          console.error('Erro ao buscar produtos:', error);
        }
      },
      toggleFavorite(product) {
      product.isFavorited = !product.isFavorited; 
      },
      nextProducts() {
        if (this.currentIndex + this.productsPerPage < this.products.length) {
          this.direction = 'right';
          this.currentIndex += this.productsPerPage;
        } else {
          this.direction = 'right';
          this.currentIndex = 0;
        }
      },
      prevProducts() {
        if (this.currentIndex > 0) {
          this.direction = 'left';
          this.currentIndex -= this.productsPerPage;
        } else {
          this.direction = 'left';
          this.currentIndex = this.products.length - this.productsPerPage;
        }
      },
      beforeEnter(el) {
        el.style.opacity = 0;
        el.style.transform = this.direction === 'right' ? 'translateX(100%)' : 'translateX(-100%)';
      },
      enter(el, done) {
        el.offsetWidth;
        el.style.transition = 'opacity 0.5s, transform 0.5s';
        el.style.opacity = 1;
        el.style.transform = 'translateX(0)';
        done();
      },
      leave(el, done) {
        el.style.transition = 'opacity 0.5s, transform 0.5s';
        el.style.opacity = 0;
        el.style.transform = this.direction === 'right' ? 'translateX(-100%)' : 'translateX(100%)';
        done();
      }
    }
  };
  </script>
  
  <style scoped>
  .products-container {
    text-align: center;
    padding: 20px;
  }
  
  h2 {
    font-size: 34px;
    margin-bottom: 20px;
    font-family: 'Inter', sans-serif;
  }
  
  .cards-wrapper {
    display: flex;
    justify-content: center;
    gap: 20px;
    align-items: stretch;
    overflow: hidden;
    margin-bottom: 20px;
  }
  
  .product-card {
    flex: 0 0 300px;
    background-color: white;
    border-radius: 15px;
    padding: 20px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
    text-align: left;
    font-family: 'Inter', sans-serif;
    transition: box-shadow 0.3s ease;
    position: relative; 
  }
  
  .product-card:hover {
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.2);
  }
  
  .product-image {
    width: 100%;
    border-radius: 10px;
    margin-bottom: 10px;
  }
  
  .favorite-btn {
    position: absolute; 
    top: 10px;
    right: 10px;
    background: transparent;
    border: none;
    cursor: pointer;
    padding: 5px;
  }
  
  .favorite-btn img {
    width: 25px; 
    height: 25px;
    transition: transform 0.3s ease;
  }
  
  .card-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 10px;
  }
  
  .card-header h3 {
    font-size: 14px;
    font-weight: 600;
    color: #000;
  }
  
  .price {
    color: red;
    font-weight: bold;
    font-size: 18px;
  }
  
  .tags {
    display: flex;
    gap: 8px;
    margin: 10px 0;
  }
  
  .tag {
    background-color: #f2f2f2;
    color: #666;
    font-size: 12px;
    padding: 5px 10px;
    border-radius: 5px;
    font-weight: 500;
  }
  
  .description {
    font-size: 12px;
    color: #666;
    margin: 10px 0 20px;
    line-height: 1.5;
  }
  
  .card-footer {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-top: auto;
  }
  
  .add-to-cart {
    background-color: black; 
    color: white; 
    font-size: 18px; 
    border: none; 
    cursor: pointer;
    width: 40px; 
    height: 40px; 
    border-radius: 50%; 
    display: flex; 
    justify-content: center; 
    align-items: center; 
    transition: transform 0.3s ease, background-color 0.3s ease; 
  }
  
  .add-to-cart:hover {
    background-color: rgb(139, 139, 139);
    transform: scale(1.1); 
  }
  
  .buy-now {
    background-color: red; 
    color: white; 
    border: none; 
    padding: 10px 40px; 
    border-radius: 8px; 
    cursor: pointer; 
    font-size: 17px;
    font-weight: bold;
    text-transform: uppercase; 
    display: block;
    margin: 0 auto; 
    transition: background-color 0.3s ease, transform 0.3s ease;
  }
  
  .buy-now:hover {
    background-color: darkred;
  }
  
  .carousel-controls {
    display: flex;
    justify-content: center;
    margin-top: 20px;
  }
  
  .control-btn {
    background-color: black;
    color: white;
    padding: 10px;
    border: none;
    border-radius: 50%;
    width: 50px;
    height: 50px;
    cursor: pointer;
    font-size: 20px;
    margin: 0 10px;
  }
  
  .favorite-btn:hover img {
    transform: scale(1.2); 
  }
  
  .buy-now:hover {
    background-color: darkred; /* Nova cor no hover */
    transform: scale(1.05); /* Leve aumento */
  }
  
  
  .control-btn.light:hover, .control-btn.dark:hover {
    opacity: 0.8;
  }
  
  
  .slide-enter-active,
  .slide-leave-active {
    transition: opacity 0.5s, transform 0.5s;
  }
  
  .slide-enter,
  .slide-leave-to {
    opacity: 0;
  }
  </style>
  