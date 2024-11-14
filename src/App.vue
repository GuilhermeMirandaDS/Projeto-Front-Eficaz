<script setup>
import { RouterLink, RouterView, useRoute } from 'vue-router';
import FooterComponent from './components/FooterComponent.vue';
import PromoCardComponent from './components/PromoCardComponent.vue';
import DestaqueComponent from './components/DestaqueComponent.vue';
import ChildrenComponent from './components/ChildrenComponent.vue';
import HeroComponent from './components/HeroComponent.vue';
import NewProductsComponent from './components/NewProductsComponent.vue';
import CommentsComponent from './components/CommentsComponent.vue';
import NavbarComponent from './components/NavbarComponent.vue';
import router from '@/router/index.js';

const checkAuth = async() => {
  const token = localStorage.getItem('AUTH_TOKEN');
  console.log("Token JWT:", token);
  if (!token) {
      router.push("/login");                
      throw new Error('Token não encontrado!');
  }

};

checkAuth();
const route = useRoute();
</script>

<template>
  <div>
    <NavbarComponent/>
  </div>
  <div>
    <div v-if="route.path !== '/register' && route.path !== '/login'  && route.path !== '/user' && route.path !== '/edit'">
      

      <div class="hero">
        <HeroComponent />
      </div>
      <div class="destaque">
        <DestaqueComponent />
      </div>
      <div class="new">
        <NewProductsComponent />
      </div>
      <div class="promo">
        <PromoCardComponent />
      </div>
      <div class="children">
        <ChildrenComponent />
      </div>
      <div class="Comments">
        <CommentsComponent />
      </div>
      <div class="footer">
        <FooterComponent />
      </div>
    </div>

    <RouterView />
  </div>
</template>

<style>
.app{
  margin: 0;
  padding: 0;
  display: flex;
  flex-direction: column;
  align-items: center;
}
</style>